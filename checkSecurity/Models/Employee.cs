using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace checkSecurity.Models
{
    public class Employee
    {
        //[Display(Name = "Emp Name")]
        public string Name { get; set; }

       // [Display(Name = "Address")]
        public string Location { get; set; }

       // [Display(Name = "Emp Id")]
        public int Id { get; set; }

       // [MaxLength(10), MinLength(10)]
        public int Mobile { get; set; }

        //[Display(Name = "Active")]
        public bool IsActive { get; set; }

    }
}