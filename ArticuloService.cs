using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Mercado
{
      public class ArticuloService
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {


                conexion.ConnectionString = "server=.\\SQLEXPRESS; database = CATALOGO_P3_DB; integrated security = true";

                comando.CommandType = System.Data.CommandType.Text;

                //comando.CommandText = "SELECT Codigo,Nombre from ARTICULOS";
                comando.CommandText = "SELECT ImagenUrl from IMAGENES";


                comando.Connection = conexion;

                conexion.Open();

                lector = comando.ExecuteReader();//esto genera un puntero
                /*
                while (lector.Read())
                {

                    Articulo aux = new Articulo();
                    aux.codigoArticulo = Convert.ToString(lector["Codigo"]);
                    aux.nombre = Convert.ToString(lector["Nombre"]);
                    //aux.precio = Convert.ToDecimal(lector["Precio"]);
                    //aux.marca = (string)lector["Descripcion"];
                    //aux.categoria = (string)lector["Descripcion"];



                    lista.Add(aux);
                }
                **/
           
                
                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.URLimagen = Convert.ToString(lector["ImagenUrl"]);
                    lista.Add(aux);
                }
                
                lector.Close();
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
