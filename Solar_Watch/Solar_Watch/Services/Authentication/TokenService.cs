using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Solar_Watch.Services.Authentication;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;
    private const int ExpirationMinutes = 30;

    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    public string CreateToken(IdentityUser user)
    {

        return null;
    }
    
    private SigningCredentials CreateSigningCredentials()
    {
        return new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration.GetSection("IssuerSigningKey").Value)
            ),
            SecurityAlgorithms.HmacSha256
        );
    }
}