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
    public partial class frmCategoriasProductos : Form
    {
        public frmCategoriasProductos()
        {
            InitializeComponent();
        }

        private void btnSalirCategoria_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
