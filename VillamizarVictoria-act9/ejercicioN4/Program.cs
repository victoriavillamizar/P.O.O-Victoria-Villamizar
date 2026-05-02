using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
   class evaluacion
    {
        /*4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
        sus nombres y puntajes promedio obtenidos (de 1 a 10).
        Cargar sus datos en vectores paralelos, mostrar docente con calificación más
        alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
        calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
        desaprobaron (tomando como base que se aprueba con una nota mayor o igual
        a 6)*/

        private string[] docente;
        private int[] nota;

        public void cargarDatos()
        {
            docente = new string[6];
            nota = new int[6];

            string linea;

            for (int i = 0; i < docente.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del docente: ");
                docente[i] = Console.ReadLine();

                Console.WriteLine("ingrese la nota de " + docente[i]);
                linea = Console.ReadLine();
                nota[i] = int.Parse(linea);
            }
        }

        public void mostrarMayorMenor()
        {
            int mayor = nota[0];
            int menor = nota[0];
            string nomMayor = docente[0];
            string nomMenor = docente[0];

            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i] > mayor)
                {
                    mayor = nota[i];
                    nomMayor = docente[i];
                }

                if (nota[i] < menor)
                {
                    menor = nota[i];
                    nomMenor = docente[i];
                }
            }

            Console.WriteLine("el docente con la mayor nota fue: " + nomMayor + " - " + mayor);
            Console.WriteLine("el docente con la menor notafue : " + nomMenor + " - " + menor);
        }

        public void ordenarMayorMenor()
        {
            int notaa;
            string nombre;

            for (int i = 0; i < nota.Length; i++)
            {
                for (int j = 0; j < nota.Length - 1; j++)
                {
                    if (nota[j] < nota[j + 1])
                    {
                        notaa = nota[j];
                        nota[j] = nota[j + 1];
                        nota[j + 1] = notaa;

                        nombre = docente[j];
                        docente[j] = docente[j + 1];
                        docente[j + 1] = nombre;
                    }
                }
            }
        }

        public void mostrarOrdenados()
        {
            Console.WriteLine("lista ordenada de mayor a menor: ");

            for (int i = 0; i < docente.Length; i++)
            {
                Console.WriteLine(docente[i] + " - " + nota[i]);
            }
        }

        public void aprobadosDesaprobados()
        {
            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < nota.Length; i++)
            {
                if (nota[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            Console.WriteLine(" la cantidad de docentes aprobados : " + aprobados);
            Console.WriteLine("la cantidad de docentes desaprobados es : " + desaprobados);
        }

        static void Main(string[] args)
        {
            evaluacion docentes = new evaluacion();
            docentes.cargarDatos();
            docentes.mostrarMayorMenor();
            docentes.ordenarMayorMenor();
            docentes.mostrarOrdenados();
            docentes.aprobadosDesaprobados();
            Console.ReadKey();
        }
    }
}