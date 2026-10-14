using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas
{
    internal class Program
    {
        static void Main(string[] args)
        {
                int opcion = 0;

                while (opcion != 4)
                {
                    Console.WriteLine("\n===== MENU PRINCIPAL =====");
                    Console.WriteLine("1. Convertir segundos a reloj");
                    Console.WriteLine("2. Convertir Celsius a Fahrenheit");
                    Console.WriteLine("3. Calcular promedio de 3 notas");
                    Console.WriteLine("4. Salir");
                    Console.Write("Seleccione una opcion: ");

                    if (int.TryParse(Console.ReadLine(), out opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                int segundos;

                                Console.Write("Ingrese los segundos: ");

                                if (int.TryParse(Console.ReadLine(), out segundos)
                                    && segundos >= 0)
                                {
                                    int horas = segundos / 3600;
                                    int minutos = (segundos % 3600) / 60;
                                    int seg = segundos % 60;

                                    Console.WriteLine(
                                        horas + " h " + minutos + " min " + seg + " s");
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese segundos validos.");
                                }
                                break;

                            case 2:
                                double celsius;

                                Console.Write("Ingrese los grados Celsius: ");

                                if (double.TryParse(Console.ReadLine(), out celsius))
                                {
                                    double fahrenheit = celsius * 9 / 5 + 32;

                                    Console.WriteLine("Fahrenheit: " + fahrenheit);
                                }
                                else
                                {
                                    Console.WriteLine("Ingrese una temperatura valida.");
                                }
                                break;

                            case 3:
                                double nota1, nota2, nota3;

                                Console.Write("Ingrese la primera nota (0 a 5): ");

                                if (!double.TryParse(Console.ReadLine(), out nota1)
                                    || nota1 < 0 || nota1 > 5)
                                {
                                    Console.WriteLine("Nota invalida.");
                                    break;
                                }

                                Console.Write("Ingrese la segunda nota (0 a 5): ");

                                if (!double.TryParse(Console.ReadLine(), out nota2)
                                    || nota2 < 0 || nota2 > 5)
                                {
                                    Console.WriteLine("Nota invalida.");
                                    break;
                                }

                                Console.Write("Ingrese la tercera nota (0 a 5): ");

                                if (!double.TryParse(Console.ReadLine(), out nota3)
                                    || nota3 < 0 || nota3 > 5)
                                {
                                    Console.WriteLine("Nota invalida.");
                                    break;
                                }

                                double promedio = (nota1 + nota2 + nota3) / 3;

                                Console.WriteLine("Promedio: " + promedio.ToString("F1"));
                                break;

                            case 4:
                                Console.WriteLine("Programa finalizado.");
                                break;

                            default:
                                Console.WriteLine("Opcion no valida.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un numero.");
                        opcion = 0;
                    }
                }
            }
        }
    }
