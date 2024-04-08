using Microsoft.AspNetCore.Identity;

namespace Solar_Watch.Services.Authentication;

public interface ITokenService
{
    public string CreateToken(IdentityUser user, string role);
}