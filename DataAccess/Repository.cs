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

    public static Repository<Models.TimeZone> TimeZone
    {
        get
        {
            return new Repository<Models.TimeZone>(new GeoContext());
        }
    }
}
