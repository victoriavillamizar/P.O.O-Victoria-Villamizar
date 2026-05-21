using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
     class operaciones
    {
        /*2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
        constructor, calcular su suma, resta, multiplicación y división, cada una en un
        método, imprimir dichos resultados.*/
        private int num1;
        private int num2;
        private int suma;
        private int resta;
        private int multiplicacion;
        private int division;

        public operaciones()
        {
            num1 = 0; 
            num2=0;

            Console.Write("ingrese el primer numero: ");
            string linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese el segundo numero: ");
            linea = Console.ReadLine(); 
            num2 = int.Parse(linea);
        }
        public void sumar()
        {
            suma = num1 + num2;
        }
        public void restaa()
        {
            resta = num1 - num2;
        }
        public void multiplicacionn()
        {
            multiplicacion = num1 * num2;
        }
        public void divisionn()
        {
            division= num1 / num2;
        }
        public void imprimir()
        {
            Console.WriteLine("el valor de la suma es: " + suma);
            Console.WriteLine("el valor de la resta es: " + resta);
            Console.WriteLine("el valor de la multiplicacion es: " + multiplicacion);
            Console.WriteLine("el valor de la division es: " + division);

        }


        static void Main(string[] args)
        {
            operaciones operaciones = new operaciones();
            operaciones.sumar();
            operaciones.restaa();
            operaciones.multiplicacionn();
            operaciones.divisionn();
            operaciones.imprimir();
            Console.ReadKey();

        }
    }
}
