# 📝 TODO App with ASP.NET Core Minimal API

This project is a simple TODO CRUD app built using **ASP.NET Core (.NET 7/8)** and demonstrates key concepts I learned from my LinkedIn Learning course.

## 🚀 What I Learned

### ✅ Minimal APIs

I learned how to build RESTful APIs using minimal syntax in `Program.cs`:

- `MapGet`, `MapPost`, `MapPut`, `MapDelete` for routing HTTP requests
- Returning consistent HTTP response types using `Results.Ok`, `Results.Created`, `Results.NotFound`, etc.

### 🔁 URL Rewriting with `UseRewriter`

Used the `UseRewriter()` middleware to:

- Redirect routes such as `/todo` → `/api/todo`
- Improve route structure and support legacy URLs

```csharp
var rewriteOptions = new RewriteOptions()
    .AddRedirect("^todo$", "api/todo");

app.UseRewriter(rewriteOptions);
```
### 🧪 HTTP Testing with Requests.http
- Created a Requests.http file in VS Code to test endpoints manually using the REST Client extension. This helps simulate:

- GET, POST, PUT, DELETE requests

- Sending JSON payloads to the API

### 🔍 Input Validation using AddEndpointFilter
- Used endpoint filters to add lightweight request validation logic before executing the endpoint handler:

```csharp
.AddEndpointFilter(async (context, next) =>
{
    var item = context.GetArgument<TodoItem>(0);
    if (string.IsNullOrWhiteSpace(item.Title))
    {
        return Results.BadRequest("Title is required.");
    }
    return await next(context);
});
```
### 🧰 Dependency Injection
- Used interfaces and DI containers to inject services:

- Defined a contract with ITaskService

- Implemented business logic in TaskService

- Registered the service with AddSingleton() for in-memory persistence

```csharp
builder.Services.AddSingleton<ITaskService, TaskService>();
```

### 🧩 Application Structure
- Program.cs: All routes, DI setup, and models defined in one place

- Requests.http: Manual HTTP testing interface

- In-memory store used for simplicity (no database)