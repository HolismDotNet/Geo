namespace Geo;

public class CountryController : ReadController<Country>
{
    public override ReadBusiness<Country> ReadBusiness => new CountryBusiness();
}
