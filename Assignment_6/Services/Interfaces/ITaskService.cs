using Assignment_6.Models;

namespace Assignment_6.Services.Interfaces
{
    public interface ITaskService
    {
        public Task<TaskItem> CreateTask(TaskItem task);

        public Task<TaskItem> GetTaskById(int id);
    }
}
