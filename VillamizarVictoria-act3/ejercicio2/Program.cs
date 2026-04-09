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
            //2. Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.

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

            if (num1 == num2 && num2 == num3)
            {
                resultado = (num1 + num2) * num3;
                Console.WriteLine("resultado suma :" + num1 + num2);
                Console.WriteLine("resultado: " + resultado);
            }
            Console.ReadKey();
        }
    }
}
