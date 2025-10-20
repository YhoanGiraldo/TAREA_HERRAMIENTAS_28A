using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FRM_AGREGAR_PRODUCTOS : Form
    {
        BLLProductos objetoCN = new BLLProductos();
        private bool Editar = false;

        public FRM_AGREGAR_PRODUCTOS()
        {
            InitializeComponent();
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTOS principal = new FRM_PRODUCTOS();
            principal.Show();
            this.Hide();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    

                    if (txtNombreProducto.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar el Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombreProducto.Focus();
                        return;
                    }
                    if (txtReferenciaProducto.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtReferenciaProducto.Focus();
                        return;
                    }
                    if (txtValorProducto.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar el Nro de Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtValorProducto.Focus();
                        return;
                    }
                    if (txtCantidadProducto.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar el Nivel de Seguridad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCantidadProducto.Focus();
                        return;
                    }                  
                   

                    objetoCN.Create(txtNombreProducto.Text, Convert.ToInt32(txtReferenciaProducto.Text), Convert.ToInt32(txtValorProducto.Text), 
                        Convert.ToInt32(txtCantidadProducto.Text));
                    MessageBox.Show("Se guardo correctamente");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos, se encontro el siguiente error : " + ex);
                }
            }



            FRM_PRODUCTOS principal = new FRM_PRODUCTOS();
            principal.Show();
            Close();

        }
    }
}
