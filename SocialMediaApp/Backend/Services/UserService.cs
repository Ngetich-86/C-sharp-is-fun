using MongoDB.Driver;
using Backend.Models;
using Backend.Data;

namespace Backend.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(DatabaseContext context)
        {
            _users = context.Users;
        }

        public async Task<List<User>> GetAllAsync() =>
            await _users.Find(_ => true).ToListAsync();

        public async Task<User> GetByIdAsync(string id) =>
            await _users.Find(u => u.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(User user) =>
            await _users.InsertOneAsync(user);
    }
}
