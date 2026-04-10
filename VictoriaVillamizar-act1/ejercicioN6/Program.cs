using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona, y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).*//

            double peso, altura, resultado;
            string linea;

            Console.Write("ingrese su peso en kg: ");
            linea = Console.ReadLine();
            peso= double.Parse(linea);

            Console.Write("ingrese su altura en metros: ");
            linea = Console.ReadLine();
            altura = double.Parse(linea);

            resultado = peso / (altura * altura);

            Console.WriteLine("su indice de masa corporal es de:" + resultado);

            Console.ReadKey();
        }
    }
}
