using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class NaveEspacial
    {

        /*2. Logística de Puerto Espacial
        Una estación de acoplamiento registra el peso de los contenedores transportados en las
        bodegas de carga de las naves espaciales que llegan al puerto.
        ● Crear la clase NaveEspacial que contenga únicamente el atributo privado
        NombreNave y su constructor para cargarlo.
        ● Crear la clase colaboradora PuertoControl que contenga:
        ○ Un vector de 3 objetos de la clase NaveEspacial.
        ○ Una matriz irregular de tipo double llamado pesoContenedores, donde
        cada fila representa a una nave, el tamaño de la fila es la cantidad de
        bodegas que posee esa nave, y los valores almacenados son los pesos (en
        toneladas) de los contenedores que transporta cada bodega.

        En PuertoControl, definir los siguientes métodos:

        1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
        cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
        irregular) y cargue el peso del contenedor asignado a cada bodega.
        2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
        espacial.
        3. Un método que identifique e informe qué nave transporta el contenedor individual
        más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
        irregular).
        4. Un método que indique el nombre de la nave que transporta menor peso acumulado
        total (la suma de todos sus contenedores).*/

        private string nombreNave;

        public NaveEspacial()
        {
            Console.Write("ingrese el nombre de la nave: ");
            nombreNave = Console.ReadLine();
        }

        public string retornarNombre()
        {
            return nombreNave;
        }
    }

    class PuertoControl
    {
        private NaveEspacial[] naves;
        private double[][] pesoContenedores;

        public PuertoControl()
        {
            naves = new NaveEspacial[3];
            pesoContenedores = new double[3][];

            for (int f = 0; f < naves.Length; f++)
            {
                Console.WriteLine("carga de la nave " + (f + 1));

                naves[f] = new NaveEspacial();

                Console.Write("ingrese la cantidad de bodegas activas: ");
                string linea = Console.ReadLine();
                int bodegas = int.Parse(linea);

                pesoContenedores[f] = new double[bodegas];

                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    Console.Write("ingrese el peso del contenedor de la bodega "
                                  + (c + 1) + ": ");
                    linea = Console.ReadLine();
                    pesoContenedores[f][c] = double.Parse(linea);
                }

                Console.WriteLine();
            }
        }

        public void mostrarPesos()
        {
            for (int f = 0; f < naves.Length; f++)
            {
                Console.WriteLine("nave: " + naves[f].retornarNombre());

                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    Console.WriteLine("bodega " + (c + 1) + ": " + pesoContenedores[f][c] + " toneladas");
                }
                Console.WriteLine();
            }
        }

        public void contenedorMasPesado()
        {
            double mayor = pesoContenedores[0][0];
            string nombreNave = naves[0].retornarNombre();

            for (int f = 0; f < pesoContenedores.Length; f++)
            {
                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    if (pesoContenedores[f][c] > mayor)
                    {
                        mayor = pesoContenedores[f][c];
                        nombreNave = naves[f].retornarNombre();
                    }
                }
            }

            Console.WriteLine("la nave que transporta el contenedor mas pesado es: "
                              + nombreNave);
            Console.WriteLine("peso del contenedor: " + mayor + " toneladas");
        }

        public void menorPesoAcumulado()
        {
            double menorSuma = 0;
            string nombreNave = "";

            for (int c = 0; c < pesoContenedores[0].Length; c++)
            {
                menorSuma += pesoContenedores[0][c];
            }

            nombreNave = naves[0].retornarNombre();

            for (int f = 1; f < pesoContenedores.Length; f++)
            {
                double suma = 0;

                for (int c = 0; c < pesoContenedores[f].Length; c++)
                {
                    suma += pesoContenedores[f][c];
                }

                if (suma < menorSuma)
                {
                    menorSuma = suma;
                    nombreNave = naves[f].retornarNombre();
                }
            }

            Console.WriteLine("la nave con menor peso acumulado es: "
                              + nombreNave);
            Console.WriteLine("peso total: " + menorSuma + " toneladas");
        }

        static void Main(string[] args)
        {
            PuertoControl puerto = new PuertoControl();
            puerto.mostrarPesos();
            puerto.contenedorMasPesado();
            puerto.menorPesoAcumulado();

            Console.ReadKey();
        }
    }
}