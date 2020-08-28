using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class AddConferenceCountryModel
    {
        public int DictionaryCountryId { get; set; }
        public string CountryCode { get; set; }
        public string DictionaryCountryName { get; set; }
    }
}
