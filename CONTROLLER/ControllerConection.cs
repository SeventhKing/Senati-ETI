using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;

namespace CONTROLLER
{
    public class ControllerConection
    {
        public static MySqlConnection getControllerConection()
        {
            return MODEL.ModelConect.getConexion();
        }
    }
}
