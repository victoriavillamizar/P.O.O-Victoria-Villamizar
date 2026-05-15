using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class cine
    {
        /*2. Gestión de Complejo de Cine
        Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
        asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
        ● Definir una matriz irregular de 4 filas para representar los asientos.
        ● Métodos:
        1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
        intervención del operador).
        2. Crear un método de &quot;Venta de Entradas&quot; que permita cargar la edad del
        espectador en un asiento específico (fila y columna).
        3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
        en cada asiento.
        4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
        5. Informar cuál es el promedio de edad de los espectadores de todo el
        complejo.*/

            private int[][] salas;
            public void iniciarSalas()
            {
                salas = new int[4][];

                salas[0] = new int[10];
                salas[1] = new int[15];
                salas[2] = new int[8];
                salas[3] = new int[12];
            }

        public void ventaEntradas()
        {
            string linea;

            Console.WriteLine("ingrese cuantas entradas quiere comprar:");
            linea = Console.ReadLine();
            int cantidad = int.Parse(linea);

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("ingrese numero de sala (1 a 4):");
                linea = Console.ReadLine();
                int fila = int.Parse(linea) - 1;

                Console.WriteLine("ingrese numero de asiento:");
                linea = Console.ReadLine();
                int columna = int.Parse(linea);

                Console.WriteLine("ingrese edad del espectador:");
                linea = Console.ReadLine();
                int edad = int.Parse(linea);

                salas[fila][columna] = edad;
               }
              }

        public void mostrarSalas()
            {
                Console.WriteLine("mapa de la sala:");

                for (int f = 0; f < salas.Length; f++)
                {
                    Console.Write("sala " + (f + 1) + ": ");

                    for (int c = 0; c < salas[f].Length; c++)
                    {
                        Console.Write(salas[f][c] + " ");
                    }

                    Console.WriteLine();
                }
            }

            public void menoresSala()
            {
                for (int f = 0; f < salas.Length; f++)
                {
                    int menores = 0;

                    for (int c = 0; c < salas[f].Length; c++)
                    {
                        if (salas[f][c] < 18 && salas[f][c] > 0)
                        {
                            menores++;
                        }
                    }

                    Console.WriteLine("sala " + (f + 1) + " cantidad de menores: " + menores);
                }
            }

        public void promedio()
        {
            int suma = 0;
            int cantidad = 0;

            for (int f = 0; f < salas.Length; f++)
            {
                for (int c = 0; c < salas[f].Length; c++)
                {
                        suma = suma + salas[f][c];
                        cantidad++;
                    
                }
            }

            if (cantidad > 0)
            {
                double promedio;

                promedio = (double)suma / cantidad;

                Console.WriteLine("el promedio general es de: " + promedio);
            }
        }

            static void Main(string[] args)
            {
                cine cine = new cine();
                cine.iniciarSalas();
                cine.ventaEntradas();
                cine.mostrarSalas();
                cine.menoresSala();
                cine.promedio();
                Console.ReadKey();
            }
        }
    }