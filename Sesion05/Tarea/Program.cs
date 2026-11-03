using System;
using Tarea;

// Crear dos cuentas
CuentaBancaria cuenta1 = new CuentaBancaria(
    "Jeferson Rodriguez", "001", 100000m);

CuentaBancaria cuenta2 = new CuentaBancaria(
    "Roger Suarez", "002", 50000m);

Console.WriteLine("°°°° SALDOS INICIALES °°°°");
Console.WriteLine(cuenta1);
Console.WriteLine(cuenta2);

// Realizar un depósito
Console.WriteLine("\n°°°° DEPÓSITO °°°°");

if (cuenta1.Depositar(25000m))
    Console.WriteLine("Depósito realizado correctamente.");
else
    Console.WriteLine("No se pudo realizar el depósito.");

// Intentar un retiro superior al saldo
Console.WriteLine("\n°°°° RETIRO °°°°");

if (cuenta1.Retirar(200000m))
    Console.WriteLine("Retiro realizado correctamente.");
else
    Console.WriteLine("Retiro rechazado: saldo insuficiente.");

// Transferir dinero entre las cuentas
Console.WriteLine("\n°°°° TRANSFERENCIA °°°");

if (cuenta1.Transferir(cuenta2, 30000m))
    Console.WriteLine("Transferencia realizada correctamente.");
else
    Console.WriteLine("No se pudo realizar la transferencia.");

// Mostrar los saldos finales
Console.WriteLine("\n°°°° SALDOS FINALES °°°°");
Console.WriteLine(cuenta1);
Console.WriteLine(cuenta2);