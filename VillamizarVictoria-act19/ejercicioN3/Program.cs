using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class Program
    {
        static void Main(string[] args)
        {
            JuegoArcade juego = new JuegoArcade();

            Console.Write("nombre del juego: ");
            juego.NombreJuego = Console.ReadLine();

            Console.Write("record actual: ");
            juego.PuntajeMaximo = int.Parse(Console.ReadLine());

            Console.Write("nivel dificultad: ");
            juego.NivelDificultad = int.Parse(Console.ReadLine());

            string ganador = "";

            for (int i = 1; i <= 4; i++)
            {
                Console.Write("jugador " + i + ": ");
                string nombre = Console.ReadLine();

                Console.Write("puntaje: ");
                int puntaje =
                    int.Parse(Console.ReadLine());

                if (juego.SuperaRecord(puntaje))
                    ganador = nombre;
            }

            Console.WriteLine();

            if (ganador != "")
                Console.WriteLine(ganador + " rompio el record.");
            else
                Console.WriteLine("nadie rompio el record.");
            Console.ReadKey();
        }
    }
}


