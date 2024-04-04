namespace Solar_Watch.Model;

public class SunriseSunset
{
    public int SunriseSunsetId { get; set; }
    public City City { get; set; }
    public DateTime Sunrise { get; set; }
    public DateTime Sunset { get; set; }
    
}