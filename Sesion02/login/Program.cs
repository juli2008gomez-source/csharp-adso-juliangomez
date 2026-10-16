using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su Usuario: ");
            string user = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese su Contraseña: ");
            string pass = Console.ReadLine().ToLower().Trim();
            if (user == "admin" && pass == "12345"){
                Console.WriteLine("Bienvenido al sistema");
                Console.WriteLine("Calculadora con Switch");
                Console.WriteLine("Digite el valor para A: ");
                string entrada = Console.ReadLine().Trim();
                int a = Convert.ToInt32(entrada);
                Console.WriteLine("Digite el valor para B: ");
                float b = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Digite la opcion deseada: ");
                //Console.WriteLine("1. Sumar");
                //Console.WriteLine("2. Restar");
                //Console.WriteLine("3. Multiplicar");
                //Console.WriteLine("4. Dividir");

                Console.WriteLine("Menu de opciones:\n1.sumar\n2.restar\n3.multiplicar\n4.dividir\n5.");
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc) 
                {
                    case 1:
                        Console.WriteLine($"La Suma de {a} + {b} es {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"La Resta de {a} - {b} es {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"La Multiplicacion de {a} * {b} es {a * b}");
                        break;
                    case 4:
                        if (b == 0)
                            Console.WriteLine("No se puede dividir entre 0");
                        else
                            Console.WriteLine($"La Division de {a} / {b} es {a / b}");
                            break;
                    case 5: 
                        double nota = Convert.ToDouble(Console.ReadLine());
                        if(nota < 0 || nota > 5)
                            Console.WriteLine("La nota debe ser entre 0.0 y 5.0");
                        else
                        {
                            if (nota <= 3.0)
                                Console.WriteLine("Nota Deficiente");
                            else if (nota < 4)
                                Console.WriteLine("Nota Aceptable");
                            else if (nota < 4.6)
                                Console.WriteLine("Nota Sobresaliente");
                            else
                                Console.WriteLine("Nota Exelente");
                        }
                        break;
             
                    default:
                        Console.WriteLine("Eleccion Incorrecta");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error en el usuario o contraseña");
            }

        }
    }
}
