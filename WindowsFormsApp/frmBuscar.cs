using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace WindowsFormsApp
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        public Articulos articuloguardado { get; set; }

        private void btnBuscar_Click(object sender, EventArgs e) // SI PONES UN DATO QUE NO EXISTE PINCHA. 
        {
            //Elimine el codigo de prueba

            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();


            auxArticulo.marca = new Marca();
            auxArticulo.categoria = new Categoria();

            if (auxNegocio.buscar(txtBuscar.Text))
            {
                auxArticulo = auxNegocio.cargar(txtBuscar.Text);
                List<Articulos> lista = new List<Articulos>();
                lista.Add(auxArticulo);
                articuloguardado = auxArticulo;
                dgvBuscar.DataSource = lista;
            }
            else
            {
                MessageBox.Show("El articulo codigo: "+txtBuscar+" no se encuentra en el catalogo.");
            }


           

            //txtImporte.Text = (String)auxArticulo.Precio;


        }


        private void txtdetalle_click(object sender, EventArgs e)
        {
            
            ArticulosNegocio auxNegocio = new ArticulosNegocio();
            Articulos auxArticulo = new Articulos();

            auxArticulo.marca = new Marca();
            auxArticulo.categoria = new Categoria();

            if (dgvBuscar.SelectedRows.Count ==1)
            {
                string codigo = Convert.ToString(dgvBuscar.CurrentRow.Cells[1].Value);
                articuloguardado = auxNegocio.cargar(codigo);
                frmDetalle detalle = new frmDetalle();
                detalle.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("No selecciono ningun articulo!");

            }

        }

        private void btmodificar_Click(object sender, EventArgs e)
        {
            frmModificar modificar = new frmModificar();
            modificar.ShowDialog();
        }
    }
}
