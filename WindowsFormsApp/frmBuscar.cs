﻿using Dominio;
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


namespace WindowsFormsApp
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select * from ARTICULOS where ID="+txtBuscar.Text;
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();

            ArticulosNegocio Negocio = new ArticulosNegocio();
            dgvBuscar.DataSource = Negocio.listar();
            //dgvBuscar.Columns[1].Visible = false;

        }
    }
}
