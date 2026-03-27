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
            //Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //a) La cantidad de valores ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares.

            int num, contnega, contposi, cont_mult_15, suma_pares;
            string linea;
            contnega = 0;
            contposi = 0;
            cont_mult_15 = 0;
            suma_pares = 0;

            for(int i =0; i<10; i++)
            {
                Console.Write("ingrese 10 valores: ");
                linea = Console.ReadLine();
                num = int.Parse(linea);


                if (num < 0)
                {
                    contnega++;
                }
                if(num>0)
                {
                    contposi++;
                }
                if(num % 15 == 0)
                {
                    cont_mult_15++;
                }
                if (num % 2 == 0)
                {
                    suma_pares = num + suma_pares;
                }
            }
            
            Console.WriteLine("la cantidad de valores negativos son: " + contnega);
            Console.WriteLine("la cantidad de valores positivos son: " + contposi);
            Console.WriteLine("la cantidad de multiplos de 15 son son: " + cont_mult_15);
            Console.WriteLine("el valor acumulado de los numeros pares: " + suma_pares);


            Console.ReadKey();
        }
    }
}
