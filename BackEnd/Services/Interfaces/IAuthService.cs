using BackEnd.Models.Entities;

namespace BackEnd._Services.Interfaces
{
    public interface IAuthService
    {
        string CreateAuthToken(User user);
    }
}
