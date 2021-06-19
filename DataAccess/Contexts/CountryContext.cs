using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Holism.Geo.DataAccess.DbContexts
{
    public class CountryContext : DbContext
    {
        string databaseName;

        public CountryDbContext()
            : base()
        {
        }

        public CountryDbContext(string databaseName)
            : base()
        {
            this.databaseName = databaseName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Config.GetConnectionString(databaseName ?? Config.DatabaseName));
        }

        public ICollection<Holism.Geo.DataAccess.Models.Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Holism.Geo.DataAccess.Models.Country>().ToTable("Countries");
            modelBuilder.Entity<Holism.Geo.DataAccess.Models.Country>().Ignore(i => i.RelatedItems);
            base.OnModelCreating(modelBuilder);
        }
    }
}
