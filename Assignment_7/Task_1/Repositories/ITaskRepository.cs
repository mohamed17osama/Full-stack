using Microsoft.AspNetCore.Mvc.RazorPages;
using Task_1.Models;

namespace Task_1.Repositories
{
    public interface ITaskRepository
    {
        public Task<Tasks> CreateTask(Tasks task);

        public Task<PageResult<Tasks>> GetAll(TaskFilterParam param);

        public Task<Tasks> GetTaskById(int id);

        public Task<Tasks> UpdateTask(int id, Tasks task);

        public Task<string> DeleteTask(int id);
    }
}