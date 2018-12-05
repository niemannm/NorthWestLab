using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NorthWestOrderSystem.Models
{
    [Table("Employee_Test_Rel")]
    public class Employee_Test_Rel
    {
        //foreign key to Test
        public int? TestID { get; set; }
        public virtual Test Test { get; set; }

        //foreign key to Employee
        public int? EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }

        [Display(Name = "Hours Worked")]
        public int HoursWorked { get; set; }
    }
}