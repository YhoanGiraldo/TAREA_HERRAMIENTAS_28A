using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class INICIO : Form
    {
        public INICIO()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dATOSACCESOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CLIENTES frm_clientes = new FRM_CLIENTES();
            frm_clientes.Show();
            this.Hide();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRODUCTOS frm_productos = new FRM_PRODUCTOS();
            frm_productos.Show();
            this.Hide();
        }
    }
}
