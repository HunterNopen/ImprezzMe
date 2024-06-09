using BackEnd.Models.DTOs;
using BackEnd.Models.Entities;

namespace BackEnd.Models.Mappers
{
    public class Mapper : IMapper
    {
        private readonly IServiceProvider _serviceProvider;

        public Mapper(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IMap<UserDTO, User> forUser(){
            return _serviceProvider.GetService<IMap<UserDTO, User>>();
        }
    }
}
