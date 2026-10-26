using System;
using System.Collections.Generic;
using System.Linq;

Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);

int opcion;

do
{
    Console.WriteLine("\n°°°° Menu de Opciones °°°°");
    Console.WriteLine("1. Registrar aprendiz");
    Console.WriteLine("2. Agregar nota");
    Console.WriteLine("3. Listar aprendices");
    Console.WriteLine("4. Ranking");
    Console.WriteLine("5. Mejor aprendiz y aprobados");
    Console.WriteLine("6. Eliminar aprendiz");
    Console.WriteLine("7. Reporte por nivel");
    Console.WriteLine("8. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        opcion = 0;
    }

    switch (opcion)
    {
        case 1:
            {
                Console.Write("Nombre del aprendiz: ");
                string nombreRegistro = Console.ReadLine()?.Trim() ?? "";

                if (nombreRegistro == "")
                {
                    Console.WriteLine("El nombre no puede estar vacío");
                    break;
                }

                if (notas.ContainsKey(nombreRegistro))
                {
                    Console.WriteLine("El aprendiz ya está registrado");
                    break;
                }

                notas[nombreRegistro] = new List<double>();

                Console.WriteLine("Aprendiz registrado correctamente");
                break;
            }

        case 2:
            {
                Console.Write("Nombre del aprendiz: ");
                string nombreNota = Console.ReadLine()?.Trim() ?? "";

                if (!notas.ContainsKey(nombreNota))
                {
                    Console.WriteLine("El aprendiz no existe");
                    break;
                }

                Console.Write("Ingrese la nota (0 a 5): ");

                if (!double.TryParse(Console.ReadLine(), out double nota))
                {
                    Console.WriteLine("Ingrese un número válido");
                    break;
                }

                if (nota < 0 || nota > 5)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 5");
                    break;
                }

                notas[nombreNota].Add(nota);

                Console.WriteLine("Nota agregada correctamente");
                break;
            }

        case 3:
            {
                if (notas.Count == 0)
                {
                    Console.WriteLine("No hay aprendices registrados");
                    break;
                }

                foreach (var aprendiz in notas)
                {
                    string nombreAprendiz = aprendiz.Key;
                    List<double> listaNotas = aprendiz.Value;

                    if (listaNotas.Count == 0)
                    {
                        Console.WriteLine(
                            $"{nombreAprendiz,-15} 0 notas · Sin promedio · Sin juicio"
                        );

                        continue;
                    }

                    double promedio = listaNotas.Average();
                    string juicio = promedio >= 3.0 ? "A" : "D";

                    Console.WriteLine(
                        $"{nombreAprendiz,-15} {listaNotas.Count} notas · " +
                        $"Promedio {promedio:N1} · Juicio {juicio}"
                    );
                }

                break;
            }

        case 4:
            {
                var ranking = notas
                    .Where(a => a.Value.Count > 0)
                    .OrderByDescending(a => a.Value.Average())
                    .ToList();

                if (ranking.Count == 0)
                {
                    Console.WriteLine("No hay aprendices con notas");
                    break;
                }

                Console.WriteLine("\n°°°° Ranking °°°°");

                int posicion = 1;

                foreach (var aprendiz in ranking)
                {
                    Console.WriteLine(
                        $"{posicion}. {aprendiz.Key,-15} " +
                        $"Promedio: {aprendiz.Value.Average():N2}"
                    );

                    posicion++;
                }

                break;
            }

        case 5:
            {
                var conNotas = notas
                    .Where(a => a.Value.Count > 0)
                    .ToList();

                if (conNotas.Count == 0)
                {
                    Console.WriteLine("Todavia no hay notas registradas");
                    break;
                }

                var mejor = conNotas
                    .OrderByDescending(a => a.Value.Average())
                    .First();

                int aprobados = conNotas
                    .Count(a => a.Value.Average() >= 3.0);

                Console.WriteLine(
                    $"Mejor aprendiz: {mejor.Key} " +
                    $"Promedio: {mejor.Value.Average():N2}"
                );

                Console.WriteLine($"Cantidad de aprobados: {aprobados}");

                break;
            }

        case 6:
            {
                Console.Write("Nombre del aprendiz que desea eliminar: ");
                string nombreEliminar = Console.ReadLine()?.Trim() ?? "";

                if (notas.Remove(nombreEliminar))
                {
                    Console.WriteLine("Aprendiz eliminado correctamente");
                }
                else
                {
                    Console.WriteLine("No se encontro ese aprendiz");
                }

                break;
            }

        case 7:
            {
                var aprendicesConNotas = notas
                    .Where(a => a.Value.Count > 0)
                    .Select(a => new
                    {
                        Nombre = a.Key,
                        Promedio = a.Value.Average()
                    })
                    .ToList();

                Console.WriteLine("\n°°°° Reporte por Nivel °°°°");

                if (aprendicesConNotas.Count == 0)
                {
                    Console.WriteLine("No hay aprendices con notas");
                    break;
                }

                var grupos = aprendicesConNotas
                    .Select(a => new
                    {
                        a.Nombre,
                        a.Promedio,
                        Nivel = a.Promedio >= 4.5 ? "Excelente"
                              : a.Promedio >= 4.0 ? "Sobresaliente"
                              : a.Promedio >= 3.0 ? "Aceptable"
                              : "Deficiente"
                    })
                    .GroupBy(a => a.Nivel)
                    .OrderBy(g => g.Key);

                foreach (var grupo in grupos)
                {
                    Console.WriteLine($"\n{grupo.Key}:");

                    foreach (var aprendiz in grupo)
                    {
                        Console.WriteLine(
                            $"  {aprendiz.Nombre,-15} " +
                            $"Promedio: {aprendiz.Promedio:N2}"
                        );
                    }

                    Console.WriteLine($"Total: {grupo.Count()} aprendices");
                }

                break;
            }

        case 8:
            Console.WriteLine("Programa finalizado");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente");
            break;
    }

} while (opcion != 8);