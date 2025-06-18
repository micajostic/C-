using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPilas
{
    public class Nodo
    {
        public Producto Dato { get; set; }
        public Nodo Siguiente { get; set; }
        public Nodo(Producto producto)
        {
            Dato = producto;
            Siguiente = null;
        }
    }
}
