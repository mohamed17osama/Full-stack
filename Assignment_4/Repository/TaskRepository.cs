using Assignment_4.Models;

namespace Assignment_4.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private List<Tasks> _tasks = new List<Tasks>();

        public List<Tasks> GetAll()
        {
            return _tasks;
        }
        public Tasks GetTask(int id)
        {
            return _tasks.FirstOrDefault(p => p.Id == id);
        }
        public Tasks CreateTask(Tasks task)
        {
            _tasks.Add(task);
            return task;
        }
    }
}
