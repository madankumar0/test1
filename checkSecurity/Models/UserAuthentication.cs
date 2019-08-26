using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace checkSecurity.Models
{
    public class UserAuthentication
    {
        [Display(Name ="User Name")]
        [MaxLength(30), MinLength(5)]
        [Required]
        [EmailAddress]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, ErrorMessage = "Must be between 5 and 20 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}