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
using SENATI_ETI_BETA_.Tablas;

namespace SENATI_ETI_BETA_
{
    public partial class MENUespecialista : Form
    {
        public MENUespecialista()
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

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMuestra.Controls.Add(childForm);
            panelMuestra.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new tabla_alumno());
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new tabla_empresa());
        }

        private void btnConevio_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new tabla_convenio());
        }

        
    }
}
