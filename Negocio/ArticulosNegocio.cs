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
        public List<Articulos> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulos> lista = new List<Articulos>();


            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select A.ID,A.Codigo,A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion Marcas From ARTICULOS A, MARCAS M where A.IdMarca= M.Id";
            comando.CommandText = "Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria";

            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            while (lector.Read())
            {
                Articulos aux = new Articulos();
                aux.Codigo = lector.GetString(1);
                aux.Nombre = lector.GetString(2);
                aux.Descripcion = lector.GetString(3);
                aux.ImagenUrl = (string)lector["ImagenUrl"];
                aux.Precio = lector.GetSqlMoney(5);

                aux.marca = new Marca();
                aux.marca.descripcion = (string)lector["Marcas"];
                aux.categoria = new Categoria();
                aux.categoria.descripcion = (string)lector["Categoria"];

                lista.Add(aux);

            }

            conexion.Close();
            return lista;
        }

        public void Agregar(Articulos nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Insert Into ARTICULOS (Codigo,Nombre,Descripcion,ImagenUrl,Precio) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "',' ','" + nuevo.Precio + "')";
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
        }
        public Articulos buscar(string codigo)
        {
            
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select A.ID,A.Codigo,A.Nombre,A.Descripcion,A.ImagenUrl,A.Precio, m.Descripcion Marcas, isnull(c.Descripcion,'Sin definir') Categoria from ARTICULOS A left join MARCAS m on m.Id=a.IdMarca left join CATEGORIAS c on c.Id=a.IdCategoria where a.Codigo='" + codigo + "'";
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();

            
            Articulos aux = new Articulos();
            while (lector.Read())
            {
                aux.Codigo = lector.GetString(1);

                aux.Nombre = lector.GetString(2);
                aux.Descripcion = lector.GetString(3);
                aux.ImagenUrl = (string)lector["ImagenUrl"];
                aux.Precio = lector.GetSqlMoney(5);
                aux.marca = new Marca();
                aux.marca.descripcion = (string)lector["Marcas"];
                aux.categoria = new Categoria();
                aux.categoria.descripcion = (string)lector["Categoria"];

            }

            conexion.Close();
            return aux;

        }

        public static int modificar (Articulos nuevo)
        {
            int retorno = 0;

            {
                   SqlConnection conexion = new SqlConnection();
                   SqlCommand comando = new SqlCommand();
                   

            //comentamos y descomentamos para poder usar la base de datos local de cada uno
            //conexion.ConnectionString = "Data Source= ALE\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
                  conexion.ConnectionString = "Data Source= DESKTOP-3EDAK3V\\SQLEXPRESS; initial catalog= CATALOGO_DB;integrated security= sspi";
                   comando.CommandType = System.Data.CommandType.Text;
                   comando.CommandText = "Update ARTICULOS SET Codigo= '" + nuevo.Codigo + "',Nombre='" + nuevo.Nombre + "',Descrpcion= '" + nuevo.Descripcion + "',ImagenUrl='" + nuevo.ImagenUrl + "',Precio='" + nuevo.Precio + "', where Codigo='" + nuevo.Codigo + "'";

                   comando.Connection = conexion;

                   conexion.Open();
                 retorno = comando.ExecuteNonQuery();
              }

              return retorno;

        }

        

    }
}
