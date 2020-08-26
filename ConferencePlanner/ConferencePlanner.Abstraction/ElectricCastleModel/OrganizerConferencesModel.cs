using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class OrganizerConferencesModel
    {

        public int ConferenceId { get; set; }

        [DisplayName("Name")]
        public string ConferenceName { get; set; }

        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        public DateTime EndDate { get; set; }

        [DisplayName("Conference Type")]
        public string ConferenceType { get; set; }

        [DisplayName("Conference Category")]
        public string ConferenceCategory { get; set; }

        public string Adress { get; set; }

        [DisplayName("Main Speaker")]
        public string MainSpeaker { get; set; }
    }
}
