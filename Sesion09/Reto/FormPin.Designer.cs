namespace Reto
{
    partial class FormPin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblInstruccion = new Label();
            txtPin = new TextBox();
            btnIngresar = new Button();
            lblIntentos = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(310, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(130, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CAJERO ADSO";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(135, 243);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(124, 25);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Ingresa tu PIN";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(341, 237);
            txtPin.MaxLength = 4;
            txtPin.Name = "txtPin";
            txtPin.PasswordChar = '*';
            txtPin.Size = new Size(99, 31);
            txtPin.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(522, 235);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(86, 40);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Location = new Point(32, 369);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(192, 25);
            lblIntentos.TabIndex = 4;
            lblIntentos.Text = "Intentos disponibles: 3";
            // 
            // FormPin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIntentos);
            Controls.Add(btnIngresar);
            Controls.Add(txtPin);
            Controls.Add(lblInstruccion);
            Controls.Add(lblTitulo);
            Name = "FormPin";
            Text = "FormPin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblInstruccion;
        private TextBox txtPin;
        private Button btnIngresar;
        private Label lblIntentos;
    }
}