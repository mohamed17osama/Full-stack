using Assignment_3.Classes;

namespace Assignment_3.Interfaces
{
    public interface ITaskRepository
    {
        public TasksClass CreateTask(TasksClass task);

        public List<TasksClass> GetAll();

        public TasksClass GetTask(int id);
    }
}
