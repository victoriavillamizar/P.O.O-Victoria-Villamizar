using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class PersonaGimnasio
    {
        /*1. Personal de un Gimnasio (Herencia Simple y Propiedades)
        Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
        Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
        método para imprimir estos datos básicos.

        Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
        un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
        para imprimir todos los datos del profesor (incluyendo los heredados).
        En el programa principal (Main):
         Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
        llamar a su método de impresión.
         Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
        que puede acceder tanto a sus métodos propios como a los de la clase base.*/
        private string nombre;
        private int dni;

        public string Nombre {
            get { return nombre;}
            set { nombre = value;}
        }
        public int Dni
        {
            set { dni = value;}
            get { return dni;}
        }
        public void imprimir()
        {
            Console.WriteLine($"nombre: {nombre} dni: {dni}");
        }

        class Profesor : PersonaGimnasio
        {
            protected string especialidad;

            public string Especialidad
            {
                get { return especialidad; }
                set { especialidad = value; }
            }

            public void imprimirTodo()
            {
                Console.WriteLine($"nombre: {nombre} dni: {dni} especialidad en el gym: {especialidad}");
            }

        }

        static void Main(string[] args)
        {

            PersonaGimnasio persona1 = new PersonaGimnasio();
            persona1.nombre = "maximo";
            persona1.dni = 95912235;
            persona1.imprimir();

            Profesor profesor1 = new Profesor();
            profesor1.Especialidad = "pesas";
            profesor1.nombre= persona1.nombre;
            profesor1.dni= persona1.dni;
            profesor1.imprimirTodo();
            Console.ReadKey();
        }
    }
}
