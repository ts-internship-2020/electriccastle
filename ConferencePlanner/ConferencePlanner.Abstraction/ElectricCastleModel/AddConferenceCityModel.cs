using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class AddConferenceCityModel
    {
        public int DictionaryCityId { get; set; }
        public string CityCode { get; set; }
        public string DictionaryCityName { get; set; }
        public int DictionaryDistrictId { get; set; }
   
    }
}
