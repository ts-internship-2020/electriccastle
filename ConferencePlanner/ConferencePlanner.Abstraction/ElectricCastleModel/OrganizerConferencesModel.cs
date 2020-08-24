using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class OrganizerConferencesModel
    {
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string ConferenceType { get; set; }

        public string ConferenceCategory { get; set; }

        public string CityName { get; set; }

        public string CountryCode { get; set; }

        public string MainSpeaker { get; set; }
    }
}
