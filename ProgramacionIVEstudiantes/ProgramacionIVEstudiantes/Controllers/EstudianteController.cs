using Microsoft.AspNetCore.Mvc;
using ProgramacionIV.ETL;

namespace ProgramacionIVEstudiantes.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("aplication/json")]
    public class EstudianteController : Controller
    {
        [HttpPost]
        [Route("InsertarEstudiante")]
        public IActionResult InsertarEstudiante(Estudiante estudiante) 
        {
            return Ok();
        }
    }
}
