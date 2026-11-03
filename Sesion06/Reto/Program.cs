using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

List<Empleado> nomina =
[
    new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
    new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
    new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
    new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
    new Contratista("Sofía León", "1005", 4_000_000m)
];

Console.WriteLine("°°°°°° NÓMINA DE EMPLEADOS °°°°°°\n");

foreach (Empleado empleado in nomina)
{
    Console.WriteLine(empleado);
}

decimal total = nomina.Sum(e => e.CalcularSalario());

Console.WriteLine("\n°°°°°° RESUMEN °°°°°°");
Console.WriteLine($"Total de nómina: {total.ToString("C0", cultura)}");

Empleado mayorPago = nomina.MaxBy(e => e.CalcularSalario())!;

Console.WriteLine(
    $"Mayor pago: {mayorPago.Nombre} - " +
    $"{mayorPago.CalcularSalario().ToString("C0", cultura)}"
);

Console.WriteLine("\n°°°°°° TOTAL POR TIPO °°°°°°");

var totalesPorTipo = nomina.GroupBy(e => e.Tipo);

foreach (var grupo in totalesPorTipo)
{
    decimal subtotal = grupo.Sum(e => e.CalcularSalario());

    Console.WriteLine(
        $"{grupo.Key}: {subtotal.ToString("C0", cultura)}"
    );
}

decimal totalBonos = nomina
    .OfType<IBonificable>()
    .Sum(e => e.CalcularBono());

Console.WriteLine(
    $"\nTotal de bonificaciones: {totalBonos.ToString("C0", cultura)}"
);

public abstract class Empleado
{
    public string Nombre { get; }
    public string Documento { get; }

    public virtual string Tipo => "Empleado";

    protected Empleado(string nombre, string documento)
    {
        Nombre = nombre;
        Documento = documento;
    }

    public abstract decimal CalcularSalario();

    public override string ToString()
    {
        return $"{Tipo,-18} | {Nombre,-15} | Documento: {Documento} | " +
               $"Pago: {CalcularSalario().ToString("C0", CultureInfo.GetCultureInfo("es-CO"))}";
    }
}

public interface IBonificable
{
    decimal CalcularBono();
}

public class EmpleadoPlanta : Empleado, IBonificable
{
    public decimal SalarioMensual { get; }
    public int AniosAntiguedad { get; }

    public override string Tipo => "Empleado de planta";

    public EmpleadoPlanta(
        string nombre,
        string documento,
        decimal salarioMensual,
        int aniosAntiguedad
    ) : base(nombre, documento)
    {
        SalarioMensual = salarioMensual;
        AniosAntiguedad = aniosAntiguedad;
    }

    public decimal CalcularBono()
    {
        return AniosAntiguedad >= 5
            ? SalarioMensual * 0.05m
            : 0m;
    }

    public override decimal CalcularSalario()
    {
        return SalarioMensual + CalcularBono();
    }
}

public class EmpleadoPorHoras : Empleado
{
    public int Horas { get; }
    public decimal ValorHora { get; }

    public override string Tipo => "Empleado por horas";

    public EmpleadoPorHoras(
        string nombre,
        string documento,
        int horas,
        decimal valorHora
    ) : base(nombre, documento)
    {
        Horas = horas;
        ValorHora = valorHora;
    }

    public override decimal CalcularSalario()
    {
        int horasNormales = Math.Min(Horas, 160);
        int horasExtras = Math.Max(Horas - 160, 0);

        return (horasNormales * ValorHora)
             + (horasExtras * ValorHora * 1.5m);
    }
}

public class Contratista : Empleado
{
    public decimal ValorContrato { get; }

    public override string Tipo => "Contratista";

    public Contratista(
        string nombre,
        string documento,
        decimal valorContrato
    ) : base(nombre, documento)
    {
        ValorContrato = valorContrato;
    }

    public override decimal CalcularSalario()
    {
        return ValorContrato * 0.90m;
    }
}