
using System;
using System.Windows.Forms;

namespace Reto
{
    public partial class Form1 : Form
    {
        private readonly CuentaBancaria _cuenta =
            new CuentaBancaria("Julian Gómez", "001-123", 500000m);

        private readonly CuentaBancaria _destino =
            new CuentaBancaria("Cuenta Destino", "002-456", 0m);

        public Form1()
        {
            InitializeComponent();
            nudMonto.Minimum = 0;
            nudMonto.Maximum = 10000000;
            nudMonto.DecimalPlaces = 0;
            nudMonto.Increment = 10000;
            nudMonto.ThousandsSeparator = true;
            btnDepositar.Click += btnDepositar_Click;
            btnRetirar.Click += btnRetirar_Click;
            btnTransferir.Click += btnTransferir_Click;
            ActualizarSaldo();
        }
        private void ActualizarSaldo()
        {
            lblTitular.Text = "Titular: " + _cuenta.Titular;

            lblSaldo.Text = "Saldo disponible: " +
                            _cuenta.Saldo.ToString("C0");

            lblDestino.Text = "Cuenta destino: " +
                              _destino.Numero +
                              " | Saldo: " +
                              _destino.Saldo.ToString("C0");
        }
        private void RegistrarMovimiento(string tipo, decimal monto)
        {
            string hora = DateTime.Now.ToString("HH:mm:ss");

            string movimiento =
                $"{hora} | {tipo} | {monto:C0}";
            lstMovimientos.Items.Insert(0, movimiento);
        }
        private void MostrarError()
        {
            MessageBox.Show(
                _cuenta.UltimoError,
                "Operación fallida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (_cuenta.Depositar(monto))
            {
                ActualizarSaldo();
                RegistrarMovimiento("Depósito", monto);

                MessageBox.Show(
                    "Depósito realizado correctamente."
                );
            }
            else
            {
                MostrarError();
            }
        }
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (_cuenta.Retirar(monto))
            {
                ActualizarSaldo();
                RegistrarMovimiento("Retiro", monto);

                MessageBox.Show(
                    "Retiro realizado correctamente."
                );
            }
            else
            {
                MostrarError();
            }
        }
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (_cuenta.Transferir(_destino, monto))
            {
                ActualizarSaldo();
                RegistrarMovimiento("Transferencia", monto);

                MessageBox.Show(
                    "Transferencia realizada correctamente."
                );
            }
            else
            {
                MostrarError();
            }
        }
    }
}
