namespace Darius.Api.Features.Weather;

public record WeatherResponse(string LocationName, double TemperatureC, double WindSpeedKmh, DateTimeOffset Time);

// Modelos para deserializar o JSON do Open-Meteo
internal record OpenMeteoResponse(CurrentWeather CurrentWeather);

internal record CurrentWeather(
    double Temperature,
    double Windspeed,
    string Time);