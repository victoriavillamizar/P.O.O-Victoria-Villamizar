using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
        /*Actividad 1: Sistema de control de vuelos
    Problema:
    Una aerolínea administra los vuelos programados mediante un sistema orientado a
    objetos.
    Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
    destino y duración en horas. Luego definir una clase derivada VueloInternacional que
    herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
    Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
    desde consola y luego:
     Mostrar los vuelos registrados y el país de destino.
     Informar cuál es el vuelo con mayor duración.
     Mostrar el orden de ejecución de los constructores.*/
        class Vuelo
        {
            protected string numeroVuelo;
            protected string destino;
            protected double duracionHoras;

            public string NumeroVuelo
            {
                get { return numeroVuelo; }
                set { numeroVuelo = value; }
            }

            public string Destino
            {
                get { return destino; }
                set { destino = value; }
            }

            public double DuracionHoras
            {
                get { return duracionHoras; }
                set { duracionHoras = value; }
            }

            public Vuelo()
            {
                Console.WriteLine("constructor de Vuelo ejecutado");
            }
        }

        class VueloInternacional : Vuelo
        {
            private string paisDestino;

            public string PaisDestino
            {
                get { return paisDestino; }
                set { paisDestino = value; }
            }

            public VueloInternacional()
            {
                Console.WriteLine("constructor de VueloInternacional ejecutado");
            }
        }

        class ControlVuelos
        {
            private List<VueloInternacional> vuelos =
                new List<VueloInternacional>();

            public void CargarVuelos()
            {
                for (int i = 0; i < 5; i++)
                {
                    VueloInternacional vuelo = new VueloInternacional();

                    Console.Write("numero de vuelo: ");
                    vuelo.NumeroVuelo = Console.ReadLine();

                    Console.Write("destino: ");
                    vuelo.Destino = Console.ReadLine();

                    Console.Write("duracion: ");
                    vuelo.DuracionHoras = double.Parse(Console.ReadLine());

                    Console.Write("pais destino: ");
                    vuelo.PaisDestino = Console.ReadLine();
                    vuelos.Add(vuelo);

                    Console.WriteLine();
                }
            }

            public void MostrarVuelos()
            {
                foreach (VueloInternacional v in vuelos)
                {
                    Console.WriteLine(
                        v.NumeroVuelo + " - " +v.Destino + " - " +v.PaisDestino);
                }
            }

            public void MostrarMayorDuracion()
            {
                int mayor = 0;

            for (int i = 1; i < vuelos.Count; i++)
            {
                if (vuelos[i].DuracionHoras >
                    vuelos[mayor].DuracionHoras)
                {
                    mayor = i;
                }
            }
                Console.WriteLine();
                Console.WriteLine( "vuelo con mayor duración: " + vuelos[mayor].NumeroVuelo);
            }
        
            static void Main(string[] args)
            {
                ControlVuelos control1 =new ControlVuelos();
                control1.CargarVuelos();
                control1.MostrarVuelos();
                control1.MostrarMayorDuracion();
                Console.ReadKey();
            }
        }
}
