using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    /*4. Inventario de Sucursales 
    Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. 
    El constructor de la clase debe cargar estos atributos por teclado.

    Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo.
    El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
    Implementar en la clase Sucursal los siguientes métodos:

    Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
    Un método que busque y muestre el nombre del artículo más caro del local.
    Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
*/
    class articulo
    {
        private string nombrearticulo;
        private double precio;
        private int stockactual;

        public articulo()
        {
            Console.Write("ingrese el nombre del articulo: ");
            nombrearticulo = Console.ReadLine();

            Console.Write("ingrese el precio: ");
            string linea = Console.ReadLine();
            precio = double.Parse(linea);

            Console.Write("ingrese la cantidad del stock actual: ");
            linea = Console.ReadLine();
            stockactual = int.Parse(linea);
        }

        public void imprimir()
        {
            Console.WriteLine("articulo: " + nombrearticulo);
            Console.WriteLine("precio: " + precio);
            Console.WriteLine("stock actual: " + stockactual);
            Console.WriteLine("valor total en inventario: " +  (precio * stockactual));
        }

        public double retornarPrecio()
        {
            return precio;
        }

        public int retornarStock()
        {
            return stockactual;
        }

        public string retornarNombre()
        {
            return nombrearticulo;
        }
    }

    class sucursal
    {
        private string nombresucursal;
        private articulo[] articulos;

        public sucursal()
        {
            Console.Write("ingrese el nombre o numero de la sucursal: ");
            nombresucursal = Console.ReadLine();

            articulos = new articulo[3];

            for (int f = 0; f < articulos.Length; f++)
            {
                Console.WriteLine("carga del articulo " + (f + 1));

                articulos[f] = new articulo();
            }
        }

        public void listaArticulos()
        {
            Console.WriteLine("lista de los articulos de la sucursal: " + nombresucursal);

            for (int f = 0; f < articulos.Length; f++)
            {
                articulos[f].imprimir();
            }
        }

        public void articuloMasCaro()
        {
            articulo mayor = articulos[0];

            for (int f = 1; f < articulos.Length; f++)
            {
                if (articulos[f].retornarPrecio() >
                    mayor.retornarPrecio())
                {
                    mayor = articulos[f];
                }
            }

            Console.WriteLine("el articulo mas caro es: " + mayor.retornarNombre());
        }

        public void reposicionUrgente()
        {
            Console.WriteLine("articulos que necesitan reposicion urgentemente: ");

            for (int f = 0; f < articulos.Length; f++)
            {
                if (articulos[f].retornarStock() <= 5)
                {
                    Console.WriteLine(articulos[f].retornarNombre());
                }
            }
        }

        static void Main(string[] args)
        {
            sucursal sucursal = new sucursal();
            sucursal.listaArticulos();
            sucursal.articuloMasCaro();
            sucursal.reposicionUrgente();
            Console.ReadKey();
        }
    }
}