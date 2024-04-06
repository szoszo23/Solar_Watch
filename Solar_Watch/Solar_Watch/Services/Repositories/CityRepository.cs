using Solar_Watch.Model;

namespace Solar_Watch.Services.Repositories;

public class CityRepository
{
    private SolarWatchDbContext _dbContext;

    public CityRepository(SolarWatchDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public IEnumerable<City> GetAll()
    {

        return _dbContext.Cities.ToList();
    }

    public City? GetByName(string name)
    {

        return _dbContext.Cities.FirstOrDefault(c => c.Name == name);
    }

    public void Add(City city)
    {

        _dbContext.Add(city);
        _dbContext.SaveChanges();
    }

    public void Delete(City city)
    {

        _dbContext.Remove(city);
        _dbContext.SaveChanges();
    }

    public void Update(City city)
    {

        _dbContext.Update(city);
        _dbContext.SaveChanges();
    }
}