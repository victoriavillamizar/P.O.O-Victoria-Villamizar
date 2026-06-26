using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    /*4.Armar tres clases: Animal, Mamífero y Perro.
   La clase Animal debe tener un atributo especie.
   La clase Mamífero, que hereda de Animal, debe tener un atributo
   tipoAlimentacion.
   La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
   Cada clase debe tener un constructor que reciba los datos correspondientes
   y los imprima indicando a qué clase pertenecen.Los datos deben ser
   asignados previamente
   Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
   constructores.*/
    class Animal
    {

        protected string especie;
        public string Especie
        {
            get { return especie; }
            set { especie = value; }
        }
        public Animal()
        {
            Console.WriteLine("clase animal tiene como datos Especie");
        }
    }

    class Mamifero : Animal
    {
        protected string tipoAlimentacion;
        public string TipoAlimentacion
        {
            get { return tipoAlimentacion; }
            set { tipoAlimentacion = value; }
        }
        public Mamifero()
        {
            Console.WriteLine("clase Mamifero tiene como datos Tipo de Alimentacion ");
        }
    }


    class Perro : Mamifero {

        protected string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Perro(string especiee, string tipoAlimentacionn, string nombree)
        {
            especie = especiee;
            tipoAlimentacion = tipoAlimentacionn;
            nombre = nombree;

            Console.WriteLine("clase perro tiene como datos Nombre " );
        }

            static void Main(string[] args)
            {
                Perro miPerro = new Perro("canino", "carnivoro", "firulais");
                Console.WriteLine();
                Console.WriteLine("nombre: " + miPerro.Nombre);
                Console.WriteLine("especie: " + miPerro.Especie);
                Console.WriteLine("tipo de alimentacion: " + miPerro.TipoAlimentacion);

                Console.ReadKey();
            }
        }
    }


