using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("===== CALCULADORA DE PROPINAS =====");
                Console.ResetColor();

                Console.Write("Total de la cuenta: ");
                double total;

                if (!double.TryParse(Console.ReadLine(), out total) || total <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, ingrese un total valido.");
                    Console.ResetColor();
                    return;
                }

                Console.Write("Porcentaje de propina: ");
                double porcentaje;

                if (!double.TryParse(Console.ReadLine(), out porcentaje)
                    || porcentaje < 0 || porcentaje > 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, ingrese un porcentaje entre 0 y 100.");
                    Console.ResetColor();
                    return;
                }

                Console.Write("Numero de personas: ");
                int personas;

                if (!int.TryParse(Console.ReadLine(), out personas) || personas <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, ingrese un numero de personas mayor que cero.");
                    Console.ResetColor();
                    return;
                }

                double propina = total * porcentaje / 100;
                double totalFinal = total + propina;
                double porPersona = totalFinal / personas;

                CultureInfo cultura = new CultureInfo("es-CO");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n===== RESULTADOS =====");
                Console.WriteLine("Propina: " + propina.ToString("C0", cultura));
                Console.WriteLine("Total: " + totalFinal.ToString("C0", cultura));
                Console.WriteLine("Cada persona paga: " + porPersona.ToString("C0", cultura));
                Console.ResetColor();
            }
        }
    }
}
