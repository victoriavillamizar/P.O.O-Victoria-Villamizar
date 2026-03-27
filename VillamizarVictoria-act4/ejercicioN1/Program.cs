using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
            //realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos
            //cobran másde $300.Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.

            int empleados, sueldo, contador, sueldos_entre100_300, sueldos_mas_300, totalsueldos;
            string linea;

            contador = 0;
            totalsueldos = 0;
            sueldos_entre100_300 = 0;
            sueldos_mas_300 = 0;
            

            Console.Write("ingrese la cantidad de empleados");
            linea = Console.ReadLine();
            empleados = int.Parse(linea);


            while (empleados >contador) {
                Console.Write("ingrese cantidad de sueldo ");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);


                if (sueldo > 100 && sueldo < 300){
                    sueldos_entre100_300 = sueldos_entre100_300 + 1;

                }
                else{ if(sueldo > 300 && sueldo < 500)
                    sueldos_mas_300 = sueldos_mas_300 + 1;
                }
                totalsueldos = totalsueldos + sueldo;
                contador = contador + 1;

                Console.WriteLine("la cantidad de empleados que hay con sueldo entre 100 y 300 son : " + sueldos_entre100_300);
                Console.WriteLine("la cantididad de empleados que hay con sueldo mayor a 300 son : " + sueldos_mas_300);
                Console.WriteLine("el importe total de la empresa es: " + totalsueldos);
                Console.ReadKey();

                Console.ReadKey();
            }
        }
    }
}
