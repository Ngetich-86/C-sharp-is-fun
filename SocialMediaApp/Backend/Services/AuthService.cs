using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Backend.Models;
using Backend.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;

namespace Backend.Services
{
    public class AuthService
    {
        private readonly IMongoCollection<User> _users;
        private readonly IConfiguration _configuration;
        private readonly string _jwtSecret;
        private readonly string _resetTokenSecret;

        public AuthService(IConfiguration configuration, DatabaseContext context)
        {
            _configuration = configuration;
            _users = context.Users;
            _jwtSecret = configuration["JwtSettings:Secret"] ?? "your-secret-key-at-least-32-characters-long";
            _resetTokenSecret = configuration["JwtSettings:ResetTokenSecret"] ?? "your-reset-token-secret-key";
        }

        public async Task<AuthResponse> Register(RegisterRequest request)
        {
            // Check if user already exists
            if (await _users.Find(u => u.Username == request.Username).AnyAsync())
                throw new Exception("Username already exists");

            if (await _users.Find(u => u.Email == request.Email).AnyAsync())
                throw new Exception("Email already exists");

            // Create password hash
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var user = new User
            {
                Username = request.Username,
                Email = request.Email,
                FullName = request.FullName,
                Password = Convert.ToBase64String(passwordHash),
                PasswordSalt = Convert.ToBase64String(passwordSalt),
                CreatedAt = DateTime.UtcNow
            };

            await _users.InsertOneAsync(user);

            var token = GenerateJwtToken(user);
            return new AuthResponse { Token = token, User = user };
        }

        public async Task<AuthResponse> Login(LoginRequest request)
        {
            var user = await _users.Find(u => u.Username == request.Username).FirstOrDefaultAsync();
            if (user == null)
                throw new Exception("User not found");

            if (!VerifyPasswordHash(request.Password, Convert.FromBase64String(user.Password), Convert.FromBase64String(user.PasswordSalt)))
                throw new Exception("Invalid password");

            var token = GenerateJwtToken(user);
            return new AuthResponse { Token = token, User = user };
        }

        public async Task<string> ForgotPassword(ForgotPasswordRequest request)
        {
            var user = await _users.Find(u => u.Email == request.Email).FirstOrDefaultAsync();
            if (user == null)
                throw new Exception("User not found");

            var resetToken = GenerateResetToken(user);
            // In a real application, you would send this token via email
            return resetToken;
        }

        public async Task ResetPassword(ResetPasswordRequest request)
        {
            var userId = ValidateResetToken(request.Token);
            if (string.IsNullOrEmpty(userId))
                throw new Exception("Invalid reset token");

            var user = await _users.Find(u => u.Id == userId).FirstOrDefaultAsync();
            if (user == null)
                throw new Exception("User not found");

            CreatePasswordHash(request.NewPassword, out byte[] passwordHash, out byte[] passwordSalt);

            var update = Builders<User>.Update
                .Set(u => u.Password, Convert.ToBase64String(passwordHash))
                .Set(u => u.PasswordSalt, Convert.ToBase64String(passwordSalt));

            await _users.UpdateOneAsync(u => u.Id == userId, update);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
        {
            using (var hmac = new HMACSHA512(storedSalt))
            {
                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(storedHash);
            }
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_jwtSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string GenerateResetToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_resetTokenSecret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, user.Id) }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        private string ValidateResetToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_resetTokenSecret);

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                return jwtToken.Claims.First(x => x.Type == ClaimTypes.NameIdentifier).Value;
            }
            catch
            {
                return null;
            }
        }
    }
} 