using Microsoft.AspNetCore.Identity;

namespace Solar_Watch.Services.Authentication;

public class AuthService : IAuthService
{
    private readonly UserManager<IdentityUser> _userManager;

    public AuthService(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<AuthResult> RegisterAsync(string email, string username, string password)
    {
        return new AuthResult(true, email, username, "");
    }
}