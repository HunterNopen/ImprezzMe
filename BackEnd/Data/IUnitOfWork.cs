using BackEnd.Repositories.Interfaces;

namespace BackEnd.Data
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }

        Task<bool> Complete();
        bool HasChanges();
    }
}
