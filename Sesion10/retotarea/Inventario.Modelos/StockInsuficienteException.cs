using System;
using System.Collections.Generic;
using System.Text;


namespace Inventario.Modelos
{
    public class StockInsuficienteException : Exception
    {
        public StockInsuficienteException(string nombreProducto, int stockDisponible)
            : base($"No hay suficiente stock de {nombreProducto}. Disponible: {stockDisponible}")
        {
        }
    }
}

