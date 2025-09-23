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

namespace TAREA_25A_HERRAMIENTAS_3
{
    public partial class frmAdminSeguridad : Form
    {
        public frmAdminSeguridad()
        {
            InitializeComponent();
        }

        private void btnSalirSeguridad_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtUsuarioSeguridad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerUsuariosSeguridad_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DATOS_ACCESO", connection);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewSeguridad.DataSource = dt;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al mostrar clientes: " + ex.Message);
                }
            }

        }

        private void dataGridViewSeguridad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewSeguridad.Rows[e.RowIndex];

                txtIdSeguridad.Text = row.Cells["IdUsuario"].Value?.ToString();
                txtEmpleadoSeguridad.Text = row.Cells["Nombre"].Value?.ToString();
                txtUsuarioSeguridad.Text = row.Cells["Usuario"].Value?.ToString();
                txtClaveSeguridad.Text = row.Cells["Contraeña"].Value?.ToString();

            }
        }

        private void btnActualizarSeguridad_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-FDFOE8V\\SQLEXPRESS;Initial Catalog=FACTURACION_H3;Integrated Security=True;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE DATOS_ACCESO SET Nombre=@Nombre, Usuario=@Usuario, Contraeña=@Contraseña WHERE IdUsuario=@IdCliente", connection);

                    cmd.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtIdSeguridad.Text));
                    cmd.Parameters.AddWithValue("@Nombre", txtEmpleadoSeguridad.Text);
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuarioSeguridad.Text);
                    cmd.Parameters.AddWithValue("@Contraseña", txtClaveSeguridad.Text);
                    int rows = cmd.ExecuteNonQuery();
                    MessageBox.Show(rows > 0 ? "Cliente actualizado correctamente." : "Cliente no encontrado.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al actualizar cliente: " + ex.Message);
                }

                txtIdSeguridad.Clear();
                txtEmpleadoSeguridad.Clear();
                txtUsuarioSeguridad.Clear();
                txtClaveSeguridad.Clear();
              
            }


        }
    }
}
