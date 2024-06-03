using BackEnd.Models.Entities;

namespace BackEnd.Services.Interfaces
{
    public interface IAuthService : IService
    {
        string CreateAuthToken(User user);
    }
}
