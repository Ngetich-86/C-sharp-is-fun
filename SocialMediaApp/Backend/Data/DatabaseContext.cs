using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Bson;
using Backend.Models;
using Microsoft.Extensions.Logging;

namespace Backend.Data
{
    public class DatabaseContext
    {
        private readonly IMongoDatabase _database;
        private readonly ILogger<DatabaseContext> _logger;

        public DatabaseContext(IOptions<MongoDbSettings> settings, ILogger<DatabaseContext> logger)
        {
            _logger = logger;
            try
            {
                Console.WriteLine("Attempting to connect to MongoDB Atlas...");
                var client = new MongoClient(settings.Value.ConnectionString);
                _database = client.GetDatabase(settings.Value.DatabaseName);
                
                // Test the connection
                _database.RunCommandAsync((Command<BsonDocument>)"{ping:1}").Wait();
                Console.WriteLine("Successfully connected to MongoDB Atlas!");
                _logger.LogInformation("Successfully connected to MongoDB Atlas!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to connect to MongoDB Atlas: {ex.Message}");
                _logger.LogError($"Failed to connect to MongoDB Atlas: {ex.Message}");
                throw;
            }
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
    }
}