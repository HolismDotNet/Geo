namespace Holism.Geo.UserApi;

public class CountryController : ReadController<Country>
{
    public override ReadBusiness<Country> ReadBusiness => new CountryBusiness();
}
