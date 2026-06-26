using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class Computadora
    {
        /*3. Fábrica de Computadoras (Herencia y Constructores con base)
        Crear una clase base llamada Computadora que contenga los atributos Marca y
        MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
        Luego, definir dos clases derivadas de la clase base:

         Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).

         Escritorio: que añade el atributo propio PotenciaFuente (en Watts).

        Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
        tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
        clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
        de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/
        protected string marca;
        protected int memoriaRAM;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int MemoriaRAM
        {
            set { memoriaRAM = value; }
            get { return memoriaRAM; }
        }
        public Computadora(string m, int ram)
        {
            marca = m;
            memoriaRAM = ram;
        }
    }


    class Notebook : Computadora
    {
        private int tamañoPantalla;
        public int TamañoPantalla
        {
            set { tamañoPantalla = value; }
            get { return tamañoPantalla; }
        }
        public Notebook(string m, int ram, int pantalla): base(m, ram)
        {
            tamañoPantalla = pantalla;
        }

        public void Mostrar()
        {
            Console.WriteLine("marca: " + Marca);
            Console.WriteLine("memoria RAM: " + MemoriaRAM + " GB");
            Console.WriteLine("tamaño de pantalla: " + TamañoPantalla + " pulgadas");
        }
    }
    
        class Escritorio : Computadora
        {
            private int potenciaFuente;
            public int PotenciaFuente
            {
                set { potenciaFuente = value; }
                get { return potenciaFuente; }
            }

            public Escritorio(string m, int ram, int potencia): base(m, ram)
            {
                potenciaFuente = potencia;
            }

            public void Mostrar()
            {
                Console.WriteLine("marca: " + Marca);
                Console.WriteLine("memoria RAM: " + MemoriaRAM + " GB");
                Console.WriteLine("potencia de la fuente: " + PotenciaFuente + " Watts");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Notebook notebook1 = new Notebook("Lenovo", 16, 15);
                Console.WriteLine("NOTEBOOK");
                notebook1.Mostrar();
                Console.WriteLine();
                Escritorio escritorio1 = new Escritorio("HP", 32, 650);
                Console.WriteLine("ESCRITORIO");
                escritorio1.Mostrar();

                Console.ReadKey();
            }
        }
    }