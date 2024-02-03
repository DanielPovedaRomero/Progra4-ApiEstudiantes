using Microsoft.AspNetCore.Mvc;
using ProgramacionIV.BLL;
using ProgramacionIV.BLL.Interfaces;
using ProgramacionIV.ETL;
using System.Diagnostics;

namespace ProgramacionIVEstudiantes.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Produces("application/json")]
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
            var respuesta = oLnEstudiante.InsertarEstudiante(estudiante);
            return Ok(respuesta);
        }

        [HttpPost]
        [Route("ConsultarEstudiante")]
        public IActionResult ConsultarEstudiante(ProgramacionIV.ETL.Entrada.ConsultarEstudiante estudiante)
        {
            var respuesta = oLnEstudiante.ConsultarEstudiante(estudiante);
            return Ok(respuesta);
        }
    }
}
