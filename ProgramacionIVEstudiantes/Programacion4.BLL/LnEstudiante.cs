using ProgramacionIV.BLL.Interfaces;
using ProgramacionIV.ETL;
using System.Diagnostics;

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

        public ETL.Salida.ConsultarEstudiante ConsultarEstudiante(ETL.Entrada.ConsultarEstudiante estudiante)
        {
            return adEstudiante.ConsultarEstudiante(estudiante);
        }
    }
}
