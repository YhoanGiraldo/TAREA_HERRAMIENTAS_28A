using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DALProductos
    {

        private DALConexion conexion = new DALConexion();

        // Cambia la declaración de dataReader para que acepte valores nulos
        SqlDataReader? dataReader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void CreateUsuario(string nombre_producto, int referencia, int valor, int cantidad)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_INSERTAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_producto", nombre_producto);
            comando.Parameters.AddWithValue("@Referencia", referencia);
            comando.Parameters.AddWithValue("@Valor", valor);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);            
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable ReadAllUsuario()
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_SELECCIONAR_ALL_PRODUCTOS";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);
            conexion.CloseConnection();
            return table;
        }

        public void UpdateUsuario(int id, string nombre_producto, int referencia, int valor, int cantidad)
        {

            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_ACTUALIZAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_producto", nombre_producto);
            comando.Parameters.AddWithValue("@Referencia", referencia);
            comando.Parameters.AddWithValue("@Valor", valor);
            comando.Parameters.AddWithValue("@Cantidad", cantidad);
            comando.Parameters.AddWithValue("@IdProducto", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void DeleteUsuario(int id)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_ELIMINAR_PRODUCTO";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

    }
}
