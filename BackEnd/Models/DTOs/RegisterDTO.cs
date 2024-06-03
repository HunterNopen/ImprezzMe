using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Login { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
