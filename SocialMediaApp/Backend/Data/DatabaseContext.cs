using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Backend.Models;

namespace Backend.Data
{
    public class DatabaseContext
    {
        private readonly IMongoDatabase _database;

        public DatabaseContext(IOptions<MongoDbSettings> settings)
        {
            var mongoSettings = settings.Value;
            var client = new MongoClient(mongoSettings.ConnectionString);
            _database = client.GetDatabase(mongoSettings.DatabaseName);
        }

        public IMongoCollection<User> Users => _database.GetCollection<User>("Users");
    }
}