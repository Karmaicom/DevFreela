using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        // api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        // api/projects/599
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // return NotFound();

            return Ok();
        }


        // api/projects
        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel model)
        {
            if (model.Title.Length > 50)
            {
                return BadRequest();
            }

            return CreatedAtAction(nameof(GetById), new { id = model.Id }, model);
        }


        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel model)
        {
            if (model.Description.Length > 200)
            {
                return BadRequest();
            }

            // Atualiza o objeto

            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Buscar, se não existir, retornar NotFound

            // Remover

            return NoContent();
        }


        // api/projects/{id}/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel model)
        {
            return NoContent();
        }

        // api/projects/1/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }


        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
        

    }
}
