using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class ParticipantsConferencesModel
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string ConferenceType { get; set; }

        public string ConferenceCategory { get; set; }

        public string Address { get; set; }

        public string Speaker { get; set; }

        public string StateName { get; set; }
    }
}
