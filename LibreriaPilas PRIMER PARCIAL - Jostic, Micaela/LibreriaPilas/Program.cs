using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la aplicación de gestión de productos en pila.");
            Console.Write("Ingrese el tamaño máximo de la pila: ");
            int max = int.Parse(Console.ReadLine());

            Pila pila = new Pila(max);
            int opcion;

            do
            {
                Console.WriteLine("\n---------MENÚ-----------");
                Console.WriteLine("1. Apilar producto (Push)");
                Console.WriteLine("2. Desapilar producto (Pop)");
                Console.WriteLine("3. Ver el producto en el tope de la pila (Peek)");
                Console.WriteLine("4. Buscar producto por código");
                Console.WriteLine("5. Esta vacía?");
                Console.WriteLine("6. Esta llena?");
                Console.WriteLine("0. Salir");

                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        if (pila.Llena())
                        {
                            Console.WriteLine("⚠️ La pila está llena, no se puede agregar más productos.");
                        }
                        else
                        {
                            Producto producto = new Producto();
                            Console.Write("Ingrese el código del producto: ");
                            producto.Codigo = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el nombre del producto: ");
                            producto.Nombre = Console.ReadLine();
                            Console.Write("Ingrese el precio del producto: ");
                            producto.Precio = decimal.Parse(Console.ReadLine());
                            pila.push(producto);
                            Console.WriteLine($"Producto {producto.Nombre} agregado a la pila.");
                        }
                        break;

                    case 2:
                        Producto eliminado = pila.Pop();
                        if(eliminado != null)
                        {
                            Console.WriteLine($"Producto {eliminado.Nombre} eliminado de la pila.");
                        }
                        break;

                    case 3:
                        Producto tope = pila.Peek();
                        if (tope != null)
                        {
                            Console.WriteLine($"Producto en el tope de la pila: Código {tope.Codigo}, Nombre {tope.Nombre}, Precio {tope.Precio}");
                        }
                        else
                        {
                            Console.WriteLine("La pila está vacía, no hay productos en el tope.");
                        }
                        break;


                    case 4:
                        Console.Write("Ingrese el código del producto a buscar: ");
                        int codigoBusqueda = int.Parse(Console.ReadLine());
                        Producto encontrado = pila.Busqueda(codigoBusqueda);
                        if (encontrado != null)
                        {
                            Console.WriteLine($"Producto encontrado: Código {encontrado.Codigo}, Nombre {encontrado.Nombre}, Precio {encontrado.Precio}");
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado en la pila.");
                        }
                        break;
                    case 5:
                        Console.WriteLine($"Pila vacía? {(pila.Vacia() ? "Si":"No")}");
                        break;
                    case 6:
                        Console.WriteLine($"Pila llena? {(pila.Llena() ? "Si" : "No")}");
                        break;
                    case 0:
                        Console.WriteLine("Saliendo de la aplicación. Hasta luego!");
                        
                        break;
                    default:
                        Console.WriteLine("Opción no válida, por favor intente de nuevo.");
                        break;
                }



            } while (opcion != 0);
        }
    }
}
