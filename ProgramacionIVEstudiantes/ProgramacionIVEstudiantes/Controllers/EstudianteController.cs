using Microsoft.AspNetCore.Mvc;
using ProgramacionIV.BLL;
using ProgramacionIV.BLL.Interfaces;
using ProgramacionIV.ETL;

namespace ProgramacionIVEstudiantes.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("aplication/json")]
    public class EstudianteController : Controller
    {

        private LnEstudiante oLnEstudiante;

        public EstudianteController(IAdEstudiante accesoDatosEstudiante)
        {
            oLnEstudiante = new LnEstudiante(accesoDatosEstudiante);
        }

        [HttpPost]
        [Route("InsertarEstudiante")]
        public IActionResult InsertarEstudiante(Estudiante estudiante) 
        {
            int respuesta = oLnEstudiante.InsertarEstudiante(estudiante);
            return Ok(respuesta);
        }
    }
}
