using Assignment_6.Models;

namespace Assignment_6.Repositories.Interfaces
{
    public interface ITaskRepositort
    {
        public Task<TaskItem> CreateTask(TaskItem task);

        public Task<TaskItem> GetTaskById(int id);
    }
}
