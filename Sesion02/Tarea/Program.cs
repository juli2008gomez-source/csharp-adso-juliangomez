using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Random random = new Random();
                int secreto = random.Next(1, 101);

                int intentos = 0;
                bool acertado = false;

                for (int i = 1; i <= 7; i++)
                {
                    Console.WriteLine("Digite el numero a encontrar:");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    intentos = i;

                    if (numero == secreto)
                    {
                        Console.WriteLine($"¡Correcto! Adivinaste en {intentos} intentos.");
                        acertado = true;
                        break;
                    }
                    else if (numero < secreto)
                    {
                        Console.WriteLine("El numero secreto es mayor.");
                    }
                    else
                    {
                        Console.WriteLine("El numero secreto es menor.");
                    }
                }

                if (!acertado)
                {
                    Console.WriteLine($"Se acabaron los intentos. El numero secreto era {secreto}.");
                }

            }
        }
    }
