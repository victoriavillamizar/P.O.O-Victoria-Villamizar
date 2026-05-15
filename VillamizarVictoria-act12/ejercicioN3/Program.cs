using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class COMIDAA
    {
        /*3. Academia de Gastronomía: Recetario Dinámico
        Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
        una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
        ● Definir un vector para los nombres de los alumnos.
        ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
        presentado.
        ● Métodos:
        1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
        de cada alumno.
        2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
        3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
        4. Calcular el puntaje promedio de cada alumno e informar si está &quot;Aprobado&quot;
        (promedio &gt;= 70) o &quot;Reprobado&quot;.
        5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
        valor máximo de la matriz).*/

            private string[] nombres;
            private int[][] puntajes;

            public void cargarDatos()
            {
                string linea;
                int[] platos = { 2, 4, 3 };

                nombres = new string[3];
                puntajes = new int[3][];

                for (int f = 0; f < nombres.Length; f++)
                {
                    Console.WriteLine("ingrese el nombre del alumno " + (f + 1) + ": ");
                    nombres[f] = Console.ReadLine();

                    puntajes[f] = new int[platos[f]];

                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        int nota;

                        do
                        {
                            Console.WriteLine("ingrese el puntaje del plato " + (c + 1) + ": ");
                            linea = Console.ReadLine();
                            nota = int.Parse(linea);

                        } while (nota < 0 || nota > 100);

                        puntajes[f][c] = nota;
                    }
                }
            }

            public void mostrarDatos()
            {
                Console.WriteLine("lista de los alumnos y sus puntajes: ");

                for (int f = 0; f < nombres.Length; f++)
                {
                    Console.WriteLine("alumno: " + nombres[f]);

                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        Console.WriteLine("plato " + (c + 1) + ": " + puntajes[f][c]);
                    }
                }
            }

            public void calcularPromedio()
            {
                Console.WriteLine("promedios:");

                for (int f = 0; f < nombres.Length; f++)
                {
                    int suma = 0;

                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        suma += puntajes[f][c];
                    }

                    double promedio = (double)suma / puntajes[f].Length;

                    if (promedio >= 70)
                    {
                        Console.WriteLine(nombres[f] + " promedio: " + promedio + " esta aprobado");
                    }
                    else
                    {
                        Console.WriteLine(nombres[f] + " promedio: " + promedio + " esta reprobado");
                    }
                }
            }

            public void mayorPuntaje()
            {
                int mayor = puntajes[0][0];
                string mejorAlumno = nombres[0];

                for (int f = 0; f < nombres.Length; f++)
                {
                    for (int c = 0; c < puntajes[f].Length; c++)
                    {
                        if (puntajes[f][c] > mayor)
                        {
                            mayor = puntajes[f][c];
                            mejorAlumno = nombres[f];
                        }
                    }
                }

                Console.WriteLine("el puntaje más alto fue: " + mayor);
                Console.WriteLine("lo obtuvo: " + mejorAlumno);
            }

            static void Main(string[] args)
            {
                COMIDAA comida = new COMIDAA();
                comida.cargarDatos();
                comida.mostrarDatos();
                comida.calcularPromedio();
                comida.mayorPuntaje();

                Console.ReadKey();
            }
        }
    }
