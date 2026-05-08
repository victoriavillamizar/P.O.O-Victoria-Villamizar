using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class matrices
    {
        /*2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
        primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
        (crearla sin la intervención del operador)
        Realizar la carga por teclado e imprimir posteriormente.*/
        private int[][] matri;
        public void cargarmatrices()
        {
            matri = new int[5][];

            string linea;

            // estas 4 primeras las dcido yo
            for (int f = 0; f < 4; f++)
            {
                Console.WriteLine("ingrese la cantidad de columnas para la fila " + f);
                linea = Console.ReadLine();

                int columnas = int.Parse(linea);

                matri[f] = new int[columnas];

                for (int c = 0; c < matri[f].Length; c++)
                {
                    Console.WriteLine("ingrese el valor para fila " + f + " columna " + c);

                    linea = Console.ReadLine();

                    matri[f][c] = int.Parse(linea);
                }
            }

            // y esta no
            matri[4] = new int[5];

            for (int c = 0; c < matri[4].Length; c++)
            {
                Console.WriteLine("ingrese el valor para fila 4 columna " + c);

                linea = Console.ReadLine();

                matri[4][c] = int.Parse(linea);
            }
        }
        public void mostrarMatriz()
        {
            Console.WriteLine("mostrar matriz: ");

            for (int f = 0; f < matri.Length; f++)
            {
                for (int c = 0; c < matri[f].Length; c++)
                {
                    Console.Write(matri[f][c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            matrices matrices = new matrices();
            matrices.cargarmatrices();
            matrices.mostrarMatriz();
            Console.ReadKey();
        }
    }
}
