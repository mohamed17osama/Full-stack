using Assignment_6.Models;

namespace Assignment_6.Services.Interfaces
{
    public interface IUserService
    {
        public Task<User> CreateUser(User user);

        public Task<User> GetUserById(int id);

        public Task<List<User>> GetAll();
    }
}
