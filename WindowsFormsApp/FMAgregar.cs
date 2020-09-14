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
using Negocio;

namespace WindowsFormsApp
{
    public partial class FMAgregar : Form
    {
        public FMAgregar()
        {
            InitializeComponent();
        }

        private void btaceptar_Click(object sender, EventArgs e)
        {
            Articulos nuevo = new Articulos();
            ArticulosNegocio Negocio = new ArticulosNegocio();

            nuevo.Nombre = txtnombre.Text;
            nuevo.Descripcion = txtdescripcion.Text;

            Negocio.Agregar(nuevo);

            MessageBox.Show("Articulo agregado exitosamente!");
            Close();

        }

        private void FMAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            cbmarca.DataSource = marcaNegocio.listar();

            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            cbcategoria.DataSource = categoriaNegocio.listar();

        }
    }
}
