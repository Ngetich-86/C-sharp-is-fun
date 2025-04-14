# Social Media Backend API

A RESTful API backend for a social media application built with ASP.NET Core and MongoDB.

## Project Structure

```
Backend/
├── Controllers/           # API endpoints
│   ├── AuthController.cs  # Authentication endpoints
│   └── UsersController.cs # User management endpoints
├── Data/                  # Data access layer
│   ├── DatabaseContext.cs # MongoDB context
│   └── MongoDbSettings.cs # MongoDB configuration
├── Models/               # Data models
│   ├── User.cs           # User model
│   └── AuthModels.cs     # Authentication models
├── Services/             # Business logic
│   ├── AuthService.cs    # Authentication service
│   └── UserService.cs    # User service
├── Program.cs            # Application entry point
└── appsettings.json      # Configuration file
```

## Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download)
- [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) account
- [Visual Studio Code](https://code.visualstudio.com/) or [Visual Studio](https://visualstudio.microsoft.com/)

## Getting Started

1. **Create a new project**
```bash
dotnet new webapi -o Backend
cd Backend
```

2. **Install required NuGet packages**
```bash
# MongoDB
dotnet add package MongoDB.Driver

# Authentication
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package System.IdentityModel.Tokens.Jwt

# Swagger
dotnet add package Swashbuckle.AspNetCore
```

3. **Configure MongoDB Atlas**
- Create a new cluster in MongoDB Atlas
- Get your connection string
- Update `appsettings.json` with your MongoDB settings:
```json
{
  "MongoDbSettings": {
    "ConnectionString": "your_mongodb_connection_string",
    "DatabaseName": "SocialMediaDb",
    "UsersCollectionName": "users"
  },
  "JwtSettings": {
    "Secret": "your-secret-key-at-least-32-characters-long",
    "ResetTokenSecret": "your-reset-token-secret-key",
    "ExpiryInDays": 7
  }
}
```

4. **Create the project structure**
```bash
mkdir Controllers
mkdir Data
mkdir Models
mkdir Services
```

5. **Create the necessary files**
- Create the files as shown in the project structure above
- Copy the code from the respective files in the repository

## Running the Project

1. **Start the application**
```bash
dotnet run
```

2. **Verify the connection**
- The console should show:
  ```
  Attempting to connect to MongoDB Atlas...
  Successfully connected to MongoDB Atlas!
  Server is running on Port 5001
  ```

3. **Access the API**
- Swagger UI: https://localhost:5001/swagger
- API Base URL: https://localhost:5001/api

## API Endpoints

### Authentication
- `POST /api/auth/register` - Register a new user
- `POST /api/auth/login` - Login and get JWT token
- `POST /api/auth/forgot-password` - Request password reset
- `POST /api/auth/reset-password` - Reset password with token

### Users
- `GET /api/users` - Get all users (requires authentication)
- `GET /api/users/{id}` - Get user by ID (requires authentication)
- `GET /api/users/profile` - Get current user's profile (requires authentication)
- `PUT /api/users/profile` - Update current user's profile (requires authentication)
- `DELETE /api/users/{id}` - Delete user (requires admin role)

## Testing the API

1. **Register a new user**
```bash
curl -X POST https://localhost:5001/api/auth/register \
-H "Content-Type: application/json" \
-d '{"username":"testuser","email":"test@example.com","fullName":"Test User","password":"password123"}'
```

2. **Login**
```bash
curl -X POST https://localhost:5001/api/auth/login \
-H "Content-Type: application/json" \
-d '{"username":"testuser","password":"password123"}'
```

3. **Access protected endpoints**
```bash
curl https://localhost:5001/api/users/profile \
-H "Authorization: Bearer YOUR_JWT_TOKEN"
```

## Development Tools

- **Thunder Client** (VS Code extension) for API testing
- **MongoDB Compass** for database management
- **Postman** for API testing (alternative to Thunder Client)

## Security Features

- JWT-based authentication
- Password hashing with salt
- Role-based authorization
- HTTPS enabled
- Secure password reset flow

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Push to the branch
5. Create a Pull Request

## License

This project is licensed under the MIT License.