using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    class Material
    {
        /* 4. Cadena de Herramientas(Herencia Multinivel y Orden de Constructores)
         Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
         herencia: Material, Herramienta y Martillo.
          La clase Material(base) debe tener un atributo TipoMaterial(ej: Madera, Acero,
         Plástico).
          La clase Herramienta(que hereda de Material) debe añadir el atributo
         FuncionPrincipal.
          La clase Martillo(que hereda de Herramienta) debe añadir el atributo PesoGramos.
         Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
         correspondientes.Al momento de ejecutarse, cada constructor debe realizar la asignación y,
         acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
         (ejemplo: &quot; Constructor de la clase Material ejecutado&quot;).
         En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
         parámetros requeridos.Observar y verificar en la consola el orden secuencial de ejecución
         en cadena de los constructores(desde la raíz hasta la clase derivada).*/
        protected string tipoMaterial;

        public string TipoMaterial
        {
            set { tipoMaterial = value; }
            get { return tipoMaterial; }
        }

        public Material(string tipo)
        {
            tipoMaterial = tipo;
            Console.WriteLine("constructor de la clase Material ejecutadose");
        }
    }

    class Herramienta : Material
    {
        protected string funcionPrincipal;
        public string FuncionPrincipal
        {
            set { funcionPrincipal = value; }
            get { return funcionPrincipal; }
        }

        public Herramienta(string tipo, string funcion) : base(tipo)
        {
            funcionPrincipal = funcion;
            Console.WriteLine("constructor de la clase Herramienta ejecutadose");
        }
    }

class Martillo : Herramienta
    {
        private int pesoGramos;

        public int PesoGramos
        {
            set{ pesoGramos = value; }
            get { return pesoGramos; }
        }

        public Martillo(string tipo, string funcion, int peso): base(tipo, funcion)
        {
            pesoGramos = peso;
            Console.WriteLine("constructor de la clase Martillo ejecutadose");
        }

        public void Mostrar()
        {
            Console.WriteLine("tipo de material: " + tipoMaterial);
            Console.WriteLine("funcion principal: " + funcionPrincipal);
            Console.WriteLine("peso: " + pesoGramos + " gramos");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Martillo martillo1 = new Martillo("acero", "golpear", 800);
            Console.WriteLine();
            martillo1.Mostrar();

            Console.ReadKey();
        }
    }
}