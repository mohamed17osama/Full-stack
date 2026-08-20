using Assignment_3.Classes;
using Assignment_3.Interfaces;

namespace Assignment_3.Services
{
    public class TaskService : ITaskService
    {
        private ITaskRepository _repo;

        public TaskService(ITaskRepository repo) 
        {  
            _repo = repo; 
        }

        public TasksClass CreateTask(TasksClass task)
        {
           return _repo.CreateTask(task);    
        }

        public List<TasksClass> GetAll()
        {
            return _repo.GetAll();
        }

        public TasksClass GetTask(int id)
        {
            return _repo.GetTask(id);
        }
    }
}
