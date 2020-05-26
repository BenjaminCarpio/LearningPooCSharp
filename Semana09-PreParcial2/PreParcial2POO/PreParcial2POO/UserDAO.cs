using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace PreParcial2POO
{
    public static class UserDAO
    {
        private static string sql = "SELECT * FROM USUARIO";

        public static List<User> getLista()
        {
            string sql = "select * from usuario";

            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<User> lista = new List<User>();
            foreach (DataRow fila in dt.Rows)
            {
                User u = new User();
                u.usuario = fila[0].ToString();
                u.contrasena = fila[1].ToString();
                u.admin = Convert.ToBoolean(fila[2].ToString());
                lista.Add(u);
            }

            return lista;
        }

        public static void crearNuevo(string usuario)
        {
            bool admin = false;
            string sql = $"INSERT INTO usuario(usuario, contrasena, admin) VALUES(" +
                         $"'{usuario}'," +
                         $"'{usuario}'," +
                         $"{admin})";
            MessageBox.Show(sql);
            ConexionDB.ExecuteQuery(sql);
        }
        public static void actualizarPermisos(string usuario, bool admin)
        {
            string sql = String.Format(
                "UPDATE usuario SET admin={0} WHERE usuario='{1}';",
                admin ? "true" : "false", usuario);
            ConexionDB.ExecuteQuery(sql);
        }
        public static void eliminar(string usuario)
        {
            string sql = String.Format(
                "DELETE FROM usuario WHERE usuario='{0}'",
                usuario);
                ConexionDB.ExecuteQuery(sql);
        }
    }
}