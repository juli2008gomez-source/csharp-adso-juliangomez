Console.WriteLine("Hello, I'm Goku!!!");

// Crear una lista
List<string> compras = ["Arroz", "Leche", "Frijol"];
Console.WriteLine($"Tienes antes de agregar {compras.Count} elementos");
compras.Add("Café"); // Permite agregar a una lista
Console.WriteLine($"Tienes despues de agregar {compras.Count} elementos");

//compras.Remove("Leche"); // Permite eliminar un elemento

Console.WriteLine(string.Join(", ", compras));
compras.Sort(); // Ordena la lista
Console.WriteLine(string.Join(", ", compras));
//Console.WriteLine(compras[2]);

Console.WriteLine("==============================");
// Crear un Diccionario

Dictionary<string, string> agenda = new(StringComparer.OrdinalIgnoreCase);

agenda["Ana"] = "3005555555";
agenda["Luis"] = "3154444444";

if (agenda.TryGetValue("hana", out string? telefono))
{
    Console.WriteLine($"Ana: {telefono}");
}

foreach (var (nombre, tel) in agenda)
{
    Console.WriteLine($"{nombre}: {tel}");
}

Console.WriteLine("==============================");

// Diccionario con listas adentro

Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);
notas["Miguel"] = [];
notas["Miguel"].Add(4.5);
notas["Miguel"].Add(3.8);
notas["Miguel"].Add(1);

foreach (var (nombre, nota) in notas)
{
    Console.WriteLine($"{nombre}: {string.Join(" - ", nota)}");
}

Console.WriteLine("==============================");

List<int> numeros = [10, 75, 45, 23, 61, 93, 72, 69, 37, 40, 84, 96];
Console.WriteLine(string.Join(", ", numeros));

var pares = numeros.Where(n => n % 2 == 0).ToList();
Console.WriteLine(string.Join(", ", pares));

var top3 = numeros.OrderByDescending(n => n).Take(3).ToList();
Console.WriteLine(string.Join(", ", top3));

Console.WriteLine($"Suma: {numeros.Sum()}, Promedio: {numeros.Average()}");

Console.WriteLine($"Algún número es mayor a 80? {numeros.Any(n => n > 80)}");
Console.WriteLine($"Números mayores a 80: {string.Join(", ", numeros.Where(n => n > 80))}");

Console.WriteLine("==============================");

// record

List<Producto> productos =
[
    new ("Cuaderno", "Papelería", 6500m, 40),
    new ("Mouse", "Tecnología", 45000m, 3),
    new ("USB 64 Gb", "Tecnología", 3800m, 15)

];

var baratos = productos.Where(p => p.Precio < 10000m);
var masCaro = productos.MaxBy(p => p.Precio);
var masCaro1 = productos.Max(p => p.Precio);
decimal valorInventario = productos.Sum(p => p.Precio * p.Stock);


Console.WriteLine($"Menores a 10000 \n{string.Join("\n", baratos)}");
Console.WriteLine($"Mas caro {masCaro}");
Console.WriteLine($"Mas caro {masCaro1}");
Console.WriteLine($"Valor Inventario {valorInventario}");

var porCategoria = productos
    .GroupBy(p => p.Categoria)
    .Select(g => new { Categoria = g.Key, Unidades = g.Sum(p => p.Stock) });

foreach (var c in porCategoria)
{
    Console.WriteLine($"{c.Categoria,-12} {c.Unidades} unidades");
}