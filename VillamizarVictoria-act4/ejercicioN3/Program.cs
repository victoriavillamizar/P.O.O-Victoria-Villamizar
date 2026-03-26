using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            //ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            //valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int suma, total;
            total = 0;
            string linea;

            do
            {
                Console.Write("ingrese un numero ");
                linea = Console.ReadLine();
                suma= int.Parse(linea);

                if (suma != 9999)
                {
                    total = total + suma;
                }
            } while (suma != 9999);
                Console.WriteLine("total de la suma" + total);
                if (total == 0)
                {
                    Console.WriteLine("el valor es 0");
                }
                else
                {
                    if (total > 0)
                    {
                        Console.WriteLine("el valor es mayor a 0");
                    }
                    else
                    {
                        Console.WriteLine("el valor es menor 0");
                    }

                }
                Console.ReadKey();
            
            
        }
    }
}
