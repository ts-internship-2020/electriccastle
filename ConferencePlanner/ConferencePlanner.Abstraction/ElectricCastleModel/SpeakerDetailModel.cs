using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class SpeakerDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Rating { get; set; }

        public string  Nationality { get; set; }

        //public string Picture { get; set; }
    }
}
