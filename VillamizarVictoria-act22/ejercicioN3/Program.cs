using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class Entrenamiento
        {
        /*  Actividad 3: Registro de entrenamientos
        Problema:
        Plantear una clase Entrenamiento con atributos: deportista y duración(en minutos).
        ● Incluir dos métodos RegistrarDuracion(sobrecarga de métodos):
        1. Uno que reciba horas y minutos y los convierta a minutos.
        2. Otro que reciba directamente los minutos.
        ● Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
        más corto.*/
            private string deportista;
            private int duracion;

            public string Deportista
            {
                get { return deportista; }
                set { deportista = value; }
            }

            public int Duracion
            {
                get { return duracion; }
                set { duracion = value; }
            }

            public Entrenamiento(string deportista)
            {
                Deportista = deportista;
            }

            public void RegistrarDuracion(int horas, int minutos)
            {
                Duracion = (horas * 60) + minutos;
            }

            public void RegistrarDuracion(int minutos)
            {
                Duracion = minutos;
            }

            public void Mostrar()
            {
                Console.WriteLine("deportista: " + Deportista);
                Console.WriteLine("duración: " + Duracion + " minutos");
            }
        }

        class RegistroEntrenamientos
        {
            private List<Entrenamiento> entrenamientos;

            public RegistroEntrenamientos()
            {
                entrenamientos = new List<Entrenamiento>();
            }

            public void CargarEntrenamientos()
            {
                Entrenamiento e1 = new Entrenamiento("maxi");
                e1.RegistrarDuracion(1, 30); // 90 minutos
                entrenamientos.Add(e1);

                Entrenamiento e2 = new Entrenamiento("vicky");
                e2.RegistrarDuracion(45);
                entrenamientos.Add(e2);

                Entrenamiento e3 = new Entrenamiento("julieta");
                e3.RegistrarDuracion(2, 0); // 120 minutos
                entrenamientos.Add(e3);

                Entrenamiento e4 = new Entrenamiento("julian");
                e4.RegistrarDuracion(75);
                entrenamientos.Add(e4);

                Entrenamiento e5 = new Entrenamiento("messi");
                e5.RegistrarDuracion(1, 10); // 70 minutos
                entrenamientos.Add(e5);
            }

            public void MostrarMasLargo()
            {
                Entrenamiento mayor = entrenamientos[0];

                foreach (Entrenamiento e in entrenamientos)
                {
                    if (e.Duracion > mayor.Duracion)
                    {
                        mayor = e;
                    }
                }

                Console.WriteLine("entrenamiento mas largo:");
                mayor.Mostrar();
            }

            public void MostrarMasCorto()
            {
                Entrenamiento menor = entrenamientos[0];

                foreach (Entrenamiento e in entrenamientos)
                {
                    if (e.Duracion < menor.Duracion)
                    {
                        menor = e;
                    }
                }

                Console.WriteLine("entrenamiento mas corto:");
                menor.Mostrar();
            }
        

        static void Main(string[] args)
        {
            RegistroEntrenamientos registro = new RegistroEntrenamientos();

            registro.CargarEntrenamientos();
            registro.MostrarMasLargo();
            registro.MostrarMasCorto();

            Console.ReadKey();
        }
    }
}
