using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class paises
    {
        /*2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
algoritmo de ordenamiento alfabético.*/
        private string[] nombrePaises;

        public void algoritmo()
        {
            string letra;
            nombrePaises = new string [] { "Venezuela","Chile", "Argentina", "Japon", "Peru" };

            for (int i = 0; i < 5; i++)
            {
                for (int m = 0; m < nombrePaises.Length - 1 - i; m++)
                {
                    if (nombrePaises[m].CompareTo(nombrePaises[m + 1]) > 0)
                    {
                        letra = nombrePaises[m];
                        nombrePaises[m] = nombrePaises[m + 1];
                        nombrePaises[m + 1] = letra;
                    }
                }
            }
            for (int i = 0; i < nombrePaises.Length; i++)
            { 
                Console.WriteLine(nombrePaises[i]);

            }
        }

        static void Main(string[] args)
        {
            paises paises = new paises();
            paises.algoritmo();
            Console.ReadKey();

        }
    }
}