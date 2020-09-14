using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class ArticulosNegocio
    {
        public List<Articulos>listar ()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulos> lista = new List<Articulos>();

            
            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select ID, Nombre, Descripcion, ImagenUrl From ARTICULOS";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read ())
            {
                Articulos aux = new Articulos ();
                aux.Nombre = lector.GetString(1);
                aux.Descripcion = lector.GetString(2);
                aux.ImagenUrl= (string)lector["ImagenUrl"];

                lista.Add(aux);

            }

            conexion.Close();
            return lista;
        }

    }
}
