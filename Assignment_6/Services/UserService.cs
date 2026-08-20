using Assignment_6.Models;
using Assignment_6.Repositories.Interfaces;
using Assignment_6.Services.Interfaces;

namespace Assignment_6.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public async Task<User> CreateUser(User user)
        {
            return await _repo.CreateUser(user);
        }

        public async Task<List<User>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _repo.GetUserById(id);
        }
    }
}
