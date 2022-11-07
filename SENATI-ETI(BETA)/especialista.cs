using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SENATI_ETI_BETA_.Presentacion;

namespace SENATI_ETI_BETA_
{
    public partial class especialista : Form
    {
        public especialista()
        {
            InitializeComponent();
            
        }

        private void especialista_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelMuestra_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void especialista_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelMuestra.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelMuestra.Controls.Add(formulario);
                panelMuestra.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }

        private void panelMuestra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario<tabla_empresa>();

        }
    }
}
