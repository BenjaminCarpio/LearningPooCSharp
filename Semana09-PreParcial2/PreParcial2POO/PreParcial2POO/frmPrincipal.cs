using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PreParcial2POO
{
    public partial class frmPrincipal : Form
    {
        private string nombreU;
        private bool AdminUser;
        
        public frmPrincipal(string nombre, bool admin)
        {
            InitializeComponent();
            nombreU = nombre;
            AdminUser = admin;
            actualizarControles();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (AdminUser == true)
            {
                //cargar aqui XD cosas extra 
            }
            else
            {
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                
            }
        }
        private void actualizarControles()
        {
            // Realizar consulta a la base de datos
            List<User> lista = UserDAO.getLista();
            List<Pedido> listaPedidos = ProductoDAO.getPedidosL();

            // Tabla (data grid view)
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = lista;
            
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = listaPedidos;
            // Menu desplegable (combo box)
            
            comboBox2.DataSource = null;
            comboBox2.ValueMember = "contrasena";
            comboBox2.DisplayMember = "usuario";
            comboBox2.DataSource = lista;
            
            List<Producto> listaProductos = ProductoDAO.getLista();
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "id_producto";
            comboBox1.DisplayMember = "producto";
            comboBox1.DataSource = listaProductos;
            
            
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length >= 5)
                {
                    UserDAO.crearNuevo(textBox1.Text);
                    
                    MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                    "contrasena igual a usuario, no admin");
                    
                    textBox1.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Favor digite un usuario (longitud minima, 5 caracteres)");
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.");
            }
        }

        private void button1_Click(object sender, EventArgs e)//Cargar historial
        {
            actualizarControles();
        }

        private void button2_Click(object sender, EventArgs e)//Actualizar datos 
        {
            actualizarControles();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            User u = (User) comboBox2.SelectedItem;
            if (u.admin)
                radioButton3.Checked = true;
            else
                radioButton4.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e) //Guardar Cambios
        {
            UserDAO.actualizarPermisos(comboBox2.Text, radioButton3.Checked);
            MessageBox.Show("Datos actualizados");
            actualizarControles();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + comboBox2.Text + "?", "SEGURO?",MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
                
            {
                UserDAO.eliminar(comboBox2.Text);

                MessageBox.Show("¡Usuario eliminado exitosamente!");

                actualizarControles();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Realizar pedido
        }
    }
}