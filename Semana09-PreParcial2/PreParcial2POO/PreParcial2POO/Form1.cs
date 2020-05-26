using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreParcial2POO
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void GoLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login unaVentana = new Login();
            unaVentana.ShowDialog();
        }

        private void CloseProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}