using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("PaymentInfo")]
    public class PaymentInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentInfoID { get; set; }

        //foreign key to Customer
        public int? CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [Display(Name = "Card Number")]
        public int CardNumber { get; set; }

        [DisplayFormat(DataFormatString = "{dd MMM yyyy}")]
        [Display(Name = "Expiration Date")]
        [DataType(DataType.Date)]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "CVV")]
        public int CVV { get; set; }

        [Display(Name = "Card Holder")]
        public string CardHolder { get; set; }
    }
}