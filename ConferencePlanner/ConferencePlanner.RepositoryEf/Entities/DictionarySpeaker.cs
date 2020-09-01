using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class DictionarySpeaker
    {
        public DictionarySpeaker()
        {
            ConferenceXdictionarySpeaker = new HashSet<ConferenceXdictionarySpeaker>();
        }

        public int DictionarySpeakerId { get; set; }
        public string SpeakerCode { get; set; }
        public string DictionarySpeakerName { get; set; }
        public decimal? Rating { get; set; }
        public string Nationality { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<ConferenceXdictionarySpeaker> ConferenceXdictionarySpeaker { get; set; }
    }
}
