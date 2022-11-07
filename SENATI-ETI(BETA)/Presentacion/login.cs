using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginETI
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
           
            string correo = "";
            string password = "hola";


            if (txtCorreo1.Texts == correo && txtPassword1.Texts == password)
            {
               // MessageBox.Show("abrir");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lblErrorLogin.Visible = true;
                this.DialogResult = DialogResult.None;
            }
            
        }

        private void txtPassword__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo1__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
