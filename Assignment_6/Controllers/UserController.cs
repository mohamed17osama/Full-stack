using Assignment_6.Models;
using Assignment_6.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_6.Controllers
{
    [ApiController]
    [Route("/api/user")]
    public class UserController:ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }
        [HttpPost]
        public async Task<ActionResult> CreateUser(User user)
        {
            return Created($"/api/user/{user.Id}", await _service.CreateUser(user));
        }
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            return Ok(await  _service.GetAll());
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult> GetUserById(int id)
        {
            return Ok(await _service.GetUserById(id));
        }
    }
}
