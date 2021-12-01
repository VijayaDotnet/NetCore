using System.ComponentModel.DataAnnotations;
using SignUpValidation.Attributes;

namespace SignUpValidation.Models
{
    public class SignUpModel
    {
        [Required (ErrorMessage = "Name is Mandatory")]
        public string Name { get; set; }

        [Required(ErrorMessage = "UserName is Mandatory")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Mandatory")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Mandatory")]
        [Compare("Password", ErrorMessage = "Confirm Password should match with Password!")]
        public string ConfirmPassword { get; set; }

        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Please enter valid contact number")]
        public string? Contact { get; set; }
        
        [Required(ErrorMessage = "Country is Mandatory")]
        public string Country { get; set; }

        [Required(ErrorMessage = "City is Mandatory")]
        public string City { get; set; }

        [Required(ErrorMessage = "Gender is Mandatory")]
        public string Gender { get; set; }

        [CheckboxValidation(ErrorMessage ="Please accept Terms and Conditions")]
        public bool Termsnconditions { get; set; }


    }
}
