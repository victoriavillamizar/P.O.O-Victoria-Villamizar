using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class MonitoreoCostero
    {
        /*3-
        Un centro de conservación marina registra de forma dinámica las especies de
        mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
         Crear la clase MonitoreoCostero que contenga como atributo privado
        una lista de cadenas de texto List&lt;string&gt; especiesDetectadas.
         Métodos en MonitoreoCostero:
        1. CargarAvistamientos(): Solicitar por teclado nombres de
        especies marinas avistadas (ej: &quot;Ballena Franca&quot;, &quot;Lobo Marino&quot;,
        &quot;Delfín&quot;) y agregarlos a la lista utilizando .Add(). La carga finaliza
        cuando el usuario ingresa la palabra &quot;FIN&quot;.
        2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
        organizada alfabéticamente de la A a la Z utilizando el método
        .Sort().
        3. MostrarReporteInvertido(): Imprimir la lista organizada de la
        Z a la A combinando .Sort() con el método .Reverse().
        4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
        animal y, utilizando los métodos de búsqueda de listas, informar si la
        especie fue divisada en la costa durante el día.*/

            private List<string> especiesDetectadas;

            public MonitoreoCostero()
            {
                especiesDetectadas = new List<string>();
            }

            public void CargarAvistamientos()
            {
                Console.Write("ingrese una especie (FIN para terminar): ");
                string especie = Console.ReadLine();

                while (especie != "FIN")
                {
                    especiesDetectadas.Add(especie);

                    Console.Write("ingrese una especie (FIN para terminar): ");
                    especie = Console.ReadLine();
                }
            }

            public void MostrarReporteOrdenado()
            {
                especiesDetectadas.Sort();

                Console.WriteLine("especies ordenadas de A a Z:");

                foreach (string especie in especiesDetectadas)
                {
                    Console.WriteLine(especie);
                }
            }

            public void MostrarReporteInvertido()
            {
                especiesDetectadas.Sort();
                especiesDetectadas.Reverse();

                Console.WriteLine("especies ordenadas de Z a A:");

                foreach (string especie in especiesDetectadas)
                {
                    Console.WriteLine(especie);
                }
            }

            public void BuscarEspecie()
            {
                Console.Write("ingrese la especie que desea buscar: ");
                string especie = Console.ReadLine();

                if (especiesDetectadas.Contains(especie))
                {
                    Console.WriteLine("la especie fue encontrada.");
                }
                else
                {
                    Console.WriteLine("la especie no fue encontrada.");
                }
            }

            static void Main(string[] args)
            {
                MonitoreoCostero monitoreo = new MonitoreoCostero();

                monitoreo.CargarAvistamientos();
                monitoreo.MostrarReporteOrdenado();
                monitoreo.MostrarReporteInvertido();
                monitoreo.BuscarEspecie();

                Console.ReadKey();
            }

        }
    }
