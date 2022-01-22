namespace Geo;

public class GeoContext : DatabaseContext
{
    public override string ConnectionStringName => "Geo";

    public DbSet<Country> Countries { get; set; }

    public DbSet<Geo.TimeZone> TimeZones { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
