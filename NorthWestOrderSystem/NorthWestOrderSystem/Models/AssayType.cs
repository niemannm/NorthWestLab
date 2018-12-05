using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("AssayType")]
    public class AssayType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AssayID { get; set; }

        [Display(Name = "Assay Title")]
        public string AssayTitle { get; set; }

        [Display(Name = "Full Description")]
        public string FullDescription { get; set; }

        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Display(Name = "Base Price")]
        [DataType(DataType.Currency)]
        public int BasePrice { get; set; }

        [Display(Name = "Procedures")]
        public string Procedures { get; set; }
    }
}