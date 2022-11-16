using CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SENATI_ETI_BETA_.Presentacion
{
    public partial class tabla_empresa : Form
    {

        public tabla_empresa()
        {
            InitializeComponent();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            CrearEmpresa AgregarEmpresa = new CrearEmpresa();
            AgregarEmpresa.Show();
        }

        

        private void tabla_empresa_Load(object sender, EventArgs e)
        {
            llenarTabla();
        }

        private void llenarTabla()
        {
            try
            {
                DataTable alumno;
                alumno = ControllerEmpresa.listarEmpresa();
                dtEmpresa.DataSource = alumno;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
