using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Backend.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("username")]
        public string Username { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("fullName")]
        public string FullName { get; set; }
        
        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}