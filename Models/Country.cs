using System;

namespace Holism.Geo.Models
{
    public class Country : Holism.Models.IGuidEntity
    {
        public Country()
        {
            RelatedItems = new System.Dynamic.ExpandoObject();
        }

        public long Id { get; set; }

        public Guid Guid { get; set; }

        public string Name { get; set; }

        public string Capital { get; set; }

        public string OfficialName { get; set; }

        public string AlternativeName { get; set; }

        public string IsoTwoLetterCode { get; set; }

        public string IsoThreeLetterCode { get; set; }

        public string IsoNumericCode { get; set; }

        public string Cctld { get; set; }

        public dynamic RelatedItems { get; set; }
    }
}
