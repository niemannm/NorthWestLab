using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("AssayType_TestType_Rel")]
    public class AssayType_TestType_Rel
    {
        //Composite key to AssayOrder
        [Key, Column(Order = 1)]
        public int? AssayID { get; set; }
        public virtual AssayType AssayType { get; set; }

        //Composite key to Test
        [Key, Column(Order = 2)]
        public int? TestTypeID { get; set; }
        public virtual TestType TestType { get; set; }
    }
}