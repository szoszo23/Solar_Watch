using System.Text.Json;
using Solar_Watch.Model;

namespace Solar_Watch.Services.Utilities;

public class JsonProcessor
{
    private readonly ILogger<JsonProcessor> _logger;

    public JsonProcessor(ILogger<JsonProcessor> logger)
    {
        _logger = logger;
    }

    public async Task<GeoCoordinates> ProcessCoordinatesJson(Task<string> dataTask)
    {
        string data = await dataTask;
        JsonDocument json = JsonDocument.Parse(data);
        JsonElement root = json.RootElement;
        var latitude = root[0].GetProperty("lat").GetDouble();
        var longitude = root[0].GetProperty("lon").GetDouble();

        return new GeoCoordinates
        {
            Latitude = latitude,
            Longitude = longitude
        };
    }
}