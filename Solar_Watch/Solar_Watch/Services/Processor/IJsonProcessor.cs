using Solar_Watch.Model;

namespace Solar_Watch.Services.Utilities;

public interface IJsonProcessor
{
    Task<GeoCoordinates> ProcessCoordinatesJson(Task<string> data);

    Task<SunriseSunset> ProcessSunriseSunsetJson(Task<string> dataTask);
    string ProcessCityJson(string data);
}