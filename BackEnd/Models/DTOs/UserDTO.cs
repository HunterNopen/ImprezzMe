using BackEnd.Models.Entities;

namespace BackEnd.Models.DTOs
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public City? City { get; set; }
    }
}
