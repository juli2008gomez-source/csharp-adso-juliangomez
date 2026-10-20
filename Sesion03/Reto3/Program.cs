string contrasena;
bool esFuerte = false;

Console.OutputEncoding = System.Text.Encoding.UTF8;

do
{
    Console.Write("\nIngrese una contraseña: ");
    contrasena = Console.ReadLine() ?? "";

    esFuerte = EvaluarContrasena(contrasena);

} while (!esFuerte);

Console.WriteLine("Contraseña fuerte");


static bool EvaluarContrasena(string clave)
{
    bool tieneMayuscula = false;
    bool tieneMinuscula = false;
    bool tieneNumero = false;
    bool tieneEspecial = false;

    foreach (char caracter in clave)
    {
        if (char.IsUpper(caracter))
            tieneMayuscula = true;

        if (char.IsLower(caracter))
            tieneMinuscula = true;

        if (char.IsDigit(caracter))
            tieneNumero = true;

        if (!char.IsWhiteSpace(caracter))
            tieneEspecial = true;
    }

    bool[] reglas =
    {
            clave.Length >= 8,
            tieneMayuscula,
            tieneMinuscula,
            tieneNumero,
            tieneEspecial,
            !clave.Contains(' ')
        };

    string[] nombres =
    {
            "Mínimo 8 caracteres",
            "Una mayúscula",
            "Una minúscula",
            "Un número",
            "Un carácter especial",
            "Sin espacios"
        };

    int puntos = 0;

    for (int i = 0; i < reglas.Length; i++)
    {
        if (reglas[i])
            puntos++;

        Console.WriteLine(
            $"{(reglas[i] ? "✅" : "❎")} {nombres[i]}"
        );
    }

    string nivel;

    if (puntos == 6)
        nivel = "Fuerte";
    else if (puntos >= 4)
        nivel = "Media";
    else
        nivel = "Débil";

    Console.WriteLine($"Nivel: {nivel} ({puntos}/6)");

    return puntos == 6;
}