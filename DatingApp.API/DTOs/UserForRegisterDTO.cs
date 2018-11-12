using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDTO
    {
        [Required(ErrorMessage = "Username is Required")]
        [MinLength(4, ErrorMessage = "More Than 4 Mr.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Too Weak")]
        public string Password { get; set; }
    }
}