using Reto1;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Reto1
{
    internal class Producto
    {
        public string Codigo { get; private set; }
        private string _nombre = "";
        public string Nombre
        {
            get => _nombre;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El nombre no puede estar vacio");
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
                throw new ArgumentException("El codigo no puede estar vacio");
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
        public bool Vender (int cantidad)
        {
            if (cantidad <= 0 || cantidad > Stock)
                return false;

            Stock -= cantidad;
            return true;
        }
        public override string ToString() => $"{Codigo} - ${Nombre} - ${Precio:N0} - Stock: {Stock}";
    }

}

