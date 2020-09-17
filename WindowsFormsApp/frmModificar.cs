using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


namespace WindowsFormsApp
{
    public partial class frmModificar : Form
    {
        public frmModificar()
        {
            InitializeComponent();
        }

        public Articulos articulomodificado { get; set; }

        private void btaceptar_Click(object sender, EventArgs e)
        {

                frmBuscar buscar = new frmBuscar();
                ArticulosNegocio auxNegocio = new ArticulosNegocio();
                Articulos auxArticulo = new Articulos();

                auxArticulo.marca = new Marca();
                auxArticulo.categoria = new Categoria();
                articulomodificado = buscar.articuloguardado;


                auxArticulo.Nombre = txtnombre.Text;
                auxArticulo.Descripcion = txtdescripcion.Text;
                auxArticulo.Codigo = articulomodificado.Codigo;

            int resultado = ArticulosNegocio.modificar(auxArticulo);

            if (resultado>0)
            {
                MessageBox.Show("Articulo Modificado exitosamente!");
            }
            else
            {
                MessageBox.Show("El articulo no pudo ser modificado!");
            }

        }
    }
}

