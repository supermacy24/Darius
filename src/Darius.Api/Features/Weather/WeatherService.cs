using System.Globalization;
using System.Text.Json;
using Microsoft.Extensions.Options;
using Darius.Api.Configuration;

namespace Darius.Api.Features.Weather;

public class WeatherService
{
    private HttpClient _httpClient;
    private readonly WeatherOptions _options;

    public WeatherService(HttpClient httpClient, IOptions<WeatherOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }

    public async Task<WeatherResponse> GetForecastAsync()
    {
        var url = $"v1/forecast?latitude={_options.Latitude.ToString(CultureInfo.InvariantCulture)}&longitude={_options.Longitude.ToString(CultureInfo.InvariantCulture)}&current_weather=true";

        var response = await _httpClient.GetFromJsonAsync<OpenMeteoResponse>(url, new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
        });

        if (response is null)
        {
            throw new InvalidOperationException("Failed to fetch weather data from Open-Meteo.");
        }

        return new WeatherResponse(
            _options.LocationName,
            response.CurrentWeather.Temperature,
            response.CurrentWeather.Windspeed,
            DateTimeOffset.Parse(response.CurrentWeather.Time));
    }
}
