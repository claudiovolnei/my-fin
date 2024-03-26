using Microsoft.EntityFrameworkCore;
using MyFin.Infrastructure.CrossCutting.IOC;
using MyFin.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

ConfigurationIOC.Load(builder.Services);

string connection = builder.Configuration.GetConnectionString("MyFin_Postgres") ??
                    throw new Exception("string de conex�o n�o encontrada.");

//builder.Services.AddDbContext<MyFinDbContext>(options =>
//                options.UseSqlite(connection, migration => migration.MigrationsAssembly("MyFin.Presentation")));

builder.Services.AddDbContext<MyFinDbContext>(options =>
                options.UseNpgsql(connection, migration => migration.MigrationsAssembly("MyFin.Presentation")));

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
