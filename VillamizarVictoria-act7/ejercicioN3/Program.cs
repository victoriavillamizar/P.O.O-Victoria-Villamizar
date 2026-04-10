using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class videojuego
    {
        /*Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
        un videojuego. El programa debe:
         Mostrar la puntuación más alta y la más baja.
         Calcular el promedio de puntuación.
         Contar cuántas veces superó los 500 puntos.*/

        private int[] puntuaciones;
        private float promedio=0;


        public void ingresepuntuaciones()
        {
            puntuaciones = new int[6];
            for (int m= 0; m< 6; m++)
            {
                Console.Write("ingrese las puntuaciones: ");
                string linea;
                linea = Console.ReadLine();
                puntuaciones[m] = int.Parse(linea);
            }
        }
        public void estadiscticas()
        {
            int puntuacionAlta = 0;
            
            for (int m = 0; m < puntuaciones.Length; m++)
            {
                if (puntuacionAlta < puntuaciones[m])
                {
                    puntuacionAlta = puntuaciones[m];
                }

            }

            int puntuacionBaja = puntuaciones[0];
            for (int m = 0; m < puntuaciones.Length; m++)
            {
                if (puntuacionBaja > puntuaciones[m])
                {
                    puntuacionBaja = puntuaciones[m];
                }
            }
            Console.WriteLine("la puntuacion mas alta es: " + puntuacionAlta);
            Console.WriteLine("la puntuacion mas baja es: " + puntuacionBaja);
        }
        public void Promedio()
        {
            int suma = 0;
            for (int m = 0; m < puntuaciones.Length; m++)
            {
                suma = suma + puntuaciones[m];

            }
            promedio = suma / 6;
            Console.WriteLine("el promedio de la puntuacion es : " + promedio);
        }

        public void superolos500()
        {
            int mayora500 = 0;
            for (int m = 0; m < 6; m++)
            {
                if (puntuaciones[m] > 500)
                {
                    mayora500++;
                }
            }
            Console.WriteLine("las veces que se supero los 500 puntos fueron: " + mayora500);
        }
        

            static void Main(string[] args)
        {
            videojuego videojuego = new videojuego();
            videojuego.ingresepuntuaciones();
            videojuego.estadiscticas();
            videojuego.Promedio();
            videojuego.superolos500();
            Console.ReadKey();
        }
    }
}
