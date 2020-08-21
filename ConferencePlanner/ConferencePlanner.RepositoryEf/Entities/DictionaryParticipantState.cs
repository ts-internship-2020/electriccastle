using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class DictionaryParticipantState
    {
        public DictionaryParticipantState()
        {
            ConferenceParticipant = new HashSet<ConferenceParticipant>();
        }

        public int DictionaryParticipantStateId { get; set; }
        public string DictionaryParticipantStateName { get; set; }
        public string ParticipantStateCode { get; set; }

        public virtual ICollection<ConferenceParticipant> ConferenceParticipant { get; set; }
    }
}
