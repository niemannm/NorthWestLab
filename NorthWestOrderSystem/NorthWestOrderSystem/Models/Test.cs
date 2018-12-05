using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Test")]
    public class Test
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TestID { get; set; }

        [Display(Name = "Estimated Days")]
        public int EstimatedDays { get; set; }

        [DisplayFormat(DataFormatString = "{dd MMM yyyy}")]
        [Display(Name = "Scheduled Date")]
        [DataType(DataType.Date)]
        public DateTime ScheduledDate { get; set; }

        [Display(Name = "Concentration")]
        public string Concentration { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Display(Name = "Actual Cost")]
        [DataType(DataType.Currency)]
        public float ActualCost { get; set; }

        //foreign key to Assay
        public int? AssayID { get; set; }
        public virtual AssayType AssayType { get; set; }
    }
}