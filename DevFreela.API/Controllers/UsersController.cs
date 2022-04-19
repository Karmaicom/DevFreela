using DevFreela.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DevFreela.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok();
        }


        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel model)
        {
            return CreatedAtAction(nameof(GetById), new { id = 1 }, model);
        }

        // api/users/1/login
        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel model)
        {
            return NoContent();
        }
    }
}
