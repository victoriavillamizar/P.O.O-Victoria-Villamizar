using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
        /*Actividad 2: Administración de entregas logísticas
        Problema:
        Una empresa de envíos desea registrar sus entregas mediante colaboración de
        clases.
        Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
        Despachador que contenga una lista de paquetes y un método para registrar nuevos
        paquetes.
        Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
         Todos los paquetes registrados.
         Cuántos superan los 10 kg de peso.
         Cuántos tienen destino nacional (por ejemplo, “Argentina”).*/
        class Paquete
        {
            private string codigo;
            private double peso;
            private string destino;

            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public double Peso
            {
                get { return peso; }
                set { peso = value; }
            }

            public string Destino
            {
                get { return destino; }
                set { destino = value; }
            }
        }

        class Despachador
        {
            private List<Paquete> paquetes =
                new List<Paquete>();

            public void RegistrarPaquetes()
            {
                for (int i = 0; i < 5; i++)
                {
                    Paquete p = new Paquete();

                    Console.Write("codigo: ");
                    p.Codigo = Console.ReadLine();

                    Console.Write("peso: ");
                    p.Peso =double.Parse(Console.ReadLine());

                    Console.Write("destino: ");
                    p.Destino =Console.ReadLine();

                    paquetes.Add(p);

                    Console.WriteLine();
                }
            }

            public void MostrarPaquetes()
            {
                foreach (Paquete p in paquetes)
                {
                    Console.WriteLine(p.Codigo + " - " +p.Peso + " kg - " +  p.Destino);
                }
            }

            public void MostrarMayoresA10Kg()
            {
                int contador = 0;

                foreach (Paquete p in paquetes)
                {
                    if (p.Peso > 10)
                        contador++;
                }

                Console.WriteLine( "paquetes mayores a 10 kg: "+ contador);
            }

            public void MostrarNacionales()
            {
                int contador = 0;

                foreach (Paquete p in paquetes)
                {
                    if (p.Destino == "argentina")
                        contador++;
                }

                Console.WriteLine("paquetes nacionales: "+ contador);
            }
        

            static void Main(string[] args)
            {
                Despachador d =new Despachador();
                d.RegistrarPaquetes();
                d.MostrarPaquetes();
                d.MostrarMayoresA10Kg();
                d.MostrarNacionales();

                Console.ReadKey();
            }
        }
}
