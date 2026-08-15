using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Interfaces
{
    public interface ITaskService
    {
        public Tasks CreateTask(Tasks task);

        public PageResult<Tasks> GetAll(TaskFilterParams param);


    }
}
