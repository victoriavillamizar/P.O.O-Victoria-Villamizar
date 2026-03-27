using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            // muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta es 39.

            int num,producto, i;
            string linea;

            Console.Write("ingrese un valor entre 1 al 10: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            if (num < 10 && num >1)
            {
                for (i = 1; i< 14; i++) {
                    producto = num * i;
                    Console.WriteLine(producto);


                }
                Console.ReadKey();
            }

        }
    }
}
