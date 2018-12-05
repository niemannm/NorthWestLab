using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Materials")]
    public class Material
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaterialID { get; set; }

        [Display(Name = "Material Type")]
        public string MaterialType { get; set; }

        [Display(Name = "Material Definition")]
        public string MaterialDefinition { get; set; }

        [Display(Name = "Cost")]
        [DataType(DataType.Currency)]
        public int Cost { get; set; }

    }
}