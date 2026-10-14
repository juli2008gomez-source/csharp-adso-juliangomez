using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola universo!!");
            Console.WriteLine("Como te llamas? ");
            String entrada = Console.ReadLine() ?? "";
            String nombre = string.IsNullOrWhiteSpace(entrada) ? "Invitado" : entrada;
            Console.WriteLine("Cual es tu edad?");
            entrada = Console.ReadLine() ?? "";
            int edad = string.IsNullOrWhiteSpace(entrada) ? 0 : Convert .ToInt32(entrada);
            Console.WriteLine("De que ciudad eres? ");
            entrada = Console.ReadLine() ?? "";
            String ciudad = string.IsNullOrWhiteSpace(entrada) ? "Sin Ciudad" : entrada;
            Console.WriteLine($"Su nombre es: {nombre}, usted tiene {edad} años y es de {ciudad}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Este texto sale en verde");
            Console.ResetColor();

            const int numero = 5;
            Console.WriteLine(7 / 2);
            Console.WriteLine(7 / 2.0);
            Console.WriteLine(7 % 2);
            Console.WriteLine((10 + 3) * 2);
        }
    }
}
