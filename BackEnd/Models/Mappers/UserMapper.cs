using BackEnd.Models.DTOs;
using BackEnd.Models.Entities;

namespace BackEnd.Models.Mappers
{
    public class UserMapper : IMap<UserDTO, User>
    {
        public User map(UserDTO dto)
        {
            return map(dto, new User());
        }

        public User map(UserDTO dto, User entity)
        {
            entity.Username = dto.Username;
            entity.City = dto.City;
            entity.Email = dto.Email;

            return entity;
        }
    }
}
