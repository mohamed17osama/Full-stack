using Assignment_4.Models;
using Assignment_4.Repository;

namespace Assignment_4.services
{
    public class TaskService : ITaskService
    {

        private ITaskRepository _repo;

        public TaskService(ITaskRepository repo)
        {
            _repo = repo;
        }

        public Tasks CreateTask(Tasks task)
        {
            return _repo.CreateTask(task);
        }

        public List<Tasks> GetAll()
        {
            return _repo.GetAll();
        }


        public Tasks GetTask(int id)
        {
            return _repo.GetTask(id);
        }
    }
}
