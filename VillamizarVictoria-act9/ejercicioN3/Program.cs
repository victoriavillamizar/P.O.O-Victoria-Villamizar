using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class atletas
    {

        /*3. Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
        carrera de 100 metros. El programa debe cargar los datos en dos vectores
        paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
        atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
        promedio.*/
        private string[] nombre;
        private int[] tiempo;

        public void cargarDatos()
        {
            nombre = new string[5];
            tiempo = new int[5];

            string linea;

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del atleta: ");
                nombre[i] = Console.ReadLine();

                Console.WriteLine("ingrese el tiempo de " + nombre[i] + " en segundos: ");
                linea = Console.ReadLine();
                tiempo[i] = int.Parse(linea);
            }
        }

        public void calcularDatos()
        {
            int suma = 0;

            for (int i = 0; i < tiempo.Length; i++)
            {
                suma = suma + tiempo[i];
            }

            double promedio = suma / 5.0;

            Console.WriteLine("el promedio de tiempos es: " + promedio);

            int mejor = tiempo[0];
            int peor = tiempo[0];
            string nomMejor = nombre[0];
            string nomPeor = nombre[0];

            for (int i = 0; i < tiempo.Length; i++)
            {
                if (tiempo[i] < mejor)
                {
                    mejor = tiempo[i];
                    nomMejor = nombre[i];
                }

                if (tiempo[i] > peor)
                {
                    peor = tiempo[i];
                    nomPeor = nombre[i];
                }
            }

            Console.WriteLine("el atleta con mejor tiempo es: " + nomMejor + " - " + mejor + " segundos");
            Console.WriteLine("el atleta con peor tiempo es: " + nomPeor + " - " + peor + " segundos");

            Console.WriteLine("atletas que superaron el promedio:");

            for (int i = 0; i < tiempo.Length; i++)
            {
                if (tiempo[i] < promedio)
                {
                    Console.WriteLine(nombre[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            atletas carrera = new atletas();
            carrera.cargarDatos();
            carrera.calcularDatos();
            Console.ReadKey();
        }
    }
}