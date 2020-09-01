using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class Location
    {
        public Location()
        {
            Conference = new HashSet<Conference>();
        }

        public int LocationId { get; set; }
        public int? DictionaryCityId { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string AdressDetails { get; set; }

        public virtual DictionaryCity DictionaryCity { get; set; }
        public virtual ICollection<Conference> Conference { get; set; }
    }
}
