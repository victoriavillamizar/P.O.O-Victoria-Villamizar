using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class suma
    {
        /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
        elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
        tercer vector del mismo tamaño. Sumar componente a componente.*/

        private int[] numeros1;
        private int[] numeros2;
        private int[] numeros3;

        public void ingresarnumeros()
        {
            numeros1 = new int[4];
            numeros2 = new int[4];
            numeros3 = new int[4];

            for (int m = 0; m < numeros1.Length; m++)
            {
                Console.Write("ingrese numeros en el primer vector: ");
                string linea;
                linea = Console.ReadLine();
                numeros1[m] = int.Parse(linea);

            }
            for (int m = 0; m < numeros2.Length; m++)
            {
                Console.Write("ingrese numeros en el segundo vector: ");
                string linea;
                linea = Console.ReadLine();
                numeros2[m] = int.Parse(linea);

            }
        }
        public void sumaVectores()
        {

            for (int m = 0; m < 4; m++)
            {
                numeros3[m] = numeros2[m] + numeros1[m];

                Console.WriteLine("la suma total de todos los numeros es: " + numeros3[m]);

            }
        }
        static void Main(string[] args)
        {

            suma suma = new suma();
            suma.ingresarnumeros();
            suma.sumaVectores();
            Console.ReadKey();
        }
    }
}
