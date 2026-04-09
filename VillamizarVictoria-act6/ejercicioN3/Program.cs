using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    internal class empleado
    {
        //Confeccionar una clase que represente un empleado. Definir como atributos su
        //nombre y su sueldo.Confeccionar los métodos para la carga, otro para imprimir
        //sus datos y por último uno que imprima un mensaje si debe pagar impuestos
        //(si el sueldo supera a 3000).
        private string linea,nombre;
        private int  sueldo;

        public void cargarDatos()
        {
            Console.Write("ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
            Console.ReadKey();

        }
        public void imprimirDatos()
        {
            Console.WriteLine("el nombre del empleado es: " + nombre);

            Console.WriteLine("el sueldo del empleado es: " + sueldo);

        }
        public void sidebeimpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("el empleado debe de pagar impuestos");
            }


        }
            static void Main(string[] args)
            {
                empleado empleado = new empleado();
                empleado.cargarDatos();
                empleado.imprimirDatos();
                empleado.sidebeimpuestos();
                Console.ReadKey();
            }
        }
    }

