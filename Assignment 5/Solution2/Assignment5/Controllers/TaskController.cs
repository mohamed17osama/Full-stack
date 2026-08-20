using System.Security.Cryptography.X509Certificates;
using Assignment5.Interfaces;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment5.Controllers
{

    [ApiController]
    [Route("/api/task")] // https://localhost:7059/api/task
    public class TaskController:ControllerBase
    {
        private ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }
        [HttpPost]
        public ActionResult CreateTask(Tasks task)
        {
            return Created("/api/task",_service.CreateTask(task));
        }

        [HttpGet]
        public ActionResult GetAll([FromQuery]TaskFilterParams param) 
        {
            return Ok(_service.GetAll(param));
        }
        
    }
}
