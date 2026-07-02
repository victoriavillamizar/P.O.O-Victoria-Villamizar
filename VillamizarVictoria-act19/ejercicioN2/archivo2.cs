using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
   
       partial class Libro
        {
            public void Resumen()
            {
                Console.WriteLine("Título: " + Titulo);
                Console.WriteLine("Autor: " + Autor);

                if (Paginas < 100)
                    Console.WriteLine("Libro corto");
                else
                    Console.WriteLine("Libro largo");
            }
        }
    }

