using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DALClientes
    {

        private DALConexion conexion = new DALConexion();

        // Cambia la declaración de dataReader para que acepte valores nulos
        SqlDataReader? dataReader;
        DataTable table = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void CreateUsuario(string nombre, string documento, string direccion, string telefono, string email, string fecha_ingreso, string encargado_datos)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_INSERTAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Documento", documento);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Fecha_ingreso", fecha_ingreso);
            comando.Parameters.AddWithValue("@Encargado_datos", encargado_datos);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable ReadAllUsuario()
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_SELECCIONAR_ALL_CLIENTES";
            comando.CommandType = CommandType.StoredProcedure;
            dataReader = comando.ExecuteReader();
            table.Load(dataReader);
            conexion.CloseConnection();
            return table;
        }


        public void UpdateUsuario(int id, string nombre, string documento, string direccion, string telefono, string email, string fecha_ingreso, string encargado_datos)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_ACTUALIZAR_CLIENTE_2";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.Parameters.AddWithValue("@Documento", documento);
            comando.Parameters.AddWithValue("@Direccion", direccion);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@Email", email);
            comando.Parameters.AddWithValue("@Fecha_ingreso", fecha_ingreso);
            comando.Parameters.AddWithValue("@Encargado_datos", encargado_datos);
            comando.Parameters.AddWithValue("@Id_Cliente", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear(); 
        }

       

        public void DeleteUsuario(int id)
        {
            comando.Connection = conexion.OpenConnection();
            comando.CommandText = "SP_ELIMINAR_CLIENTE";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_cliente", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }


    }
}
