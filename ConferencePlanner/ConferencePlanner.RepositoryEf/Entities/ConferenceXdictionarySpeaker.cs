using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class ConferenceXdictionarySpeaker
    {
        public int DictionarySpeakerId { get; set; }
        public int ConferenceId { get; set; }
        public bool IsMainSpeaker { get; set; }

        public virtual Conference Conference { get; set; }
        public virtual DictionarySpeaker DictionarySpeaker { get; set; }
    }
}
