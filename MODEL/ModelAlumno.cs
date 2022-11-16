using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODEL
{
    public class ModelAlumno
    {
		
        public static DataTable getAlumno()
        {
			DataTable tabla = new DataTable();
			MySqlDataReader leer;
			try
			{
				MySqlCommand comando = new MySqlCommand();
                comando.Connection = ModelConect.getConexion();
                comando.CommandText = "ListarAlumno";
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
