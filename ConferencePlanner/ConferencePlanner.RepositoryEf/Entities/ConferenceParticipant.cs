using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class ConferenceParticipant
    {
        public int ConferenceId { get; set; }
        public string ParticipantEmail { get; set; }
        public int? DictionaryParticipantStateId { get; set; }
        public string EmailCode { get; set; }

        public virtual Conference Conference { get; set; }
        public virtual DictionaryParticipantState DictionaryParticipantState { get; set; }
    }
}
