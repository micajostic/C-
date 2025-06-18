using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPilas
{
    public class Pila
    {
        private Nodo tope;
        private int maximo;
        private int cantidad;

        public Pila(int tMax)
        {
            tope = null;
            maximo = tMax;
            cantidad = 0;
        }

        public bool Llena()
        {
            return cantidad == maximo;
        }

        public bool Vacia()
        {
            return cantidad == 0;
        }

        public void push(Producto producto)
        {
            if(Llena())
            {
                Console.WriteLine("Pila llena, no se puede agregar el producto.");
            }
            else
            {
                Nodo nodo = new Nodo(producto);
                nodo.Siguiente = tope;
                tope = nodo;
                cantidad++;
            }
        }

        public Producto Pop()
        {
            Producto eliminado = null;

            if(Vacia())
            {
                Console.WriteLine("Pila vacía, no se puede eliminar ningún producto.");
            }
            else
            {
                eliminado = tope.Dato;
                tope = tope.Siguiente;
                cantidad--;
            }

            return eliminado;
        }

        public Producto Peek()
        {
            if (Vacia())
            {
                return null;
            }

            return tope.Dato;
        }

        public Producto Busqueda(int codigo)
        {
            Nodo aux = tope;
            while (aux != null)
            {
                if (aux.Dato.Codigo == codigo)
                {
                    return aux.Dato;
                }
                aux = aux.Siguiente;
            }

            Console.WriteLine("Producto no encontrado.");
            return null;
        }
    }
}
