using System.ComponentModel.DataAnnotations;

namespace MyWallWebAPI.Domain.Models.DTOs
{
    public class SignInDTO
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}