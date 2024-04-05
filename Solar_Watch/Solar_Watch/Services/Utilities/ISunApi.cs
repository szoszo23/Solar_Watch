using Solar_Watch.Model;

namespace Solar_Watch.Services.Utilities;

public interface ISunApi
{
    Task<string> GetSunriseSunset(GeoCoordinates coordinates, DateTime date);
}