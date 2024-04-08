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

    [HttpGet("GetSunriseSunset"), Authorize(Roles = "User, Admin")]
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
            var existingSunrise = _sunriseSunsetRepository.GetByName(existingCity.CityId, date);
            if (existingSunrise != null)
            {
                _sunriseSunsetRepository.Delete(existingSunrise);
                _cityRepository.Delete(existingCity);
            }

            return Ok("City and Sunrise sunset deleted");
        }
        
        return NotFound("city not found");
        
    }

    [HttpPatch("SunriseSunset"), Authorize(Roles = "Admin")]
    public async Task<ActionResult<SolarWatch>> UpdateSunriseSunset([Required] string city, [Required] DateTime date,
        DateTime? sunrise, DateTime? sunset)
    {
        var existingCity = _cityRepository.GetByName(city);

        if (existingCity == null)
        {
            return NotFound("City not found");
        }

        var existingSunriseSunset = _sunriseSunsetRepository.GetByName(existingCity.CityId, date);

        if (existingSunriseSunset == null)
        {
            return NotFound("Sunrise and sunset data not found for the specified city and date");
        }

        // Update the sunrise and sunset times if provided in the parameters
        if (sunrise.HasValue)
        {
            existingSunriseSunset.Sunrise = sunrise.Value;
        }

        if (sunset.HasValue)
        {
            existingSunriseSunset.Sunset = sunset.Value;
        }

        _sunriseSunsetRepository.Update(existingSunriseSunset);

        var updatedSolarWatch = new SolarWatch
        {
            Date = date,
            City = city,
            Sunrise = existingSunriseSunset.Sunrise,
            Sunset = existingSunriseSunset.Sunset
        };

        return Ok(updatedSolarWatch);
    }
}