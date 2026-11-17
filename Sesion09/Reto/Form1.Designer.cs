namespace Reto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblTitular = new Label();
            lblSaldo = new Label();
            lblDestino = new Label();
            lblMonto = new Label();
            nudMonto = new NumericUpDown();
            btnDepositar = new Button();
            lblHitorial = new Label();
            btnTransferir = new Button();
            btnRetirar = new Button();
            lstMovimientos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(297, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CAJERO AUTOMATICO";
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(217, 73);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(69, 25);
            lblTitular.TabIndex = 1;
            lblTitular.Text = "Titular: ";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(217, 132);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(66, 25);
            lblSaldo.TabIndex = 2;
            lblSaldo.Text = "Saldo: ";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(217, 175);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(140, 25);
            lblDestino.TabIndex = 3;
            lblDestino.Text = "Cuenta destino: ";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(217, 226);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(75, 25);
            lblMonto.TabIndex = 4;
            lblMonto.Text = "Monto: ";
            // 
            // nudMonto
            // 
            nudMonto.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Location = new Point(360, 226);
            nudMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(84, 31);
            nudMonto.TabIndex = 5;
            nudMonto.ThousandsSeparator = true;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(201, 351);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(100, 30);
            btnDepositar.TabIndex = 6;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            // 
            // lblHitorial
            // 
            lblHitorial.AutoSize = true;
            lblHitorial.Location = new Point(217, 284);
            lblHitorial.Name = "lblHitorial";
            lblHitorial.Size = new Size(211, 25);
            lblHitorial.TabIndex = 7;
            lblHitorial.Text = "Historial de Movimientos";
            // 
            // btnTransferir
            // 
            btnTransferir.Location = new Point(517, 351);
            btnTransferir.Name = "btnTransferir";
            btnTransferir.Size = new Size(93, 30);
            btnTransferir.TabIndex = 8;
            btnTransferir.Text = "Transferir";
            btnTransferir.UseVisualStyleBackColor = true;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(360, 351);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(92, 30);
            btnRetirar.TabIndex = 9;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            // 
            // lstMovimientos
            // 
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(450, 284);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(308, 54);
            lstMovimientos.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstMovimientos);
            Controls.Add(btnRetirar);
            Controls.Add(btnTransferir);
            Controls.Add(lblHitorial);
            Controls.Add(btnDepositar);
            Controls.Add(nudMonto);
            Controls.Add(lblMonto);
            Controls.Add(lblDestino);
            Controls.Add(lblSaldo);
            Controls.Add(lblTitular);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTitular;
        private Label lblSaldo;
        private Label lblDestino;
        private Label lblMonto;
        private NumericUpDown nudMonto;
        private Button btnDepositar;
        private Label lblHitorial;
        private Button btnTransferir;
        private Button btnRetirar;
        private ListBox lstMovimientos;
    }
}
