namespace Backend.Data
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string UsersCollectionName { get; set; }
    }
}