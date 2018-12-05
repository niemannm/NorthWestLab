using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Please put a First Name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please put a Last Name")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please put a Street Address")]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required(ErrorMessage = "Please put a City")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please put a State")]
        [Display(Name = "State")]
        public string State { get; set; }

        [RegularExpression(@"^\d{5}([\-]\d{4})?$", ErrorMessage = "Zip Codes should be 5 numbers")]
        [Required(ErrorMessage = "Please put a Zipcode")]
        [Display(Name = "Zipcode")]
        public int Zip { get; set; }

        [EmailAddress(ErrorMessage = "Please put a valid Email")]
        [Required(ErrorMessage = "Please put an Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [RegularExpression(@"^\+?\(?\d+\)?(\s|\-|\.)?\d{1,3}(\s|\-|\.)?\d{4}[\s]*[\d]*$", ErrorMessage = "Please put a valid phone number: (###) ###-####")]
        [Required(ErrorMessage = "Please put a Phone Number")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }
    }
}