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
    public partial class FRM_PRODUCTOS : Form
    {
        BLLProductos objetoCN = new BLLProductos();
        private int id = 0;
        private bool Editar = false;

        public FRM_PRODUCTOS()
        {
            InitializeComponent();
        }

        private void ViewAllUsuario()
        {
            BLLProductos objeto = new BLLProductos();

            DGProdutos.DataSource = objeto.View();
        }

        private void ClearControls()
        {

            txtANombreProducto.Clear();
            txtAReferenciaProducto.Clear();
            txtAValorProducto.Clear();
            txtACantidadProducto.Clear();
        }


        private void btnAIngresarProductos_Click(object sender, EventArgs e)
        {
            FRM_AGREGAR_PRODUCTOS principal = new FRM_AGREGAR_PRODUCTOS();
            principal.Show();
            this.Hide();
        }

        private void btnASalirProductos_Click(object sender, EventArgs e)
        {
            INICIO form2 = new INICIO();
            form2.Show();
            this.Hide();
        }

        private void FRM_PRODUCTOS_Load(object sender, EventArgs e)
        {
            ViewAllUsuario();
        }


        private void btnAActualizar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {

                if (txtANombreProducto.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtANombreProducto.Focus();
                    return;
                }

                if (txtAReferenciaProducto.Text == "")
                {
                    MessageBox.Show("Falta Ingresar la Contraseña", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAReferenciaProducto.Focus();
                    return;
                }

                if (txtAValorProducto.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nro de Intentos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAValorProducto.Focus();
                    return;
                }


                if (txtACantidadProducto.Text == "")
                {
                    MessageBox.Show("Falta Ingresar el Nivel de Seguridad", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtACantidadProducto.Focus();
                    return;
                }

            }

            if (Editar == true)
            {
                objetoCN.Update(id, txtANombreProducto.Text, Convert.ToInt32(txtAReferenciaProducto.Text),
                    Convert.ToInt32(txtAValorProducto.Text), Convert.ToInt32(txtACantidadProducto.Text));
                MessageBox.Show("Registro actualizado correctamente");
                ViewAllUsuario();
                ClearControls();
                Editar = false;

            }

        }

        private void btnAEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DGProdutos.SelectedRows.Count > 0)
            {
                id = Convert.ToInt32(DGProdutos.CurrentRow.Cells["IdProducto"].Value);
                objetoCN.Delete(id);
                MessageBox.Show("Registro eliminado correctamente");
                ViewAllUsuario();
            }
            else
                MessageBox.Show("Debe seleccionar un resgistro en el DataGridView");
        }

        private void btnASeleccionarProductos_Click(object sender, EventArgs e)
        {
            if (DGProdutos.SelectedRows.Count > 0)
            {
                Editar = true;
                txtANombreProducto.Text = DGProdutos.CurrentRow.Cells["Nombre_producto"].Value.ToString();
                txtAReferenciaProducto.Text = DGProdutos.CurrentRow.Cells["Referencia"].Value.ToString();
                txtAValorProducto.Text = DGProdutos.CurrentRow.Cells["Valor"].Value.ToString();
                txtACantidadProducto.Text = DGProdutos.CurrentRow.Cells["Cantidad"].Value.ToString();   
                id = Convert.ToInt32(DGProdutos.CurrentRow.Cells["IdProducto"].Value);
            }

            else
                MessageBox.Show("Debe seleccionar un resgistro en el DataGridView");
        }
    }
}

