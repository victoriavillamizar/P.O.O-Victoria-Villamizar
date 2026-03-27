using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se cuenta con la siguiente información:
            //● Las edades de 20 estudiantes del turno mañana.
            //● Las edades de 30 estudiantes del turno tarde.
            //● Las edades de 15 estudiantes del turno noche.
            //Las edades de cada estudiante deben ingresarse por teclado.
            //a) Obtener el promedio de las edades de cada turno(tres promedios)
            //b) Imprimir dichos promedios(promedio de cada turno)
            //c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            //promedio de edades menor.


            int valor, contador_ma, contador_tarde, contador_noche,promedio_ma,promedio_ta,promedio_no ;
            string linea;
            contador_ma = 0;
            contador_noche = 0;
            contador_tarde = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("ingrese las 20 edades de turno mañana: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                contador_ma = contador_ma+valor;
            }

            for (int i = 0; i < 30; i++) { 
                Console.Write("ingrese las 30 edades de turno tarde: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                contador_tarde = contador_noche + valor;

            }
            for (int i = 0; i < 30; i++)
            {
                Console.Write("ingrese las 15 edades de turno moche: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                contador_noche = contador_noche+ valor;
            }

            promedio_ma = contador_ma / 20;
            promedio_ta = contador_ma / 30;
            promedio_no = contador_ma / 15;

            Console.WriteLine("el promedio de turno mañana es " + promedio_ma);
            Console.WriteLine("el promedio de turno tarde es: " + promedio_ta);
            Console.WriteLine("el promedio de turno noche es: " + promedio_no);
            
            if( promedio_ma<promedio_ta && promedio_ma < promedio_no)
            {
                Console.WriteLine("la mañana tiene el menor promedio de todos");
            }
            else
            {
                if(promedio_ta<promedio_ma && promedio_ta < promedio_no)
                {
                    Console.WriteLine("la tarde tiene el menor promedio de todos");
                }
                else
                {
                    Console.WriteLine("la noche tiene menor promedio de todos");
                }
                Console.ReadKey();
            }






        }
        }
    }