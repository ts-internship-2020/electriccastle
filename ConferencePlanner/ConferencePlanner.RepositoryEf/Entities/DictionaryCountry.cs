using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class DictionaryCountry
    {
        public DictionaryCountry()
        {
            DictionaryDistrict = new HashSet<DictionaryDistrict>();
        }

        public int DictionaryCountryId { get; set; }
        public string CountryCode { get; set; }
        public string DictionaryCountryName { get; set; }

        public virtual ICollection<DictionaryDistrict> DictionaryDistrict { get; set; }
    }
}
