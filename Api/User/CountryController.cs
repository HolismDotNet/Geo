using Holism.Api;
using Holism.Business;
using Holism.Geo.Business;
using Holism.Geo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Holism.Geo.UserApi
{
    public class CountryController : ReadController<Country>
    {
        public override ReadBusiness<Country> ReadBusiness => new CountryBusiness();
    }
}
