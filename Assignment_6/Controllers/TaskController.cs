using Assignment_6.Models;
using Assignment_6.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_6.Controllers
{
    [ApiController]
    [Route("/api/task")]  // https://localhost:7288/api/task
    public class TaskController:ControllerBase
    {
        private readonly ITaskService _service;

        public TaskController(ITaskService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> CreateTask(TaskItem task)
        {
            return Created($"/api/task/{task.Id}", await  _service.CreateTask(task));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetTaskById(int id)
        {
            var data = await _service.GetTaskById(id);
            return Ok(new
            {
                TaskId = data.Id,
                Title = data.Title,
                IsCompleted = data.IsCompleted,
                UserId = data.UserId,
                UserName = data.User.Name,
                UserAge = data.User.Age
            });
        }
    }
}
