using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_OBLIGATORIO___Jostic__Micaela
{
    public class Alumno
    {
        public string Nombre { get; set; }

        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public string Mostrar()
        {
            return Nombre;
        }
    }
}
