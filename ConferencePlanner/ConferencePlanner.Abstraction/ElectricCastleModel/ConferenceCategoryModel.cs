using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConferencePlanner.Abstraction.ElectricCastleModel
{
    public class ConferenceCategoryModel
    {
        public int ConferenceCategoryId { get; set; }

        [DisplayName("Name")]
        public string ConferenceCategoryName { get; set; }

        [DisplayName("Code")]
        public string ConferenceCategoryCode { get; set; }
    }
}
