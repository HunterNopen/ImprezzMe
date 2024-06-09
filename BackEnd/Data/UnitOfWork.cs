using BackEnd.Models.Mappers;
using BackEnd.Repositories;
using BackEnd.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;
        private readonly IMapper mapper;

        public UnitOfWork(DataContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        public IUserRepository UserRepository => new UserRepository(context);

        public async Task<bool> Complete()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public bool HasChanges()
        {
            return context.ChangeTracker.HasChanges();
        }
    }
}
