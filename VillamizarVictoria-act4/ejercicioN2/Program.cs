using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)
            int i = 1;
            while (i < 26)
            {
                Console.WriteLine(11 * i);
                i++;
            }
            Console.ReadKey();

            
        }
    }
}
