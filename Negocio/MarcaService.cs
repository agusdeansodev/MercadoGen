using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaService
    {
        public List<Marca> listar()
        {
            AccesoDatos _accesoDatos = new AccesoDatos();
            List<Marca>lista= new List<Marca>();

            try
            {
                _accesoDatos.setearConsulta("SELECT Id, IdArticulo, Descripcion FROM MARCAS");
                _accesoDatos.ejecutarAccion();

                while (_accesoDatos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.id = Convert.ToInt32(_accesoDatos.Lector["Id"]);
                    aux.descripcion = _accesoDatos.Lector["Descripcion"].ToString();

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


    }
}
