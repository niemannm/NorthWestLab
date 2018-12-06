using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Wage")]
    public class Wage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WageID { get; set; }

        [Display(Name = "Wage Amount")]
        [DataType(DataType.Currency)]
        public int WageAmount { get; set; }
    }
}