using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Mercado
{
     class ArticuloService
    {
        public List<Articulo> listar() 
        {
            List <Articulo> lista =new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            
            try
            {
                

                conexion.ConnectionString = "server=.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Codigo,Nombre,Precio from ARTICULOS";
                comando.CommandText = "SELECT Descripcion from MARCAS";
                comando.CommandText = "SELECT Descripcion from CATEGORIAS";

                comando.Connection = conexion;

                conexion.Open();
                lector= comando.ExecuteReader();//esto genera un puntero

                while (lector.Read()) {

                    Articulo aux = new Articulo();

                    aux.nombre = (string) lector["Nombre"];
                    aux.codigoArticulo = (string)lector["Codigo"];
                    aux.descripcion = (string)lector["Descripcion"];
                    //aux.marca = (int)lector["Marca"];
                    aux.categoria = (string)lector["Descripcion"];
                    aux.precio = (int)lector["Precio"];
                    //aux.imagen = (string)lector["URL"];
                    lista.Add(aux);
                }

                conexion.Close();
                return lista;

            } // fin try
            catch (Exception ex)
            {
                throw ex;

            }

           
        }
    }
}
