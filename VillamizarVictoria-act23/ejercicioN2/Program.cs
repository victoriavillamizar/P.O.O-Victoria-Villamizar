using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ejercicioN2
{
    class Dron
    {
        /*2-
        Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
        drones de entrega en vuelo de regreso a la base.
         Crear la clase Dron que contenga los atributos privados: codigo (string) y
        nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
        Su constructor debe recibir cod y bat.
         Crear la clase CentroControl que administre una lista de objetos
        List&lt;Dron&gt;.
         Métodos en CentroControl:

        1. Un constructor que cargue por teclado una lista inicial de 4 drones
        ingresando sus códigos y baterías.
        2. ListarFlota(): Mostrar la lista de drones en pantalla.
        3. RemoverDronesBajos(): Recorrer la lista y remover por
        completo de la flota a todos aquellos drones cuyo nivel de batería
        sea menor o igual al 15% (ya que requieren mantenimiento
        automático urgente).
        4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
        cantidad de drones operativos utilizando la propiedad .Count.*/
        private string codigo;
        private int nivelBateria;
        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public int NivelBateria
        {
            set { if (value >= 0 && value <= 100) {
                    nivelBateria = value;
                }
            }
            get { return nivelBateria; }

        }
        public Dron(string cod, int bat)
        {
            codigo = cod;
            nivelBateria = bat;
        }
    }
        class CentroControl
        {
            private List<Dron> drones;

        public CentroControl()
        {
            drones = new List<Dron>();

            for (int i = 0; i < 4; i++)
            {
                Console.Write("codigo: ");
                string codigo = Console.ReadLine();

                Console.Write("bateria: ");
                int nivelBateria = int.Parse(Console.ReadLine());

                drones.Add(new Dron(codigo, nivelBateria));

            }
        }
            public void ListarFlota()
            {
                foreach (Dron dron in drones)
                {
                    Console.WriteLine("codigo: " + dron.Codigo + " - bateria: " + dron.NivelBateria + "%");
                }
            }

            public void RemoverDronesBajos()
            {
                drones.RemoveAll(dron => dron.NivelBateria <= 15);
            }

            public void MostrarDronesRestantes()
            {
                Console.WriteLine("drones restantes:");

                ListarFlota();

                Console.WriteLine("cantidad de drones operativos: " + drones.Count);
            }
        

        static void Main(string[] args)
        {
                CentroControl centro = new CentroControl();

                centro.ListarFlota();
                centro.RemoverDronesBajos();
                centro.MostrarDronesRestantes();

                Console.ReadKey();
            }

        }
    }
