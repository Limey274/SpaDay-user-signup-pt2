using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.ViewModel
{
    public class AddUserViewModel
    {


        [Required(ErrorMessage = "Please Enter a Username")]
        [StringLength(15, MinimumLength = 5)]
        public string Username { get; set; }


        //[Required(ErrorMessage ="Please Enter your Email Address")]
        [EmailAddress]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please Enter a Password")]
        [StringLength(20, MinimumLength = 6)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please Verify your Password")]
        [Compare("Password", ErrorMessage = "The two passwords must match")]
        public string Verify { get; set; }

      }
}