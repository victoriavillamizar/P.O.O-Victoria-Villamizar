using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN5
{
    class Vehiculo
    {
        /*5-
        Un taller mecánico automatizado administra la recepción y egreso de automóviles
        que se encuentran en el sector de reparaciones.
         Crear la clase Vehiculo que contenga como atributos privados: patente
        (string) y costoReparacion (double). Definir sus propiedades
        correspondientes y un constructor que reciba pat y costo.
         Crear la clase GestionTaller que administre una lista de objetos List.
         Métodos en GestionTaller:
        o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
        reparación de un vehículo para agregarlo a la lista mediante .Add().
        o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
        recorriendo la lista, informar si el vehículo está en el taller y mostrar
        su costo asociado.
        o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
        vehículo en la lista y, si existe, removerlo de la colección mediante
        .Remove() confirmando la entrega del automóvil.

        o CalcularRecaudacionPendiente(): Listar los vehículos
        actualmente en reparación, la cantidad total de unidades alojadas en
        el taller mediante la propiedad .Count y la suma total acumulada por
        cobrar.*/
       
        
            private string patente;
            private double costoReparacion;

            public string Patente
            {
                set { patente = value; }
                get { return patente; }
            }

            public double CostoReparacion
            {
                set { costoReparacion = value; }
                get { return costoReparacion; }
            }

            public Vehiculo(string pat, double costo)
            {
                patente = pat;
                costoReparacion = costo;
            }
        }

        class GestionTaller
        {
            private List<Vehiculo> vehiculos;

            public GestionTaller()
            {
                vehiculos = new List<Vehiculo>();
            }

            public void IngresarVehiculo()
            {
                Console.Write("patente: ");
                string patente = Console.ReadLine();

                Console.Write("costo de reparacion: ");
                double costo = double.Parse(Console.ReadLine());

                Vehiculo vehiculo = new Vehiculo(patente, costo);

                vehiculos.Add(vehiculo);

                Console.WriteLine("vehiculo ingresado correctamente.");
            }

            public void BuscarVehiculo()
            {
                Console.Write("ingrese la patente a buscar: ");
                string patente = Console.ReadLine();

                bool encontrado = false;

                foreach (Vehiculo vehiculo in vehiculos)
                {
                    if (vehiculo.Patente == patente)
                    {
                        Console.WriteLine("el vehiculo esta en el taller.");
                        Console.WriteLine("costo de reparacion: $" + vehiculo.CostoReparacion);

                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("el vehiculo no esta en el taller.");
                }
            }

            public void EntregarVehiculo()
            {
                Console.Write("ingrese la patente del vehiculo: ");
                string patente = Console.ReadLine();

                Vehiculo encontrado = null;

                foreach (Vehiculo vehiculo in vehiculos)
                {
                    if (vehiculo.Patente == patente)
                    {
                        encontrado = vehiculo;
                    }
                }

                if (encontrado != null)
                {
                    vehiculos.Remove(encontrado);
                    Console.WriteLine("vehiculo entregado correctamente.");
                }
                else
                {
                    Console.WriteLine("el vehiculo no esta en el taller.");
                }
            }

            public void CalcularRecaudacionPendiente()
            {
                double total = 0;

                Console.WriteLine("vehiculos en reparacion:");

                foreach (Vehiculo vehiculo in vehiculos)
                {
                    Console.WriteLine("patente: " + vehiculo.Patente +
                                      " - costo: $" + vehiculo.CostoReparacion);

                    total = total + vehiculo.CostoReparacion;
                }

                Console.WriteLine("cantidad de vehiculos: " + vehiculos.Count);
                Console.WriteLine("total pendiente de cobro: $" + total);
            }
        
            static void Main(string[] args)
            {
                GestionTaller taller = new GestionTaller();

                taller.IngresarVehiculo();
                taller.IngresarVehiculo();

                taller.BuscarVehiculo();
                taller.CalcularRecaudacionPendiente();
                taller.EntregarVehiculo();

                Console.ReadKey();
            }
        }
    }
