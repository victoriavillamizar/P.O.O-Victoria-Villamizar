using ejercicioN1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class temperatura
    {
        /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
        dato las temperaturas medias mensuales de dichos paises.
        Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
        mensuales.
        Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
        memoria.
        a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
        b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las
        mismas.
        c. Calcular la temperatura media trimestral de cada país.
        d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
        e. Imprimir el nombre del país con la temperatura media trimestral mayor.*/
        
            private string[] paises;
            private int[,] temperaturas;

            public void cargarDatos()
            {
                paises = new string[4];
                temperaturas = new int[4, 3];

                string linea;

                for (int f = 0; f < 4; f++)
                {
                    Console.WriteLine("ingrese el nombre del pais: ");
                    paises[f] = Console.ReadLine();

                    for (int c = 0; c < 3; c++)
                    {
                        Console.WriteLine("ingrese la temperatura del mes" + (c + 1));
                        linea = Console.ReadLine();
                        temperaturas[f, c] = int.Parse(linea);
                    }
                }
            }

            public void mostrarDatos()
            {
                Console.WriteLine("datos cargados: ");

                for (int f = 0; f < 4; f++)
                {
                    Console.Write(paises[f] + ": ");

                    for (int c = 0; c < 3; c++)
                    {
                        Console.Write(temperaturas[f, c] + " ");
                    }

                    Console.WriteLine();
                }
            }

            public void temperaturaPromedio()
            {
                double promedio;
                double mayor = 0;
                string paisMayor = "";

                Console.WriteLine("el promedio trimestral de cada pais es: ");

                for (int f = 0; f < 4; f++)
                {
                    int suma = 0;

                    for (int c = 0; c < 3; c++)
                    {
                        suma = suma + temperaturas[f, c];
                    }

                    promedio = suma / 3.0;

                    Console.WriteLine(paises[f] + " promedio: " + promedio);

                    if (promedio > mayor)
                    {
                        mayor = promedio;
                        paisMayor = paises[f];
                    }
                }

                Console.WriteLine("el pais que tiene mayor promedio trimestral: " + paisMayor);
            }


                static void Main(string[] args)
                    {
                temperatura tempo = new temperatura();
                tempo.cargarDatos();
                tempo.mostrarDatos();
                tempo.temperaturaPromedio();
                Console.ReadKey();


}
    }
}
