using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
     class Program
        {
            static void Main(string[] args)
            {
                Libro[] libros = new Libro[2];

                for (int i = 0; i < libros.Length; i++)
                {
                    libros[i] = new Libro();

                    Console.Write("titulo: ");
                    libros[i].Titulo = Console.ReadLine();

                    Console.Write("autor: ");
                    libros[i].Autor = Console.ReadLine();

                    Console.Write("paginas: ");
                    libros[i].Paginas = int.Parse(Console.ReadLine());
                }

                int mayor = 0;

                for (int i = 1; i < libros.Length; i++)
                {
                    if (libros[i].Paginas > libros[mayor].Paginas)
                        mayor = i;
                }

                Console.WriteLine();
                libros[0].Resumen();
                Console.WriteLine();
                libros[1].Resumen();

                Console.WriteLine();
                Console.WriteLine("libro mas extenso: "+ libros[mayor].Titulo);
            Console.ReadKey();
        }
        }
}