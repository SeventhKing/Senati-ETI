using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CONTROLLER;

namespace CONTROLLER
{
    public class AgregarEmpresa
    {
        public void CrearEmpresa()
        {
            MySqlConnection database = Conection.getConexion();
            database.Open();
        }

    }

}
