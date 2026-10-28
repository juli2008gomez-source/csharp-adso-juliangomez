using Reto1;
List<Producto> inventario = [
    new Producto("MOU001","Mouse", 4500m, 10),
    new Producto("TEC001", "Teclado", 85000m, 5),
    new Producto("AUD001", "Audifonos", 60000m, 8)
];
List<lineaVenta> carrito = [];

bool continuar = true;

while (continuar)
{
    Console.WriteLine("\n°°°° TIENDA °°°°");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Ver carrito");
    Console.WriteLine("5. Ver inventario");
    Console.WriteLine("6. Salir");
    Console.Write("Elige una opcion: ");

    string? opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            RegistrarProducto();
            break;

        case "2":
            AgregarStock();
            break;

        case "3":
            VenderProducto();
            break;

        case "4":
            VerCarrito();
            break;

        case "5":
            VerInventario();
            break;

        case "6":
            continuar = false;
            Console.WriteLine("Cerrado");
            break;
        default:
            Console.WriteLine("Opcion invalida");
            break;

    }
}
void RegistrarProducto()
{
    Console.WriteLine("Codigo del producto: ");
    string codigo = Console.ReadLine() ?? "";
    codigo = codigo.Trim().ToUpperInvariant();
    if (inventario.Any(p => p.Codigo == codigo))
    {
        Console.WriteLine("Error: ya existe un producto con ese codigo.");
        return;
    }

    Console.WriteLine("Nombre del producto: ");
    string nombre = Console.ReadLine() ?? "";
    if (string.IsNullOrWhiteSpace(nombre))
    {
        Console.WriteLine("Error: nombre vacio.");
        return;
    }

    Console.WriteLine("Precio del producto: ");
    if(!decimal.TryParse(Console.ReadLine(), out decimal precio) || precio <= 0)
    {
        Console.WriteLine("Error: Precio invalido debe ser mayor que cero");
        return;
    }
   

    Console.WriteLine("Stock Inicial: ");
    if(!int.TryParse(Console.ReadLine(), out int stock) || stock < 0)
    {
        Console.WriteLine("Error: el stock debe ser un numero entero igual o mayor que cero");
        return;
    }

    Producto producto = new Producto(codigo, nombre, precio, stock);

    inventario.Add(producto);

    Console.WriteLine("Producto registrado correctamente");
}

void AgregarStock()
{
    Console.Write("Codigo del Producto ");
    string codigo = Console.ReadLine() ?? "";

    codigo = codigo.Trim().ToUpperInvariant();

    Producto? producto = inventario.FirstOrDefault(p => p.Codigo == codigo);
    if(producto == null)
    {
        Console.WriteLine("Error: el producto no existe");
        return;
    }
    Console.WriteLine("Cantidad que deseas agregar: ");
    if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
    {
        Console.WriteLine("Error: ingresa una cantidad entera mayor que cero");
        return;
    }
    producto.AgregarStock(cantidad);

    Console.WriteLine("Stock actualizado correctamente ");
    Console.WriteLine($"nuevo stock: {producto.Stock}");
}

void VenderProducto()
{
    Console.WriteLine("Codigo del producto: ");
    string codigo = Console.ReadLine() ?? "";

    codigo = codigo.Trim().ToUpperInvariant();
    Producto? producto = inventario.FirstOrDefault(p => p.Codigo == codigo);

    if (producto == null)
    {
        Console.WriteLine("Error: el producto no existe");
        return;
    }
    Console.Write("Cantidad que deseas vender: ");
    if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
    {
        Console.WriteLine("Error: ingresa una cantidad entera mayor que cero");
        return;
    }
    if (!producto.Vender(cantidad))
    {
        Console.WriteLine("Error: cantidad invalida o stock insuficiente ");
        return;
    }
    decimal subtotal = producto.Precio * cantidad;

    lineaVenta linea = new lineaVenta(
        producto.Codigo,
        producto.Nombre,
        cantidad,
        subtotal
    );
    carrito.Add(linea);

    Console.WriteLine("Venta realizada correctamente");
    Console.WriteLine($"subtotal: ${subtotal}");
}

void VerCarrito()
{
    if(carrito.Count == 0)
    {
        Console.WriteLine("El carrito esta Vacio");
        return;
    }

    foreach(lineaVenta linea in carrito)
    {
        Console.WriteLine($"{linea.Codigo} - {linea.Nombre} - Cantidad: {linea.Cantidad} - Subtotal: ${linea.Subtotal}");
    }
    decimal total = carrito.Sum(linea => linea.Subtotal);
    Console.WriteLine($"Total de la venta: ${total}");
}

void VerInventario()
{
    foreach(Producto producto in inventario)
    {
        Console.WriteLine(producto);
    }
}