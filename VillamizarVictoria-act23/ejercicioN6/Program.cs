using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN6
{
    /*6-
    Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
    para organizar la consulta de ejemplares por parte de los lectores.
     Crear la clase Libro que contenga como atributos privados: titulo
    (string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
    un constructor que reciba tit y anio.
     Crear la clase BibliotecaCentral que administre una lista de objetos
    List.
     Métodos en BibliotecaCentral:
    1. CargarCatalogo(): Solicitar por teclado títulos y años de
    publicación para agregar libros a la lista mediante .Add(). La carga
    finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
    2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
    junto a la cantidad total de obras registradas mediante la propiedad
    .Count.
    3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
    imprimir en consola únicamente aquellos libros cuyo año de
    publicación sea menor a dicho valor.
    4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
    los métodos de búsqueda y remoción de listas, eliminarlo de la
    colección si se encuentra presente.*/
        class Libro
        {
            private string titulo;
            private int anioPublicacion;

            public string Titulo
            {
                get { return titulo; }
            }

            public int AnioPublicacion
            {
                get { return anioPublicacion; }
            }

            public Libro(string tit, int anio)
            {
                titulo = tit;
                anioPublicacion = anio;
            }
        }

        class BibliotecaCentral
        {
            private List<Libro> libros;

            public BibliotecaCentral()
            {
                libros = new List<Libro>();
            }

            public void CargarCatalogo()
            {
                Console.Write("titulo: ");
                string titulo = Console.ReadLine();

                while (titulo != "FIN")
                {
                    Console.Write("año de publicacion: ");
                    int anio = int.Parse(Console.ReadLine());

                    Libro libro = new Libro(titulo, anio);

                    libros.Add(libro);

                    Console.Write("titulo: ");
                    titulo = Console.ReadLine();
                }
            }

            public void ListarCatalogo()
            {
                foreach (Libro libro in libros)
                {
                    Console.WriteLine("titulo: " + libro.Titulo + " - año: " + libro.AnioPublicacion);
                }

                Console.WriteLine("cantidad total de obras: " + libros.Count);
            }

            public void FiltrarPorAnio()
            {
                Console.Write("ingrese un año: ");
                int anio = int.Parse(Console.ReadLine());

                foreach (Libro libro in libros)
                {
                    if (libro.AnioPublicacion < anio)
                    {
                        Console.WriteLine("Titulo: " + libro.Titulo + " - Año: " + libro.AnioPublicacion);
                    }
                }
            }

            public void RemoverLibro()
            {
                Console.Write("ingrese el titulo del libro a eliminar: ");
                string titulo = Console.ReadLine();

                Libro encontrado = null;

                foreach (Libro libro in libros)
                {
                    if (libro.Titulo == titulo)
                    {
                        encontrado = libro;
                    }
                }

                if (encontrado != null)
                {
                    libros.Remove(encontrado);
                    Console.WriteLine("libro eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("el libro no se encuentra en el catalogo.");
                }
            }
        
            static void Main(string[] args)
            {
                BibliotecaCentral biblioteca = new BibliotecaCentral();

                biblioteca.CargarCatalogo();
                biblioteca.ListarCatalogo();
                biblioteca.FiltrarPorAnio();
                biblioteca.RemoverLibro();

                Console.ReadKey();
            }
        }
    }
  