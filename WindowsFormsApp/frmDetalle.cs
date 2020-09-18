using Dominio;
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
    public partial class frmDetalle : Form
    {
        public frmDetalle()
        {
            InitializeComponent();
        }

        public frmDetalle(Articulos articulo)
        {

        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            frmBuscar buscar = new frmBuscar();
            txtcodigo.Text = buscar.articuloguardado.Codigo;
            txtnombre.Text = buscar.articuloguardado.Nombre;


        }
    }
}
