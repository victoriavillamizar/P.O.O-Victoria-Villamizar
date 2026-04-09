using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN1
{
    class plano
    {
        //Desarrollar una clase que represente un punto en el plano y tenga los
        //siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
        //encuentra dicho punto(concepto matemático, primer cuadrante si x e y son
        //positivas, si x&lt;0 e y&gt;0 segundo cuadrante, etc.)
        private string linea;
        private int x, y;

        public void iniciar()
        {
            Console.Write("ingrese el valor de x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);

            Console.Write("ingrese el valor de y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);
            Console.ReadKey();

        }
        public void calcularcuadrante() { 
        if (x > 0 && y > 0){
                Console.WriteLine("primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("segundo cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("tercer cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("cuarto cuadrante");
            }


            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            plano plano = new plano();
            plano.iniciar();
            plano.calcularcuadrante();
            Console.ReadKey();
        }
    }
}
