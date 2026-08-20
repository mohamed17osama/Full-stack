using Assignment_6.AppDBContext;
using Assignment_6.Models;
using Assignment_6.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Assignment_6.Repositories
{
    public class TaskRepository : ITaskRepositort
    {
        private readonly AppDbContext _dbContext;

        public TaskRepository(AppDbContext context)
        {
            _dbContext = context;
        }

        public async Task<TaskItem> CreateTask(TaskItem task)
        {
            _dbContext.TaskItems.Add(task);
            await _dbContext.SaveChangesAsync();
            return task;
        }

        public async Task<TaskItem> GetTaskById(int id)
        {
            var query = _dbContext.TaskItems.AsQueryable();

            query = query.Include(t => t.User).Where(t => t.Id == id);

            var task = await query.SingleAsync();

            return task;
        }
    }
}
