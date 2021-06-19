using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Holism.Geo.DataAccess
{
    public class Config : Holism.Framework.Config
    {
        public static string DatabaseConnectionString
        {
            get
            {
                return GetSetting("GeoDatabase");
            }
        }
    }
}