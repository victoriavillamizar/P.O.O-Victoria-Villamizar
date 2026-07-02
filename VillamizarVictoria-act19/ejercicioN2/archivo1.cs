using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
 
      partial class Libro
        {
        /*2. Crear una clase parcial Libro.
        En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
        cantidad de páginas sea mayor a 10. Valores cargados desde consola
        En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
        si el libro es corto (menos de 100 páginas) o largo.
        Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso.*/
            private string titulo;
            private string autor;
            private int paginas;

            public string Titulo
            {
                get { return titulo; }
                set { titulo = value; }
            }

            public string Autor
            {
                get { return autor; }
                set { autor = value; }
            }

            public int Paginas
            {
                get { return paginas; }
                set
                {
                    if (value > 10)
                        paginas = value;
                }
            }
        }
    }