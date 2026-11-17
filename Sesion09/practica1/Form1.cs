using System;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // --- MÉTODOS AUXILIARES ---
        private int ObtenerNumero(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new ArgumentException($"El campo {nombreCampo} no puede estar vacío.", nombreCampo);

            if (!int.TryParse(texto, out int numero))
                throw new ArgumentException($"El campo {nombreCampo} debe ser un número entero válido.", nombreCampo);

            return numero;
        }

        private int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("No se puede dividir entre cero (0).", nameof(divisor));

            return dividendo / divisor;
        }

        private void MostrarError(ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // --- SALUDAR ---
        private void Saludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Hola, {textNombre.Text} Bienvenido";
        }

        // --- OPERACIONES ---
        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtn1.Text, "Número 1");
                int n2 = ObtenerNumero(txtn2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 + n2);
            }
            catch (ArgumentException ex) { MostrarError(ex); }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtn1.Text, "Número 1");
                int n2 = ObtenerNumero(txtn2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 - n2);
            }
            catch (ArgumentException ex) { MostrarError(ex); }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtn1.Text, "Número 1");
                int n2 = ObtenerNumero(txtn2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 * n2);
            }
            catch (ArgumentException ex) { MostrarError(ex); }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtn1.Text, "Número 1");
                int n2 = ObtenerNumero(txtn2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(Dividir(n1, n2));
            }
            catch (ArgumentException ex) { MostrarError(ex); }
        }
    }
}