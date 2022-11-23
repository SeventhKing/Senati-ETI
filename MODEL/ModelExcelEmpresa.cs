using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Renci.SshNet;
using Renci.SshNet.Messages;

namespace MODEL
{
    public class ModelExcelEmpresa
    {
        private static int contador = 0;
        public static bool CargarDataEmpresa(DataTable dt)
        {
            bool respuesta = false;
            string carrera, ruc, razon_social, actividad_principal, direccion, id_sede_sunat, nombre_sede, latitud, longitud, direccion_sede, departamento_sede, provincia_sede,
                distrito_sede, telefono_sede, correo_sede, id_monitor, dni_monitor, apellidos_monitor, nombres_monitor, cargo_monitor, correo_monitor, telefono_monitor;
            DataTable dta = new DataTable();
            

            try
            {
                using (MySqlConnection con = ModelConect.getConexion())
                {
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "IngresarEmpresa";

                            
                                foreach (DataRow row in dt.Rows)
                                {
                                    carrera = row[0].ToString();
                                    ruc = row[1].ToString();
                                    razon_social = row[2].ToString();
                                    actividad_principal = row[3].ToString();
                                    direccion = row[4].ToString();
                                    id_sede_sunat = row[5].ToString();
                                    nombre_sede = row[6].ToString();
                                    latitud = row[7].ToString();
                                    longitud = row[8].ToString();
                                    direccion_sede = row[9].ToString();
                                    departamento_sede = row[10].ToString();
                                    provincia_sede = row[11].ToString();
                                    distrito_sede = row[12].ToString();
                                    telefono_sede = row[13].ToString();
                                    correo_sede = row[14].ToString();
                                    id_monitor = row[15].ToString();
                                    dni_monitor = row[16].ToString();
                                    apellidos_monitor = row[17].ToString();
                                    nombres_monitor = row[18].ToString();
                                    cargo_monitor = row[19].ToString();
                                    correo_monitor = row[20].ToString();
                                    telefono_monitor = row[21].ToString();

                                    dta = ModelValidarEmpresa.Verificar(carrera, ruc, razon_social, actividad_principal, direccion, id_sede_sunat, nombre_sede, latitud, longitud, direccion_sede, departamento_sede, provincia_sede,
                                    distrito_sede, telefono_sede, correo_sede, id_monitor, dni_monitor, apellidos_monitor, nombres_monitor, cargo_monitor, correo_monitor, telefono_monitor);


                                    //MessageBox.Show(dta.Rows.Count.ToString());

                                    if (dta.Rows.Count == 0)
                                    {
                                        cmd.Parameters.AddWithValue("_CARRERA", carrera);
                                        cmd.Parameters.AddWithValue("_RUC", ruc);
                                        cmd.Parameters.AddWithValue("_RAZON_SOCIAL", razon_social);
                                        cmd.Parameters.AddWithValue("_ACTIVIDAD_PRINCIPAL", actividad_principal);
                                        cmd.Parameters.AddWithValue("_DIRECCION", direccion);
                                        cmd.Parameters.AddWithValue("_ID_SEDE_SUNAT", id_sede_sunat);
                                        cmd.Parameters.AddWithValue("_NOMBRE_SEDE", nombre_sede);
                                        cmd.Parameters.AddWithValue("_LATITUD", latitud);
                                        cmd.Parameters.AddWithValue("_LONGITUD", longitud);
                                        cmd.Parameters.AddWithValue("_DIRECCION_SEDE", direccion_sede);
                                        cmd.Parameters.AddWithValue("_DEPARTAMENTO_SEDE", departamento_sede);
                                        cmd.Parameters.AddWithValue("_PROVINCIA_SEDE", provincia_sede);
                                        cmd.Parameters.AddWithValue("_DISTRITO_SEDE", distrito_sede);
                                        cmd.Parameters.AddWithValue("_TELEFONO_SEDE", telefono_sede);
                                        cmd.Parameters.AddWithValue("_CORREO_SEDE", correo_sede);
                                        cmd.Parameters.AddWithValue("_ID_MONITOR", id_monitor);
                                        cmd.Parameters.AddWithValue("_DNI_MONITOR", dni_monitor);
                                        cmd.Parameters.AddWithValue("_APELLIDOS_MONITOR", apellidos_monitor);
                                        cmd.Parameters.AddWithValue("_NOMBRES_MONITOR", nombres_monitor);
                                        cmd.Parameters.AddWithValue("_CARGO_MONITOR", cargo_monitor);
                                        cmd.Parameters.AddWithValue("_CORREO_MONITOR", correo_monitor);
                                        cmd.Parameters.AddWithValue("_TELEFONO_MONITOR", telefono_monitor);

                                        cmd.ExecuteNonQuery();
                                        //contador++;
                                        
                                       
                                    }
                                    cmd.Parameters.Clear();
                                }
                            }
                            con.Close();
                        respuesta = true;

                    }
                    catch (Exception e)
                    {
                        con.Close();
                        respuesta = false;
                        MessageBox.Show("Error : " + e);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex);
            }
            return respuesta;

        }

        
        
        
    }
}

