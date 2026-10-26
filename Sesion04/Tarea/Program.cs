using System;
using System.Collections.Generic;
using System.Linq;

List<Venta> ventas =
[
    new("Portátil", "Medellín", 2, 2_800_000m),
    new("Mouse", "Bogotá", 10, 45_000m),
    new("Teclado", "Cali", 5, 120_000m),
    new("Monitor", "Medellín", 3, 750_000m),
    new("Mouse", "Medellín", 8, 45_000m),
    new("Portátil", "Bogotá", 1, 2_800_000m),
    new("Diadema", "Cali", 6, 180_000m),
    new("Monitor", "Bogotá", 2, 750_000m),
    new("Teclado", "Medellín", 4, 120_000m),
    new("Diadema", "Bogotá", 3, 180_000m),
    new("Portátil", "Cali", 2, 2_800_000m),
    new("Mouse", "Cali", 12, 45_000m)
];

decimal totalVendido = ventas.Sum(v => v.Cantidad * v.PrecioUnitario);

Console.WriteLine("°°°° Reporte de Ventas °°°°");
Console.WriteLine($"Total vendido: {totalVendido:N0}");

decimal promedioVenta = totalVendido / ventas.Count;

Console.WriteLine($"Promedio por venta: {promedioVenta:N2}");

var ventasPorCiudad = ventas
    .GroupBy(v => v.Ciudad)
    .Select(g => new
    {
        Ciudad = g.Key,
        Total = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(g => g.Total);

Console.WriteLine("\n°°°° VENTAS POR CIUDAD °°°°");

foreach (var ciudad in ventasPorCiudad)
{
    Console.WriteLine($"{ciudad.Ciudad,-12} ${ciudad.Total:N0}");
}

var topProductos = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new
    {
        Producto = g.Key,
        Ingresos = g.Sum(v => v.Cantidad * v.PrecioUnitario)
    })
    .OrderByDescending(g => g.Ingresos)
    .Take(3);

Console.WriteLine("\n°°°° Top 3 Productos por Ingresos °°°°");

int posicion = 1;

foreach (var producto in topProductos)
{
    Console.WriteLine(
        $"{posicion}. {producto.Producto,-12} ${producto.Ingresos:N0}"
    );

    posicion++;
}

var productoMasVendido = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new
    {
        Producto = g.Key,
        Unidades = g.Sum(v => v.Cantidad)
    })
    .OrderByDescending(g => g.Unidades)
    .First();

Console.WriteLine("\n°°°° Producto mas Vendido °°°°");
Console.WriteLine(
    $"{productoMasVendido.Producto}: {productoMasVendido.Unidades} unidades"
);

record Venta(
    string Producto,
    string Ciudad,
    int Cantidad,
    decimal PrecioUnitario
);