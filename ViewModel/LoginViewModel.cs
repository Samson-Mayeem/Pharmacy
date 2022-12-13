using System.ComponentModel.DataAnnotations;

namespace samPharma.ViewModel
{
    public class LoginViewModel
    {
        [Display(Name ="Email Address")]
        [Required(ErrorMessage ="Email address is request")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
