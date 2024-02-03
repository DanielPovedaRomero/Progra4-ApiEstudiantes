using ProgramacionIV.ETL;

namespace ProgramacionIV.BLL.Interfaces
{
    public interface IAdEstudiante
    {
        public int InsertarEstudiante(Estudiante estudiante);
        public ETL.Salida.ConsultarEstudiante ConsultarEstudiante(ETL.Entrada.ConsultarEstudiante estudiante);
    }
}
