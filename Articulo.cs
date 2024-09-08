using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    public class Articulo
    {
        public string codigoArticulo { get; set; }
        public string nombre { get; set; }
        public string marca { get; set; } //(seleccionable de una lista desplegable).
        public string categoria { get; set; } //(seleccionable de una lista desplegable.
        public int precio { get; set; }
        public string URLimagen {  get; set; }
  
    }
}
