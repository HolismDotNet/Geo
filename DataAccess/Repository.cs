using Holism.Geo.Models;
using Holism.DataAccess;

namespace Holism.Geo.DataAccess
{
    public class Repository
    {
        public static Repository<Country> Country
        {
            get
            {
                return new Holism.DataAccess.Repository<Country
                >(new GeoContext());
            }
        }
    }
}
