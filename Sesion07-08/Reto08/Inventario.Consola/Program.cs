
using Inventario.Datos;
using Inventario.Servicios;
using Inventario.Modelos;

var servicio = new ServicioInventario(
    new RepositorioJson("inventario.json")
);

int opcion = 0;

do
{
    Console.WriteLine("\n°°°°° INVENTARIO °°°°°");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Ver inventario");
    Console.WriteLine("5. Productos con stock bajo");
    Console.WriteLine("6. Buscar producto");
    Console.WriteLine("7. Eliminar producto");
    Console.WriteLine("8. Salir");
    Console.Write("Seleccione una opción: ");

    if (!int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine("°°°° Ingrese un número válido °°°°");
        continue;
    }

    try
    {
        switch (opcion)
        {
            case 1:
                Console.Write("Código: ");
                string codigo = Console.ReadLine() ?? "";

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Precio: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
                    throw new ArgumentException("°°°° Precio inválido °°°°");

                Console.Write("Stock inicial: ");
                if (!int.TryParse(Console.ReadLine(), out int stock))
                    throw new ArgumentException("°°°° Stock inválido °°°°");

                servicio.Agregar(new Producto(codigo, nombre, precio, stock));
                Console.WriteLine("°°°° Producto registrado °°°°");
                break;

            case 2:
                Console.Write("Código: ");
                codigo = Console.ReadLine() ?? "";

                Console.Write("Cantidad a agregar: ");
                if (!int.TryParse(Console.ReadLine(), out int cantidad))
                    throw new ArgumentException("°°°° Cantidad inválida °°°°");

                servicio.AgregarStock(codigo, cantidad);
                Console.WriteLine("°°°° Stock actualizado °°°°");
                break;

            case 3:
                Console.Write("Código: ");
                codigo = Console.ReadLine() ?? "";

                Console.Write("Cantidad a vender: ");
                if (!int.TryParse(Console.ReadLine(), out cantidad))
                    throw new ArgumentException("°°°° Cantidad inválida °°°°");

                servicio.Vender(codigo, cantidad);
                Console.WriteLine("°°°° Producto Vendido Exitosamente °°°°");
                break;

            case 4:
                foreach (var producto in servicio.Listar())
                    Console.WriteLine(producto);
                break;

            case 5:
                foreach (var producto in servicio.StockBajo())
                    Console.WriteLine(producto);
                break;

            case 6:
                Console.Write("Buscar Producto: ");
                string texto = Console.ReadLine() ?? "";

                foreach (var producto in servicio.BuscarPorTexto(texto))
                    Console.WriteLine(producto);
                break;

            case 7:
                Console.Write("Código del producto a eliminar: ");
                codigo = Console.ReadLine() ?? "";

                servicio.Eliminar(codigo);
                Console.WriteLine("°°°° Producto Eliminado Exitosamente °°°°");
                break;

            case 8:
                Console.WriteLine("°°°° Fin del programa °°°°");
                break;

            default:
                Console.WriteLine("°°°° Opción no válida °°°°");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }

} while (opcion != 8);
