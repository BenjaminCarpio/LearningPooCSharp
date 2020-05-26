using System;
using System.Collections.Generic;
using System.Data;

namespace PreParcial2POO
{
    public class ProductoDAO
    {
        private static string sql = "SELECT * FROM INVENTARIO";
        
        public static List<Producto> getLista()
        {
            string sql = "select * from inventario";

            DataTable dt = ConexionDB.ExecuteQuery(sql);

            List<Producto> lista = new List<Producto>();
            foreach (DataRow fila in dt.Rows)
            {
                Producto u = new Producto();
                u.idProducto = Convert.ToInt32(fila[0]);
                u.producto = fila[1].ToString();
                u.descripcion = fila[2].ToString();
                u.precioXD = Convert.ToDouble(fila[3]);
                u.stock =  Convert.ToInt32(fila[4]);
                lista.Add(u);
            }
            return lista;
        }

        public static List<Pedido> getPedidosL()
        {
            string sql = "SELECT * FROM PEDIDO";
            DataTable dt2 = ConexionDB.ExecuteQuery(sql);
            
            List<Pedido> lista = new List<Pedido>();
            foreach (DataRow fila in dt2.Rows)
            {
                Pedido  u = new Pedido();
                u.idRegistro = Convert.ToInt32(fila[0]);
                u.usuario = fila[1].ToString();
                u.producto = Convert.ToInt32(fila[2]);
                u.cantidad = Convert.ToInt32(fila[3]);
                lista.Add(u);
            }
            return lista;
        }
    }
}