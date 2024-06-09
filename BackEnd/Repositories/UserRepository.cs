using BackEnd.Data;
using BackEnd.Models.Entities;
using BackEnd.Repositories.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext context;

        public UserRepository(DataContext context)
        {
            this.context = context;
        }

        public async Task<int> AddAsync(User entity)
        {
            var user = await context.AddAsync<User>(entity);
            await context.SaveChangesAsync();

            return user.Entity.Id;
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            return await context.Users.FirstOrDefaultAsync(u => u.Username == username);
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
