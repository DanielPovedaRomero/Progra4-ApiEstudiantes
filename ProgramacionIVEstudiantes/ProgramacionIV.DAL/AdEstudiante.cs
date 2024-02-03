using ProgramacionIV.BLL.Interfaces;
using ProgramacionIV.ETL;

namespace ProgramacionIV.DAL
{
    public class AdEstudiante : IAdEstudiante
    {
        public Estudiante ConsultarEstudiante(Estudiante estudiante)
        {
            return estudiante;
        }

        public int InsertarEstudiante(Estudiante estudiante)
        {
            return 100;
        }
    }
}
