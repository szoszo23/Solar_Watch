namespace Solar_Watch.Model;

public class City
{
    public int CityId { get; }
    public string Name { get; set; }
    public GeoCoordinates Coordinates { get; set; }
    public string Country { get; set; }
    public SunriseSunset SunriseSunset { get; set; }
    public int SunriseSunsetId { get; set; }
}