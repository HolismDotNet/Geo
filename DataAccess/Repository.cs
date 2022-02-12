namespace Geo;

public class Repository
{
    public static Write<Geo.Country> Country
    {
        get
        {
            return new Write<Geo.Country>(new GeoContext());
        }
    }

    public static Write<Geo.TimeZone> TimeZone
    {
        get
        {
            return new Write<Geo.TimeZone>(new GeoContext());
        }
    }
}
