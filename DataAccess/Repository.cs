namespace Holism.Geo.DataAccess;

public class Repository
{
    public static Repository<Country> Country
    {
        get
        {
            return new Repository<Country>(new GeoContext());
        }
    }

    public static Repository<TimeZone> TimeZone
    {
        get
        {
            return new Repository<TimeZone>(new GeoContext());
        }
    }
}
