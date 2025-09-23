using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;
using SqlException = Microsoft.Data.SqlClient.SqlException;


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA_25A_HERRAMIENTAS_3
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void btnSalirClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {


            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int NumDocumento, StrTelefono;
                String strNombre, strDireccion, strEmail, DtmFechaModifica, strUsuario;

                txtIdCLiente.Text = " ";
                strNombre = txtNombreCliente.Text;
                NumDocumento = Convert.ToInt32(txtDocumentoCliente.Text);
                strDireccion = txtDireccionCliente.Text;
                StrTelefono = Convert.ToInt32(txtTelefonoCliente.Text);
                strEmail = txtEmailCliente.Text;
                DtmFechaModifica = txtFechaModificaCliente.Text;
                strUsuario = txtUsuarioModificaCliente.Text;


                try
                {


                    //connection = new SqlCommand(connectionString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO CLIENTES (Nombre, Documento, Direccion, Telefono, Email, Fecha_Modificar, Usuario_Modifica) " +
                                                     "VALUES (@Nombre, @NumDocumento, @Direccion, @Telefono, @Email, @FechaModifica, @UsuarioModifica)", connection);


                    cmd.Parameters.AddWithValue("@Nombre", strNombre);
                    cmd.Parameters.AddWithValue("@NumDocumento", NumDocumento);
                    cmd.Parameters.AddWithValue("@Direccion", strDireccion);
                    cmd.Parameters.AddWithValue("@Telefono", StrTelefono);
                    cmd.Parameters.AddWithValue("@Email", strEmail);
                    cmd.Parameters.AddWithValue("@FechaModifica", DtmFechaModifica);
                    cmd.Parameters.AddWithValue("@UsuarioModifica", strUsuario);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente insertado correctamente.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al insertar cliente: " + ex.Message);
                }

                txtIdCLiente.Clear();
                txtNombreCliente.Clear();
                txtDocumentoCliente.Clear();
                txtDireccionCliente.Clear();
                txtTelefonoCliente.Clear();
                txtEmailCliente.Clear();
                txtFechaModificaCliente.Clear();
                txtUsuarioModificaCliente.Clear();



            }
        }

        private void btnVerDatosCliente_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CLIENTES", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewCliente.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al mostrar clientes: " + ex.Message);
                }
            }

        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {              


                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE CLIENTES SET Nombre=@Nombre, Documento=@NumDocumento, Direccion=@Direccion, Telefono=@Telefono," +
                        " Email=@Email, Fecha_Modificar=@FechaModifica, Usuario_Modifica=@UsuarioModifica WHERE IdCliente=@IdCliente", connection);

                    cmd.Parameters.AddWithValue("@IdCliente", Convert.ToInt64(txtIdCLiente.Text));
                    cmd.Parameters.AddWithValue("@Nombre", txtNombreCliente.Text);
                    cmd.Parameters.AddWithValue("@NumDocumento", Convert.ToInt64(txtDocumentoCliente.Text));
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccionCliente.Text);
                    cmd.Parameters.AddWithValue("@Telefono", Convert.ToInt64(txtTelefonoCliente.Text));
                    cmd.Parameters.AddWithValue("@Email", txtEmailCliente.Text);
                    cmd.Parameters.AddWithValue("@FechaModifica", txtFechaModificaCliente.Text);
                    cmd.Parameters.AddWithValue("@UsuarioModifica", txtUsuarioModificaCliente.Text);

                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Cliente actualizado correctamente." : "Cliente no encontrado.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar cliente: " + ex.Message);
                }

                txtIdCLiente.Clear();
                txtNombreCliente.Clear();
                txtDocumentoCliente.Clear();
                txtDireccionCliente.Clear();
                txtTelefonoCliente.Clear();
                txtEmailCliente.Clear();
                txtFechaModificaCliente.Clear();
                txtUsuarioModificaCliente.Clear();
            }

        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int IdCLiente;
            IdCLiente = Convert.ToInt32(txtIdCLiente.Text);
            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM CLIENTES WHERE IdCliente=@IdCliente", connection);
                    cmd.Parameters.AddWithValue("@IdCliente", IdCLiente);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Cliente eliminado correctamente." : "Cliente no encontrado.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al eliminar cliente: " + ex.Message);
                }


            }

        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            txtIdCLiente.Clear();
            txtNombreCliente.Clear();
            txtDocumentoCliente.Clear();
            txtDireccionCliente.Clear();
            txtTelefonoCliente.Clear();
            txtEmailCliente.Clear();
            txtFechaModificaCliente.Clear();
            txtUsuarioModificaCliente.Clear();

        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCliente.Rows[e.RowIndex];

                txtIdCLiente.Text = row.Cells["IdCliente"].Value?.ToString();
                txtNombreCliente.Text = row.Cells["Nombre"].Value?.ToString();
                txtDocumentoCliente.Text = row.Cells["Documento"].Value?.ToString();
                txtDireccionCliente.Text = row.Cells["Direccion"].Value?.ToString();
                txtTelefonoCliente.Text = row.Cells["Telefono"].Value?.ToString();
                txtEmailCliente.Text = row.Cells["Email"].Value?.ToString();
                txtFechaModificaCliente.Text = row.Cells["Fecha_Modificar"].Value?.ToString();
                txtUsuarioModificaCliente.Text = row.Cells["Usuario_Modifica"].Value?.ToString();
            }

        }
    }
}
