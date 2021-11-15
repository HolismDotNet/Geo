namespace Holism.Geo.Models
{
    public class TimeZone : Holism.Models.IEntity
    {
        public TimeZone()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public long CountryId { get; set; }

        public string TimeZoneIdentifier { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
