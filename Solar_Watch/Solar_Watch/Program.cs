using Microsoft.EntityFrameworkCore;
using Solar_Watch.Services;
using Solar_Watch.Services.Utilities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
builder.Services.AddSingleton<IJsonProcessor,JsonProcessor>();
builder.Services.AddSingleton<ISunApi, SunApi>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();