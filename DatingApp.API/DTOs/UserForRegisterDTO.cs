using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DTOs
{
    public class UserForRegisterDTO
    {
        [Required(ErrorMessage = "Got To Have a Username Buddy")]
        [MinLength(4, ErrorMessage = "More Than 4 Mr.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Yes, Password Jacko")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Too Weak")]
        public string Password { get; set; }
    }
}