using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BLLClientes
    {

        private DALClientes objetoCD = new DALClientes();

        public DataTable View()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.ReadAllUsuario();
            return tabla;
        }

        public void Create(string nombre, string documento, string direccion, string telefono, string email, string fecha_ingreso, string encargado_datos)
        {

            objetoCD.CreateUsuario(nombre, documento, direccion, telefono, email, fecha_ingreso, encargado_datos);
        }


        public void Update(int id, string nombre, string documento, string direccion, string telefono, string email, string fecha_ingreso, string encargado_datos)
        {
            objetoCD.UpdateUsuario(Convert.ToInt32(id), nombre, documento, direccion, telefono, email, fecha_ingreso, encargado_datos);
        }


        public void Delete(int id)
        {

            objetoCD.DeleteUsuario(Convert.ToInt32(id));
        }


    }
}
