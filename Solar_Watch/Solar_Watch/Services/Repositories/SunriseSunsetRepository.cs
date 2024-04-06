using Solar_Watch.Model;

namespace Solar_Watch.Services.Repositories;

public class SunriseSunsetRepository
{
    private SolarWatchDbContext _dbContext;

    public SunriseSunsetRepository(SolarWatchDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public IEnumerable<SunriseSunset> GetAll()
    {

        return _dbContext.SunriseSunsets.ToList();
    }

    public SunriseSunset? GetByName(int cityId, DateTime date)
    {

        return _dbContext.SunriseSunsets.FirstOrDefault(ss => ss.City.CityId == cityId && ss.Sunrise.Date == date);
    }

    public void Add(SunriseSunset sunriseSunset)
    {

        _dbContext.Add(sunriseSunset);
        _dbContext.SaveChanges();
    }

    public void Delete(SunriseSunset sunriseSunset)
    {

        _dbContext.Remove(sunriseSunset);
        _dbContext.SaveChanges();
    }

    public void Update(SunriseSunset sunriseSunset)
    {

        _dbContext.Update(sunriseSunset);
        _dbContext.SaveChanges();
    }
}