using Microsoft.AspNetCore.Mvc;

namespace Solar_Watch.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SolarController : ControllerBase
{
    private readonly ILogger<SolarController> _logger;

    public SolarController(ILogger<SolarController> logger)
    {
        _logger = logger;
    }
}