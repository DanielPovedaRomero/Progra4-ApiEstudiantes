using ProgramacionIV.BLL.Interfaces;
using ProgramacionIV.ETL;

namespace ProgramacionIV.DAL
{
    public class AdEstudiante : IAdEstudiante
    {
        public ETL.Salida.ConsultarEstudiante ConsultarEstudiante(ETL.Entrada.ConsultarEstudiante estudiante)
        {
            var objeto = new ETL.Salida.ConsultarEstudiante();
            objeto.nombre = "Daniel";
            objeto.apellido1 = "Poveda";
            objeto.apellido2 = "Romero";
            objeto.edad = 26;
            objeto.correo = "correo@gmail.com";
            return objeto;
        }

        public int InsertarEstudiante(Estudiante estudiante)
        {
            return 100;
        }
    }
}
