using BackEnd.Models.Entities;

namespace BackEnd.Deprecated._Services.Interfaces
{
    public interface IAuthService : IService
    {
        string CreateAuthToken(User user);
    }
}
