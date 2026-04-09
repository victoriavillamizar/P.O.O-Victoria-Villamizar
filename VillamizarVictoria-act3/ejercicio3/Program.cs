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
            //3. Se ingresan por teclado tres números, si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez"
            int num1, num2, num3, resultado;
            string linea;

            Console.Write("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese el segundo numero ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);


            Console.Write("ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.WriteLine("todos los números son menores a diez");
            }

            Console.ReadKey();
        }
    }
}

