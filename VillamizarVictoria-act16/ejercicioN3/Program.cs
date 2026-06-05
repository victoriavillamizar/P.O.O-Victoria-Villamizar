using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class vehiculo
    {
        /*3. Crear una clase base Vehículo que contenga atributos marca y
        velocidadMaxima.
        Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo. Cada
        una debe tener un constructor que reciba los valores de los atributos base
        mediante la palabra clave base, y un atributo propio (cantidadPuertas en
        Auto, cilindrada en Moto).
        Crear un objeto de cada clase y mostrar todos sus datos por consola.*/
        protected string marca;
        protected double velocidadMaxima;
         

        public string Auto
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }
        public double VelocidadMaxima
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }

        public class auto : vehiculo
        {
            private int cantidadPuertas;

            public int CantidadPuertas
            {
                set
                {
                    cantidadPuertas = value;
                }
                get
                {
                    return cantidadPuertas;
                }
            }
            public auto(string marca, double velocidadMaxima) : base(marca)
            {
                this.CantidadPuertas = puertas;
            }
        }
        public class moto : vehiculo
        {
            private int cilindradaMoto;

            public int CilindradaMoto
            {
                set
                {
                    cilindradaMoto = value;
                }
                get
                {
                    return cilindradaMoto;
                }
            }
        }











        static void Main(string[] args)
        {
        }
    }
}
