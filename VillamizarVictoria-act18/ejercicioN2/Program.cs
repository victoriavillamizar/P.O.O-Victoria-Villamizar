using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    class CriaturaMarina
    {
        /*2.Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
        La clase CriaturaMarina debe tener como atributos privados: Especie (string),
        ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
        propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
        ● La profundidad óptima sea estrictamente mayor a cero (0).
        ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
        asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
        La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
        de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
        criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
        a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
        nivel de salinidad para sobrevivir.*/

            private string especie;
            private int profundidadOptima;
            private int nivelSalinidad;

            public string Especie
            {
                get { return especie; }
                set { especie = value; }
            }

            public int ProfundidadOptima
            {
                get { return profundidadOptima; }
                set
                {
                    if (value > 0)
                        profundidadOptima = value;
                }
            }

            public int NivelSalinidad
            {
                get { return nivelSalinidad; }
                set
                {
                    if (value >= 1 && value <= 100)
                        nivelSalinidad = value;
                    else
                        nivelSalinidad = 35;
                }
            }
        }

        class HabitatAcuatico
        {
            private CriaturaMarina[] criaturas = new CriaturaMarina[3];

            public void CargarCriaturas()
            {
                for (int i = 0; i < criaturas.Length; i++)
                {
                    criaturas[i] = new CriaturaMarina();

                    Console.WriteLine("criatura " + (i + 1));

                    Console.Write("especie: ");
                    criaturas[i].Especie = Console.ReadLine();

                    Console.Write("profundidad optima (metros): ");
                    criaturas[i].ProfundidadOptima = int.Parse(Console.ReadLine());

                    Console.Write("nivel de salinidad: ");
                    criaturas[i].NivelSalinidad = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                }
            }

            public void MostrarOrdenadas()
            {
                for (int i = 0; i < criaturas.Length - 1; i++)
                {
                    for (int j = i + 1; j < criaturas.Length; j++)
                    {
                        if (criaturas[i].ProfundidadOptima >
                            criaturas[j].ProfundidadOptima)
                        {
                            CriaturaMarina aux = criaturas[i];
                            criaturas[i] = criaturas[j];
                            criaturas[j] = aux;
                        }
                    }
                }
                Console.WriteLine("criaturas ordenadas por profundidad");
                Console.WriteLine();

                for (int i = 0; i < criaturas.Length; i++)
                {
                    Console.WriteLine("epecie: " + criaturas[i].Especie);
                    Console.WriteLine("profundidad: " + criaturas[i].ProfundidadOptima + " metros");
                    Console.WriteLine("salinidad: " + criaturas[i].NivelSalinidad);
                    Console.WriteLine();
                }
            }

            public void MostrarMayorSalinidad()
            {
                int mayor = 0;

                for (int i = 1; i < criaturas.Length; i++)
                {
                    if (criaturas[i].NivelSalinidad >
                        criaturas[mayor].NivelSalinidad)
                    {
                        mayor = i;
                    }
                }
                Console.WriteLine("la especie que requiere mayor nivel de salinidad es: " + criaturas[mayor].Especie);
            }
        

            static void Main(string[] args)
            {
                HabitatAcuatico habitat = new HabitatAcuatico();
                habitat.CargarCriaturas();
                Console.WriteLine();
                habitat.MostrarOrdenadas();
                habitat.MostrarMayorSalinidad();
                Console.ReadKey();
            }
        }
}