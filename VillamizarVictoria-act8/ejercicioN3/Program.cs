using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
        class Vectores
        {
            /*3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
             (el orden lo pueden elegir ustedes).*/

            private int[] vector;

        public void cargarvalores()
        {
            string linea;
            vector = new int[10];
            Console.WriteLine(" de cuantos elementos va a ser el vector: ");
            linea = Console.ReadLine();
            vector = new int[int.Parse(linea)];


            Console.WriteLine("ingrese los valores del vector: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }

        }

        public void ordenar()
        {
            int ordenar;

            Console.WriteLine("elementos ordenados: ");
            for (int i = 0; i < vector.Length; i++)
            {
                for (int m = 0; m < vector.Length - 1 - i; m++)
                {
                    if (vector[m] > vector[m + 1])
                    {
                        ordenar = vector[m];
                        vector[m] = vector[m + 1];
                        vector[m + 1] = ordenar;
                    }
                }
            }
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
            static void Main(string[] args)
            {
                Vectores vector= new Vectores();
                vector.cargarvalores();
                vector.ordenar();
                Console.ReadKey();
            }
        }
    }