using System.Collections.Generic;
using Holism.Geo.Models;
using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace Holism.Geo.DataAccess
{
    public class GeoContext : DatabaseContext
    {
        public override string ConnectionStringName => "Geo";

        public DbSet<Country> Countries { get; set; }

        public DbSet<TimeZone> TimeZones { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
