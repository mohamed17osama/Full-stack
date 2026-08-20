using Assignment_6.Models;
using Assignment_6.Repositories.Interfaces;
using Assignment_6.Services.Interfaces;

namespace Assignment_6.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepositort _repo;

        public TaskService(ITaskRepositort repo)
        {
            _repo = repo;
        }

        public async Task<TaskItem> CreateTask(TaskItem task)
        {
            return await _repo.CreateTask(task);
        }

        public async Task<TaskItem> GetTaskById(int id)
        {
            return await _repo.GetTaskById(id);
        }
    }
}
