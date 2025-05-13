using Microsoft.AspNetCore.Rewrite;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

// Registering the service using Singleton lifetime for simplicity
// It persists data for the lifetime of the app (in-memory store)
builder.Services.AddSingleton<ITaskService, TaskService>();

var app = builder.Build();

#region URL Rewriting Middleware
// UseRewriter allows custom URL rewrites or redirects
var rewriteOptions = new RewriteOptions()
    .AddRedirect("^todo$", "api/todo"); // e.g., /todo -> /api/todo
app.UseRewriter(rewriteOptions);
#endregion

#region Minimal API Endpoints

app.MapGet("/api/todo", (ITaskService service) =>
{
    return Results.Ok(service.GetAll());
});

app.MapGet("/api/todo/{id}", (int id, ITaskService service) =>
{
    var task = service.Get(id);
    return task is null ? Results.NotFound() : Results.Ok(task);
});

app.MapPost("/api/todo", async (TodoItem item, ITaskService service) =>
{
    service.Create(item);
    return Results.Created($"/api/todo/{item.Id}", item);
})
.AddEndpointFilter(async (context, next) =>
{
    // Example validation filter
    var item = context.GetArgument<TodoItem>(0);
    if (string.IsNullOrWhiteSpace(item.Title))
    {
        return Results.BadRequest("Title is required.");
    }
    return await next(context);
});

app.MapPut("/api/todo/{id}", (int id, TodoItem item, ITaskService service) =>
{
    var updated = service.Update(id, item);
    return updated ? Results.Ok(item) : Results.NotFound();
});

app.MapDelete("/api/todo/{id}", (int id, ITaskService service) =>
{
    var deleted = service.Delete(id);
    return deleted ? Results.NoContent() : Results.NotFound();
});

#endregion

app.Run();

#region Models and Services

// Model representing a TODO item
record TodoItem(int Id, string Title, bool IsDone);

// Interface defining the contract for a TaskService
interface ITaskService
{
    IEnumerable<TodoItem> GetAll();
    TodoItem? Get(int id);
    void Create(TodoItem item);
    bool Update(int id, TodoItem updatedItem);
    bool Delete(int id);
}

// In-memory implementation of the ITaskService
class TaskService : ITaskService
{
    private readonly List<TodoItem> _items = new();
    private int _nextId = 1;

    public IEnumerable<TodoItem> GetAll() => _items;

    public TodoItem? Get(int id) => _items.FirstOrDefault(x => x.Id == id);

    public void Create(TodoItem item)
    {
        var newItem = item with { Id = _nextId++ };
        _items.Add(newItem);
    }

    public bool Update(int id, TodoItem updatedItem)
    {
        var index = _items.FindIndex(x => x.Id == id);
        if (index == -1) return false;
        _items[index] = updatedItem with { Id = id };
        return true;
    }

    public bool Delete(int id)
    {
        var item = Get(id);
        return item != null && _items.Remove(item);
    }
}

#endregion