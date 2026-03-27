using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que lea los lados de n triángulos, e informar
            //a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
            //iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
            //b) Cantidad de triángulos de cada tipo.
            //c) Tipo de triángulo que posee menor cantidad.

            int numtriangulo, contequi, contisos, contesca, lado1, lado2, lado3;
            string linea;
            contequi = 0;
            contesca = 0;
            contisos = 0;


            Console.Write("ingrese numeros de triangulos");
            linea = Console.ReadLine();
            numtriangulo = int.Parse(linea);

            for (int i = 1; i < numtriangulo; i++)
            {
                Console.Write("ingrese un lado del triangulo");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);

                Console.Write("ingrese un segundo lado del triangulo");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);

                Console.Write("ingrese tercer lado del triangulo");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);

                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("este triangulo equilatero");
                    contequi++;
                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        Console.WriteLine("este triangulo isosceles");
                        contisos++;
                    }
                    else
                    {
                        Console.WriteLine("este triangulo escaleno");
                        contesca++;
                    }
                }
            }
                    Console.WriteLine("la cantidad de triangulos equilateros son: " + contequi);
                    Console.WriteLine("la cantidad de triangulos isosceles son: " + contisos);
                    Console.WriteLine("la cantidad de triangulos escalenos son: " + contesca);

                    if(contequi<contesca && contequi < contisos)
                    {
                        Console.WriteLine("los triangulos equilateros poseen menor cantidad de triangulos");
                    }
                    else
                    {
                        if(contesca<contequi&& contesca < contisos)
                        {
                            Console.WriteLine("los triangulos escalenos poseen menor cantidad de triangulos");
                        }
                        else
                        {
                            Console.WriteLine("los triangulos isosceles poseen menor cantidad de triangulos");
                        }
                        Console.ReadKey();

                    }



                



            }


        }
    }

