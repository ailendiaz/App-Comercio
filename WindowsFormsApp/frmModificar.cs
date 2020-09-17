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

        

        //private void btactualizar_Click(object sender, EventArgs e)
        //{
            

         // ArticulosNegocio auxNegocio = new ArticulosNegocio();
         //  Articulos auxArticulo = new Articulos();

          // auxArticulo.marca = new Marca();
          // auxArticulo.categoria = new Categoria();
           
          //auxArticulo= auxNegocio.Modificar(auxArticulo);// aca habria que pasarle el txtbuscar.text del form buscar
           // para que modifique ese pero no se como. La funcion buscar recibe una string del txt pero desde el otro form no se puede acceder
          // List<Articulos> lista = new List<Articulos>();
          //lista.Add(auxArticulo);

            //dgvBuscar.DataSource = lista;
        }
    }

