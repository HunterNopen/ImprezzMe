namespace BackEnd.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }

        Task SaveAsync();
    }
}
