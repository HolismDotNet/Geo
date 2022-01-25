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

    public static Repository<Geo.Geo.TimeZone> TimeZone
    {
        get
        {
            return new Repository<Geo.Geo.TimeZone>(new GeoContext());
        }
    }
}
