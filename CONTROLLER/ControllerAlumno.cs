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
        public static DataTable listarAlumno()
        {
            return MODEL.ModelAlumno.getAlumno();
        }
    }
}
