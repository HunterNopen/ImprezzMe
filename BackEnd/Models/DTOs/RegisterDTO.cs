using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models.DTOs
{
    public class RegisterDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
