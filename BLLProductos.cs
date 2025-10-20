using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class BLLProductos
    {

        private DALProductos objetoCD = new DALProductos();

        public DataTable View()
        {

            DataTable tabla = new DataTable();
            tabla = objetoCD.ReadAllUsuario();
            return tabla;
        }

        public void Create(string nombre_producto, int referencia, int valor, int cantidad)
        {

            objetoCD.CreateUsuario(nombre_producto, referencia, valor, cantidad);
        }


        public void Update(int id, string nombre_producto, int referencia, int valor, int cantidad)
        {
            objetoCD.UpdateUsuario(id, nombre_producto, referencia, valor, cantidad);
        }


        public void Delete(int id)
        {

            objetoCD.DeleteUsuario(id);
        }


    }
}

