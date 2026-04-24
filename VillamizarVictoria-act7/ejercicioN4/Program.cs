using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    class vectores
    {
        /*Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
ordenado de menor a mayor y de mayor a menor.*/
        private int[] elementos;

        public void cargarelementos()
        {
            elementos = new int[10];
            for (int m = 0; m < 10; m++)
            {
                Console.Write("ingrese los elementos: ");
                string linea;
                linea = Console.ReadLine();
                elementos[m] = int.Parse(linea);
            }
        }
        public void menorMayoryMayoramenor()
        {
            bool menorMayor = true;
            bool mayorMenor = true;

            for (int m = 0; m < 9; m++)
            {
                if (elementos[m] > elementos[m + 1])
                {
                    menorMayor = false;
                }
            }

            for (int m = 0; m < 9; m++)
            {
                if (elementos[m] < elementos[m + 1])
                {
                    mayorMenor = false;
                }
            }
            if (menorMayor == true)
            {
                Console.WriteLine("los elementos estan ordenados de menor a mayor");
            }
            else if (mayorMenor == true)
            {
                Console.WriteLine("los elemenstos estan ordenados de mayor a menor");
            }

        }
        static void Main(string[] args)
        {
            vectores vectores = new vectores();
            vectores.cargarelementos();
            vectores.menorMayoryMayoramenor();
            Console.ReadKey();
        }
    }
}
