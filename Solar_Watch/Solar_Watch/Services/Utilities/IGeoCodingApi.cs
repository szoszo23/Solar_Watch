namespace Solar_Watch.Services.Utilities;

public interface IGeoCodingApi
{
    Task<string> GetCoordinates(string city);
}