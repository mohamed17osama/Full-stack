using Assignment_3.Classes;
using Assignment_3.Exceptions;
using Assignment_3.Interfaces;

namespace Assignment_3.Repositories
{
    public class TaskRepository:ITaskRepository
    {
        private  List<TasksClass> _tasks = new List<TasksClass>();

        public TasksClass CreateTask(TasksClass task)
        {
            Console.WriteLine("Create class reached");
            for (int i = 0; i < _tasks.Count; i++)
            {
                if (_tasks[i].Title == task.Title)
                {
                    throw new ConflictException("Title already exist");
                    return task;
                }
            }
            _tasks.Add(task);

            return task;

        }
        public List<TasksClass> GetAll()
        {
            return _tasks;
        }
        public TasksClass GetTask(int id)
        {
            for (int i= 0; i < _tasks.Count; ++i)
            {
                if (_tasks[i].Id == id) 
                {
                    return _tasks[i]; 
                }
            }
            throw new NotFoundException("ID does not exist");
        }
    }
}
