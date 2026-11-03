using System;
using System.Globalization;
using System.Linq;

CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

IMetodoPago efectivo = new PagoEfectivo();
IMetodoPago tarjeta = new PagoTarjeta("1234567890123456");
IMetodoPago billetera = new PagoBilletera();

ProcesadorPagos procesador = new ProcesadorPagos();

Console.WriteLine("°°°°°° SISTEMA DE PAGOS °°°°°°\n");

procesador.Cobrar(efectivo, 100_000m);
procesador.Cobrar(tarjeta, 500_000m);
procesador.Cobrar(billetera, 200_000m);

procesador.Cobrar(billetera, 2_500_000m);

Console.WriteLine("\n°°°°°° DEVOLUCIONES °°°°°°\n");

procesador.Devolver(efectivo, 50_000m);
procesador.Devolver(tarjeta, 100_000m);
procesador.Devolver(billetera, 80_000m);

public interface IMetodoPago
{
    string Nombre { get; }
    decimal CalcularComision(decimal monto);
    bool Validar(decimal monto);
}

public interface IReembolsable
{
    void Reembolsar(decimal monto);
}

public class PagoEfectivo : IMetodoPago
{
    public string Nombre => "Efectivo";

    public decimal CalcularComision(decimal monto)
    {
        return 0m;
    }

    public bool Validar(decimal monto)
    {
        return monto > 0;
    }
}

public class PagoTarjeta : IMetodoPago, IReembolsable
{
    public string Nombre => "Tarjeta";

    public string Numero { get; }

    public PagoTarjeta(string numero)
    {
        Numero = numero;
    }

    public decimal CalcularComision(decimal monto)
    {
        return monto * 0.03m;
    }

    public bool Validar(decimal monto)
    {
        return monto > 0 &&
               Numero.Length == 16 &&
               Numero.All(char.IsDigit);
    }

    public void Reembolsar(decimal monto)
    {
        Console.WriteLine($"Reembolso a tarjeta: {monto.ToString("C0", CultureInfo.GetCultureInfo("es-CO"))}");
    }
}

public class PagoBilletera : IMetodoPago, IReembolsable
{
    public string Nombre => "Billetera";

    public decimal CalcularComision(decimal monto)
    {
        return monto * 0.01m;
    }

    public bool Validar(decimal monto)
    {
        return monto > 0 && monto <= 2_000_000m;
    }

    public void Reembolsar(decimal monto)
    {
        Console.WriteLine($"Reembolso a billetera: {monto.ToString("C0", CultureInfo.GetCultureInfo("es-CO"))}");
    }
}

public class ProcesadorPagos
{
    private readonly CultureInfo cultura =
        CultureInfo.GetCultureInfo("es-CO");

    public bool Cobrar(IMetodoPago metodo, decimal monto)
    {
        if (!metodo.Validar(monto))
        {
            Console.WriteLine($"Pago rechazado: {metodo.Nombre}. Datos no válidos.");
            return false;
        }

        decimal comision = metodo.CalcularComision(monto);
        decimal total = monto + comision;

        Console.WriteLine($"Método: {metodo.Nombre}");
        Console.WriteLine($"Monto: {monto.ToString("C0", cultura)}");
        Console.WriteLine($"Comisión: {comision.ToString("C0", cultura)}");
        Console.WriteLine($"Total a pagar: {total.ToString("C0", cultura)}");
        Console.WriteLine("----------------------------------");

        return true;
    }

    public bool Devolver(IMetodoPago metodo, decimal monto)
    {
        if (monto <= 0)
        {
            Console.WriteLine("El monto del reembolso debe ser mayor que cero.");
            return false;
        }

        if (metodo is IReembolsable reembolsable)
        {
            reembolsable.Reembolsar(monto);
            return true;
        }

        Console.WriteLine($"El método {metodo.Nombre} no permite reembolsos.");
        return false;
    }
}