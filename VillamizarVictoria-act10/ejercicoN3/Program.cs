using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicoN3
{
    class matrizz
    {
        /*3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
        etc.)*/

        private int[,] matriz;
        private int filas;
        private int columnas;

        public void cargarMatriz()
        {
            string linea;

            Console.WriteLine("ingrese cantidad de filas: ");
            linea = Console.ReadLine();
            filas = int.Parse(linea);

            Console.WriteLine("ingrese cantidad de columnas: ");
            linea = Console.ReadLine();
            columnas = int.Parse(linea);

            matriz = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.WriteLine("ingrese valor para fila " + f + " columna " + c);
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void mostrarVertices()
        {
            Console.WriteLine("valores de los vertices:");

            Console.WriteLine("superior izquierdo: " + matriz[0, 0]);
            Console.WriteLine("superior derecho: " + matriz[0, columnas - 1]);
            Console.WriteLine("inferior izquierdo: " + matriz[filas - 1, 0]);
            Console.WriteLine("inferior derecho: " + matriz[filas - 1, columnas - 1]);
        }

        static void Main(string[] args)
        {
            matrizz matri = new matrizz();
            matri.cargarMatriz();
            matri.mostrarVertices();
            Console.ReadKey();
        }
    }
}