using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class ModelEmpresa
    {
        public static DataTable getEmpresa()
        {
            DataTable tabla = new DataTable();
            MySqlDataReader leer;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = ModelConect.getConexion();
                comando.CommandText = "ListarEmpresa";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;

            }
            catch (Exception)
            {

                return tabla = null;
            }
        }
    }
}
