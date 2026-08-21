using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update.Internal;
using Task_1.Data;
using Task_1.Exceptions;
using Task_1.Models;

namespace Task_1.Repositories
{
    public class TaskRepository:ITaskRepository
    {
        private readonly AppDbContext _dbcontext;

        public TaskRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<Tasks> CreateTask(Tasks task)
        {
            //var query = _dbcontext.Tasks.AsQueryable();
            //var UserFoundById = query.Where(t =>  t.Title == task.Title);
            //if(UserFoundById == null)
            //{
            _dbcontext.Tasks.Add(task);
            await _dbcontext.SaveChangesAsync();
            return task;
            //}
            //throw new ConflictException("ID already exist");
            //return task;

        }

        public async Task<PageResult<Tasks>> GetAll(TaskFilterParam param)
        {
            IEnumerable<Tasks> _tasks = await _dbcontext.Tasks.ToListAsync();
            IEnumerable<Tasks> Tasks = _tasks;

            if (!string.IsNullOrEmpty(param.Search))
            {
                Tasks = Tasks.Where(p => p.Title.Contains(param.Search, StringComparison.OrdinalIgnoreCase));
            }
            if (!string.IsNullOrEmpty(param.Status))
            {
                Tasks = Tasks.Where(p => p.Status.Contains(param.Status, StringComparison.OrdinalIgnoreCase));
            }
            //if (param.IsCompleted.HasValue)
            //{
            //    Tasks = Tasks.Where(p => p.IsCompleted == param.IsCompleted);
            //}
            var allowedSort = new Dictionary<string, Func<Tasks, object>>
            {
                ["Title"] = p => p.Title,
                ["Id"] = p => p.Id,
                ["Status"] = p => p.Status
                //["Iscompleted"] = p => p.IsCompleted
            };
            if (allowedSort.TryGetValue(param.SortBy ?? "Id", out var keySelector))
            {
                Tasks = param.Order == "dec" ? Tasks.OrderByDescending(keySelector) : Tasks.OrderBy(keySelector);
            }

            Tasks = Tasks.Skip((param.Page - 1) * param.pageSize).Take(param.pageSize).ToList();
            return new PageResult<Tasks>
            {
                Data = Tasks,
                Page = param.Page,
                PageSize = param.pageSize,
                TotalCount = _tasks.Count()
            };
        }
        public async Task<Tasks> GetTaskById(int id)
        {
            var task = await _dbcontext.Tasks.FindAsync(id);
            if (task == null)
            {
                throw new TaskNotFound("ID Not Found");
            }

            return task;
        }
        public async Task<Tasks> UpdateTask(int id, Tasks task)
        {
            var FoundTask = await _dbcontext.Tasks.FindAsync(id);
            if(FoundTask == null)
            {
                _dbcontext.Tasks.Add(task);
                await _dbcontext.SaveChangesAsync();
                return task;
            }
            _dbcontext.Entry(FoundTask).CurrentValues.SetValues(task);
            await _dbcontext.SaveChangesAsync();
            return task;
        }
        public async Task<string> DeleteTask(int id)
        {
            var task = await _dbcontext.Tasks.FindAsync(id);
            if(task == null)
            {
                return "Task Not found";
            }
            _dbcontext.Tasks.Remove(task);
            await _dbcontext.SaveChangesAsync();
            return "Task Removed";
        }

    }
}
