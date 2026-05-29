using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class atleta
    {
        /*3. Competencia de Atletismo
        Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera).
        Definir un constructor para ingresar ambos datos.
        Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
        Definir los siguientes métodos en la clase Carrera:
        Un constructor que cargue los datos de los 3 atletas de la carrera.
        Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
        Un método que calcule e imprima el tiempo promedio de la carrera.
        Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
        Un método que muestre a los atletas que superaron el promedio.
*/
        private string nombre;
        private double tiemposegundos;

        public atleta()
        {
            Console.Write("ingrese el nombre del atleta: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese el tiempo en segundos: ");
            string linea = Console.ReadLine();
            tiemposegundos = double.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("tiempo: " + tiemposegundos + " segundos");
        }

        public double retornarTiempo()
        {
            return tiemposegundos;
        }

        public string retornarNombre()
        {
            return nombre;
        }
    }

    class carrera
    {
        private atleta[] atletas;

        public carrera()
        {
            atletas = new atleta[3];

            for (int f = 0; f < atletas.Length; f++)
            {
                Console.WriteLine("carga del atleta " + (f + 1));

                atletas[f] = new atleta();
            }
        }

        public void imprimirAtletas()
        {
            Console.WriteLine("lista de los atletas: ");

            for (int f = 0; f < atletas.Length; f++)
            {
                atletas[f].imprimir();
            }
        }

        public void promedioCarrera()
        {
            double suma = 0;
            double promedio;

            for (int f = 0; f < atletas.Length; f++)
            {
                suma = suma + atletas[f].retornarTiempo();
            }

            promedio = suma / atletas.Length;

            Console.WriteLine("el tiempo promedio es: " + promedio);
        }

        public void ganadorCarrera()
        {
            atleta ganador = atletas[0];

            for (int f = 1; f < atletas.Length; f++)
            {
                if (atletas[f].retornarTiempo() < ganador.retornarTiempo())
                {
                    ganador = atletas[f];
                }
            }

            Console.WriteLine("el ganador de la carrera es: " +
                              ganador.retornarNombre());
        }

        public void superaronPromedio()
        {
            double suma = 0;
            double promedio;

            for (int f = 0; f < atletas.Length; f++)
            {
                suma = suma + atletas[f].retornarTiempo();
            }

            promedio = suma / atletas.Length;

            Console.WriteLine("atletas que superaron el promedio:");

            for (int f = 0; f < atletas.Length; f++)
            {
                if (atletas[f].retornarTiempo() > promedio)
                {
                    Console.WriteLine(atletas[f].retornarNombre());
                }
            }
        }

        static void Main(string[] args)
        {
            carrera carrera = new carrera();
            carrera.imprimirAtletas();
            carrera.promedioCarrera();
            carrera.ganadorCarrera();
            carrera.superaronPromedio();
            Console.ReadKey();
        }
    }
}