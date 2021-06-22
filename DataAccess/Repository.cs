using Holism.Geo.Models;
using Holism.Geo.DataAccess.Contexts;
using Holism.DataAccess;

namespace Holism.Geo.DataAccess
{
    public class Repository
    {
        public static Repository<Country> Country
        {
            get
            {
                return new Holism.DataAccess.Repository<Country>(new CountryContext());
            }
        }
    }
}
