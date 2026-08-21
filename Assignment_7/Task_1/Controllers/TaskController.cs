using Microsoft.AspNetCore.Mvc;
using System.Text;
using Task_1.DTOs;
using Task_1.Exceptions;
using Task_1.Models;
using Task_1.Services;

namespace Task_1.Controllers
{
    [ApiController]
    [Route("/api/task")] // https://localhost:7265/api/task
    public class TaskController:ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateTask([FromBody] CreateTaskRequestDTO task)
        {

            return Created($"/api/task/{task.Title}", await _taskService.CreateTask(task));
        }
        [HttpGet]
        public async Task<ActionResult> GetAll([FromQuery] TaskFilterParam param)
        {
            return Ok(await _taskService.GetAll(param));
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetTaskById(int id)
        {
            return Ok(await _taskService.GetTaskById(id));
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> UpdateTask(int id, [FromBody] UpdateTaskRequestDTO task)
        {
            return Ok(await _taskService.UpdateTask(id, task));
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> DeleteTask(int id)
        {
            return Ok(await _taskService.DeleteTask(id));
        } 
    }
}
