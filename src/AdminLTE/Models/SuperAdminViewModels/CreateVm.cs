using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.Models.SuperAdminViewModels
{
    public class CreateVm
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Number Token for Redeem")]
        public string Email { get; set; }

        //[Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Stocks")]
        public string LastName { get; set; }
    }
}
