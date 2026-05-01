using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    class nombredepaises
    {
       /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        habitantes de este.Ordenar alfabéticamente e imprimir los resultados.Por último
        ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
        nuevamente.*/

        private string[] paisesNombre;
        private string[] paisesOrden;
        private int[] habitantes;

        public void cargaValores()
        {
            paisesNombre = new string[5];
            habitantes = new int[5];

            Console.WriteLine("ingrese el nombre de 5 paises");
            for (int i = 0; i < paisesNombre.Length; i++)
            {
                Console.Write("");
                paisesNombre[i] = Console.ReadLine(); ;
            }
            string linea;

            for (int i = 0; i < paisesNombre.Length; i++)
            {
                Console.WriteLine("ingrese los habitantes de " + paisesNombre[i]);
                Console.Write("");
                linea = Console.ReadLine();
                habitantes[i] = int.Parse(linea);
            }
        }

        public void ordenarAlfabeticamente()
        {
            paisesOrden = new string[5];
            string var;

            // copiar nombres
            for (int i = 0; i < paisesNombre.Length; i++)
            {
                paisesOrden[i] = paisesNombre[i];
            }

            // ordenar
            for (int i = 0; i < paisesOrden.Length; i++)
            {
                for (int m = 0; m < paisesOrden.Length - 1 - i; m++)
                {
                    if (paisesOrden[m].CompareTo(paisesOrden[m + 1]) > 0)
                    {
                        var = paisesOrden[m];
                        paisesOrden[m] = paisesOrden[m + 1];
                        paisesOrden[m + 1] = var;
                    }
                }
            }

            Console.WriteLine("Paises ordenados alfabeticamente:");

            for (int i = 0; i < paisesOrden.Length; i++)
            {
                Console.WriteLine(paisesOrden[i]);
            }
        }

        public void ordenarHabitantesMYMN()
        {
            int var1;
            string var2;
            for (int i = 0; i < paisesNombre.Length; i++)
            {
                for (int m = 0; m < habitantes.Length - 1 - i; m++)
                {
                    if (habitantes[m] < habitantes[m + 1])
                    {
                        var1 = habitantes[m];
                        habitantes[m] = habitantes[m + 1];
                        habitantes[m + 1] = var1;
                        var2 = paisesNombre[m];
                        paisesNombre[m] = paisesNombre[m + 1];  
                        paisesNombre[m + 1] = var2;
                    }
                }
            }

            Console.WriteLine("paises ordenados por habitantes");
            for (int i = 0; i < habitantes.Length; i++)
            {
                Console.WriteLine(paisesNombre[i] + ": " + habitantes[i]);
            }

        }


        static void Main(string[] args)
        {
            nombredepaises paises = new nombredepaises();
            paises.cargaValores();
            paises.ordenarAlfabeticamente();
            paises.ordenarHabitantesMYMN();
            Console.ReadKey();
        }
    }
}
