using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLLER
{
    public class ControllerEmpresa
    {
        public static DataTable listarEmpresa()
        {
            return MODEL.ModelEmpresa.getEmpresa();
        }

        public static bool insertarempresa(DataTable dta)
        {
            return MODEL.ModelExcelEmpresa.CargarDataEmpresa(dta);
        }
    }
}
