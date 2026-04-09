using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    class operaciones
    {
        //Implementar la clase operaciones. Se deben cargar dos valores enteros,
        // calcular su suma, resta, multiplicación y división, cada una en un método, imprimir dichos resultados.

        private string linea;
        private int num1,num2,suma,resta,multiplicacion,division;

        public void cargarvalores()
        {
            Console.Write("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.Write("ingrese el sueldo segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.ReadKey();
        }
        public void Suma()
        {
            suma = num1 + num2;
        }
        public void Resta()
        {
            resta = num1 - num2;
        }
        public void Multiplicacion()
        {
            multiplicacion = num1 * num2;
        }
        public void Division()
        {
            division = num1 / num2;
        }
        public void mostrarResultados(){
            Console.WriteLine("la suma de los numeros es:" + suma);
            Console.WriteLine("la resta de los numeros es: "+ resta);
            Console.WriteLine("la multiplicacion de los numeros es: "+multiplicacion);
            Console.WriteLine("la division de los numeros es: "+division);


        }
        static void Main(string[] args)
        {
            operaciones operaciones= new operaciones();
            operaciones.cargarvalores();
            operaciones.Suma();
            operaciones.Resta();
            operaciones.Multiplicacion();
            operaciones.Division();
            operaciones.mostrarResultados();

            Console.ReadKey();
        }
    }
}
