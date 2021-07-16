using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Holism.Geo.Models;

namespace Holism.Geo.DataAccess
{
    public class GeoContext : DatabaseContext
    {
        public override string ConnectionStringName => "Geo";

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
