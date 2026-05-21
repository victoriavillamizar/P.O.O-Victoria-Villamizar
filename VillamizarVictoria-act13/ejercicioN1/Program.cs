using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class empleado 
    {
        /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. En el constructor cargar los atributos y luego en otro
        método imprimir sus datos y por último uno que imprima un mensaje si debe
        pagar impuestos (si el sueldo supera a 3000)*/
        private string nombre;
        private int sueldo;

        public empleado()
        {
            Console.Write("ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese el sueldo del empleado: ");
            string linea = Console.ReadLine();
            sueldo = int.Parse(linea);

        }
        public void imprimir()
        {
            Console.WriteLine("nombre del empleado:" + nombre);
            Console.WriteLine("sueldo del empleado:" + sueldo);
        }
        public void impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("el empleado " + nombre + " debe pagar impuestos");
            }
        }

        static void Main(string[] args)
        {
            empleado empleado = new empleado();
            empleado.imprimir();
            empleado.impuestos();
            Console.ReadKey();
        }
    }
}
