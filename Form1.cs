using System.Windows.Forms;

namespace TAREA_25A_HERRAMIENTAS_3
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes newMDIChild = new frmClientes();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos newMDIChild = new frmProductos();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoriasProductos newMDIChild = new frmCategoriasProductos();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFacturas newMDIChild = new frmFacturas();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformes newMDIChild = new frmInformes();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados newMDIChild = new frmEmpleados();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRolEmpleados newMDIChild = new frmRolEmpleados();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void seguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdminSeguridad newMDIChild = new frmAdminSeguridad();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void frmPrincipal_Load(object sender, EventArgs e)
        {
            await webViewPrincipal.EnsureCoreWebView2Async(null);

            webViewPrincipal.CoreWebView2.Navigate("https://www.google.com");

            webViewPrincipal.Visible = false;
            panelPrincipal.Visible = false;


        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            webViewPrincipal.Visible = true;
            panelPrincipal.Visible = false;

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webViewPrincipal.Visible = false;
            panelPrincipal.Visible = true;
        }
    }
}
