using ejercicioN1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class Documento
    {
        /*1-
        En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
        llegada.
         Crear la clase Documento que contenga como atributos privados:
        nombreArchivo (string) y cantidadPaginas (int). Definir sus
        propiedades de solo lectura y un constructor que reciba los parámetros nom
        y pag.
         Crear la clase ServidorImpresion que administre una lista dinámica de
        documentos (List&lt;Documento&gt;).
         Métodos en ServidorImpresion:
        1. AgregarDocumento(): Solicitar por teclado los datos de un
        documento y agregarlo al final de la lista utilizando .Add().
        2. ImprimirSiguiente(): Si la lista no está vacía, simular la
        impresión del primer documento de la lista (mostrar sus datos en
        consola) y removerlo de la colección mediante .RemoveAt(0). Si está
        vacía, advertir que no hay trabajos pendientes.
        3. MostrarColaPendiente(): Listar todos los documentos que
        están esperando ser impresos y la cantidad total de páginas
        acumuladas en la cola de espera utilizando .Count.*/
        private string nombreArchivo;
        private int cantidadPaginas;
        public string NombreArchivo
        {
            get { return nombreArchivo; }
        }

        public int CantidadPaginas
        {
            get { return cantidadPaginas; }

        }
        public Documento(string nom, int pag)
        {
            nombreArchivo = nom;
            cantidadPaginas = pag;
        }
    }
}
class ServidorImpresion
{
    private List<Documento> documentos;

    public ServidorImpresion()
    {
        documentos = new List<Documento>();
    }

    public void AgregarDocumento()
    {
        Console.Write("nombre del archivo: ");
        string nombre = Console.ReadLine();

        Console.Write("cantidad de paginas: ");
        int paginas = int.Parse(Console.ReadLine());

        Documento doc = new Documento(nombre, paginas);

        documentos.Add(doc);

        Console.WriteLine("documento agregado correctamente.");
    }

    public void ImprimirSiguiente()
    {
        if (documentos.Count > 0)
        {
            Console.WriteLine("archivo: " + documentos[0].NombreArchivo);
            Console.WriteLine("paginas: " + documentos[0].CantidadPaginas);

            documentos.RemoveAt(0);

            Console.WriteLine("documento impreso y eliminado de la cola.");
        }
        else
        {
            Console.WriteLine("no hay trabajos pendientes.");
        }
    }

    public void MostrarColaPendiente()
    {
        if (documentos.Count == 0)
        {
            Console.WriteLine("no hay documentos en espera.");
            return;
        }

        int totalPaginas = 0;

        Console.WriteLine("DOCUMENTOS PENDIENTES:");

        foreach (Documento doc in documentos)
        {
            Console.WriteLine("archivo: " + doc.NombreArchivo + " - paginas: " + doc.CantidadPaginas);

            totalPaginas += doc.CantidadPaginas;
        }

        Console.WriteLine("cantidad de documentos: " + documentos.Count);
        Console.WriteLine("total de páginas: " + totalPaginas);
    }


    static void Main(string[] args)
    {
        ServidorImpresion servidor = new ServidorImpresion();

        servidor.AgregarDocumento();
        servidor.AgregarDocumento();

        servidor.MostrarColaPendiente();

        servidor.ImprimirSiguiente();

        servidor.MostrarColaPendiente();
        Console.ReadKey();
    }
}
