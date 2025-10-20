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
    public partial class FRM_CLIENTES : Form
    {
        BLLClientes objetoCN = new BLLClientes();
        private int id = 0;
        private bool Editar = false;

        public FRM_CLIENTES()
        {
            InitializeComponent();
        }

        private void ViewAllUsuario()
        {
            BLLClientes objeto = new BLLClientes();

            DGFrmClientes.DataSource = objeto.View();
        }

        private void ClearControls()
        {
            txtActualizarNombreCliente.Clear();
            txtActualizarDocumentoCliente.Clear();
            txtActualizarDireccionCLiente.Clear();
            txtActualizarTelefonoCLiente.Clear();
            txtActualizarEmailCliente.Clear();
            txtActualizarFechaRegistroCliente.Clear();

        }


        private void btnAgregarNuevo_Click(object sender, EventArgs e)
        {

            FMR_AGREGAR_CLIENTES principal = new FMR_AGREGAR_CLIENTES();
            principal.Show();
            this.Hide();
        }

        private void btnSalirCliente_Click(object sender, EventArgs e)
        {
            INICIO form2 = new INICIO();
            form2.Show();
            this.Hide();
        }

        private void FRM_CLIENTES_Load(object sender, EventArgs e)
        {
            ViewAllUsuario();
        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {

                if (txtActualizarNombreCliente.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarNombreCliente.Focus();
                    return;
                }

                if (txtActualizarDocumentoCliente.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarDocumentoCliente.Focus();
                    return;
                }

                if (txtActualizarDireccionCLiente.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nro de Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarDireccionCLiente.Focus();
                    return;
                }


                if (txtActualizarTelefonoCLiente.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nivel de Seguridad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarTelefonoCLiente.Focus();
                    return;
                }

                if (txtActualizarEmailCliente.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Fecha de Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarEmailCliente.Focus();
                    return;
                }

                if (txtActualizarFechaRegistroCliente.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Fecha de Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarFechaRegistroCliente.Focus();
                    return;
                }

                if (txtActualizarEncargado.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Fecha de Registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtActualizarEncargado.Focus();
                    return;
                }
            }

            if (Editar == true)
            {
                objetoCN.Update(id, txtActualizarNombreCliente.Text, txtActualizarDocumentoCliente.Text, txtActualizarDireccionCLiente.Text,
                    txtActualizarTelefonoCLiente.Text, txtActualizarEmailCliente.Text, txtActualizarFechaRegistroCliente.Text, txtActualizarEncargado.Text);
                MessageBox.Show("Registro actualizado correctamente");
                ViewAllUsuario();
                ClearControls();
                Editar = false;

            }




        }

        private void btnSeleccionarDatoCliente_Click(object sender, EventArgs e)
        {

            if (DGFrmClientes.SelectedRows.Count > 0)
            {
                Editar = true;
                txtActualizarNombreCliente.Text = DGFrmClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtActualizarDocumentoCliente.Text = DGFrmClientes.CurrentRow.Cells["Documento"].Value.ToString();
                txtActualizarDireccionCLiente.Text = DGFrmClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                txtActualizarTelefonoCLiente.Text = DGFrmClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                txtActualizarEmailCliente.Text = DGFrmClientes.CurrentRow.Cells["Email"].Value.ToString();
                txtActualizarFechaRegistroCliente.Text = DGFrmClientes.CurrentRow.Cells["Fecha_ingreso"].Value.ToString();
                txtActualizarEncargado.Text = DGFrmClientes.CurrentRow.Cells["Encargado_datos"].Value.ToString();
                id = Convert.ToInt32(DGFrmClientes.CurrentRow.Cells["IdCliente"].Value);
            }

            else
                MessageBox.Show("Debe seleccionar un resgistro en el DataGridView");

        }

        private void DGFrmClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (DGFrmClientes.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(DGFrmClientes.CurrentRow.Cells["IdCLiente"].Value);
                objetoCN.Delete(id);
                MessageBox.Show("Registro eliminado correctamente");
                ViewAllUsuario();
            }
            else
                MessageBox.Show("Debe seleccionar un resgistro en el DataGridView");
        }
    }
}
