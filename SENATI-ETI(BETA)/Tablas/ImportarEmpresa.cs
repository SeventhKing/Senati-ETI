using CONTROLLER;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SENATI_ETI_BETA_.Tablas
{
    public partial class ImportarEmpresa : Form
    {
        private DataSet dtsTablas = new DataSet();
        private bool resultado;
        public ImportarEmpresa()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            //configuracion de ventana para seleccionar un archivo
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            //oOpenFileDialog.Filter = "Excel Worbook|*.xlsx";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                cboHojas.Items.Clear();
                dgvDatos.DataSource = null;

                txtRuta.Text = oOpenFileDialog.FileName;

                
                try
                {
                    //FileStream nos permite leer, escribir, abrir y cerrar archivos en un sistema de archivos, como matrices de bytes
                    FileStream fsSource = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read);

                    //ExcelReaderFactory.CreateBinaryReader = formato XLS
                    //ExcelReaderFactory.CreateOpenXmlReader = formato XLSX
                    //ExcelReaderFactory.CreateReader = XLS o XLSX
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fsSource);

                    //convierte todas las hojas a un DataSet
                    dtsTablas = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    //obtenemos las tablas y añadimos sus nombres en el desplegable de hojas
                    foreach (DataTable tabla in dtsTablas.Tables)
                    {
                        cboHojas.Items.Add(tabla.TableName);
                    }
                    cboHojas.SelectedIndex = 0;
                    dgvDatos.DataSource = dtsTablas.Tables[cboHojas.SelectedIndex];

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvDatos.DataSource = dtsTablas.Tables[cboHojas.SelectedIndex];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnRegistrarData_Click(object sender, EventArgs e)
        {
            DataTable data = (DataTable)(dgvDatos.DataSource);

            resultado = ControllerEmpresa.insertarempresa(data);
            if (resultado)
            {
                MessageBox.Show("Se registro la data");
                
            }
            else
            {
                MessageBox.Show("Hubo un problema al registrar");
            }
            this.Close();
        }
    }
}
