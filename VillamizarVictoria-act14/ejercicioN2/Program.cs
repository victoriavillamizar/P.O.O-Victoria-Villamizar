using ejercicioN2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class pasajero
    {
        /*2. Control de Vuelos
        Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). 
        En su constructor, solicitar la carga de estos tres datos.

        Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. 
        Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
        Agregar los siguientes métodos en la clase Vuelo:
        Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
        Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
        Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI. */

        private int dni;
        private string nombre;
        private int equipajekilos;

        public pasajero()
        {
            Console.WriteLine("ingrese el nombre del pasajero: ");
            nombre = Console.ReadLine();

            Console.WriteLine("ingrese el dni del pasajero: ");
            string linea = Console.ReadLine();
            dni = int.Parse(linea);

            Console.WriteLine("ingrese el equipaje en kilos: ");
            linea = Console.ReadLine();
            equipajekilos = int.Parse(linea);
        }
        public void imprimir()
        {
            Console.WriteLine("nombre: " + nombre);
            Console.WriteLine("DNI: " + dni);
            Console.WriteLine("equipaje en kg: " + equipajekilos);
        }

        public double retornarEquipaje()
        {
            return equipajekilos;
        }

        public string retornarNombre()
        {
            return nombre;
        }

        public int retornarDni()
        {
            return dni;
        }
    }

}
    class vuelo
    {
    private pasajero[] pasajeros;

    public vuelo()
    {
        pasajeros = new pasajero[4];

        for (int f = 0; f < pasajeros.Length; f++)
        {
            Console.WriteLine("carga del pasajero " + (f + 1));

            pasajeros[f] = new pasajero();
        }
    }
    public void listadoPasajeros()
    {
        Console.WriteLine("listado completo de pasajeros:");

        for (int f = 0; f < pasajeros.Length; f++)
        {
            pasajeros[f].imprimir();
        }
    }
    public void pesoTotalEquipaje()
    {
        double total = 0;

        for (int f = 0; f < pasajeros.Length; f++)
        {
            total = total + pasajeros[f].retornarEquipaje();
        }

        Console.WriteLine("el peso total del equipaje es: " + total + " kg");
    }
    public void excesoEquipaje()
    {
        Console.WriteLine("pasajeros que sobrepasan los 23 kg: ");

        for (int f = 0; f < pasajeros.Length; f++)
        {
            if (pasajeros[f].retornarEquipaje() > 23)
            {
                Console.WriteLine("nombre: " + pasajeros[f].retornarNombre());
                Console.WriteLine("dNI: " + pasajeros[f].retornarDni());
            }
        }
    }

    static void Main(string[] args)
    {
        vuelo vuelo = new vuelo();
        vuelo.listadoPasajeros();
        vuelo.pesoTotalEquipaje();
        vuelo.excesoEquipaje();
        Console.ReadKey();
    }
}

    /*
class pasajero
{
private string nombre;
private string dni;
private double equipajekilos;

public pasajero()
{
    Console.Write("Ingrese el nombre del pasajero: ");
    nombre = Console.ReadLine();

    Console.Write("Ingrese el DNI: ");
    dni = Console.ReadLine();

    Console.Write("Ingrese el peso del equipaje en kg: ");
    string linea = Console.ReadLine();
    equipajekilos = double.Parse(linea);
}

public void imprimir()
{
    Console.WriteLine("Nombre: " + nombre);
    Console.WriteLine("DNI: " + dni);
    Console.WriteLine("Equipaje en kg: " + equipajekilos);
}

public double retornarEquipaje()
{
    return equipajekilos;
}

public string retornarNombre()
{
    return nombre;
}

public string retornarDni()
{
    return dni;
}
}

class vuelo
{
private pasajero[] pasajeros;

public vuelo()
{
    pasajeros = new pasajero[4];

    for (int f = 0; f < pasajeros.Length; f++)
    {
        Console.WriteLine("Carga del pasajero " + (f + 1));

        pasajeros[f] = new pasajero();
    }
}

public void listadoPasajeros()
{
    Console.WriteLine("Listado completo de pasajeros:");

    for (int f = 0; f < pasajeros.Length; f++)
    {
        pasajeros[f].imprimir();
    }
}

public void pesoTotalEquipaje()
{
    double total = 0;

    for (int f = 0; f < pasajeros.Length; f++)
    {
        total = total + pasajeros[f].retornarEquipaje();
    }

    Console.WriteLine("El peso total del equipaje es: " + total + " kg");
}

public void excesoEquipaje()
{
    Console.WriteLine("Pasajeros que exceden los 23 kg:");

    for (int f = 0; f < pasajeros.Length; f++)
    {
        if (pasajeros[f].retornarEquipaje() > 23)
        {
            Console.WriteLine("Nombre: " + pasajeros[f].retornarNombre());
            Console.WriteLine("DNI: " + pasajeros[f].retornarDni());
        }
    }
}

static void Main(string[] args)
{
    vuelo vuelo1 = new vuelo();

    vuelo1.listadoPasajeros();
    vuelo1.pesoTotalEquipaje();
    vuelo1.excesoEquipaje();

    Console.ReadKey();
}
}
}
}*/