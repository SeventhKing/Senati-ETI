using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace MODEL
{
    public class ExcelEmpresa
    {
        //private int ruc;
        //private string razon_social;
        //private string actividad_principal;
        //private string domicilio_legal;
        //private string id_sede_sunat;
        //private string nombre_sede;
        //private string latitud_sede;
        //private string longitud_sede;
        //private string direccion_sede;
        //private string departamento_sede;
        //private string provincia_sede;
        //private string distrito_sede;
        //private string telefono_sede;
        //private string correo_sede;

        public static bool  CargarDataEmpresa(DataTable dt)
        {
            bool respuesta = false;

            try
            {
                using (MySqlConnection con = ModelConect.getConexion())
                {
                    
                    using (MySqlTransaction trx = con.BeginTransaction())
                    {
                        try
                        {
                            using (MySqlCommand cmd = new MySqlCommand())
                            {
                                cmd.Connection = con;
                                cmd.Transaction = trx;
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "IngresarEmpresa";
                                foreach (DataRow row in dt.Rows)
                                {
                                    cmd.Parameters.AddWithValue("_ruc", row[0].ToString());
                                    cmd.Parameters.AddWithValue("_razon_social", row[1].ToString());
                                    cmd.Parameters.AddWithValue("_actividad_principal", row[2].ToString());
                                    cmd.Parameters.AddWithValue("_domicilio_legal", row[3].ToString());
                                    cmd.Parameters.AddWithValue("_id_sede_sunat", row[4].ToString());
                                    cmd.Parameters.AddWithValue("_nombre_sede", row[5].ToString());
                                    cmd.Parameters.AddWithValue("_latitud_sede", row[6].ToString());
                                    cmd.Parameters.AddWithValue("_longitud_sede", row[7].ToString());
                                    cmd.Parameters.AddWithValue("_direccion_sede", row[8].ToString());
                                    cmd.Parameters.AddWithValue("_departamento_sede", row[9].ToString());
                                    cmd.Parameters.AddWithValue("_provincia_sede", row[10].ToString());
                                    cmd.Parameters.AddWithValue("_distrito_sede", row[11].ToString());
                                    cmd.Parameters.AddWithValue("_telefono_sede", row[12].ToString());
                                    cmd.Parameters.AddWithValue("_correo_sede", row[13].ToString());
                                    cmd.ExecuteNonQuery();
                                    cmd.Parameters.Clear();

                                }
                                trx.Commit();
                                con.Close();
                                respuesta = true;

                            }
                        }
                        catch (Exception)
                        {
                            trx.Rollback();
                            con.Close();
                            respuesta = false;
                            throw;
                        }

                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            
            
            return respuesta;

        }

        
    }
}

