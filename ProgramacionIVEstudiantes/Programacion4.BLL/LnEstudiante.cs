using ProgramacionIV.BLL.Interfaces;
using ProgramacionIV.ETL;

namespace ProgramacionIV.BLL
{
    public class LnEstudiante
    {
        private IAdEstudiante adEstudiante;

        public LnEstudiante(IAdEstudiante adEstudiante) 
        { 
            this.adEstudiante = adEstudiante;
        }

        public int InsertarEstudiante(Estudiante estudiante) 
        {
            return adEstudiante.InsertarEstudiante(estudiante);
        }

        public Estudiante ConsultarEstudiante(Estudiante estudiante) 
        {
            return adEstudiante.ConsultarEstudiante(estudiante);
        }
    }
}
