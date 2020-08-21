using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class DictionaryCity
    {
        public DictionaryCity()
        {
            Location = new HashSet<Location>();
        }

        public int DictionaryCityId { get; set; }
        public string CityCode { get; set; }
        public string DictionaryCityName { get; set; }
        public int? DictionaryDistrictId { get; set; }

        public virtual DictionaryDistrict DictionaryDistrict { get; set; }
        public virtual ICollection<Location> Location { get; set; }
    }
}
