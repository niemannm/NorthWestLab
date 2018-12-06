using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("AssayOrder")]
    public class AssayOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }

        [Display(Name = "Preliminary Charge")]
        [DataType(DataType.Currency)]
        public int PreliminaryCharge { get; set; }

        [Display(Name = "Final Charge")]
        [DataType(DataType.Currency)]
        public int? FinalCharge { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }


        [Display(Name = "First Payment")]
        public bool FirstPayment { get; set; }


        [Display(Name = "Second Payment")]
        public bool SecondPayment { get; set; }


        [Display(Name = "Discount Percentage")]
        public decimal? DiscountPercentage { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

        //foreign key to Customer
        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        //foreign key to Status
        public int? StatusID { get; set; }
        public virtual Status Status { get; set; }

        //public int? AssayTypeID { get; set; }
        //public virtual AssayType AssayType { get; set; }

        //public int? LTNumber { get; set; }
        //public virtual Compound Compound { get; set; }
    }
}