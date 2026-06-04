using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class ReservaNatural
    {
        /*3. Geolocalización de Reservas Naturales
        Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
        especies protegidas en cuadrículas de territorio.
        ● Confeccionar la clase ReservaNatural que tenga como atributos privados el
        NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
        mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
        cantidad de animales avistados en cada sector). El constructor de la clase debe
        cargar por teclado el nombre y rellenar el mapa de avistamientos.
        ● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
        objetos de la clase ReservaNatural.
        La clase CentroEcologico debe implementar los siguientes métodos:
        1. Un constructor que solicite la carga secuencial de las 3 reservas.
        2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
        registró en toda su superficie (la suma de toda su matriz rectangular).
        3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
        columna]) que registró la mayor concentración de avistamientos de toda la red de
        reservas, indicando a qué reserva pertenece.*/

        private string nombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            Console.Write("ingrese el nombre de la reserva: ");
            nombreReserva = Console.ReadLine();

            avistamientos = new int[3, 3];

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write("ingrese avistamientos en [" + f + "," + c + "]: ");
                    string linea = Console.ReadLine();
                    avistamientos[f, c] = int.Parse(linea);
                }
            }
        }

        public string retornarNombre()
        {
            return nombreReserva;
        }
        public int retornarTotal()
        {
            int suma = 0;

            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 3; c++)
                {
                    suma += avistamientos[f, c];
                }
            }

            return suma;
        }

        public int retornarValor(int fila, int columna)
        {
            return avistamientos[fila, columna];
        }
    }

    class CentroEcologico
    {
        private ReservaNatural[] reservas;

        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];

            for (int f = 0; f < reservas.Length; f++)
            {
                Console.WriteLine("carga de la reserva " + (f + 1));

                reservas[f] = new ReservaNatural();

                Console.WriteLine();
            }
        }

        public void totalAvistamientos()
        {
            Console.WriteLine("total de avistamientos por reserva:");

            for (int f = 0; f < reservas.Length; f++)
            {
                Console.WriteLine(reservas[f].retornarNombre() +": " + reservas[f].retornarTotal());
            }
        }

        public void mayorConcentracion()
        {
            int mayor = reservas[0].retornarValor(0, 0);
            string nombreReserva = reservas[0].retornarNombre();
            int filaMayor = 0;
            int columnaMayor = 0;

            for (int r = 0; r < reservas.Length; r++)
            {
                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (reservas[r].retornarValor(f, c) > mayor)
                        {
                            mayor = reservas[r].retornarValor(f, c);
                            nombreReserva = reservas[r].retornarNombre();
                            filaMayor = f;
                            columnaMayor = c;
                        }
                    }
                }
            }

            Console.WriteLine("mayor concentracion de avistamientos:");
            Console.WriteLine("reserva: " + nombreReserva);
            Console.WriteLine("coordenada: [" +filaMayor + "," + columnaMayor + "]");
            Console.WriteLine("cantidad: " + mayor);
        }

        static void Main(string[] args)
        {
            CentroEcologico centro = new CentroEcologico();
            centro.totalAvistamientos();
            centro.mayorConcentracion();
            Console.ReadKey();
        }
    }
}