// MongoDbContext.cs
using MongoDB.Bson;
using MongoDB.Driver;
using System;

namespace DAL7.MongoDB
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext(string connectionString, string databaseName)
        {
            Console.WriteLine($"Creating MongoDB context...");
            Console.WriteLine($"Connection string: {connectionString}");
            Console.WriteLine($"Database name: {databaseName}");

            try
            {
                var client = new MongoClient(connectionString);
                _database = client.GetDatabase(databaseName);

                // Тестовый запрос для проверки
                var pingCommand = new BsonDocument("ping", 1);
                _database.RunCommand<BsonDocument>(pingCommand);

                Console.WriteLine("MongoDB context created successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating MongoDB context: {ex.Message}");
                throw;
            }
        }

        public MongoDbContext(string connectionString)
            : this(connectionString, "MongoDB_lab7")
        {
        }

        // Возвращаем коллекции как BsonDocument
        public IMongoCollection<BsonDocument> Contracts =>
            _database.GetCollection<BsonDocument>("contracts");

        public IMongoCollection<BsonDocument> Departments =>
            _database.GetCollection<BsonDocument>("departments");

        public IMongoCollection<BsonDocument> Employees =>
            _database.GetCollection<BsonDocument>("employees");

        public IMongoCollection<BsonDocument> Participations =>
            _database.GetCollection<BsonDocument>("participations");

        public IMongoCollection<BsonDocument> Projects =>
            _database.GetCollection<BsonDocument>("projects");

        public IMongoCollection<BsonDocument> Specialties =>
            _database.GetCollection<BsonDocument>("specialties");
    }
}