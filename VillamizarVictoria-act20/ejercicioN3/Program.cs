using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN3
{
    /*Actividad 3: Estadísticas de visitas a zonas arqueológicas
    Problema:
    Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
    arqueológicas durante 4 semanas.
    Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
    días. Luego:
     Calcular el total de visitas por zona y almacenarlo en un vector.
     Mostrar los datos en forma tabular.
     Agregar estos resultados a una lista llamada zonasVisitadas que contenga
    nombres de zonas y total de visitas.
     Determinar cuál fue la zona más visitada.*/
        class ZonaArqueologica
        {
            private string nombre;
            private int totalVisitas;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public int TotalVisitas
            {
                get { return totalVisitas; }
                set { totalVisitas = value; }
            }
        }

        class Instituto
        {
            private int[,] visitas =new int[3, 4];
            private int[] totales =new int[3];
            private string[] nombres ={"Zona Norte", "Zona Centro", "Zona Sur" };

            private List<ZonaArqueologica> zonasVisitadas = new List<ZonaArqueologica>();

            public void CargarDatos()
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(
                        nombres[i]);

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write("semana " +(j + 1) + ": ");
                        visitas[i, j] = int.Parse( Console.ReadLine());
                        totales[i] += visitas[i, j];
                    }
                    Console.WriteLine();
                }
            }

            public void MostrarTabla()
            {
                Console.WriteLine("VISITAS");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(nombres[i] + " ");

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(visitas[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }

            public void GenerarLista()
            {
                for (int i = 0; i < 3; i++)
                {
                    ZonaArqueologica z =new ZonaArqueologica();
                    z.Nombre = nombres[i];
                    z.TotalVisitas =totales[i];

                    zonasVisitadas.Add(z);
                }
            }
            public void MostrarZonaMasVisitada()
            {
                int mayor = 0;

                for (int i = 1;
                    i < zonasVisitadas.Count;
                    i++)
                {
                    if (zonasVisitadas[i].TotalVisitas > zonasVisitadas[mayor].TotalVisitas)
                    {
                        mayor = i;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("zona mas visitada: " + zonasVisitadas[mayor] .Nombre);

                Console.WriteLine("total de visitas: " + zonasVisitadas[mayor].TotalVisitas);
            }
            static void Main(string[] args)
            {
                Instituto instituto1 = new Instituto();
                instituto1.CargarDatos();
                instituto1.MostrarTabla();
                instituto1.GenerarLista();
                instituto1.MostrarZonaMasVisitada();

                Console.ReadKey();
            }
        }
}

