using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    class RobotEnsamblador
    {
        /*4. Línea de Ensamblaje Robótico
        En una planta de fabricación automatizada, cada robot industrial realiza tareas de
        ensamblaje complejas divididas en operaciones secundarias de duración variable.
        ● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
        1. ModeloRobot.
        2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
        fila representa una de las 4 fases principales del proceso (Estructura,
        Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
        completar las distintas subtareas de esa fase (por ejemplo, en la fase de
        Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
        1).
        3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
        cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar

        (definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
        una de ellas.

        ● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
        RobotEnsamblador. Implementar en PlantaIndustrial:
        1. Un constructor que cargue la información de los 3 robots instalados en la
        planta.
        2. Un método que muestre un reporte detallado con los tiempos de operación
        de cada robot fase por fase.
        3. Un método que calcule el promedio general de tiempo por tarea de cada
        robot y declare al &quot;Robot más Eficiente&quot; (aquel que registre el promedio de
        tiempo por operación más bajo de la planta).*/ 

        private string modeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador()
        {
            modeloRobot = Console.ReadLine();

            tiemposOperacion = new float[4][];

            string[] fases = { "estructura", "cableado", "pintura", "testeo" };

            for (int f = 0; f < tiemposOperacion.Length; f++)
            {
                Console.Write("ingrese cantidad de subtareas para " + fases[f] + ": ");
                string linea = Console.ReadLine();
                int cantidad = int.Parse(linea);

                tiemposOperacion[f] = new float[cantidad];

                for (int c = 0; c < tiemposOperacion[f].Length; c++)
                {
                    Console.Write("ingrese tiempo de la subtarea " + (c + 1) + ": ");
                    linea = Console.ReadLine();
                    tiemposOperacion[f][c] = float.Parse(linea);
                }
            }
        }

        public string retornarModelo()
        {
            return modeloRobot;
        }

        public float retornarTiempo(int fila, int columna)
        {
            return tiemposOperacion[fila][columna];
        }

        public int retornarCantidadSubtareas(int fila)
        {
            return tiemposOperacion[fila].Length;
        }

        public float retornarPromedio()
        {
            float suma = 0;
            int cantidad = 0;

            for (int f = 0; f < tiemposOperacion.Length; f++)
            {
                for (int c = 0; c < tiemposOperacion[f].Length; c++)
                {
                    suma += tiemposOperacion[f][c];
                    cantidad++;
                }
            }

            return suma / cantidad;
        }
    }

    class PlantaIndustrial
    {
        private RobotEnsamblador[] robots;

        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];

            for (int f = 0; f < robots.Length; f++)
            {
                Console.WriteLine("carga del robot " + (f + 1));
                Console.Write("ingrese el modelo del robot: ");

                robots[f] = new RobotEnsamblador();

                Console.WriteLine();
            }
        }

        public void reporteTiempos()
        {
            string[] fases = { "estructura", "cableado", "pintura", "testeo" };

            for (int r = 0; r < robots.Length; r++)
            {
                Console.WriteLine("robot: " + robots[r].retornarModelo());

                for (int f = 0; f < 4; f++)
                {
                    Console.WriteLine("fase: " + fases[f]);

                    for (int c = 0;
                         c < robots[r].retornarCantidadSubtareas(f);
                         c++)
                    {
                        Console.WriteLine("subtarea " + (c + 1) + ": " +robots[r].retornarTiempo(f, c) +" segundos");
                    }
                }
                Console.WriteLine();
            }
        }

        public void robotMasEficiente()
        {
            float menorPromedio = robots[0].retornarPromedio();
            string modelo = robots[0].retornarModelo();

            for (int f = 1; f < robots.Length; f++)
            {
                if (robots[f].retornarPromedio() < menorPromedio)
                {
                    menorPromedio = robots[f].retornarPromedio();
                    modelo = robots[f].retornarModelo();
                }
            }

            Console.WriteLine("robot mas eficiente: " + modelo);
            Console.WriteLine("promedio por tarea: " + menorPromedio + " segundos");
        }

        static void Main(string[] args)
        {
            PlantaIndustrial planta = new PlantaIndustrial();
            planta.reporteTiempos();
            planta.robotMasEficiente();
            Console.ReadKey();
        }
    }
}