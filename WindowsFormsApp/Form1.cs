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
using Dominio;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticulosNegocio Negocio = new ArticulosNegocio();
            //DGVLista.DataSource = Negocio.listar();
            //DGVLista.Columns[2].Visible = false;
            //Al habilitar las lineas de codigo comentadas pincha
        }

        private void DGVLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVLista_SelectionChanged(object sender, EventArgs e)
        {
            //Este try no haria falta porque todo tiene imagen
            try
            {
                Articulos articulo = (Articulos)DGVLista.CurrentRow.DataBoundItem;
                pbarticulo.Load(articulo.ImagenUrl);
            }
            catch (Exception)
            {

           
            }
            
        }
    }
}
