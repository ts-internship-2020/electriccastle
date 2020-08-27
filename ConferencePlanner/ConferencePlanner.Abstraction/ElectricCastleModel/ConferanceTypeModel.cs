using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
     public class ConferanceTypeModel
    {
        public int ConferenceTypeId { get; set; }

        [DisplayName("Name")]
        public string ConferenceTypeName { get; set; }

        [DisplayName("Code")]
        public string ConferenceTypeCode { get; set; }
    }
}
