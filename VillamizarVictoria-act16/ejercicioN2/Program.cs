using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class producto
    {
        /*2. Plantear una clase Producto y otra clase Inventario.
        La clase Producto debe tener como atributos privados el nombre, precio y
        stock. Definir propiedades para acceder a estos atributos, asegurando que el
        stock no pueda ser negativo y el precio sea mayor a cero.
        La clase Inventario debe contener 3 objetos de la clase Producto. Definir un
        método para mostrar todos los productos ordenados de menor a mayor en
        base al precio, además, mostrar el producto más caro y más barato del
        inventario.*/
        private string nombre;
        private int precio;
        private int stock;


        public producto()
        {
            Console.WriteLine("ingrese nombre del producto");
            nombre = Console.ReadLine();

            Console.WriteLine("ingrese precio del producto");
            string linea = Console.ReadLine();
            Precio = int.Parse(linea);

            Console.WriteLine("ingrese el stock del producto");
            linea = Console.ReadLine();
            Stock = int.Parse(linea);


        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public int Precio
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("el precio no puede ser menor a 0");
                }
                else
                {
                    precio = value;
                }
            }
            get {
                return precio;
            }
        }
        public int Stock
        {
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    Console.WriteLine("mal el stock no puede ser negativo. lol");
                    stock = 0;
                }
            }
            get
            {
                return stock;
            }
        }
        public void Imprimir()
        {
            Console.WriteLine("nombre : " + nombre + " precio: " + precio + " stock: " + stock);
        }

        class Inventario
        {
            private producto[] productos;

            public Inventario()
            {
                productos = new producto[3];

                for (int i = 0; i < 3; i++)
                {
                    productos[i] = new producto();
                }
            }

            public producto[] Productos
            {
                get
                {
                    return productos;
                }
            }

            public void MostrarOrdenados()
            {
                for (int i = 0; i < productos.Length; i++)
                {
                    for (int j = i + 1; j < productos.Length; j++)
                    {
                        if (productos[i].Precio > productos[j].Precio)
                        {
                            producto aux = productos[i];
                            productos[i] = productos[j];
                            productos[j] = aux;
                        }
                    }
                }

                Console.WriteLine("productos ordenados por precio:");

                for (int i = 0; i < productos.Length; i++)
                {
                    productos[i].Imprimir();
                }
                Console.WriteLine("producto mas barato:");
                productos[0].Imprimir();

                Console.WriteLine("producto mas caro:");
                productos[productos.Length - 1].Imprimir();
             
            
            }
        }
        static void Main(string[] args)
        {
            Inventario inventario1 = new Inventario();
            inventario1.MostrarOrdenados();

            Console.ReadKey();
        }
    }
}

