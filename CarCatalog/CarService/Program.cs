using Azure;
using Azure.Data.Tables;
using CarService;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS services
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Use CORS
app.UseCors();

app.MapGet("/api/cars", async () =>
{
    var connectionString = app.Configuration.GetConnectionString("AzureTableStorage");
    var tableClient = new TableClient(connectionString, "Cars");

    var cars = new List<Car>();

    await foreach (var carEntity in tableClient.QueryAsync<CarEntity>())
    {
        cars.Add(new Car
        {
            Make = carEntity.Make,
            Model = carEntity.Model,
            Year = carEntity.Year
        });
    }

    return cars;
});

app.Run();

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

