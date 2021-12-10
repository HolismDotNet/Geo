namespace Holism.Geo.Models;

public class TimeZone : IEntity
{
    public TimeZone()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long CountryId { get; set; }

    public string TimeZoneIdentifier { get; set; }

    public dynamic RelatedItems { get; set; }
}
