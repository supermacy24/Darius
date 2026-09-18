namespace Darius.Api.Features.Weather;

public static class WeatherEndpoint
{
    public static WebApplication MapWeatherEndpoints(this WebApplication app)
    {
        app.MapGet("/weather", async (WeatherService service) => await service.GetForecastAsync());
        return app;
    }
}