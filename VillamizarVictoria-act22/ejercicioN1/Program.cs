using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
       class ClaseGimnasio
        {
       /* Actividad 1: Control de horarios en un gimnasio
        Problema:
        Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin(usar
        DateTime).
        ● Implementar un constructor que permita cargar los datos desde consola y otro
        que cargue valores por defecto(sobrecarga de constructores).
        ● Incluir un método para calcular la duración de la clase usando TimeSpan.
        ● Crear un vector de 3 clases de gimnasio y mostrar:
        1. La clase que tenga la mayor duración.
        2. El nombre y el horario de inicio de la clase más temprana.*/

            private string nombreClase;
            private DateTime horaInicio;
            private DateTime horaFin;

            public string NombreClase
            {
                get { return nombreClase; }
                set { nombreClase = value; }
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

            public ClaseGimnasio()
            {
                NombreClase = "Musculación";
                HoraInicio = DateTime.Today.AddHours(8);
                HoraFin = DateTime.Today.AddHours(9);
            }

            public ClaseGimnasio(string nombre, DateTime inicio, DateTime fin)
            {
                NombreClase = nombre;
                HoraInicio = inicio;
                HoraFin = fin;
            }

            public TimeSpan CalcularDuracion()
            {
                return HoraFin - HoraInicio;
            }

            public void Mostrar()
            {
                Console.WriteLine("nombre de la clase: " + NombreClase);
                Console.WriteLine("hora de inicio (colocar la hora y los minutos): " + HoraInicio.ToShortTimeString());
                Console.WriteLine("hora de fin (colocar la hora y los minutos): " + HoraFin.ToShortTimeString());
                Console.WriteLine("duracion: " + CalcularDuracion());
            }
        }
    
    class Gimnasio
    {
        private ClaseGimnasio[] clases;

        public Gimnasio()
        {
            clases = new ClaseGimnasio[3];
        }

        public void CargarClases()
        {
            for (int i = 0; i < clases.Length; i++)
            {
                Console.WriteLine("clase " + (i + 1));

                Console.Write("nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("hora de inicio (en horas y minutos): ");
                DateTime inicio = DateTime.Today.Add(TimeSpan.Parse(Console.ReadLine()));

                Console.Write("hora de fin (en horas y minutos): ");
                DateTime fin = DateTime.Today.Add(TimeSpan.Parse(Console.ReadLine()));

                clases[i] = new ClaseGimnasio(nombre, inicio, fin);
            }
        }

        public void MostrarMayorDuracion()
        {
            ClaseGimnasio mayor = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].CalcularDuracion() > mayor.CalcularDuracion())
                {
                    mayor = clases[i];
                }
            }

            Console.WriteLine("la clase con mayor duración fue: " );
            mayor.Mostrar();
        }

        public void MostrarMasTemprana()
        {
            ClaseGimnasio temprana = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].HoraInicio < temprana.HoraInicio)
                {
                    temprana = clases[i];
                }
            }

            Console.WriteLine("la clase que comienza mas temprano es:");
            Console.WriteLine("nombre: " + temprana.NombreClase);
            Console.WriteLine("hora de inicio: " + temprana.HoraInicio.ToShortTimeString());
        }
    

        static void Main(string[] args)
        {
            Gimnasio gimnasio = new Gimnasio();

            gimnasio.CargarClases();
            gimnasio.MostrarMayorDuracion();
            gimnasio.MostrarMasTemprana();

            Console.ReadKey();
        }
    }
}