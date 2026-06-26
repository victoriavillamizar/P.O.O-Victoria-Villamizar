using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class Pelicula
    {
        /*2. Catálogo de Películas (Encapsulación, Validación y Composición)
        Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
        La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
        (un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
        asegurando mediante validaciones lógicas que:
         La duración en minutos sea estrictamente mayor a cero (0).
         La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
        un valor por defecto de 1).
        La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
        la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
        películas ordenadas de mayor a menor en base a su duración. Además, el método debe
        informar el título de la película con mejor calificación y cuál es la película más corta del
        catálogo.*/

        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public int DuracionMinutos
        {
            set
            {
                if (value > 0)
                {
                    duracionMinutos = value;
                }
            }
            get { return duracionMinutos; }
        }
        public int Calificacion
        {
            set
            {
                if (value < 1 || value >5)
                {
                    calificacion = 1;
                }

                else
                {
                    calificacion = value;
                }
            }
            get { return calificacion; }
        }


        class Catalogo
        {
            private Pelicula[] peliculas;

            public Catalogo()
            {
                peliculas = new Pelicula[3];
             }
            public void cargarPeli()
            {
        
                for (int i = 0; i < peliculas.Length; i++)
                {
                    peliculas[i] = new Pelicula();

                    Console.Write("escriba el titulo de la pelicula: ");
                    peliculas[i].Titulo = Console.ReadLine();

                    Console.Write("cuando dura la pelicula en minutos: ");
                    peliculas[i].DuracionMinutos = int.Parse(Console.ReadLine());

                    Console.Write("ingrese su calificacion de la peli: ");
                    peliculas[i].Calificacion = int.Parse(Console.ReadLine());
                }
            }
            public void pelisOrde()
            {
                Pelicula mejorcalificacion = peliculas[0];
                Pelicula masCorta = peliculas[0];
                
                    for (int i = 0; i < peliculas.Length - 1; i++)
                {
                    for (int j = i + 1; j < peliculas.Length; j++)
                    {
                        if (peliculas[i].duracionMinutos < peliculas[j].duracionMinutos)
                        {
                            Pelicula aux = peliculas[i];
                            peliculas[i] = peliculas[j];
                            peliculas[j] = aux;
                        }
                    }
                }
                for (int i = 0; i < peliculas.Length; i++)
                {
                    Console.WriteLine("titulo de la pelicula: " + peliculas[i].titulo); 
                    Console.WriteLine(" duracion de la pelicula: " + peliculas[i].duracionMinutos); 
                    Console.WriteLine( "calificacion de la pelicula: "+ peliculas[i].calificacion);
                    Console.WriteLine();
                }

                    for (int i = 0; i < peliculas.Length; i++) {
                    if (peliculas[i].Calificacion > mejorcalificacion.Calificacion)
                    {
                        mejorcalificacion = peliculas[i];
                    }
                    if (peliculas[i].DuracionMinutos < masCorta.duracionMinutos)
                    {
                        masCorta = peliculas[i];
                    }
                   
                }
                Console.WriteLine("la pelicula con mejor calificacion fue: " + mejorcalificacion.titulo);
                Console.WriteLine("la pelicula mas corta fue: " + masCorta.titulo);
                
                }
            }
        static void Main(string[] args)
        { 
            Catalogo catalogo1 = new Catalogo();
            catalogo1.cargarPeli();
            catalogo1.pelisOrde();
            Console.ReadKey();
        }
    }
}
