using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Solar_Watch.Model;
using Solar_Watch.Services.Repositories;
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
    private readonly CityRepository _cityRepository;
    private readonly SunriseSunsetRepository _sunriseSunsetRepository;
    public SolarController(ILogger<SolarController> logger, IJsonProcessor jsonProcessor, ISunApi sunApi,
        IGeoCodingApi geoCodingApi, CityRepository cityRepository, SunriseSunsetRepository sunriseSunsetRepository)
    {
        _logger = logger;
        _jsonProcessor = jsonProcessor;
        _sunApi = sunApi;
        _geoCodingApi = geoCodingApi;
        DotNetEnv.Env.Load();
        _apiKey = DotNetEnv.Env.GetString("API_KEY");
        _cityRepository = cityRepository;
        _sunriseSunsetRepository = sunriseSunsetRepository;
    }

    [HttpGet("GetSunriseSunset"), Authorize(Roles="User, Admin")]
    public async Task<ActionResult<SolarWatch>> GetSunriseSunset([Required] string city, [Required] DateTime date)
    {
        var existingCity = _cityRepository.GetByName(city);


        if (existingCity == null)
        {
            var geoCoordinatesTask = _geoCodingApi.GetCoordinates(city);
            var geoCoordinates = await geoCoordinatesTask;
            var coordinatesTask = _jsonProcessor.ProcessCoordinatesJson(geoCoordinatesTask);
            var coordinates = await coordinatesTask;
            var country = _jsonProcessor.ProcessCityJson(geoCoordinates);

            existingCity = new City()
            {
                Name = city,
                Coordinates = coordinates,
                Country = country
            };
        }

        var existingSunrise = _sunriseSunsetRepository.GetByName(existingCity.CityId, date);
        if (existingSunrise == null)
        {
            var sunriseTask = _sunApi.GetSunriseSunset(existingCity.Coordinates, date);
            var sunriseJsonTask = _jsonProcessor.ProcessSunriseSunsetJson(sunriseTask);
            var sunriseJson = await sunriseJsonTask;

            if (sunriseJson != null)
            {
                existingSunrise = new SunriseSunset()
                {
                    City = existingCity,
                    Sunrise = sunriseJson.Sunrise,
                    Sunset = sunriseJson.Sunset
                };
                _sunriseSunsetRepository.Add(existingSunrise);
            }
            else
            {
                return NotFound("Sunrise sunset data not found");
            }
        }


        var solarWatch = new SolarWatch
        {
            Date = date,
            City = city,
            Sunrise = existingSunrise.Sunrise,
            Sunset = existingSunrise.Sunset
        };

        return Ok(solarWatch);
    }
    
    [HttpDelete("SunriseSunset"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<SolarWatch>> DeleteSunriseSunset([Required] string city, [Required] DateTime date)
    {
        var existingCity = _cityRepository.GetByName(city);


        if (existingCity != null)
        {
            _cityRepository.Delete(existingCity);
            return Ok(existingCity);
        }
        else
        {
            return NotFound("city not found");
        }
    }
}