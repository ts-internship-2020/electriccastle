using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class Conference
    {
        public Conference()
        {
            ConferenceParticipant = new HashSet<ConferenceParticipant>();
            ConferenceXdictionarySpeaker = new HashSet<ConferenceXdictionarySpeaker>();
        }

        public int ConferenceId { get; set; }
        public string OrganizerEmail { get; set; }
        public string OrganizerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? DictionaryConferenceCategoryId { get; set; }
        public int? DictionaryConferenceTypeId { get; set; }
        public int LocationId { get; set; }

        public virtual DictionaryConferenceCategory DictionaryConferenceCategory { get; set; }
        public virtual DictionaryConferenceType DictionaryConferenceType { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<ConferenceParticipant> ConferenceParticipant { get; set; }
        public virtual ICollection<ConferenceXdictionarySpeaker> ConferenceXdictionarySpeaker { get; set; }
    }
}
