using Assignment_6.Models;

namespace Assignment_6.Repositories.Interfaces
{
    public interface IUserRepository
    {
        public Task<User> CreateUser(User user);

        public Task<User> GetUserById(int id);

        public Task<List<User>> GetAll();

    }
}
