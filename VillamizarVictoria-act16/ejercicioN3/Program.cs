using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ejercicioN3
{

    class Vehiculo
    {
        /*3. Crear una clase base Vehículo que contenga atributos marca y
         velocidadMaxima.
         Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
         una debe tener un constructor que reciba los valores de los atributos base
         mediante la palabra clave base, y un atributo propio (cantidadPuertas en
         Auto, cilindrada en Moto).*/


        protected string marca;
        protected double velocidadMaxima;
 
        public Vehiculo(string marca, double velocidadMaxima)
        {
            this.marca = marca;
            this.velocidadMaxima = velocidadMaxima;
        }

        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }

        public double VelocidadMaxima
        {
            get
            {
                return velocidadMaxima;
            }
            set
            {
                velocidadMaxima = value;
            }
        }
    }
    class Auto : Vehiculo
    {
        private int cantidadPuertas;


        public Auto(string marca, double velocidadMaxima, int cantidadPuertas)
            : base(marca, velocidadMaxima)
        {

            this.cantidadPuertas = cantidadPuertas;
        }


        public int CantidadPuertas
        {
            get
            {
                return cantidadPuertas;
            }
            set
            {
                cantidadPuertas = value;
            }
        }
    }


    class Moto : Vehiculo
    {
        private int cilindradaMoto;

        public Moto(string marca, double velocidadMaxima, int cilindradaMoto)
            : base(marca, velocidadMaxima)
        {
            this.cilindradaMoto = cilindradaMoto;
        }

        public int CilindradaMoto
        {
            get
            {
                return cilindradaMoto;
            }
            set
            {
                cilindradaMoto = value;
            }
        }
    

        static void Main(string[] args)
        {
            Auto miAuto = new Auto("ford", 200, 4);
            Moto miMoto = new Moto("yamaha", 150, 600);

            Console.WriteLine("datos del auto:");
            Console.WriteLine("marca: " + miAuto.Marca);
            Console.WriteLine("velocidad maxima: " + miAuto.VelocidadMaxima + " km/h");
            Console.WriteLine("puertas: " + miAuto.CantidadPuertas);

            Console.WriteLine("datos de la moto");
            Console.WriteLine("marca: " + miMoto.Marca);
            Console.WriteLine("velocidad maxima: " + miMoto.VelocidadMaxima + " km/h");
            Console.WriteLine("cilindrada: " + miMoto.CilindradaMoto + "cc");

            Console.ReadKey();
        }
    }
}
