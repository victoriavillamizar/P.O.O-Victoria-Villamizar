using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
   class matrizz
    {
        /*1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.*/
        private int[,] matriz;

        public void cargarMatriz()
        {
            matriz = new int[2, 5];
            string linea;

            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.WriteLine("ingrese valor para fila " + f + " columna " + c);
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void mostrarMatriz()
        {
            Console.WriteLine("matriz ya cargada:");

            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
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
            matri.mostrarMatriz();
            Console.ReadKey();
        }
    }
}