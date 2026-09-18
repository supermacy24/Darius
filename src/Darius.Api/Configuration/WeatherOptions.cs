namespace Darius.Api.Configuration;

public class WeatherOptions
{
    public string LocationName {get;set;} = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}