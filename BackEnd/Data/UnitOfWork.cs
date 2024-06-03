using BackEnd.Repositories;
using BackEnd.Repositories.Interfaces;

namespace BackEnd.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context = new DataContext(default);
        public IUserRepository UserRepository => new UserRepository(context);

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
