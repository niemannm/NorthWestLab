using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Test_Sample_Rel")]
    public class Test_Sample_Rel
    {
        //foreign key to Sample
        [Key, Column(Order = 1)]
        public int? CompoundSequenceCode { get; set; }
        public virtual Sample Sample { get; set; }

        //foreign key to Test
        [Key, Column(Order = 2)]
        public int? TestID { get; set; }
        public virtual Test Test { get; set; }
    }
}