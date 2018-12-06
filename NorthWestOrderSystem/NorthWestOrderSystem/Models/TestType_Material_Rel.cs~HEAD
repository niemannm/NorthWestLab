using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("TestType_Material_Rel")]
    public class TestType_Material_Rel
    {
        //foreign key to Test
        [Key, Column(Order = 1)]
        public int? TestTypeID { get; set; }
        public virtual TestType TestType { get; set; }

        //foreign key to Employee
        [Key, Column(Order = 2)]
        public int? MaterialID { get; set; }
        public virtual Material Material{ get; set; }
    }
}