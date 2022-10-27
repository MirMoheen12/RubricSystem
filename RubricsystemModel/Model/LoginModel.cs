using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubricsystemModel.Model
{
    public class LoginModel
    {
        [Required(ErrorMessage = "The Email is required.")]
        [EmailAddress(ErrorMessage = "Email is incorrect")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember Me")]
        [Required(ErrorMessage = "This Field is Required")]
        public bool RememberMe { get; set; }
    }
}
