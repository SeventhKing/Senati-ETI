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
    public class ModelValidarEmpresa
    {
        public static DataTable Verificar(string CARRERA, string RUC ,string RAZON_SOCIAL ,string ACTIVIDAD_PRINCIPAL,string DIRECCION ,string ID_SEDE_SUNAT ,
            string NOMBRE_SEDE ,string LATITUD ,string LONGITUD ,string DIRECCION_SEDE , string DEPARTAMENTO_SEDE ,string PROVINCIA_SEDE ,string DISTRITO_SEDE ,
            string TELEFONO_SEDE ,string CORREO_SEDE ,string ID_MONITOR ,string DNI_MONITOR , string APELLIDOS_MONITOR ,string NOMBRES_MONITOR ,string CARGO_MONITOR ,
            string CORREO_MONITOR ,string TELEFONO_MONITOR)
        {
            DataTable tabla = new DataTable();
            MySqlDataReader leer;
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = ModelConect.getConexion();
                comando.CommandText = "ValidarEmpresa";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("_CARRERA", CARRERA);
                comando.Parameters.AddWithValue("_RUC", RUC);
                comando.Parameters.AddWithValue("_RAZON_SOCIAL", RAZON_SOCIAL);
                comando.Parameters.AddWithValue("_ACTIVIDAD_PRINCIPAL", ACTIVIDAD_PRINCIPAL);
                comando.Parameters.AddWithValue("_DIRECCION", DIRECCION);
                comando.Parameters.AddWithValue("_ID_SEDE_SUNAT", ID_SEDE_SUNAT);
                comando.Parameters.AddWithValue("_NOMBRE_SEDE", NOMBRE_SEDE);
                comando.Parameters.AddWithValue("_LATITUD", LATITUD);
                comando.Parameters.AddWithValue("_LONGITUD", LONGITUD);
                comando.Parameters.AddWithValue("_DIRECCION_SEDE", DIRECCION_SEDE);
                comando.Parameters.AddWithValue("_DEPARTAMENTO_SEDE", DEPARTAMENTO_SEDE);
                comando.Parameters.AddWithValue("_PROVINCIA_SEDE", PROVINCIA_SEDE);
                comando.Parameters.AddWithValue("_DISTRITO_SEDE", DISTRITO_SEDE);
                comando.Parameters.AddWithValue("_TELEFONO_SEDE", TELEFONO_SEDE);
                comando.Parameters.AddWithValue("_CORREO_SEDE", CORREO_SEDE);
                comando.Parameters.AddWithValue("_ID_MONITOR", ID_MONITOR);
                comando.Parameters.AddWithValue("_DNI_MONITOR", DNI_MONITOR);
                comando.Parameters.AddWithValue("_APELLIDOS_MONITOR", APELLIDOS_MONITOR);
                comando.Parameters.AddWithValue("_NOMBRES_MONITOR", NOMBRES_MONITOR);
                comando.Parameters.AddWithValue("_CARGO_MONITOR", CARGO_MONITOR);
                comando.Parameters.AddWithValue("_CORREO_MONITOR", CORREO_MONITOR);
                comando.Parameters.AddWithValue("_TELEFONO_MONITOR", TELEFONO_MONITOR);

                leer = comando.ExecuteReader();
                tabla.Load(leer);
                return tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("capa model: "+ex);
                return tabla = null;
            }
        }
    }
}
