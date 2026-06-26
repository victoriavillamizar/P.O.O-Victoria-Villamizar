using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class Persona{

        /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
        edad (definir las propiedades para poder acceder a dichos atributos). Definir
        un método para imprimirlos. 
        Plantear una segunda clase Empleado que
        herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
        método para imprimir su sueldo. Definir un objeto de la clase Persona y
        llamar a sus métodos y propiedades. También crear un objeto de la clase
        Empleado y llamar a sus métodos y propiedades.*/

        protected string nombre;
        protected int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public void imprimir()
        {
            Console.WriteLine(nombre + " tiene " + edad + " años");

        }
        public class Empleado : Persona
        {
            private int sueldo;

            public int Sueldo
            {
                set
                {
                    sueldo = value;
                }
                get
                {
                    return sueldo;
                }
            }
            public void imprimirsueldo()
            {
                Console.WriteLine(nombre +" tiene " + edad + " años" + " y tiene un sueldo de: " + sueldo);

            }
        }
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "maximo";
            persona1.Edad = 16;
            persona1.imprimir();

            Empleado empleado1 = new Empleado();
            empleado1.Nombre = "victoria";
            empleado1.Edad = 17;
            empleado1.Sueldo = 6767;
            empleado1.imprimirsueldo();
            Console.ReadKey();
        }
    }
}
