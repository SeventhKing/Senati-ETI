using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
    }
}
