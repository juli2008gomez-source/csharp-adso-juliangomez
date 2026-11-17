using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        private ConversorTemperatura conversor =
            new ConversorTemperatura();

        public Form1()
        {
            InitializeComponent();
            cmbOrigen.Items.Add("Celsius (°C)");
            cmbOrigen.Items.Add("Fahrenheit (°F)");
            cmbOrigen.Items.Add("Kelvin (K)");
            cmbDestino.Items.Add("Celsius (°C)");
            cmbDestino.Items.Add("Fahrenheit (°F)");
            cmbDestino.Items.Add("Kelvin (K)");
            cmbOrigen.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            btnConvertir.Click += btnConvertir_Click;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            lblResultado.Text = "Resultado:";

            bool valido = true;

            if (!decimal.TryParse(txtValor.Text, out decimal valor))
            {
                errorProvider1.SetError(
                    txtValor,
                    "Ingresa un número válido."
                );

                valido = false;
            }

            if (cmbOrigen.SelectedItem == null)
            {
                errorProvider1.SetError(
                    cmbOrigen,
                    "Selecciona la unidad de origen."
                );

                valido = false;
            }

            if (cmbDestino.SelectedItem == null)
            {
                errorProvider1.SetError(
                    cmbDestino,
                    "Selecciona la unidad de destino."
                );

                valido = false;
            }

            if (!valido)
                return;

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            if ((origen == "Celsius (°C)" && valor < -273.15m) ||
                (origen == "Fahrenheit (°F)" && valor < -459.67m) ||
                (origen == "Kelvin (K)" && valor < 0))
            {
                errorProvider1.SetError(
                    txtValor,
                    "La temperatura no puede ser inferior al cero absoluto."
                );

                return;
            }

            decimal resultado = conversor.Convertir(
                valor,
                origen,
                destino
            );

            lblResultado.Text =
                $"Resultado: {resultado:F2} {destino}";
        }
    }
}