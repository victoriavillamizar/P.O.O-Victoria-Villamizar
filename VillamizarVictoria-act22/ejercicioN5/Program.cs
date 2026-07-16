using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN5
{
    internal class Program
    {
        /* Actividad 5: Gestión de Carreras Deportivas
           Consigna:
           Crear un sistema para gestionar carreras deportivas.Cada carrera tiene un código,
           una hora de inicio y una hora de fin.Cada carrera puede registrar varios corredores.
           Se pide:
           1. Crear una clase Carrera con:
           o Atributos: código, hora de inicio, hora de fin y lista de corredores ya
           definidos.
           o Dos constructores (uno por defecto y otro con parámetros).
           o Método para calcular la duración de la carrera usando TimeSpan.
           2. Crear una clase Corredor con:
           o Atributos: nombre, número de dorsal y tiempo total.
           o Sobrecarga de métodos para registrar el tiempo total (en minutos o en
           horas y minutos).

           3. Mostrar en consola(usando Console.SetCursorPosition()) :
           o La carrera con mayor duración.
           o El corredor más rápido.
           4. Utilizar this en los constructores o métodos donde corresponda.
           5. Deben ser 4 carreras.*/


        class Corredor
        {
            private string nombre;
            private int dorsal;
            private int tiempoTotal;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public int Dorsal
            {
                get { return dorsal; }
                set { dorsal = value; }
            }

            public int TiempoTotal
            {
                get { return tiempoTotal; }
                set { tiempoTotal = value; }
            }

            public Corredor(string nombre, int dorsal)
            {
                this.nombre = nombre;
                this.dorsal = dorsal;
            }


            public void RegistrarTiempo(int minutos)
            {
                TiempoTotal = minutos;
            }

            public void RegistrarTiempo(int horas, int minutos)
            {
                TiempoTotal = (horas * 60) + minutos;
            }
        }

        class Carrera
        {
            private string codigo;
            private DateTime horaInicio;
            private DateTime horaFin;
            private List<Corredor> corredores;

            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public DateTime HoraInicio
            {
                get { return horaInicio; }
                set { horaInicio = value; }
            }

            public DateTime HoraFin
            {
                get { return horaFin; }
                set { horaFin = value; }
            }

            public List<Corredor> Corredores
            {
                get { return corredores; }
                set { corredores = value; }
            }


            public Carrera()
            {
                Codigo = "SIN CODIGO";
                HoraInicio = DateTime.Today.AddHours(8);
                HoraFin = DateTime.Today.AddHours(9);
                Corredores = new List<Corredor>();
            }


            public Carrera(string codigo, DateTime horaInicio, DateTime horaFin)
            {
                this.codigo = codigo;
                this.horaInicio = horaInicio;
                this.horaFin = horaFin;
                corredores = new List<Corredor>();
            }

            public TimeSpan CalcularDuracion()
            {
                return HoraFin - HoraInicio;
            }

            public void AgregarCorredor(Corredor corredor)
            {
                Corredores.Add(corredor);
            }
        }

        class GestionCarreras
        {
            private Carrera[] carreras;

            public GestionCarreras()
            {
                carreras = new Carrera[4];
            }

            public void CargarCarreras()
            {
                carreras[0] = new Carrera("C001", DateTime.Today.AddHours(8), DateTime.Today.AddHours(10));
                carreras[1] = new Carrera("C002", DateTime.Today.AddHours(7), DateTime.Today.AddHours(11));
                carreras[2] = new Carrera("C003", DateTime.Today.AddHours(9), DateTime.Today.AddHours(10).AddMinutes(30));
                carreras[3] = new Carrera("C004", DateTime.Today.AddHours(6), DateTime.Today.AddHours(9));

                Corredor c1 = new Corredor("maxi", 101);
                c1.RegistrarTiempo(55);

                Corredor c2 = new Corredor("angel", 102);
                c2.RegistrarTiempo(1, 10);

                Corredor c3 = new Corredor("agus", 103);
                c3.RegistrarTiempo(48);

                Corredor c4 = new Corredor("stiles", 104);
                c4.RegistrarTiempo(1, 5);

                carreras[0].AgregarCorredor(c1);
                carreras[1].AgregarCorredor(c2);
                carreras[2].AgregarCorredor(c3);
                carreras[3].AgregarCorredor(c4);
            }

            public void MostrarCarreraMasLarga()
            {
                Carrera mayor = carreras[0];

                for (int i = 1; i < carreras.Length; i++)
                {
                    if (carreras[i].CalcularDuracion() > mayor.CalcularDuracion())
                    {
                        mayor = carreras[i];
                    }
                }

                Console.SetCursorPosition(0, 2);
                Console.WriteLine("carrera con mayor duracion:");
                Console.WriteLine("codigo: " + mayor.Codigo);
                Console.WriteLine("duracion: " + mayor.CalcularDuracion());
            }

            public void MostrarCorredorMasRapido()
            {
                Corredor rapido = carreras[0].Corredores[0];

                foreach (Carrera carrera in carreras)
                {
                    foreach (Corredor corredor in carrera.Corredores)
                    {
                        if (corredor.TiempoTotal < rapido.TiempoTotal)
                        {
                            rapido = corredor;
                        }
                    }
                }

                Console.SetCursorPosition(0, 7);
                Console.WriteLine("corredor mas rapido:");
                Console.WriteLine("nombre: " + rapido.Nombre);
                Console.WriteLine("tiempo: " + rapido.TiempoTotal + " minutos");
            }

            static void Main(string[] args)
            {
                GestionCarreras gestion1 = new GestionCarreras();
                gestion1.CargarCarreras();
                gestion1.MostrarCarreraMasLarga();
                gestion1.MostrarCorredorMasRapido();
                Console.ReadKey();
            }
        }
    }
}