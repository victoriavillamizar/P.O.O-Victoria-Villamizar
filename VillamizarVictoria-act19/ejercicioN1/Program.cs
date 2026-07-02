using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class Program
        {
            static void Main(string[] args)
            {
                ReservaHotel[] reservas = new ReservaHotel[3];

                for (int i = 0; i < reservas.Length; i++)
                {
                    reservas[i] = new ReservaHotel();

                    Console.Write("cliente: ");
                    reservas[i].NombreCliente = Console.ReadLine();

                    Console.Write("noches: ");
                    reservas[i].CantidadNoches = int.Parse(Console.ReadLine());

                    Console.Write("habitacion: ");
                    reservas[i].TipoHabitacion = Console.ReadLine();
                }

                int mayor = 0;

                for (int i = 1; i < reservas.Length; i++)
                {
                    if (reservas[i].CalcularTotal() > reservas[mayor].CalcularTotal())
                        mayor = i;
                }

                Console.WriteLine("pagara mas: " + reservas[mayor].NombreCliente);
            Console.ReadKey();
            }
        }
    }


   