using BackEnd.Models.DTOs;
using BackEnd.Models.Entities;

namespace BackEnd.Models.Mappers
{
    public interface IMapper
    {
        IMap<UserDTO, User> forUser();
    }
}
