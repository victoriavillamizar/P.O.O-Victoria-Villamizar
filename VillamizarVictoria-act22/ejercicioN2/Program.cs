using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{ 

    class ElementoPantalla
    {
    /*Actividad 2: Posicionamiento de elementos en consola
    Problema:
    Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
    ● Implementar propiedades y un constructor que cargue valores.
    ● Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
    nombre en pantalla y Console.CursorVisible para ocultar el cursor.
    ● Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
    consola.
    */
    private string nombre;
    private int posX;
    private int posY;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public int PosX
    {
        get { return posX; }
        set { posX = value; }
    }

    public int PosY
    {
        get { return posY; }
        set { posY = value; }
    }


    public ElementoPantalla(string nombre, int posX, int posY)
    {
        Nombre = nombre;
        PosX = posX;
        PosY = posY;
    }


    public void Mostrar()
    {
        Console.CursorVisible = false;
        Console.SetCursorPosition(PosX, PosY);
        Console.Write(Nombre);
    }
}

class Pantalla
{
    private ElementoPantalla[] elementos;

    public Pantalla()
    {
        elementos = new ElementoPantalla[4];
    }

    public void CargarElementos()
    {
        elementos[0] = new ElementoPantalla("VAMOS", 5, 3);
        elementos[1] = new ElementoPantalla("ARGENTINA", 25, 6);
        elementos[2] = new ElementoPantalla("CARAJO", 10, 12);
        elementos[3] = new ElementoPantalla("!!!!", 40, 18);
    }

    public void MostrarElementos()
    {
        for (int i = 0; i < elementos.Length; i++)
        {
            elementos[i].Mostrar();
        }
    }
   
        static void Main(string[] args)
    {
        Pantalla pantalla1 = new Pantalla();
        pantalla1.CargarElementos();
        pantalla1.MostrarElementos();
        Console.SetCursorPosition(0, 22);
        Console.CursorVisible = true;

        Console.ReadKey();
    }
}
}
