using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    internal class Program
    {
        //*4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.*//
        static void Main(string[] args)
        {
            int precio, cantproduct, total;
            string linea;

            Console.Write("ingrese precio");
            linea = Console.ReadLine();
            precio = int.Parse(linea);

            Console.Write("ingrese cantidad llevada");
            linea = Console.ReadLine();
            cantproduct = int.Parse(linea);

            total = precio * cantproduct;
            Console.WriteLine("total precio a pagar:" + total);

            Console.ReadKey();

        }
    }
}
