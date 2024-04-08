using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
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
builder.Services.AddSwaggerGen(option =>
{
    option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
    option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter a valid token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});

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
builder.Services.AddScoped<ITokenService, TokenService>();

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