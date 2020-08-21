using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class DictionaryDistrict
    {
        public DictionaryDistrict()
        {
            DictionaryCity = new HashSet<DictionaryCity>();
        }

        public int DictionaryDistrictId { get; set; }
        public string DistrictCode { get; set; }
        public string DictionaryDistrictName { get; set; }
        public int? DictionaryCountryId { get; set; }

        public virtual DictionaryCountry DictionaryCountry { get; set; }
        public virtual ICollection<DictionaryCity> DictionaryCity { get; set; }
    }
}
