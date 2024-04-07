using Microsoft.EntityFrameworkCore;
using Solar_Watch.Model;

namespace Solar_Watch.Services;

public class SolarWatchDbContext : DbContext
{
    public DbSet<City> Cities { get; set; }
    public DbSet<SunriseSunset> SunriseSunsets { get; set; }

    public SolarWatchDbContext()
    {
    }
    public SolarWatchDbContext(DbContextOptions<SolarWatchDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<City>().HasKey(c => c.CityId);
        builder.Entity<City>().OwnsOne(c => c.Coordinates);
        builder.Entity<City>().HasIndex(c => c.Name).IsUnique();
        
        builder.Entity<SunriseSunset>()
            .HasOne(ss => ss.City)
            .WithOne(c => c.SunriseSunset)
            .HasForeignKey<City>(c => c.SunriseSunsetId);
    }
}