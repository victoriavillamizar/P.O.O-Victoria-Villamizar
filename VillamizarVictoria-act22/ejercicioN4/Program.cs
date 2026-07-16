using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{

    class Vuelo
        {
        /*  Actividad 4: Gestión de vuelos
            Problema:
            Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada(DateTime).
            ● Usar la palabra clave this en el constructor para diferenciar los parámetros de
            los atributos.
            ● Crear un método para calcular la duración del vuelo (TimeSpan).
            ● Cargar un vector con 4 vuelos y mostrar:
            1. El código y duración del vuelo más largo.
            2. El código del vuelo que salga más temprano.*/

            private string codigo;
            private DateTime horaSalida;
            private DateTime horaLlegada;

            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public DateTime HoraSalida
            {
                get { return horaSalida; }
                set { horaSalida = value; }
            }

            public DateTime HoraLlegada
            {
                get { return horaLlegada; }
                set { horaLlegada = value; }
            }


            public Vuelo(string codigo, DateTime horaSalida, DateTime horaLlegada)
            {
                this.codigo = codigo;
                this.horaSalida = horaSalida;
                this.horaLlegada = horaLlegada;
            }


            public TimeSpan CalcularDuracion()
            {
                return HoraLlegada - HoraSalida;
            }

            public void Mostrar()
            {
                Console.WriteLine("codigo: " + Codigo);
                Console.WriteLine("hora de salida: " + HoraSalida.ToShortTimeString());
                Console.WriteLine("hora de llegada: " + HoraLlegada.ToShortTimeString());
                Console.WriteLine("duracion: " + CalcularDuracion());
            }
        }

        class GestionVuelos
        {
            private Vuelo[] vuelos;

            public GestionVuelos()
            {
                vuelos = new Vuelo[4];
            }

            public void CargarVuelos()
            {
                vuelos[0] = new Vuelo("AR101",
                    DateTime.Today.AddHours(8),
                    DateTime.Today.AddHours(10));

                vuelos[1] = new Vuelo("AR205",
                    DateTime.Today.AddHours(6).AddMinutes(30),
                    DateTime.Today.AddHours(9));

                vuelos[2] = new Vuelo("AR330",
                    DateTime.Today.AddHours(14),
                    DateTime.Today.AddHours(18));

                vuelos[3] = new Vuelo("AR450",
                    DateTime.Today.AddHours(11),
                    DateTime.Today.AddHours(12).AddMinutes(30));
            }

            public void MostrarVueloMasLargo()
            {
                Vuelo mayor = vuelos[0];

                for (int i = 1; i < vuelos.Length; i++)
                {
                    if (vuelos[i].CalcularDuracion() > mayor.CalcularDuracion())
                    {
                        mayor = vuelos[i];
                    }
                }

                Console.WriteLine("vuelo mas largo:");
                Console.WriteLine("codigo: " + mayor.Codigo);
                Console.WriteLine("duracion: " + mayor.CalcularDuracion());
            }

            public void MostrarVueloMasTemprano()
            {
                Vuelo temprano = vuelos[0];

                for (int i = 1; i < vuelos.Length; i++)
                {
                    if (vuelos[i].HoraSalida < temprano.HoraSalida)
                    {
                        temprano = vuelos[i];
                    }
                }

                Console.WriteLine("vuelo que sale mas temprano:");
                Console.WriteLine("codigo: " + temprano.Codigo);
            }
        

        static void Main(string[] args)
        {
            GestionVuelos gestion = new GestionVuelos();

            gestion.CargarVuelos();
            gestion.MostrarVueloMasLargo();
            gestion.MostrarVueloMasTemprano();

            Console.ReadKey();
        }
    }
}