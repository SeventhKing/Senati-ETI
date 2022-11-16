using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODEL
{
    public class ModelConect
    {
        public static MySqlConnection getConexion()
        {
            MySqlConnection conex;
            string servidor = "localhost";
            string bd = "prueba";
            string usuario = "root";
            string password = "";

            string cadenaConexion = "server=" + servidor +
                                          "; User Id=" + usuario +
                                          "; Password=" + password +
                                          "; DataBase= " + bd + ";";


            try
            {
                conex = new MySqlConnection(cadenaConexion);
                conex.ConnectionString = cadenaConexion;
                conex.Open();
                return conex;
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Nose pudo conectar a la base de datos:" + e);
                return null;
            }


        }
    }
}
