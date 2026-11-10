
using System;

namespace Inventario.Modelos
{
    public class Producto
    {
        public string Codigo { get; private set; }

        private string _nombre = "";
        public string Nombre
        {
            get => _nombre;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacío");

                _nombre = value.Trim();
            }
        }

        private decimal _precio;
        public decimal Precio
        {
            get => _precio;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("El precio debe ser mayor que cero.");

                _precio = value;
            }
        }

        public int Stock { get; private set; }

        public Producto(string codigo, string nombre, decimal precio, int stock)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("El código no puede estar vacío");

            if (stock < 0)
                throw new ArgumentException("El stock no puede ser negativo");

            Codigo = codigo.Trim().ToUpperInvariant();
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }

        public void AgregarStock(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero");

            Stock += cantidad;
        }

        public void Vender(int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero");

            if (cantidad > Stock)
                throw new StockInsuficienteException(Nombre, Stock);

            Stock -= cantidad;
        }

        public override string ToString() =>
            $"{Codigo} - {Nombre} - ${Precio:N0} - Stock: {Stock}";
    }
}
