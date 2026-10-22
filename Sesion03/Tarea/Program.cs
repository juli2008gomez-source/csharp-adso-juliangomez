
using System;
using System.Text;

class Program
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n========= Menu =========");
            Console.WriteLine("1. Generador de usuarios");
            Console.WriteLine("2. Analizador de frases");
            Console.WriteLine("3. Salir");
            Console.Write("Seleccione una opcion: ");

            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Ingrese una opcion valida.");
                Console.ReadKey();
                continue;
            }

            switch (opcion)
            {
                case 1:
                    GeneradorUsuarios();
                    break;

                case 2:
                    AnalizadorFrases();
                    break;

                case 3:
                    Console.WriteLine("Programa finalizado.");
                    break;

                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }
        } while (opcion != 3);
    }

    static void GeneradorUsuarios()
    {
        Console.WriteLine("\nGENERADOR DE USUARIOS");

        Console.Write("Ingrese el nombre completo: ");
        string nombre = Console.ReadLine() ?? "";

        Console.Write("Ingrese el documento: ");
        string documento = Console.ReadLine() ?? "";

        string[] partes = nombre.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries
        );

        if (partes.Length < 2 || documento.Length < 2 ||
            !long.TryParse(documento, out _))
        {
            Console.WriteLine("Ingrese un nombre completo y un documento valido.");
            return;
        }

        string apellido;

        if (partes.Length == 4)
        {
            apellido = partes[2];
        }
        else
        {
            apellido = partes[1];
        }

        string primeraLetra = partes[0].Substring(0, 1);

        string ultimosDigitos = documento.Substring(
            documento.Length - 2
        );

        string usuario = primeraLetra + apellido + ultimosDigitos;

        usuario = QuitarTildes(usuario).ToLowerInvariant();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Usuario generado: " + usuario);
        Console.ResetColor();
    }

    static void AnalizadorFrases()
    {
        Console.WriteLine("\nANALIZADOR DE FRASES");

        Console.Write("Ingrese una frase: ");
        string frase = Console.ReadLine() ?? "";

        string[] palabras = frase.Split(
            (char[])null,
            StringSplitOptions.RemoveEmptyEntries);

        StringBuilder fraseInvertida = new StringBuilder();

        for (int i = palabras.Length - 1; i >= 0; i--)
        {
            fraseInvertida.Append(palabras[i]);

            if (i > 0)
            {
                fraseInvertida.Append(" ");
            }
        }

        Console.WriteLine("Cantidad de palabras: " + palabras.Length);
        Console.WriteLine("Frase en orden inverso: " + fraseInvertida);
    }

    static string QuitarTildes(string texto)
    {
        return texto
            .Replace("á", "a")
            .Replace("é", "e")
            .Replace("í", "i")
            .Replace("ó", "o")
            .Replace("ú", "u")
            .Replace("Á", "A")
            .Replace("É", "E")
            .Replace("Í", "I")
            .Replace("Ó", "O")
            .Replace("Ú", "U")
            .Replace("ñ", "n")
            .Replace("Ñ", "N");
    }
}