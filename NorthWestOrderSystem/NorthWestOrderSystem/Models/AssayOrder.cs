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

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        [Display(Name = "Preliminary Charge")]
        [DataType(DataType.Currency)]
        public float PreliminaryCharge { get; set; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        [Display(Name = "Final Charge")]
        [DataType(DataType.Currency)]
        public float? FinalCharge { get; set; }

        [Display(Name = "Due Date")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        [Display(Name = "First Payment")]
        public bool FirstPayment { get; set; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        [Display(Name = "Second Payment")]
        public bool SecondPayment { get; set; }

        [System.Web.Mvc.HiddenInput(DisplayValue = false)]
        [Display(Name = "Discount Percentage")]
        public float? DiscountPercentage { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

        //foreign key to Customer
        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        //foreign key to Status
        public int? StatusID { get; set; }
        public virtual Status Status { get; set; }

        public virtual AssayType AssayType { get; set; }

        public virtual Compound Compound { get; set; }
    }
}