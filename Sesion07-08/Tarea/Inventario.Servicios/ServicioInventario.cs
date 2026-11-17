
using System;
using System.Collections.Generic;
using System.Linq;
using Inventario.Datos;
using Inventario.Modelos;

namespace Inventario.Servicios
{
    public class ServicioInventario
    {
        private readonly IRepositorioProductos _repositorio;

        public ServicioInventario(IRepositorioProductos repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Producto> Listar()
        {
            return _repositorio.ObtenerTodos()
                .OrderBy(p => p.Nombre)
                .ToList();
        }

        public void Agregar(Producto producto)
        {
            if (_repositorio.BuscarPorCodigo(producto.Codigo) != null)
                throw new ArgumentException("Ya existe un producto con ese código.");

            _repositorio.Agregar(producto);
        }

        public void AgregarStock(string codigo, int cantidad)
        {
            Producto? producto = _repositorio.BuscarPorCodigo(codigo);

            if (producto == null)
                throw new ArgumentException("Producto no encontrado.");

            producto.AgregarStock(cantidad);
            _repositorio.Actualizar(producto);
        }

        public void Vender(string codigo, int cantidad)
        {
            Producto? producto = _repositorio.BuscarPorCodigo(codigo);

            if (producto == null)
                throw new ArgumentException("Producto no encontrado.");

            producto.Vender(cantidad);
            _repositorio.Actualizar(producto);
        }

        public List<Producto> StockBajo()
        {
            return Listar()
                .Where(p => p.Stock < 5)
                .ToList();
        }

        public List<Producto> BuscarPorTexto(string texto)
        {
            return Listar()
                .Where(p =>
                    p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase) ||
                    p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public void Eliminar(string codigo)
        {
            _repositorio.Eliminar(codigo);
        }
    }
}
