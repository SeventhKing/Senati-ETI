using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLER
{
    public class Conection
    {
     public static MySqlConnection getConexion()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Port = 3306;
            builder.Password = "";
            builder.Database = "systemeti";
            MySqlConnection conexion = new MySqlConnection(builder.ToString());
            return conexion;
        }
    }
}
