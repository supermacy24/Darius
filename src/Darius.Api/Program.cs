using Darius.Api.Configuration;
using Darius.Api.Features.Clock;
using Darius.Api.Features.Weather;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ClockService>();
builder.Services.AddHttpClient<WeatherService>(client =>
{
    client.BaseAddress = new Uri("https://api.open-meteo.com/");
});

builder.Services.Configure<WeatherOptions>(builder.Configuration.GetSection("Weather"));

var app = builder.Build();

app.MapClockEndpoints();
app.MapWeatherEndpoints();

app.MapGet("/", () => new
{
    name = "Darius",
    status = "running"
});

app.MapGet("/health", () => Results.Ok(new
{
    status = "healthy"
}));

app.Run();