using BackEnd.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace BackEnd.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> GetAllAsync();

        Task<TEntity> GetByIdAsync(int id);

        Task<int> AddAsync(TEntity entity);

        void Delete(TEntity entity);

        Task DeleteByIdAsync(int id);

        void Update(TEntity entity);
    }
}
