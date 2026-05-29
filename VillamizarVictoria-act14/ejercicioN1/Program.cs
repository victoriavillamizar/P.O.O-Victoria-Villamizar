using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class vehiculo
    {
        /*1. El Sistema de Peaje.
        Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
        La clase Vehiculo debe tener los siguientes atributos privados:
        Patente (de tipo string).
        Tipo (puede ser "Auto", "Camion" o "Moto").
        Tarifa (un valor decimal que representa el costo de su pase).
        El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.

        La clase CabinaPeaje debe tener como atributos privados:
        El número o identificador de la cabina.
        Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
        Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. 
        Además, implementar los siguientes métodos dentro de CabinaPeaje:
        Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
        Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
        Un método que muestre la patente del vehículo que pagó la tarifa más cara.
        */
        private string patente;
        private string tipo;
        private double tarifa;

        public vehiculo()
        {
            Console.Write("ingrese la patente: ");
            patente = Console.ReadLine();

            Console.Write("ingrese el tipo de vehiculo (auto/camion/moto): ");
            tipo = Console.ReadLine();

            Console.Write("ingrese la tarifa: ");
            string linea = Console.ReadLine();
            tarifa = double.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("patente: " + patente);
            Console.WriteLine("tipo: " + tipo);
        }

        public double retornarTarifa()
        {
            return tarifa;
        }

        public string retornarPatente()
        {
            return patente;
        }
    }

    class cabinapeaje
    {
        private int identificador;
        private vehiculo vehiculo1, vehiculo2, vehiculo3;

        public cabinapeaje()
        /* Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
    Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
    Un método que muestre la patente del vehículo que pagó la tarifa más cara.
    */
        {
            Console.Write("ingrese el numero de cabina: ");
            string linea = Console.ReadLine();
            identificador = int.Parse(linea);

            Console.WriteLine("carga del vehiculo 1");
            vehiculo1 = new vehiculo();

            Console.WriteLine("arga del vehiculo 2");
            vehiculo2 = new vehiculo();

            Console.WriteLine("carga del vehiculo 3");
            vehiculo3 = new vehiculo();
        }

        public void imprimirVehiculos()
        {
            Console.WriteLine("vehiculos registrados en la cabina " + identificador);

            vehiculo1.imprimir();
            vehiculo2.imprimir();
            vehiculo3.imprimir();
        }

        public void recaudacionTotal()
        {
            double total;

            total = vehiculo1.retornarTarifa() + vehiculo2.retornarTarifa() + vehiculo3.retornarTarifa();
            Console.WriteLine("la recaudacion total fue de: " + total);
        }

        public void vehiculoMasCaro()
        {
            if (vehiculo1.retornarTarifa() > vehiculo2.retornarTarifa() &&
                vehiculo1.retornarTarifa() > vehiculo3.retornarTarifa())
            {
                Console.WriteLine("el vehiculo que pago la tarifa mas cara es: " +
                                  vehiculo1.retornarPatente());
            }
            else
            {
                if (vehiculo2.retornarTarifa() > vehiculo3.retornarTarifa())
                {
                    Console.WriteLine("el vehiculo que pago la tarifa mas cara es: " +
                                      vehiculo2.retornarPatente());
                }
                else
                {
                    Console.WriteLine("el vehiculo que pago la tarifa mas cara es: " +
                                      vehiculo3.retornarPatente());
                }
            }
        }

        static void Main(string[] args)
        {
            cabinapeaje cabina1 = new cabinapeaje();

            cabina1.imprimirVehiculos();
            cabina1.recaudacionTotal();
            cabina1.vehiculoMasCaro();

            Console.ReadKey();
        }
    }
}