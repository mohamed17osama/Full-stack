using Assignment5.Interfaces;
using Assignment5.Models;

namespace Assignment5.Services
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
        public PageResult<Tasks> GetAll(TaskFilterParams param) 
        {
            return _repo.GetAll(param);
        }
    }
}
