using Assignment5.Interfaces;
using Assignment5.Models;

namespace Assignment5.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private List<Tasks> _tasks = new List<Tasks>();
        public Tasks CreateTask(Tasks task)
        {
            _tasks.Add(task);
            return task;
        }

        public PageResult<Tasks> GetAll(TaskFilterParams param)
        {
            IEnumerable<Tasks> tasks = _tasks;

            if (!string.IsNullOrEmpty(param.Search))
            {
                tasks = tasks.Where(p => p.Title.Contains(param.Search, StringComparison.OrdinalIgnoreCase));
            }
            if(param.Workers.HasValue)
            {
                tasks = tasks.Where(p => p.Workers ==  param.Workers);
            }
            if(param.Iscompleted.HasValue)
            {
                tasks = tasks.Where(p=> p.IsCompleted == param.Iscompleted);
            }
            var allowedSort = new Dictionary<string, Func<Tasks, object>>
            {
                ["Title"] = p => p.Title,
                ["Id"] = p => p.Id,
                ["Workers"] = p => p.Workers,
                ["Iscompleted"] = p => p.IsCompleted
            };
            if(allowedSort.TryGetValue(param.SortBy ?? "Id", out var keySelector))
            {
                tasks = param.Order == "dec" ? tasks.OrderByDescending(keySelector) : tasks.OrderBy(keySelector);
            }

            tasks = tasks.Skip((param.Page-1)*param.PageSize).Take(param.PageSize).ToList();
            return new PageResult<Tasks>
            {
                Data = tasks,
                Page = param.Page,
                PageSize = param.PageSize,
                TotalCount = _tasks.Count()
            };
        }
    }
}
