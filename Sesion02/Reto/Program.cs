using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al cajero");
            int saldo = 500000;
            int i = 0;
            int transaciones = 0;

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite su pin");
                string pin = Console.ReadLine();


                if (pin == "1234")

                {
                    Console.WriteLine("\n1 consultar saldo\n2 depositar \n3 retirar \n4 salir");

                    string opc = Console.ReadLine();
                    i = 5;
                    while (opc != "4")
                    {

                        switch (opc)
                        {
                            case "1":
                                Console.WriteLine($"su saldo actual es {saldo} ");
                                transaciones += 1;
                                break;

                            case "2":
                                int depositar = 0;
                                do
                                {
                                    Console.WriteLine("Cuanto va a depositar ");
                                } while (!int.TryParse(Console.ReadLine(), out depositar));
                                saldo += depositar;
                                Console.WriteLine($"consignacion exitosa y su saldo actual es {saldo}");
                                transaciones++;
                                break;
                            case "3":
                                int retirar = 0;
                                do
                                {
                                    Console.WriteLine("Cuanto va a retirar");

                                } while (!int.TryParse(Console.ReadLine(), out retirar) || retirar < 0 || retirar > saldo);
                                if (retirar % 10000 == 0)
                                    saldo -= retirar;
                                Console.WriteLine($"Retiro exitos y su saldo actual es {saldo}");
                                transaciones++;
                                break;
                            default:
                                Console.WriteLine("seleccion erronea");
                                break;

                        }
                        Console.WriteLine("\n1 consultar saldo,\n2 depositar, \n3 retirar, \n4 salir");

                        opc = Console.ReadLine();
                    }
                }
            }

            if (i == 3)
                Console.WriteLine("tarjeta bloqueada");
            else
            {
                Console.WriteLine("transaccion finalizada");
                Console.WriteLine($"Cantidad de transacciones {transaciones}");
            }
        }
    }
}
