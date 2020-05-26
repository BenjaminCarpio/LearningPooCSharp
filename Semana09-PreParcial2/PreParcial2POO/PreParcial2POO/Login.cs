using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace PreParcial2POO
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("No se permiten campos vacios");
            }
            else
            {
                try
                {
                    string query = $"SELECT usuario, admin FROM usuario WHERE usuario = '{textBox1.Text}' AND contrasena = '{textBox2.Text}'";
                    var cmd = ConexionDB.ExecuteQuery(query);

                    DataTableReader dr;
                    dr = cmd.CreateDataReader();
                    string user;
                    bool adminUser = false;
                    if (dr.Read())
                    {
                        adminUser = dr.GetBoolean(1);
                        user = dr.GetString(0);
                        MessageBox.Show("Iniciado sesion correctamente");
                        if (adminUser == true)
                        {
                            MessageBox.Show("Bienvenido Administrador " + user);
                        }
                        else
                        {
                            MessageBox.Show("Bienvenido " + user);
                            
                        }
                        this.Hide();
                        this.Close();
                        frmPrincipal ventanaMain= new frmPrincipal(user, adminUser);
                       ventanaMain.ShowDialog();

                    } else 
                        MessageBox.Show("Credenciales erroneas");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
        }
        
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) LoginButton_Click(sender, e);
        }
    }
}