
using Inventario.Modelos;

namespace Inventario.Escritorio_
{
    public partial class FormProducto : Form
    {
        public Producto? ProductoCreado { get; private set; }

        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(Producto producto)
        {
            InitializeComponent();

            txtCodigo.Text = producto.Codigo;
            txtNombre.Text = producto.Nombre;
            nudPrecio.Value = producto.Precio;
            nudStock.Value = producto.Stock;

            txtCodigo.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            try
            {
                ProductoCreado = new Producto(
                    txtCodigo.Text,
                    txtNombre.Text,
                    nudPrecio.Value,
                    (int)nudStock.Value
                );

                DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                errorProvider1.SetError(btnGuardar, ex.Message);
            }
        }
    }
}

