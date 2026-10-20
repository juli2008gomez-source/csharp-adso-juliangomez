using System.Text;

//MostrarTitulo("Mis Métodos");
//Console.WriteLine(Sumar(5, 8));
//Console.WriteLine(MensajeConNumeros(15, "Este es el mensaje"));
//Console.WriteLine(EsPar(8));

//// Este es un procedimiento
//static void MostrarTitulo(string mensaje)
//{
//    Console.WriteLine($"=== {mensaje.ToUpper()} ===");
//}

//// Esta es una función
//static int Sumar(int a, int b)
//{
//    return a + b;
//}

//static string MensajeConNumeros(int x, string dato)
//{
//    return $"{dato}, y su numero es {x}";
//}

////static bool EsPar(int numero)
////{
////    return numero % 2 == 0;
////}


//static bool EsPar(int numero) => numero % 2 == 0;

//// Sobrecargas y parametros opcionales

//static double Area(double lado) => lado * lado;
//static double Area1(double ancho, double alto) => ancho * alto;

//Area(4);
//Area1(4, 3);

//static void Saludar(string nombre = "Invitado", string saludo = "Hola")
//{
//    Console.WriteLine($"{saludo}, {nombre}!!");
//}

//Saludar("Edison", "Bienvenido");
//Saludar("DArley");
//Saludar();

//static int Multiplicar(int a = 3, int b = 2) =>  a * b;
////{
////    return a * b;
////}

//Console.WriteLine(Multiplicar(5, 3));
//Console.WriteLine(Multiplicar(9));
//Console.WriteLine(Multiplicar());

//// Métodos Comodín
//static int LeerEntero(string mensaje)
//{
//    Console.Write(mensaje);
//    int valor;
//    while (!int.TryParse(Console.ReadLine(), out valor))
//    {
//        Console.Write("Valor no válido. Intenta de nuevo\nDigite un número entero: ");
//    }
//    return valor;
//}

//Console.WriteLine(LeerEntero("Digite un número entero: "));

//static decimal LeerDecimal(string mensaje)
//{
//    Console.Write(mensaje);
//    decimal valor;
//    while (!decimal.TryParse(Console.ReadLine(), out valor))
//    {
//        Console.Write("Valor no válido. Intenta de nuevo\nDigite un número decimal: ");
//    }
//    return valor;

//}
//Console.WriteLine(LeerDecimal("Digite un número decimal: "));


//// Arreglos y cadenas

//decimal[] notas = new decimal[5]; // Declara el arreglo
//for(int i = 0; i < notas.Length; i++)
//{
//    notas[i] = LeerDecimal($"Nota {i + 1}: ");
//}

//Console.WriteLine(string.Join(" | ", notas)); // Muestra el arreglo


////=== contar vocales en una frase

//static int ContarVocales(string texto)
//{
//    int totalvocales = 0;
//    foreach (char c in texto.ToLower())
//    {
//        if ("aeiouáéíóú".Contains(c))
//            totalvocales++;
//    }
//    return totalvocales;
//}

//Console.WriteLine(ContarVocales("Hola profé Querido"));

//Console.WriteLine(char.IsDigit('7'));
//Console.WriteLine(char.IsDigit('e'));

//Console.WriteLine(char.IsUpper('A'));
//Console.WriteLine(char.IsUpper('a'));

//Console.WriteLine(char.IsLower('A'));
//Console.WriteLine(char.IsLower('a'));

//Console.WriteLine(char.IsWhiteSpace(' '));
//Console.WriteLine(char.IsUpper('x'));


// contar tipos de caracteres en un texto



string texto = "@ Hola, Soy Goku 2026_04 ";
int digitos = 0, mayusculas = 0, minusculas = 0, espacios = 0, especiales = 0;

Console.WriteLine(texto);
foreach (char c in texto)
{
    if (char.IsDigit(c))
        digitos++;
    else if (char.IsUpper(c))
        mayusculas++;
    else if (char.IsLower(c))
        minusculas++;
    else if (char.IsWhiteSpace(c))
        espacios++;
    else if (char.IsSymbol(c))
        especiales++;
}

Console.WriteLine($"Dígitos: {digitos}");
Console.WriteLine($"Mayúsculas: {mayusculas}");
Console.WriteLine($"Minúsculas: {minusculas}");
Console.WriteLine($"Espacio en Blanco: {espacios}");
Console.WriteLine($"Caracteres especiales: {especiales}");


// primera línea del archivo

static string Invertir(string texto)
{
    var sb = new StringBuilder();
    for (int i = texto.Length - 1; i >= 0; i--) sb.Append(texto[i]);
    return sb.ToString();
}