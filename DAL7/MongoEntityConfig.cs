// MongoEntityConfig.cs
using System;
using System.Collections.Generic;

namespace DAL7.MongoDB
{
    public static class MongoEntityConfig
    {
        // Конфигурация: для каждого типа сущности указываем имя свойства PK
        public static Dictionary<Type, string> IdProperties = new Dictionary<Type, string>
        {
            { typeof(contract), "contract_code" },
            { typeof(department), "department_code" },
            { typeof(employee), "employee_id" },
            { typeof(participation), "id" },
            { typeof(project), "project_code" },
            { typeof(specialty), "specialty_code" }
        };

        public static string GetIdPropertyName(Type entityType)
        {
            return IdProperties.TryGetValue(entityType, out var idProperty)
                ? idProperty
                : "Id"; // fallback
        }
    }
}