using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
        /*4-
        Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
        vinculados a una red hogareña.
         Crear la clase DispositivoInteligente que contenga como atributos
        privados: nombreDispositivo(string) y consumoWatts(double). Definir
        sus propiedades y un constructor que reciba nom y watts.
         Crear la clase colaboradora PanelDomotico que administre un objeto
        List&lt;DispositivoInteligente&gt;.
         Métodos en PanelDomotico:
        1. Un constructor que permita al usuario cargar dinámicamente
        dispositivos por teclado.El sistema preguntará después de cada
        carga si se desea agregar otro dispositivo.
        2. MostrarDispositivos(): Listar todos los dispositivos
        configurados junto a sus consumos.
        3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
        Watts totales que consume la casa sumando los valores de la lista.
        4. DesconectarDispositivo(): Solicitar al usuario el nombre de
        un dispositivo y, si existe en la lista, removerlo de forma dinámica
        para simular su apagado remoto.*/
        class DispositivoInteligente
        {
            private string nombreDispositivo;
            private double consumoWatts;

            public string NombreDispositivo
            {
                set { nombreDispositivo = value; }
                get { return nombreDispositivo; }
            }

            public double ConsumoWatts
            {
                set { consumoWatts = value; }
                get { return consumoWatts; }
            }

            public DispositivoInteligente(string nom, double watts)
            {
                nombreDispositivo = nom;
                consumoWatts = watts;
            }
        }

        class PanelDomotico
        {
            private List<DispositivoInteligente> dispositivos;

            public PanelDomotico()
            {
                dispositivos = new List<DispositivoInteligente>();

                string respuesta = "si";

                while (respuesta == "si")
                {
                    Console.Write("nombre del dispositivo: ");
                    string nombre = Console.ReadLine();

                    Console.Write("consumo en watts: ");
                    double watts = double.Parse(Console.ReadLine());

                    dispositivos.Add(new DispositivoInteligente(nombre, watts));

                    Console.Write("desea agregar otro dispositivo? (si o no): ");
                    respuesta = Console.ReadLine();
                }
            }

            public void MostrarDispositivos()
            {
                foreach (DispositivoInteligente dispositivo in dispositivos)
                {
                    Console.WriteLine("dispositivo: " + dispositivo.NombreDispositivo +  " - consumo: " + dispositivo.ConsumoWatts + "w");
                }
            }

            public void CalcularConsumoTotal()
            {
                double total = 0;

                foreach (DispositivoInteligente dispositivo in dispositivos)
                {
                    total = total + dispositivo.ConsumoWatts;
                }

                Console.WriteLine("consumo total: " + total + "w");
            }

            public void DesconectarDispositivo()
            {
                Console.Write("ingrese el nombre del dispositivo a desconectar: ");
                string nombre = Console.ReadLine();

                DispositivoInteligente encontrado = null;

                foreach (DispositivoInteligente dispositivo in dispositivos)
                {
                    if (dispositivo.NombreDispositivo == nombre)
                    {
                        encontrado = dispositivo;
                    }
                }

                if (encontrado != null)
                {
                    dispositivos.Remove(encontrado);
                    Console.WriteLine("dispositivo desconectado.");
                }
                else
                {
                    Console.WriteLine("el dispositivo no existe.");
                }
            }
        
            static void Main(string[] args)
            {
                PanelDomotico panel = new PanelDomotico();

                panel.MostrarDispositivos();
                panel.CalcularConsumoTotal();
                panel.DesconectarDispositivo();

                Console.ReadKey();
            }
        }
    }