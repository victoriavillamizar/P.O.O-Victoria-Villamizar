using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class paciente
    {
        /*1. Monitoreo Clínico de Pacientes
        En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
        cardíaco de los pacientes.
        ● Plantear una clase llamada Paciente que tenga como atributos privados:
        1. Nombre (de tipo string).
        2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los
        registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
        clave de cada día: mañana, mediodía, tarde y noche).
        3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
        teclado de las 12 lecturas cardíacas.

        ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
        objetos de la clase Paciente. Su constructor debe inicializar el vector y solicitar la
        carga de los 3 pacientes. Implementar los siguientes métodos dentro de
        SalaMonitoreo:
        1. Un método que imprima la grilla de lecturas cardíacas completa de cada
        paciente organizada por día y momento.
        2. Un método que calcule e imprima el promedio de pulsaciones de cada
        paciente a lo largo de todo su monitoreo.
        3. Un método que verifique si algún paciente registró un evento de taquicardia
        severa (cualquier lectura individual que sea estrictamente mayor a 120
        pulsaciones), mostrando por consola su nombre y la lectura detectada.*/

        private string nombre;
        private int[,] ritmoCardiaco;

        public paciente(){

            Console.Write("ingrese el nombre del paciente: ");
            nombre = Console.ReadLine();

            ritmoCardiaco = new int[3, 4];

            string[] momentos = { "mañana", "mediodia", "tarde", "noche" };

            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("dia " + (f + 1));

                for (int c = 0; c < 4; c++)
                {
                    Console.Write("ingrese las pulsaciones de " +
                                  momentos[c] + ": ");
                    string linea = Console.ReadLine();
                    ritmoCardiaco[f, c] = int.Parse(linea);
                }
            }
        }


        public void imprimirLecturas()
        {

            string[] momentos = { "mañana", "mediodia", "tarde", "noche" };


            Console.WriteLine("paciente: " + nombre);

            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("dia " + (f + 1));

                for (int c = 0; c < 4; c++)
                {
                    Console.WriteLine(momentos[c] + ": " + ritmoCardiaco[f, c]);
                }

                Console.WriteLine();
            }
        }

        public void promedioPulsaciones()
        {
            int suma = 0;

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    suma = suma + ritmoCardiaco[f, c];
                }
            }

            double promedio = (double)suma / 12;

            Console.WriteLine("promedio de " + nombre + ": " + promedio);
        }

        public void verificarTaquicardia()
        {
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 4; c++)
                {
                    if (ritmoCardiaco[f, c] > 120)
                    {
                        Console.WriteLine("paciente: " + nombre);
                        Console.WriteLine("lectura detectada: " + ritmoCardiaco[f, c]);
                    }
                }
            }
        }
    }

    class SalaMonitoreo
    {
        private paciente[] pacientes;

        public SalaMonitoreo()
        {
            pacientes = new paciente[3];

            for (int f = 0; f < pacientes.Length; f++)
            {
                Console.WriteLine("carga del paciente " + (f + 1));

                pacientes[f] = new paciente();
            }
        }

        public void imprimirGrilla()
        {

            Console.WriteLine();
            Console.WriteLine("LECTURAS CARDIACAS");

            for (int f = 0; f < pacientes.Length; f++)
            {
                pacientes[f].imprimirLecturas();
            }
        }

        public void promediosPacientes()
        {
            for (int f = 0; f < pacientes.Length; f++)
            {
                pacientes[f].promedioPulsaciones();
            }
        }

        public void eventosTaquicardia()
        {
            Console.WriteLine("pacientes con taquicardia severa:");

            for (int f = 0; f < pacientes.Length; f++)
            {
                pacientes[f].verificarTaquicardia();
            }
        }

        static void Main(string[] args)
        {
            SalaMonitoreo sala = new SalaMonitoreo();
            sala.imprimirGrilla();
            sala.promediosPacientes();
            sala.eventosTaquicardia();
            Console.ReadKey();
        }
    }
}