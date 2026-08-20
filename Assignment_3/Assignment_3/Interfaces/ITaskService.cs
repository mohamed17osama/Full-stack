using Assignment_3.Classes;

namespace Assignment_3.Interfaces
{
    public interface ITaskService
    {
        public TasksClass CreateTask(TasksClass task);

        public List<TasksClass> GetAll();

        public TasksClass GetTask(int id);
    }
}
