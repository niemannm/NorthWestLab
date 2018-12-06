using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    public class NewOrder
    {
        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        public String Comments { get; set; }

        [Display(Name = "AssayTitle")]
        public String AssayTitle { get; set; }
        

        [Display(Name = "Compound Name")]
        public String CompoundName { get; set; }



        [Key, Column(Order = 1)]
        public int? OrderID { get; set; }
        public virtual AssayOrder AssayOrder { get; set; }

        [Key, Column(Order = 2)]
        public int? AssayID { get; set; }
        public virtual AssayType AssayType { get; set; }

        public int? LTNumber { get; set; }
        public virtual Compound Compound { get; set; }
    }
}