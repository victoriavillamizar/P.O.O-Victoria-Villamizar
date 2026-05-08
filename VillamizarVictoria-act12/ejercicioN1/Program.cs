using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class sucursal
    {
        /*1. Sistema de Logística: Envíos por Sucursal
        Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
        cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
        represente el peso (en kg) de cada paquete enviado.
        ● Métodos:
        1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
        paquetes se enviaron hoy para definir el tamaño de su fila.
        2. Cargar el peso de cada paquete.
        3. Imprimir el peso de todos los paquetes organizados por sucursal.
        4. Calcular e informar el peso total despachado por cada sucursal.
        5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
        pertenece.*/

        private string[] nombres;
        private double[][] peso;

            public void cargarDatos()
            {
                nombres = new string[3];
                peso = new double[3][];
                string linea;

                for (int f = 0; f < 3; f++)
                {
                    Console.WriteLine("ingrese el nombre de la sucursal: ");
                    nombres[f] = Console.ReadLine();

                    Console.WriteLine("ingrese la cantidad de paquetes enviados: ");
                    linea = Console.ReadLine();

                    int cantidad = int.Parse(linea);

                    peso[f] = new double[cantidad];

                    for (int c = 0; c < peso[f].Length; c++)
                    {
                        Console.WriteLine("ingrese el peso del paquete: " + (c + 1));
                        linea = Console.ReadLine();

                        peso[f][c] = double.Parse(linea);
                    }
                }
            }

            public void mostrarPaquetes()
            {
                Console.WriteLine("paquetes por sucursal: ");

                for (int f = 0; f < peso.Length; f++)
                {
                    Console.WriteLine("sucursal: " + nombres[f]);

                    for (int c = 0; c < peso[f].Length; c++)
                    {
                        Console.Write(peso[f][c] + " kg ");
                    }

                    Console.WriteLine();
                }
            }

            public void pesoTotalSucursal()
            {
                double suma;

                Console.WriteLine("peso total por sucursal: ");

                for (int f = 0; f < peso.Length; f++)
                {
                    suma = 0;

                    for (int c = 0; c < peso[f].Length; c++)
                    {
                        suma = suma + peso[f][c];
                    }

                    Console.WriteLine(nombres[f] + ": " + suma + " kg ");
                }
            }

            public void paqueteMasPesado()
            {
                double mayor = peso[0][0];
                string sucursalMayor = nombres[0];

                for (int f = 0; f < peso.Length; f++)
                {
                    for (int c = 0; c < peso[f].Length; c++)
                    {
                        if (peso[f][c] > mayor)
                        {
                            mayor = peso[f][c];
                            sucursalMayor = nombres[f];
                        }
                    }
                }

                Console.WriteLine("el paquete mas pesado  es: " + mayor + "kg");
                Console.WriteLine("su sucursal fue: " + sucursalMayor);
            }

            static void Main(string[] args)
            {
                sucursal sucursal = new sucursal();
                sucursal.cargarDatos();
                sucursal.mostrarPaquetes();
                sucursal.pesoTotalSucursal();
                sucursal.paqueteMasPesado();
                Console.ReadKey();
            }
        }
    }