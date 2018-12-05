using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Compound")]
    public class Compound
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LTNumber { get; set; }

        [Display(Name = "Compound Name")]
        public string CompoundName { get; set; }

        [Display(Name = "Compound Status")]
        public string CompoundStatus { get; set; }

        [DisplayFormat(DataFormatString = "{dd MMM yyyy}")]
        [Display(Name = "Date Arrived")]
        [DataType(DataType.Date)]
        public DateTime DateArrived { get; set; }

        [DisplayFormat(DataFormatString = "{dd MMM yyyy}")]
        [Display(Name = "Confirmation Date")]
        [DataType(DataType.Date)]
        public DateTime ConfirmationDateTime { get; set; }

        [Display(Name = "Weight")]
        public string Weight { get; set; }

        [Display(Name = "Molecular Mass")]
        public string MolecularMass { get; set; }

        [Display(Name = "Maximum Tolerated Dose")]
        public string MaximumToleratedDose { get; set; }

        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        //foreign key to Employee
        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}