using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class cargarNelementos
    {
        /*1. Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
del vector.*/
        private int[] vector;

        public void cargarDatos()
        {
            vector = new int[10];

            for (int m = 0; m < 10; m++)
            {
                Console.WriteLine("ingrese elemento");
                string linea = Console.ReadLine();
                vector[m] = int.Parse(linea);

            }
        }
        public void imprimirMenor()
        {
            int min = vector[0];
            int cont = 0;
            for (int m = 0; m < 10; m++)
            {
                if (vector[m] < min)
                {
                    min = vector[m];
                }
                else if (min == vector[m])
                {
                    cont++;
                }
            }
            if (cont == vector.Length)
            {
                Console.WriteLine("el numero minimo se repite");
            }
            else
            {
                Console.WriteLine("el numero mas minimo es : " + min);
            }
        }

                static void Main(string[] args)
                {
                    cargarNelementos type = new cargarNelementos();
                    type.cargarDatos();
                    type.imprimirMenor();

                }
            }
        }
    
