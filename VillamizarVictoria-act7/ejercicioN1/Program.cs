using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class vectores
    {
        //Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
        //El valor acumulado de todos los elementos del vector.
        //El valor acumulado de los elementos del vector que sean mayores a 36. Cantidad de valores mayores a 50.

        private int[]numeros;
        public void ingresarValores()
        {
            numeros = new int[8];
            for (int m = 0; m < 8; m++)
            {
                Console.Write("ingrese algun numero: ");
                string linea;
                linea = Console.ReadLine();
                 numeros[m] = int.Parse(linea);


            }
            
        }
        public void SumaTotal()
        {
            int suma=0;
            
            for (int m = 0; m < 8; m++) {
       
                suma = suma + numeros[m];

            }
            Console.WriteLine("la suma total de todos los numeros es: "+suma);
        }

        public void mayoresa36()
        {
            int mayores36;
            mayores36 = 0;
            for (int m = 0; m < 8; m++) {
                if (numeros[m] > 36) {
                    mayores36 = mayores36 + numeros[m];
                }
               
            }
            Console.WriteLine("la suma de los numeros mayores a 36: " + mayores36);
        }
        public void mayoresa50()
        {
            int mayores50 = 0;
            int cont = 0;
            for (int m = 0; m < 8; m++)
            {
                if (numeros[m] > 50)
                {
                    mayores50 = mayores50 + numeros[m];
                    cont ++;
                }
            }
            Console.WriteLine("cantidad de valores mayores a 50: " + cont);




        }
            static void Main(string[] args)
            {
                vectores vectores = new vectores();

                vectores.ingresarValores();
                vectores.SumaTotal();
                vectores.mayoresa36();
                vectores.mayoresa50();
            Console.ReadKey();
            }
        }
    }