namespace Solar_Watch.Services.Authentication;

public class AuthService : IAuthService
{

    public async Task<AuthResult> RegisterAsync(string email, string username, string password)
    {
        return new AuthResult(true, email, username, "");
    }
}