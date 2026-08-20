using Asp.Versioning;
using Assignment_4.Models;
using Assignment_4.services;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_4.Controllers.Version2
{
    [ApiController]
    [ApiVersion("2.0")]
    [Route("/api/v{version:ApiVersion}/task")]  // https://localhost:7257/api/v2/task
    public class TaskController:ControllerBase
    {
        private ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }

        [Route("{id}")]
        public ActionResult GetTask(int id)
        {
            return Ok(new {Id =  id, Title = "Version 2 task", Status = "Pending", dueDate = "16 Oct 2026", CreatedAt = "5 Oct 2026" });
        }
    }
}
