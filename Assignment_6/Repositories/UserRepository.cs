using Assignment_6.AppDBContext;
using Assignment_6.Models;
using Assignment_6.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Assignment_6.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _dbcontext;

        public UserRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<User> CreateUser(User user)
        {
            _dbcontext.Users.Add(user);

            await _dbcontext.SaveChangesAsync();

            return user;
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbcontext.Users.ToListAsync();
        }

        public async Task<User> GetUserById(int id)
        {
            var task = await _dbcontext.Users.FindAsync(id);

            return task;
        }
    }
}
