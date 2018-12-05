using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Assay_Test_Rel")]
    public class Assay_Test_Rel
    {
        //Composite key to AssayOrder
        [Key, Column(Order = 1)]
        public int? OrderID { get; set; }
        public virtual AssayOrder AssayOrder { get; set; }

        //Composite key to Test
        [Key, Column(Order = 2)]
        public int? TestID { get; set; }
        public virtual Test Test { get; set; }

        [Display(Name = "Raw Test Results")]
        public string RawTestResults { get; set; }

        [Display(Name = "Analysis")]
        public string Analysis { get; set; }
    }
}