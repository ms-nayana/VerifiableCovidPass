using System.ComponentModel.DataAnnotations;

namespace CovidPass.Models
{
    public class UserInfo
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "PhoneNumer")]
        public string PhoneNumer { get; set; }
    }
}
