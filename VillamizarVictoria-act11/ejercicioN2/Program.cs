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

            matri[0] = new int[1];
            matri[1] = new int[2];
            matri[2] = new int[3];
            matri[3] = new int[4];

            string linea;

            for (int f = 0; f < matri.Length; f++)
            {
                for (int c = 0; c < matri[f].Length; c++)
                {
                    Console.WriteLine("Ingrese valor para fila " + f + " columna " + c);
                    linea = Console.ReadLine();
                    matri[f][c] = int.Parse(linea);
                }
            }
        }
            public void mostrarMatriz()
        {
            Console.WriteLine("Matriz cargada:");

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
