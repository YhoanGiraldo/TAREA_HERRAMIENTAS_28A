using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class DALConexion
    {
        private SqlConnection Conexion = new
            SqlConnection("Data Source= DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=BD_TEST;Integrated Security=True;Encrypt=False;");

       
        public SqlConnection OpenConnection()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        
        public SqlConnection CloseConnection()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
