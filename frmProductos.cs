using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TAREA_25A_HERRAMIENTAS_3
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PRODUCTOS", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewProductos.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al mostrar productos: " + ex.Message);
                }
            }

        }

        private void btnActualizarProductos_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string updateQuery = "UPDATE PRODUCTOS SET Nombre=@Nombre, Codigo_producto=@Codigo_producto, Precio_compra=@Precio_compra, " +
                    "Precio_venta=@Precio_venta, Cantidad_stock=@Cantidad_stock, Categoria=@Categoria, Detalles_producto=@Detalles " +
                    "WHERE IdProducto=@IdProducto";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(updateQuery, connection);

                    command.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(txtIdProductos.Text));
                    command.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                    command.Parameters.AddWithValue("@Codigo_producto", txtCodigoProductos.Text);
                    command.Parameters.AddWithValue("@Precio_compra", txtPrecioCompraProducto.Text);
                    command.Parameters.AddWithValue("@Precio_venta", txtPrecioVentaProducto.Text);
                    command.Parameters.AddWithValue("@Cantidad_stock", txtCantidadStockProducto.Text);
                    command.Parameters.AddWithValue("@Categoria", comboBoxProductos.Text);
                    command.Parameters.AddWithValue("@Detalles", txtDetallesProducto.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto actualizado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto con el Id especificado.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar el producto: " + ex.Message);
                }

                txtIdProductos.Text = " ";
                txtNombreProducto.Clear();
                txtCodigoProductos.Clear();
                txtPrecioCompraProducto.Clear();
                txtPrecioVentaProducto.Clear();
                txtCantidadStockProducto.Clear();
                comboBoxProductos.Text = "";
                txtDetallesProducto.Clear();
            }

        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewProductos.Rows[e.RowIndex];

                txtIdProductos.Text = row.Cells["IdProducto"].Value?.ToString();
                txtNombreProducto.Text = row.Cells["Nombre"].Value?.ToString();
                txtCodigoProductos.Text = row.Cells["Codigo_producto"].Value?.ToString();
                txtPrecioCompraProducto.Text = row.Cells["Precio_compra"].Value?.ToString();
                txtPrecioVentaProducto.Text = row.Cells["Precio_venta"].Value?.ToString();
                txtCantidadStockProducto.Text = row.Cells["Cantidad_stock"].Value?.ToString();
                comboBoxProductos.Text = row.Cells["Categoria"].Value?.ToString();
                txtDetallesProducto.Text = row.Cells["Detalles_producto"].Value?.ToString();

            }
        }

        private void txtDetallesProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                txtIdProductos.Text = " ";
                try
                {


                    //connection = new SqlCommand(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO PRODUCTOS (Nombre, Codigo_producto, Precio_compra, Precio_venta," +
                                                    "Cantidad_stock, Categoria, Detalles_producto) VALUES (@Nombre, @Codigo_producto, @Precio_compra, " +
                                                    "@Precio_venta, @Cantidad_stock, @Categoria, @Detalles_producto)", connection)
                    {

                    };
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreProducto.Text);
                    cmd.Parameters.AddWithValue("@Codigo_producto", txtCodigoProductos.Text);
                    cmd.Parameters.AddWithValue("@Precio_compra", Convert.ToInt32(txtPrecioCompraProducto.Text));
                    cmd.Parameters.AddWithValue("@Precio_venta", Convert.ToInt32(txtPrecioVentaProducto.Text));
                    cmd.Parameters.AddWithValue("@Cantidad_stock", Convert.ToInt32(txtCantidadStockProducto.Text));
                    cmd.Parameters.AddWithValue("@Categoria", comboBoxProductos.SelectedItem);
                    cmd.Parameters.AddWithValue("@Detalles_producto", txtDetallesProducto.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Producto insertado correctamente.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al insertar producto: " + ex.Message);
                }

                txtIdProductos.Text = " ";
                txtNombreProducto.Clear();
                txtCodigoProductos.Clear();
                txtPrecioCompraProducto.Clear();
                txtPrecioVentaProducto.Clear();
                txtCantidadStockProducto.Clear();
                comboBoxProductos.Text = "";
                txtDetallesProducto.Clear();
            }

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

            int IdProducto;
            IdProducto = Convert.ToInt32(txtIdProductos.Text);
            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM PRODUCTOS WHERE IdProducto=@IdProducto", connection);
                    cmd.Parameters.AddWithValue("@IdProducto", IdProducto);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Cliente eliminado correctamente." : "Cliente no encontrado.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al eliminar Producto: " + ex.Message);
                }

                txtIdProductos.Text = " ";
                txtNombreProducto.Clear();
                txtCodigoProductos.Clear();
                txtPrecioCompraProducto.Clear();
                txtPrecioVentaProducto.Clear();
                txtCantidadStockProducto.Clear();
                comboBoxProductos.Text = "";
                txtDetallesProducto.Clear();


            }

        }
    }
}
