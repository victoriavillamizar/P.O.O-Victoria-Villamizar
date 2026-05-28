using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    class alumno
    {
        /*4. Plantear una clase Alumno que tenga los atributos privados: nombre y un
        vector de 4 notas. Definir un constructor que solicite el ingreso del nombre del
        alumno y sus 4 calificaciones.
        Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
        Alumno.
        Agregar los siguientes métodos:
        a) Un método que imprima el nombre de cada alumno y su promedio.
        b) Un método que muestre el nombre del alumno con el promedio más
        alto.
        c) Un método que indique qué alumnos tienen al menos una nota
        desaprobada (nota menor a 6)*/
        private string nombre;
        private int[] notas;

        public alumno()
        {
            notas = new int[4];

            Console.Write("ingrese el nombre del alumno: ");
            nombre = Console.ReadLine();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("ingrese la nota: " + (i + 1) + ": ");
                string linea = Console.ReadLine();
                notas[i] = int.Parse(linea);
            }
        }

        public float promedio()
        {
            int suma = 0;

            for (int i = 0; i < 4; i++)
            {
                suma = suma + notas[i];
            }

            float promedio = suma / 4;
            return promedio;
        }

        public string retornarNombre()
        {
            return nombre;
        }

        public bool desaprobado()
        {
            for (int i = 0; i < 4; i++)
            {
                if (notas[i] < 6)
                {
                    return true;
                }
            }

            return false;
        }
    }

    class curso
    {
        private alumno[] alumnos;

        public curso()
        {
            alumnos = new alumno[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("alumno " + (i + 1));
                alumnos[i] = new alumno();
            }
        }

        public void imprimirPromedios()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(alumnos[i].retornarNombre() + " tiene promedio: " + alumnos[i].promedio());
            }
        }

        public void mejorPromedio()
        {
            float mayor = alumnos[0].promedio();
            string nombre = alumnos[0].retornarNombre();

            for (int i = 1; i < 3; i++)
            {
                if (alumnos[i].promedio() > mayor)
                {
                    mayor = alumnos[i].promedio();
                    nombre = alumnos[i].retornarNombre();
                }
            }

            Console.WriteLine("el alumno con el mejor promedio es: " + nombre);
        }

        public void alumnosDesaprobados()
        {
            Console.WriteLine("alumnos que desaprobaron:");

            for (int i = 0; i < 3; i++)
            {
                if (alumnos[i].desaprobado())
                {
                    Console.WriteLine(alumnos[i].retornarNombre());
                }
            }
        }

        static void Main(string[] args)
        {
            curso curso1 = new curso();

            curso1.imprimirPromedios();
            curso1.mejorPromedio();
            curso1.alumnosDesaprobados();

            Console.ReadKey();
        }
    }
}