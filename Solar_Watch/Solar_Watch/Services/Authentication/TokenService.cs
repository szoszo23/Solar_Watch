using Microsoft.AspNetCore.Identity;

namespace Solar_Watch.Services.Authentication;

public class TokenService : ITokenService
{
    private const int ExpirationMinutes = 30;

    public string CreateToken(IdentityUser user)
    {

        return null;
    }
}