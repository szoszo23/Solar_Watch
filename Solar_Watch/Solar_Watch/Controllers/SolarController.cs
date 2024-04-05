using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Solar_Watch.Model;
using Solar_Watch.Services.Utilities;

namespace Solar_Watch.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SolarController : ControllerBase
{
    private readonly ILogger<SolarController> _logger;
    private readonly IJsonProcessor _jsonProcessor;
    private readonly string _apiKey;
    private readonly ISunApi _sunApi;
    private readonly IGeoCodingApi _geoCodingApi;
    public SolarController(ILogger<SolarController> logger, IJsonProcessor jsonProcessor, ISunApi sunApi,
        IGeoCodingApi geoCodingApi)
    {
        _logger = logger;
        _jsonProcessor = jsonProcessor;
        _sunApi = sunApi;
        _geoCodingApi = geoCodingApi;
        DotNetEnv.Env.Load();
        _apiKey = DotNetEnv.Env.GetString("API_KEY");
    }

    [HttpGet("GetSunriseSunset")]
    public async Task<ActionResult<SolarWatch>> GetSunriseSunset([Required] string city, [Required] DateTime date)
    {
        City searchedCity;
        var geoCoordinatesTask = _geoCodingApi.GetCoordinates(city);
        var geoCoordinates = await geoCoordinatesTask;
        var coordinatesTask = _jsonProcessor.ProcessCoordinatesJson(geoCoordinatesTask);
        var coordinates = await coordinatesTask;
        var country = _jsonProcessor.ProcessCityJson(geoCoordinates);

        if (coordinates != null)
        {
            searchedCity = new City()
            {
                Name = city,
                Coordinates = coordinates,
                Country = country
            };
        }
        else
        {
            return NotFound("City not found");
        }

        SunriseSunset searchedSunriseSunset;
        var sunriseTask = _sunApi.GetSunriseSunset(searchedCity.Coordinates, date);
        var sunriseJsonTask = _jsonProcessor.ProcessSunriseSunsetJson(sunriseTask);
        var sunriseJson = await sunriseJsonTask;

        if (sunriseJson != null)
        {
            searchedSunriseSunset = new SunriseSunset()
            {
                City = searchedCity,
                Sunrise = sunriseJson.Sunrise,
                Sunset = sunriseJson.Sunset
            };
        }
        else
        {
            return NotFound("Sunrise sunset data not found");
        }

        var solarWatch = new SolarWatch()
        {
            Date = date,
            City = city,
            Sunrise = searchedSunriseSunset.Sunrise,
            Sunset = searchedSunriseSunset.Sunset
        };

        return Ok(solarWatch);
    }
}