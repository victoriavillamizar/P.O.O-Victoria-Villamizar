using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class SondaExploradora
    {
        /*3.Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
        AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
        realice su asignación.
        Luego, definir dos clases derivadas de la clase base:
        ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
        soportada en atmósferas).
        ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
        Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
        tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
        clase SondaExploradora mediante el uso explícito de la palabra clave base.
        En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
        parámetros unificados por consola.*/

        protected string modelo;
        protected int autonomiaMinutos;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int AutonomiaMinutos
        {
            get { return autonomiaMinutos; }
            set { autonomiaMinutos = value; }
        }

        public SondaExploradora(string modeloo, int autonomiaa)
        {
            modelo = modeloo;
            autonomiaMinutos = autonomiaa;
        }
    }

    class SondaSubmarina : SondaExploradora
    {
        private int presionMaximaAtm;
        public int PresionMaximaAtm
        {
            get { return presionMaximaAtm; }
            set { presionMaximaAtm = value; }
        }

        public SondaSubmarina(string modeloo, int autonomiaa, int presionn) : base(modeloo, autonomiaa)
        {
            presionMaximaAtm = presionn;
        }
    }

    class RoverTerrestre : SondaExploradora
    {
        private int cantidadRuedas;

        public int CantidadRuedas
        {
            get { return cantidadRuedas; }
            set { cantidadRuedas = value; }
        }

        public RoverTerrestre(string modeloo, int autonomiaa, int ruedass) : base(modeloo, autonomiaa)
        {
            cantidadRuedas = ruedass;
        }
    
        static void Main(string[] args)
        {
            SondaSubmarina submarina1 = new SondaSubmarina("Aqua-X", 300, 120);

            RoverTerrestre rover1 = new RoverTerrestre("Mars-R", 500, 6);

            Console.WriteLine("SONDA SUBMARINA");
            Console.WriteLine("modelo: " + submarina1.Modelo);
            Console.WriteLine("autonomia: " + submarina1.AutonomiaMinutos + " minutos");
            Console.WriteLine("presión maxima: " + submarina1.PresionMaximaAtm + " atm");

            Console.WriteLine();

            Console.WriteLine("ROVER TERRESTRE");
            Console.WriteLine("modelo: " + rover1.Modelo);
            Console.WriteLine("autonomía: " + rover1.AutonomiaMinutos + " minutos");
            Console.WriteLine("cantidad de ruedas: " + rover1.CantidadRuedas);

            Console.ReadKey();
        }

    }
}