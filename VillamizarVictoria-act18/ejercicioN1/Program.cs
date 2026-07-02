using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class DispositivoEnergia
    {
        /*1.
        Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
        CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
        generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
        generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
        imprimir estos datos básicos.

        Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
        un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
        en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
        Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.

        En el programa principal (Main):
        ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
        ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
        puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
        muestra de información.*/

       
        private string codigoIdentificador;
        private double generacionKwh;
        public string CodigoIdentificador
        {
            set { codigoIdentificador = value;  }
            get{ return codigoIdentificador;}
        }
        public double GeneracionKwh
        {
            set
            {
                if (value > 0)
                {
                    generacionKwh = value;
                }
                else
                {
                    generacionKwh = 0;
                }
            }
            get { return generacionKwh;}
        }
        public void Imprimir()
        {
            Console.WriteLine("codigo identificador: " + codigoIdentificador);
            Console.WriteLine("Kilowatts-hora generados: " + generacionKwh);
        }

        class PanelSolar : DispositivoEnergia
        {
            private double areaMetros;
            public double AreaMetros
            {
                set
                {
                    if (value > 0)
                    {
                        areaMetros = value;
                    }
                    else
                    {
                       areaMetros = 0;
                    }
                }
                get { return areaMetros; }
            }
            public void imprimir2()
            {
                Console.WriteLine("area en metros cuadrados: " + areaMetros);
                Console.WriteLine("codigo identificador: " + codigoIdentificador);
                Console.WriteLine("generacion kwh: " + generacionKwh);
            }
        }

        static void Main(string[] args)
        {
            DispositivoEnergia dispositivoEnergia1 = new DispositivoEnergia();
            Console.Write("ingrese el codigo identificador: ");
            dispositivoEnergia1.CodigoIdentificador = Console.ReadLine();

            Console.Write("ingrese los Kilowatts-hora generados: ");
            dispositivoEnergia1.GeneracionKwh = double.Parse(Console.ReadLine());

            Console.WriteLine();
            dispositivoEnergia1.Imprimir();
            Console.WriteLine();

            PanelSolar solar1 = new PanelSolar();
            Console.Write("ingrese el codigo identificador del panel: ");
            solar1.CodigoIdentificador = Console.ReadLine();
            Console.Write("ingrese los Kilowatts-hora generados: ");
            solar1.GeneracionKwh = double.Parse(Console.ReadLine());
            Console.Write("ingrese el area en metros cuadrados: ");
            solar1.AreaMetros = double.Parse(Console.ReadLine());
            Console.WriteLine();
            solar1.imprimir2();

            Console.ReadKey();

        }
    }
}
