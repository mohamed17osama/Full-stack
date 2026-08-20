using Assignment_3.Classes;
using Assignment_3.Interfaces;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_3.Controllers
{
    [ApiController]
    [Route("/task/api")] // https://localhost:7280/task/api
    public class TasksController:ControllerBase
    {
        private ITaskService _service;
        public TasksController(ITaskService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult GetTask(int id)
        {
            return Ok(_service.GetTask(id));
        }
        [HttpPost]
        public ActionResult? CreateTask(TasksClass task)
        {
            var tk = _service.CreateTask(task);
            return Created("/task/api", tk);
        }
    }
}
