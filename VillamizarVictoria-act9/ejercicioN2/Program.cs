using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
     class empresa
    {
        /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
        realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
        vectores paralelos, ordenar los datos de mayor a menor según las ventas,
        imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
        el que menos vendió de los 5 empleados.*/

        private string[] vendedor;
        private int[] ventas;

        public void cargarDatos()
        {
            vendedor = new string[5];
            ventas = new int[5];

            string linea;

            for (int i = 0; i < vendedor.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del vendedor: ");
                vendedor[i] = Console.ReadLine();

                Console.WriteLine("ingrese el total de ventas del vendedor: " + vendedor[i]);
                linea = Console.ReadLine();
                ventas[i] = int.Parse(linea);
            }
        }

        public void ordenarMayormenor()
        {
            string nombre;
            int venta;

            for (int i = 0; i < ventas.Length; i++)
            {
                for (int m = 0; m < ventas.Length - 1; m++)
                {
                    if (ventas[m] < ventas[m + 1])
                    {
                        venta = ventas[m];
                        ventas[m] = ventas[m + 1];
                        ventas[m + 1] = venta;

                        nombre = vendedor[m];
                        vendedor[m] = vendedor[m + 1];
                        vendedor[m + 1] = nombre;
                    }
                }
            }
        }

        public void mostrarDatos()
        {
            Console.WriteLine("lista ordenada de mayor a menor:");

            for (int i = 0; i < vendedor.Length; i++)
            {
                Console.WriteLine(vendedor[i] + " - $" + ventas[i]);
            }

            Console.WriteLine("el vendedor que menos vendio fue: ");
            Console.WriteLine(vendedor[vendedor.Length - 1] + " - $" + ventas[ventas.Length - 1]);
        }

        static void Main(string[] args)
        {
            empresa empleado = new empresa();
            empleado.cargarDatos();
            empleado.ordenarMayormenor();
            empleado.mostrarDatos();
            Console.ReadKey();
        }
    }
}