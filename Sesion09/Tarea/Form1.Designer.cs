namespace Tarea
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            lblOrigen = new Label();
            cmbOrigen = new ComboBox();
            lblDestino = new Label();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(271, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(267, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONVERSOR DE TEMPERATURA";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(271, 98);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(142, 25);
            lblValor.TabIndex = 1;
            lblValor.Text = "Ingresa el Valor: ";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(438, 98);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 31);
            txtValor.TabIndex = 2;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(264, 171);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(162, 25);
            lblOrigen.TabIndex = 3;
            lblOrigen.Text = "Unidad de Origen: ";
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(460, 168);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(110, 33);
            cmbOrigen.TabIndex = 4;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(264, 225);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(169, 25);
            lblDestino.TabIndex = 5;
            lblDestino.Text = "Unidad de Destino: ";
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(460, 232);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(110, 33);
            cmbDestino.TabIndex = 6;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(476, 332);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(94, 30);
            btnConvertir.TabIndex = 7;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(264, 295);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(99, 25);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado: ";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(lblDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblValor;
        private TextBox txtValor;
        private Label lblOrigen;
        private ComboBox cmbOrigen;
        private Label lblDestino;
        private ComboBox cmbDestino;
        private Button btnConvertir;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
    }
}
