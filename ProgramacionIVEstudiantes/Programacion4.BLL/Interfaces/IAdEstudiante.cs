using ProgramacionIV.ETL;

namespace ProgramacionIV.BLL.Interfaces
{
    public interface IAdEstudiante
    {
        public int InsertarEstudiante(Estudiante estudiante);
        public Estudiante ConsultarEstudiante(Estudiante estudiante);
    }
}
