using Assignment_4.Models;

namespace Assignment_4.Repository
{
    public interface ITaskRepository
    {
        public List<Tasks> GetAll();
        public Tasks GetTask(int id);

        public Tasks CreateTask(Tasks task);
    }
}
