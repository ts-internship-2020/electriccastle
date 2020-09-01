using System;
using System.Collections.Generic;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class ConferenceModel
    {
        public int ConferenceId { get; set; }

        public string ConferenceName { get; set; }

        public string OrganizerEmail { get; set; }

        public string OrganizerName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int DictionaryConferenceCategoryId { get; set; }

        public int DictionaryConferenceTypeId { get; set; }

        public int LocationId { get; set; }

        public string AdressDetails { get; set; }

        public List<SpeakerListModel> Speakers { get; set; }

        public int DictionaryCityId { get; set; }

        public int DictionaryDistrictId { get; set; }

        public int DictionaryCountryId { get; set; }
    }
}
