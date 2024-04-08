using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Solar_Watch.Model;
using Solar_Watch.Services;
using Solar_Watch.Services.Authentication;
using Solar_Watch.Services.Repositories;
using Solar_Watch.Services.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        var jwtSettings = builder.Configuration.GetSection("JwtSettings").Get<JwtSettings>();
        var issuerSigningKey = builder.Configuration.GetSection("IssuerSigningKey").Value;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ClockSkew = TimeSpan.Zero,
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings.ValidIssuer,
            ValidAudience = jwtSettings.ValidAudience,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(issuerSigningKey)),
        };
    });
builder.Services
    .AddIdentityCore<IdentityUser>(options =>
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.User.RequireUniqueEmail = true;
        options.Password.RequireDigit = false;
        options.Password.RequiredLength = 4;
        options.Password.RequireNonAlphanumeric = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireLowercase = false;
    })
    .AddEntityFrameworkStores<UserContext>();
builder.Services.AddSingleton<IGeoCodingApi>(provider =>
{
    var logger = provider.GetRequiredService<ILogger<GeoCodingApi>>();
    DotNetEnv.Env.Load();
    var apiKey = DotNetEnv.Env.GetString("API_KEY");
    return new GeoCodingApi(logger, apiKey);
});

builder.Services.AddDbContext<SolarWatchDbContext>(options =>
{
    DotNetEnv.Env.Load();
    var connString = DotNetEnv.Env.GetString("CONNECTION_STRING");
    options.UseSqlServer(connString);
});
builder.Services.AddDbContext<UserContext>(options =>
{
    DotNetEnv.Env.Load();
    var connString = DotNetEnv.Env.GetString("CONNECTION_STRING");
    options.UseSqlServer(connString);
});
builder.Services.AddSingleton<IJsonProcessor,JsonProcessor>();
builder.Services.AddSingleton<ISunApi, SunApi>();
builder.Services.AddScoped<CityRepository>();
builder.Services.AddScoped<SunriseSunsetRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();