using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_OBLIGATORIO___Jostic__Micaela
{
    public class Nodo
    {
        public Alumno Dato;
        public Nodo Siguiente;

        public Nodo(Alumno dato)
        {
            Dato = dato;
            Siguiente = null;
        }

    }
}
