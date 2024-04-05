using System.Net;

namespace Solar_Watch.Services.Utilities;

public class GeoCodingApi : IGeoCodingApi
{
    private readonly ILogger<GeoCodingApi> _logger;
    private readonly string _apiKey;
    
    public GeoCodingApi(ILogger<GeoCodingApi> logger, string apiKey)
    {
        _logger = logger;
        _apiKey = apiKey;
    }
    
    public async Task<string> GetCoordinates(string city)
    {
        var url = $"http://api.openweathermap.org/geo/1.0/direct?q={city}&limit={1}&appid={_apiKey}";

        using var client = new HttpClient();
        var response = await client.GetAsync(url);
        _logger.LogInformation($"Received data from API: {response}");
        if( response.StatusCode == HttpStatusCode.NotFound)
        {
            return null;
        }

        return await response.Content.ReadAsStringAsync();
    }
}