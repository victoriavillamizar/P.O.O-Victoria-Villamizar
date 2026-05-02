using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
   class matrizz
    {
        /*2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
primer fila con la segunda. Imprimir luego la matriz.*/
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

        public void intercambiarFilas()
        {
            int var;

            for (int c = 0; c < columnas; c++)
            {
                var = matriz[0, c];
                matriz[0, c] = matriz[1, c];
                matriz[1, c] = var;
            }
        }

        public void mostrarMatriz()
        {
            Console.WriteLine("matriz:");

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            matrizz matri = new matrizz();
            matri.cargarMatriz();
            matri.intercambiarFilas();
            matri.mostrarMatriz();
            Console.ReadKey();
        }
    }
}