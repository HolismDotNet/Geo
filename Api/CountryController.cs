using Holism.Api.Controllers;
using Holism.Business;
using Holism.Geo.Business;
using Holism.Geo.Models;

namespace Holism.Geo.Api.Controllers
{
    public class CountryController : ReadController<Country>
    {
        public override ReadBusiness<Country> ReadBusiness => new CountryBusiness();
    }
}
