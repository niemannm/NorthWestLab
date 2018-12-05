using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Sample")]
    public class Sample
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Compound Sequence Code")]
        public int CompoundSequenceCode { get; set; }

        //foreign key to Compound
        public int? LTNumber { get; set; }
        public virtual Compound Compound { get; set; }
    }
}