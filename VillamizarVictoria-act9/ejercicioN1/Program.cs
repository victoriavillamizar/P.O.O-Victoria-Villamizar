using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    class datosestudiantes
    {
        /*1. Se desea desarrollar un programa que permita registrar los nombres y las
        calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
        nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
        estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
        máxima o mínima.*/

        private int[] calificacion;
        private string[] alumno;

        public void cargarvalores()
        {
            alumno = new string[6];
            calificacion = new int[6];

            Console.WriteLine("ingrese los nombres de los 6 alumnos:");

            for (int i = 0; i < alumno.Length; i++)
            {
                alumno[i] = Console.ReadLine();
            }

            string linea;

            for (int i = 0; i < alumno.Length; i++)
            {
                Console.WriteLine("ingrese la calificacion del alumno: " + alumno[i]);
                linea = Console.ReadLine();
                calificacion[i] = int.Parse(linea);
            }
        }

        public void datosEstudiantes()
        {
            int notaAlta = calificacion[0];
            int baja = calificacion[0];

            for (int i = 0; i < alumno.Length; i++)
            {
                if (notaAlta < calificacion[i])
                {
                    notaAlta = calificacion[i];
                }

                if (baja > calificacion[i])
                {
                    baja = calificacion[i];
                }
            }

            int contadorAlta = 0;
            int contadorBaja = 0;

            Console.WriteLine("el/los alumnos con la mayor nota es:");

            for (int i = 0; i < alumno.Length; i++)
            {
                if (notaAlta == calificacion[i])
                {
                    Console.WriteLine(alumno[i] + ": " + calificacion[i]);
                    contadorAlta++;
                }
            }

            Console.WriteLine("el/los alumnos con la menor nota es:");

            for (int i = 0; i < alumno.Length; i++)
            {
                if (baja == calificacion[i])
                {
                    Console.WriteLine(alumno[i] + ": " + calificacion[i]);
                    contadorBaja++;
                }
            }

            if (contadorAlta > 1)
            {
                Console.WriteLine("hay estudiantes con la misma nota maxima");
            }

            if (contadorBaja > 1)
            {
                Console.WriteLine("hay estudiantes con la misma nota minima");
            }
        }

        static void Main(string[] args)
        {
            datosestudiantes estudiantes = new datosestudiantes();
            estudiantes.cargarvalores();
            estudiantes.datosEstudiantes();
            Console.ReadKey();
        }
    }
}
