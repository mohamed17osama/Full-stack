using Assignment5.Models;

namespace Assignment5.Interfaces
{
    public interface ITaskRepository
    {
        public Tasks CreateTask(Tasks task);

        public PageResult<Tasks> GetAll(TaskFilterParams param);
    }
}
