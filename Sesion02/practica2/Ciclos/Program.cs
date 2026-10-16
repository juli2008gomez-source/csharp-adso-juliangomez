using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Ciclos
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"Valor {i}");
            //}
            //Cilos do - while 

            //int edad;
            //do
            //{
            //    console.writeline("digite su edad: ");

            //    while (!int.tryparse(console.readline(), out edad) || edad < 1 || > 120);

            //}

            double numero;
            do
            {
                Console.WriteLine("Digite un numero para generar la tabla de multiplicar");
            } while (!double.TryParse(Console.ReadLine(), out numero));
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

        }
    }
}
