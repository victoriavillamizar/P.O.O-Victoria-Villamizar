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

            int empleados, sueldo, contador, sueldos_entre100_300, sueldos_mas_300, totalsueldos,i;
            string linea;

            contador = 0;
            empleados = 0;
            sueldos_entre100_300 = 0;
            sueldos_mas_300 = 0;
            sueldo = 0;
            totalsueldos = 0;


            Console.Write("ingrese cantidad de empleados");
            linea = Console.ReadLine();
            contador = int.Parse(linea);


            while (empleados < contador) {
                Console.Write("ingrese cantidad de sueldo ");
                linea = Console.ReadLine();
                empleados = int.Parse(linea);


                if (sueldo > 100 && sueldo < 300){
                    sueldos_entre100_300 = sueldos_entre100_300 + 1;

                }
                else (sueldo > 300 && sueldo < 500){
                    sueldos_mas_300 = sueldos_mas_300 + 1;
                }
                totalsueldos = totalsueldos + sueldo;

                Console.ReadKey();
            }
        }
    }
}
