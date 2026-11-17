using System;
using System.Windows.Forms;

namespace Reto
{
    public partial class FormPin : Form
    {
        private const string PinCorrecto = "1234";
        private int intentos = 3;

        public FormPin()
        {
            InitializeComponent();

            btnIngresar.Click += btnIngresar_Click;
            txtPin.KeyDown += txtPin_KeyDown;

            txtPin.PasswordChar = '*';
            txtPin.MaxLength = 4;

            lblIntentos.Text = "Intentos disponibles: 3";
            AcceptButton = btnIngresar;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == PinCorrecto)
            {
                MessageBox.Show(
                    "Acceso permitido. Bienvenido al cajero.",
                    "Acceso correcto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                intentos--;

                if (intentos > 0)
                {
                    lblIntentos.Text =
                        $"Intentos disponibles: {intentos}";

                    MessageBox.Show(
                        "PIN incorrecto. Intenta nuevamente.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPin.Clear();
                    txtPin.Focus();
                }
                else
                {
                    MessageBox.Show(
                        "Has agotado los 3 intentos. El cajero se cerrará.",
                        "Acceso bloqueado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    DialogResult = DialogResult.Abort;
                    Close();
                }
            }
        }

        private void txtPin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
