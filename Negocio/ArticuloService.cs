using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using Dominio;



namespace Negocio
{
    public class ArticuloService
    {
        public List<Articulo> listar()
        {   
            AccesoDatos _accesoDatos = new AccesoDatos();

            List<Articulo> lista = new List<Articulo>();
       
            try
            {
                _accesoDatos.setearConsulta("SELECT Codigo, Nombre, Precio FROM ARTICULOS");
                _accesoDatos.ejecutarLectura();

                while (_accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.codigoArticulo = _accesoDatos.Lector["Codigo"].ToString();
                    aux.nombre = _accesoDatos.Lector["Nombre"].ToString();
                    aux.precio = Convert.ToSingle(_accesoDatos.Lector["Precio"]);

                    lista.Add(aux);
                }
                _accesoDatos.cerrarConexion();

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregarProducto(Articulo _articulo)
        {
              AccesoDatos _accesoDatos= new AccesoDatos();

            try
            {
                _accesoDatos.setearConsulta("INSERT INTO ARTICULOS (Codigo,Nombre,Precio) VALUES ('" + _articulo.codigoArticulo + "','" + _articulo.nombre + "'," + _articulo.precio + ")");

                _accesoDatos.ejecutarAccion();

                

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

                _accesoDatos.cerrarConexion();
                
            }
        }
    }

}
