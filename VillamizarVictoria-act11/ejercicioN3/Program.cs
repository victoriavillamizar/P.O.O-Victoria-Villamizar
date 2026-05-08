using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class inasistencias
    {
        /*3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
        empresa.
        Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
        irregular para cargar los días que han faltado cada empleado (cargar el número de día que
        faltó)
        Cada fila de la matriz representa los días de cada empleado.
        a. Mostrar los empleados con la cantidad de inasistencias.
        b. Cuál empleado faltó menos días.*/

        private string[] empleados;
        private int[][] faltas;

            public void cargarDatos()
            {
                empleados = new string[3];
                faltas = new int[3][];

                string linea;
                for (int f = 0; f < 3; f++)
                {
                    Console.WriteLine("ingrese el nombre del empleado: ");
                    empleados[f] = Console.ReadLine();

                    Console.WriteLine("ingrese cuantas faltas tiene: " + empleados[f]);
                    linea = Console.ReadLine();

                    int cantidad = int.Parse(linea);

                    faltas[f] = new int[cantidad];

                    for (int c = 0; c < faltas[f].Length; c++)
                    {
                        Console.WriteLine("ingrese numero del dia en el que falto: ");
                        linea = Console.ReadLine();

                        faltas[f][c] = int.Parse(linea);
                    }
                }
            }

            public void mostrarfaltas()
            {
                Console.WriteLine("cantidad de inasistencias de los empleados: ");

                for (int f = 0; f < 3; f++)
                {
                    Console.WriteLine(empleados[f] + " falto " + faltas[f].Length + " dias");
                }
            }

            public void empleadoMenosfaltas()
            {
                int menor = faltas[0].Length;
                string empleMenos = empleados[0];

                for (int f = 1; f < 3; f++)
                {
                    if (faltas[f].Length < menor)
                    {
                        menor = faltas[f].Length;
                        empleMenos = empleados[f];
                    }
                }

                Console.WriteLine("el empleado que tuvo menos faltas fue: " + empleMenos);
            }

            static void Main(string[] args)
            {
                inasistencias faltas = new inasistencias();
                faltas.cargarDatos();
                faltas.mostrarfaltas();
                faltas.empleadoMenosfaltas();
                Console.ReadKey();
            }
        }
    }