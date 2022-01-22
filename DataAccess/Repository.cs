namespace Geo;

public class Repository
{
    public static Repository<Geo.Country> Country
    {
        get
        {
            return new Repository<Geo.Country>(new GeoContext());
        }
    }

    public static Repository<Geo.Models.TimeZone> TimeZone
    {
        get
        {
            return new Repository<Geo.Models.TimeZone>(new GeoContext());
        }
    }
}
