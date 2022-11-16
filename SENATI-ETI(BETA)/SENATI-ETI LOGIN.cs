using CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SENATI_ETI_BETA_
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void conex()
        {

            CONTROLLER.ControllerConection.getControllerConection();
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            //string correo = "especialista@senati.pe";
            //string password = "senati2022";


            conex();
            MENUespecialista esp = new MENUespecialista();
            this.Hide();
            esp.Show();

            /*if (txtCorreo.Texts == correo && txtPassword.Texts == password)
            {
                conex();
                MENUespecialista esp = new MENUespecialista();
                this.Hide();
                esp.Show();
            }
            else
            {
                lblerror.Visible = true;
                this.DialogResult = DialogResult.None;
            }*/

        }
    }
}
