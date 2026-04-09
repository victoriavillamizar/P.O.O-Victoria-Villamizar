using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
            int dia, mes;
            string linea;

            Console.Write("ingrese el dia: ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);

            Console.Write("ingrese el mes: ");
            linea = Console.ReadLine();
            mes = int.Parse(linea);

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("es navidad");
            }
            else
            {
                Console.WriteLine("no es Navidad");
            }
            Console.ReadKey();
        }
    }
}

