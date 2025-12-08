using DAL7.MongoDB;
using System;
using System.Configuration;

namespace DAL7.MongoDB
{
    public static class MongoConfig
    {
        // Строка подключения к MongoDB
        public const string ConnectionString = "mongodb://localhost:27017/MongoDB_lab7";

        // Название базы данных
        public const string DatabaseName = "MongoDB_lab7";

        // Создание контекста с настройками по умолчанию
        public static MongoDbContext CreateContext()
        {
            return new MongoDbContext(ConnectionString, DatabaseName);
        }

        // Создание контекста с кастомными настройками
        public static MongoDbContext CreateContext(string connectionString, string databaseName)
        {
            return new MongoDbContext(connectionString, databaseName);
        }
    }
}