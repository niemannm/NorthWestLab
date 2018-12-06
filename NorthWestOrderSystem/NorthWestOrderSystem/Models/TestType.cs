using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("TestType")]
    public class TestType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestTypeID { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Procedures")]
        public string Procedures { get; set; }

        [Display(Name = "Estimated Duration")]
        public string EstimatedDuration { get; set; }

        [Display(Name = "Estimated Cost")]
        public int EstimatedCost { get; set; }
    }
}