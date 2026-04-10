using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1

{
    internal class Program
    {
        //1. Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro).*//
        static void Main(string[] args)
        {
            int num1, resultado;
            string linea;

            Console.Write("ingrese el lado del cubo: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            resultado = num1 * 4;
            Console.WriteLine("perimetro del cubo" + resultado);

            Console.ReadKey();

        }
    }
}
