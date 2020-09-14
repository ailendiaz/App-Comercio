using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado listado = new frmListado();
            listado.ShowDialog();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FMAgregar agregar = new FMAgregar();
            agregar.ShowDialog(); 
        }
    }
}
