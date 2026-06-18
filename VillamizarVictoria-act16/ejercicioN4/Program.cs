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
            get
            {
                return especie;
            }
            set
            {
                especie = value;
            }
        }
        public Animal(string especie)
        {
            this.especie = especie;
            Console.WriteLine($"su especie es: {this.especie}");
        }

        public class Mamifero : Animal
        {
            protected string tipoAlimentacion;
            public string TipoAlimentacion
            {
                get
                {
                    return tipoAlimentacion;
                }
                set
                {
                    tipoAlimentacion = value;
                }
            }
            public Mamifero(string especie, string tipoAlimentacion) : base(especie)
            {
                this.tipoAlimentacion = tipoAlimentacion;
                Console.WriteLine($"su tipo de alimentacion es: {this.tipoAlimentacion}");

            }
        }

        class Perro : Mamifero
        {

            protected string nombre;
            public string Nombre
            {
                get
                {
                    return nombre;
                }
                set
                {
                    nombre = value;
                }
            }

            public Perro(string especie, string tipoAlimentacion, string nombre) : base(especie, tipoAlimentacion)
            {
                this.nombre = nombre;
                Console.WriteLine($"el nombre es : {this.nombre}");
            }
        }
            static void Main(string[] args)
            {
                Perro miPerro = new Perro("canino", "carnivoro", "firulais");
                Console.WriteLine($"datos del animal: {miPerro.Nombre} es un {miPerro.Especie} y es {miPerro.TipoAlimentacion}.");
                Console.ReadKey();
            }
        }
    }
    

     

