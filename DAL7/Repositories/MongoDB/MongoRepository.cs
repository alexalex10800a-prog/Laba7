// MongoRepository.cs
using DAL7.Interfaces;
using DAL7.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DAL7.Repositories.MongoDB
{
    public abstract class MongoRepository<T> : IRepository<T> where T : class, new()
    {
        protected readonly IMongoCollection<BsonDocument> _collection;
        private readonly string _idPropertyName;
        private readonly PropertyInfo _idPropertyInfo;

        protected MongoRepository(IMongoCollection<BsonDocument> collection)
        {
            _collection = collection;
            _idPropertyName = MongoEntityConfig.GetIdPropertyName(typeof(T));
            _idPropertyInfo = typeof(T).GetProperty(_idPropertyName) ??
                throw new InvalidOperationException(
                    $"Property '{_idPropertyName}' not found in {typeof(T).Name}");
        }

        public virtual List<T> GetList()
        {
            var documents = _collection.Find(new BsonDocument()).ToList();
            return documents.Select(ConvertFromDocument).ToList();
        }

        public virtual T GetItem(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            var document = _collection.Find(filter).FirstOrDefault();
            return document != null ? ConvertFromDocument(document) : null;
        }

        public virtual void Create(T item)
        {
            var document = ConvertToDocument(item);
            _collection.InsertOne(document);
        }

        public virtual void Update(T item)
        {
            var idValue = _idPropertyInfo.GetValue(item);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", idValue);
            var document = ConvertToDocument(item);
            _collection.ReplaceOne(filter, document);
        }

        public virtual void Delete(int id)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("_id", id);
            _collection.DeleteOne(filter);
        }

        protected virtual T ConvertFromDocument(BsonDocument document)
        {
            var entity = new T();

            foreach (var element in document.Elements)
            {
                // Особый случай для _id
                if (element.Name == "_id")
                {
                    _idPropertyInfo.SetValue(entity, ConvertIdValue(element.Value));
                    continue;
                }

                // Ищем соответствующее свойство
                var propertyName = FindPropertyName(element.Name);
                var property = typeof(T).GetProperty(propertyName);

                if (property != null && property.CanWrite)
                {
                    // Пропускаем коллекции и навигационные свойства
                    if (IsNavigationProperty(property))
                        continue;

                    // Пропускаем свойства с типом других сущностей
                    if (IsEntityType(property.PropertyType))
                        continue;

                    try
                    {
                        var value = ConvertValue(element.Value, property.PropertyType);
                        property.SetValue(entity, value);
                    }
                    catch (Exception ex)
                    {
                        // Логируем, но не падаем
                        Console.WriteLine($"Warning: Could not set property {property.Name}: {ex.Message}");
                    }
                }
            }

            return entity;
        }

        private bool IsNavigationProperty(PropertyInfo property)
        {
            // Проверяем, является ли свойство коллекцией
            var propertyType = property.PropertyType;

            // ICollection<T>, List<T>, IEnumerable<T>
            if (propertyType.IsGenericType &&
                (propertyType.GetGenericTypeDefinition() == typeof(ICollection<>) ||
                 propertyType.GetGenericTypeDefinition() == typeof(List<>) ||
                 propertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
            {
                return true;
            }

            // Массивы
            if (propertyType.IsArray)
                return true;

            // Проверяем, является ли тип другой сущностью (по неймспейсу)
            if (propertyType.Namespace != null &&
                propertyType.Namespace.Contains("DAL7") &&
                !propertyType.IsPrimitive &&
                propertyType != typeof(string) &&
                propertyType != typeof(DateTime))
            {
                return true;
            }

            return false;
        }

        private bool IsEntityType(Type type)
        {
            // Проверяем, является ли тип другой сущностью из DAL7
            if (type.Namespace != null && type.Namespace.Contains("DAL7"))
            {
                // Исключаем примитивные типы и строки
                if (!type.IsPrimitive &&
                    type != typeof(string) &&
                    type != typeof(DateTime) &&
                    type != typeof(decimal))
                {
                    return true;
                }
            }

            return false;
        }

        private object ConvertValue(BsonValue bsonValue, Type targetType)
        {
            if (bsonValue.IsBsonNull)
                return GetDefaultValue(targetType);

            // Обрабатываем Nullable типы
            if (Nullable.GetUnderlyingType(targetType) != null)
            {
                var underlyingType = Nullable.GetUnderlyingType(targetType);
                var value = ConvertValue(bsonValue, underlyingType);
                return value;
            }

            if (targetType == typeof(string))
                return bsonValue.AsString;
            if (targetType == typeof(int))
                return bsonValue.AsInt32;
            if (targetType == typeof(long))
                return bsonValue.AsInt64;
            if (targetType == typeof(bool))
                return bsonValue.AsBoolean;
            if (targetType == typeof(double))
                return bsonValue.AsDouble;
            if (targetType == typeof(decimal))
                return (decimal)bsonValue.AsDouble;
            if (targetType == typeof(DateTime))
                return bsonValue.ToUniversalTime();
            if (targetType == typeof(float))
                return (float)bsonValue.AsDouble;

            // Если тип не поддерживается, возвращаем строку
            return bsonValue.ToString();
        }

        private object GetDefaultValue(Type type)
        {
            return type.IsValueType ? Activator.CreateInstance(type) : null;
        }

        protected virtual BsonDocument ConvertToDocument(T entity)
        {
            var document = new BsonDocument();
            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                // Пропускаем навигационные свойства
                if (IsNavigationProperty(property) || IsEntityType(property.PropertyType))
                    continue;

                var value = property.GetValue(entity);
                if (value != null)
                {
                    // Если это свойство PK, сохраняем как _id
                    if (property.Name == _idPropertyName)
                    {
                        document["_id"] = ConvertToBsonValue(value);
                    }
                    else
                    {
                        // Используем имя свойства как имя поля в MongoDB
                        document[property.Name] = ConvertToBsonValue(value);
                    }
                }
            }

            return document;
        }

        private object ConvertIdValue(BsonValue bsonValue)
        {
            // Конвертируем _id в правильный тип
            if (_idPropertyInfo.PropertyType == typeof(int))
                return bsonValue.AsInt32;
            if (_idPropertyInfo.PropertyType == typeof(string))
                return bsonValue.AsString;
            if (_idPropertyInfo.PropertyType == typeof(long))
                return bsonValue.AsInt64;

            return bsonValue.ToString();
        }

        

        private BsonValue ConvertToBsonValue(object value)
        {
            if (value == null)
                return BsonNull.Value;

            return BsonValue.Create(value);
        }

        private string FindPropertyName(string fieldName)
        {
            var type = typeof(T);

            // Пробуем точное совпадение
            var property = type.GetProperty(fieldName);
            if (property != null)
                return property.Name;

            // Пробуем без учета регистра
            property = type.GetProperties()
                .FirstOrDefault(p => string.Equals(p.Name, fieldName, StringComparison.OrdinalIgnoreCase));
            if (property != null)
                return property.Name;

            // Пробуем заменить подчеркивания
            var normalizedFieldName = fieldName.Replace("_", "");
            property = type.GetProperties()
                .FirstOrDefault(p => string.Equals(p.Name, normalizedFieldName, StringComparison.OrdinalIgnoreCase));

            return property?.Name ?? fieldName;
        }
    }
}