using Asp.Versioning;
using Assignment_4.Models;
using Assignment_4.services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_4.Controllers.Version1
{
    [ApiController]
    [ApiVersion("1.0", Deprecated = true)]
    [Route("/api/v{version:ApiVersion}/task")]
    public class TaskController : ControllerBase
    {
        private ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<Tasks>> GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpPost]
        public ActionResult CreateTask(Tasks task)
        {
            _service.CreateTask(task);
            return Created();
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult GetTask(int id)
        {
            var task = _service.GetTask(id);
            if (task != null)
            {
                return Ok(task);
            }
            return NotFound();
        }
    }
}
