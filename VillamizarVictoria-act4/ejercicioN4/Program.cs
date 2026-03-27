using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioN4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
            // cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            //finalizar al ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes informe: ) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:
            // Estado de la cuenta:
            //○ “Acreedor” si el saldo es &gt; 0.
            //○ “Deudor” si el saldo es &lt; 0.
            //○ “Nulo” si el saldo es = 0.
            //b) La suma total de los saldos acreedores.


            int numdecuenta, saldo, total;
            string linea;

            total = 0;
            string[] estado = new string[0];
            int[] numerocuenta = new int[0];
            
            

            do
            {
                Console.WriteLine("ingrese el numero de cuenta: ");
                linea = Console.ReadLine();
                numdecuenta = int.Parse(linea);

                if (numdecuenta >= 0)
                {
                    string estadodelacuenta;
                    numerocuenta = numerocuenta.Append(numdecuenta).ToArray();
                    Console.WriteLine("ingrese el saldo de la cuenta: ");
                    linea = Console.ReadLine();
                    saldo = int.Parse(linea);

                    if (saldo > 0)
                    {
                        total = total + saldo;
                        estadodelacuenta = "acreedor";
                    }
                    else{
                        if (saldo < 0)
                        {
                            estadodelacuenta = "deudor";
                        }
                            else{
                                estadodelacuenta = "nulo";
                        }
                    }
                    estado = estado.Append(estadodelacuenta).ToArray();

                }
            }
            while (numdecuenta >= 0);
                for (int i = 0; i < numerocuenta.Length; i++)
            {
                Console.WriteLine("numero de cuenta: " + numerocuenta[i]);

                Console.WriteLine("estado de la cuenta: " + estado[i]);
            }
            Console.WriteLine("la suma total de los acreedores es: " + total);

            Console.ReadKey();
        }

        
    }
}
