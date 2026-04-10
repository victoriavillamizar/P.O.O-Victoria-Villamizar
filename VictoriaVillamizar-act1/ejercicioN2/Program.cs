using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*2. Escribir un programa en el cual se ingresen cuatro números, calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto.*//
            int num1,num2,num3,num4,resul1,resul2;
            string linea;

            Console.Write("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.Write("ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            Console.Write("ingrese el cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            resul1 = num1 + num2;
            Console.WriteLine("la suma es:" + resul1);

            resul2 = num3 * num4;
            Console.WriteLine("la suma es:" + resul2);


            Console.ReadKey();

        }
    }
}
