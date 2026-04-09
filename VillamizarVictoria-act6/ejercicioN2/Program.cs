using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class cuadrado 
    {
        //2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
        //métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
        private string linea;
        private int num1, Perimetro,Superficie;

        public void iniciar()
        {
            Console.Write("ingrese el valor de un lado del cadrado: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);


        Console.ReadKey();
        }
        public void perimetro()
        {
                Perimetro = num1 * 4;
                Console.WriteLine("el perimetro total del cuadrado es: " + Perimetro);

            }
        public void superficie()
        {
            Superficie = num1 * num1;
            Console.WriteLine("la superficie del cuadrado es: " + Superficie);

        }

        static void Main(string[] args)
        {
            cuadrado cuadrado = new cuadrado();
            cuadrado.iniciar();
            cuadrado.perimetro();
            cuadrado.superficie();
            Console.ReadKey();
        }
    }
}
