using Microsoft.EntityFrameworkCore;

namespace Reto;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        using (var db = new AgendaContext()) db.Database.EnsureCreated();
        CargarContactos();
    }

    private void CargarContactos(string filtro = "")
    {
        using var db = new AgendaContext();   // una oficina nueva para cada trámite
        dgvContactos.DataSource = db.Contactos
            .Where(c => EF.Functions.Like(c.Nombre, $"%{filtro}%"))
            .OrderBy(c => c.Nombre)
            .ToList();
        lblTotal.Text = $"{dgvContactos.Rows.Count} contactos";
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider1.SetError(txtNombre, "Escribe el nombre.");
            return;
        }
        if (string.IsNullOrWhiteSpace(txtTelefono.Text))
        {
            errorProvider1.SetError(txtTelefono, "Escribe el telefono.");
            return;
        }

        string correo = txtCorreo.Text.Trim();
        if (string.IsNullOrWhiteSpace(correo))
        {
            errorProvider1.SetError(txtCorreo, "Escribe el correo.");
            return;
        }
        if (!correo.Contains("@"))
        {
            errorProvider1.SetError(txtCorreo, "El correo debe contener '@'.");
            return;
        }

        using var db = new AgendaContext();
        db.Contactos.Add(new Contacto
        {
            Nombre = txtNombre.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            Correo = txtCorreo.Text.Trim()
        });
        db.SaveChanges();

        txtNombre.Clear(); txtTelefono.Clear(); txtCorreo.Clear();
        CargarContactos();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvContactos.CurrentRow?.DataBoundItem is not Contacto contacto) return;
        if (MessageBox.Show($"¿Eliminar a {contacto.Nombre}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

        using var db = new AgendaContext();
        db.Contactos.Remove(contacto);
        db.SaveChanges();
        CargarContactos(txtBuscar.Text);
    }

    private void txtBuscar_TextChanged_1(object sender, EventArgs e) => CargarContactos(txtBuscar.Text);

    private void btnGuardarCambios_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        if (_idContactoEditando is null)
        {
            MessageBox.Show("Haz doble clic en un contacto de la lista para editarlo.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string nombre = txtNombre.Text.Trim();
        string telefono = txtTelefono.Text.Trim();
        string correo = txtCorreo.Text.Trim();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            errorProvider1.SetError(txtNombre, "Escribe el nombre.");
            return;
        }

        if (string.IsNullOrWhiteSpace(telefono))
        {
            errorProvider1.SetError(txtTelefono, "Escribe el telefono.");
            return;
        }

        if (string.IsNullOrWhiteSpace(correo) || !correo.Contains("@"))
        {
            errorProvider1.SetError(txtCorreo, "Escribe un correo válido con '@'.");
            return;
        }

        using var db = new AgendaContext();
        var contacto = db.Contactos.Find(_idContactoEditando.Value);

        if (contacto is null)
        {
            MessageBox.Show("El contacto ya no existe en la base de datos.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            _idContactoEditando = null;
            CargarContactos(txtBuscar.Text);
            return;
        }

        contacto.Nombre = nombre;
        contacto.Telefono = telefono;
        contacto.Correo = correo;
        db.SaveChanges();

        _idContactoEditando = null;
        txtNombre.Clear();
        txtTelefono.Clear();
        txtCorreo.Clear();
        CargarContactos(txtBuscar.Text);
    }
    private int? _idContactoEditando = null;

    private void dgvContactos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        if (dgvContactos.Rows[e.RowIndex].DataBoundItem is Contacto contacto)
        {
            _idContactoEditando = contacto.Id;
            txtNombre.Text = contacto.Nombre;
            txtTelefono.Text = contacto.Telefono;
            txtCorreo.Text = contacto.Correo;
            errorProvider1.Clear();
        }
    }
}