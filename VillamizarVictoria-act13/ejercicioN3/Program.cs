using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    class socio
    {
        /*3. Plantear una clase Club y otra clase Socio.
        La clase Socio debe tener los siguientes atributos privados: nombre y la
        antigüedad en el club (en años). En el constructor pedir la carga del nombre y
        su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
        Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
        antigüedad en el club.*/
        private string nombre;
        private int antiguedad;

        public socio()
        {
            Console.Write("ingrese el nombre del socio: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese los años que tiene en el club: ");
            string linea = Console.ReadLine();
            antiguedad = int.Parse(linea);

        }
        public void mayorantieguedad()
        {
            int m;
            if( antiguedad > m ) {
                
        }
    }
        class club
        {
            private socio socio1, socio2, socio3;
            public club() {
                socio1 = new socio();
                socio2= new socio();
                socio3 = new socio();
        }


        static void Main(string[] args)
        {
        }
    }
}
