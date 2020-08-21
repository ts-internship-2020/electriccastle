using System;
using System.Collections.Generic;

namespace ConferencePlanner.Repository.Ef.Entities
{
    public partial class DictionaryConferenceCategory
    {
        public DictionaryConferenceCategory()
        {
            Conference = new HashSet<Conference>();
        }

        public int DictionaryConferenceCategoryId { get; set; }
        public string DictionaryConferenceCategoryName { get; set; }
        public string ConferenceCategoryCode { get; set; }

        public virtual ICollection<Conference> Conference { get; set; }
    }
}
