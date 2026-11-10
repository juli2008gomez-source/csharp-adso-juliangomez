using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Inventario.Modelos;

namespace Inventario.Datos
{
    public class RepositorioJson : IRepositorioProductos
    {
        private readonly string _ruta;

        public RepositorioJson(string ruta)
        {
            _ruta = Path.GetFullPath(ruta);
        }

        public List<Producto> ObtenerTodos()
        {
            if (!File.Exists(_ruta))
                return new List<Producto>();

            try
            {
                string json = File.ReadAllText(_ruta);

                return JsonSerializer.Deserialize<List<Producto>>(json)
                    ?? new List<Producto>();
            }
            catch (JsonException)
            {
                File.Copy(_ruta, _ruta + ".danado", true);
                return new List<Producto>();
            }
        }

        private void Guardar(List<Producto> productos)
        {
            string json = JsonSerializer.Serialize(
                productos,
                new JsonSerializerOptions { WriteIndented = true }
            );

            File.WriteAllText(_ruta, json);
        }

        public Producto? BuscarPorCodigo(string codigo)
        {
            return ObtenerTodos().FirstOrDefault(
                p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)
            );
        }

        public void Agregar(Producto producto)
        {
            var productos = ObtenerTodos();
            productos.Add(producto);
            Guardar(productos);
        }

        public void Actualizar(Producto producto)
        {
            var productos = ObtenerTodos();

            int indice = productos.FindIndex(
                p => p.Codigo == producto.Codigo
            );

            if (indice >= 0)
            {
                productos[indice] = producto;
                Guardar(productos);
            }
        }

        public void Eliminar(string codigo)
        {
            var productos = ObtenerTodos();

            int eliminados = productos.RemoveAll(
                p => p.Codigo.Equals(codigo, StringComparison.OrdinalIgnoreCase)
            );

            if (eliminados > 0)
                Guardar(productos);
        }
    }
}
