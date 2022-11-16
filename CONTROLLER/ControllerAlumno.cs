using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class ControllerAlumno
    {
        

        public static int PERIODO { get ; set; }
        public static int GRUPO { get ; set; }
        public static int ID_ALUMNO { get ; set; }
        public static int PARTE_PERIODO { get ; set; }
        public static string ZONAL { get ; set ; }
        public static string CAMPUS { get; set; }
        public static string TIPO { get; set; }
        public static string PROGRAMA { get; set; }
        public static string CARRERA { get; set; }
        public static string COD_CARRERA { get; set; }
        public static string CLASE { get; set; }
        public static string BLOQUE { get; set; }
        public static string CORREO_ALUMNOS { get; set; }
        public static string NOMBRE { get; set; }
        public static string TIPO_ALUMNO { get; set; }
        public static string ATRIBUTO { get; set; }
        public static string FECHA_MATRICULA { get; set; }
        public static string CONDICION_PAGO { get; set; }
        public static string DECRIP_BECA { get; set; }
        public static string CONDICION_ACAD { get; set; }
        public static string COD_RETIRO { get; set; }
        public static string FECHA_RETIRO { get; set; }
        public static string COMENTARIO_RETIRO { get; set; }
        public static string MOTIVO_RETIRO { get; set; }
        public static string FECHA_REGISTRO_ACTIVIDAD { get; set; }
        public static string SEXO { get; set; }

        public static DataTable listarAlumno()
        {
            return MODEL.ModelAlumno.getAlumno();
        }
    }
}
