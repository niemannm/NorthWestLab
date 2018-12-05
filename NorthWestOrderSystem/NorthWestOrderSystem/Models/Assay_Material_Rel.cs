using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Assay_Material_Rel")]
    public class Assay_Material_Rel
    {

        //Composite key to AssayType
        [Key, Column(Order = 1)]
        public int AssayID { get; set; }
        public virtual AssayType AssayType { get; set; }

        //Composite key to Material
        [Key, Column (Order = 2)]
        public int MaterialID { get; set; }
        public virtual Material Material { get; set; }
    }
}