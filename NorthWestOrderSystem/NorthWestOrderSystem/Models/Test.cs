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

        [Display(Name = "Scheduled Date")]
        [DataType(DataType.Date)]
        public DateTime ScheduledDate { get; set; }

        [Display(Name = "Completion Date")]
        [DataType(DataType.Date)]
        public DateTime CompletionDate { get; set; }

        [Display(Name = "Concentration")]
        public string Concentration { get; set; }

        [Display(Name = "Actual Cost")]
        [DataType(DataType.Currency)]
        public double ActualCost { get; set; }

        //foreign key to TestType
        public int? TestTypeID { get; set; }
        public virtual TestType TestType { get; set; }
    }
}