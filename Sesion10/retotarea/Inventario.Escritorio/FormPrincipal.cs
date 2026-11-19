
using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio_
{
    public partial class FormPrincipal : Form
    {
        private readonly ServicioInventario _servicio =
            new(new RepositorioJson("inventario.json"));

        public FormPrincipal()
        {
            InitializeComponent();
            CargarProductos();
        }

        private void CargarProductos(List<Producto>? productos = null)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos ?? _servicio.Listar();

            decimal valorTotal = _servicio.Listar().Sum(p => p.Precio * p.Stock);
            lblValor.Text = $"Valor del inventario: {valorTotal:C0}";
        }

        private Producto? Seleccionado()
        {
            return dgvProductos.CurrentRow?.DataBoundItem as Producto;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos(_servicio.BuscarPorTexto(txtBuscar.Text));
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Columns["Precio"] is DataGridViewColumn precio)
            {
                precio.DefaultCellStyle.Format = "C0";
            }

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.DataBoundItem is Producto producto && producto.Stock < 5)
                {
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                using var form = new FormProducto();

                if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null)
                    return;

                try
                {
                    _servicio.Agregar(form.ProductoCreado);
                    CargarProductos();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "No se pudo agregar",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
        }

        private void lblValor_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            var respuesta = MessageBox.Show(
                $"¿Eliminar {producto.Nombre}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                _servicio.Eliminar(producto.Codigo);
                CargarProductos();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            try
            {
                _servicio.Vender(producto.Codigo, (int)nudCantidad.Value);
                CargarProductos();

                MessageBox.Show("Venta realizada correctamente.");
            }
            catch (StockInsuficienteException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Stock insuficiente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            try
            {
                _servicio.AgregarStock(producto.Codigo, (int)nudCantidad.Value);
                CargarProductos();

                MessageBox.Show("Stock agregado correctamente.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvProductos.Rows[e.RowIndex].DataBoundItem is not Producto producto)
                return;

            using var form = new FormProducto(producto);

            if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null)
                return;

            try
            {
                producto.Editar(
                    form.ProductoCreado.Nombre,
                    form.ProductoCreado.Precio
                );

                _servicio.Actualizar(producto);

                CargarProductos();

                MessageBox.Show("Producto actualizado correctamente.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error al editar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            using var form = new FormReportes(_servicio);
            form.ShowDialog();
        }
    }
}
