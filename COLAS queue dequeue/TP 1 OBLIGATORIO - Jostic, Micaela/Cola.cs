using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_OBLIGATORIO___Jostic__Micaela
{
    public class Cola
    {
        Nodo _inicio;

        public void encolar(Alumno alumno) //queue
        {
            Nodo nuevo = new Nodo(alumno);
            if (_inicio == null)
            {
                _inicio = nuevo;
            }
            else
            {
                Nodo aux = _inicio;
                while (aux.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = nuevo;
            }
        }

        public Alumno desencolar() //dequeue
        {
            if (_inicio == null)
            {
                return null;
            }
            else
            {
                Alumno dato = _inicio.Dato;
                _inicio = _inicio.Siguiente;
                return dato;
            }
        }

        public Alumno Tope() 
        {
            if (_inicio != null)
            {
                return _inicio.Dato;
            }
            return null;
        }

        public Nodo Inicio() //peek
        {
            return _inicio;
        }
    }
}
