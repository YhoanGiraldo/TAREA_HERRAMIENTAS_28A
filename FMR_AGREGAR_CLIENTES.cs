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
    public partial class FMR_AGREGAR_CLIENTES : Form
    {

        BLLClientes objetoCN = new BLLClientes();

        private bool Editar = false;

        public FMR_AGREGAR_CLIENTES()
        {
            InitializeComponent();
        }


        

        private void FMR_AGREGAR_CLIENTES_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {

            FRM_CLIENTES principal = new FRM_CLIENTES();
            principal.Show();
            this.Hide();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {

            if (Editar == false)
            {
                try
                {
                    //Validación de controles

                    if (txtNombreCliente.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar el Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNombreCliente.Focus();
                        return;
                    }
                    if (txtDocumentoCliente.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDocumentoCliente.Focus();
                        return;
                    }
                    if (txtDireccionCliente.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar el Nro de Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDireccionCliente.Focus();
                        return;
                    }
                    if (txtTelefonoCliente.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar el Nivel de Seguridad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTelefonoCliente.Focus();
                        return;
                    }
                    if (txtEmailCliente.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar la Fecha de Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEmailCliente.Focus();
                        return;
                    }
                    if (txtFechaRegistroCliente.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar la Fecha de Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtFechaRegistroCliente.Focus();
                        return;
                    }
                    if (txtEncargadoCliente.Text == "")
                    {
                        MessageBox.Show("Falta Ingresar la Fecha de Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEncargadoCliente.Focus();
                        return;
                    }

                    objetoCN.Create(txtNombreCliente.Text, txtDocumentoCliente.Text, txtDireccionCliente.Text, txtTelefonoCliente.Text, txtEmailCliente.Text,
                        txtFechaRegistroCliente.Text, txtEncargadoCliente.Text);
                    MessageBox.Show("Se guardo correctamente");
             
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos, se encontro el siguiente error : " + ex);
                }
            }        



            FRM_CLIENTES principal = new FRM_CLIENTES();
            principal.Show();
            Close();

        }
    }
}
