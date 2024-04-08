using Microsoft.AspNetCore.Mvc;
using Solar_Watch.Services.Authentication;

namespace Solar_Watch.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authenticationService;

    public AuthController(IAuthService authenticationService)
    {
        _authenticationService = authenticationService;
    }
}