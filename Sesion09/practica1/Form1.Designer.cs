namespace practica1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblPregunta = new Label();
            textNombre = new TextBox();
            btnSaludar = new Button();
            lblSaludo = new Label();
            lblN1 = new Label();
            lblN2 = new Label();
            lblResultado = new Label();
            btnSuma = new Button();
            btnResta = new Button();
            btnMultiplicar = new Button();
            txtResultado = new TextBox();
            txtn2 = new TextBox();
            txtn1 = new TextBox();
            btnDivision = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(21, 21);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(264, 39);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "¿Como te llamas?";
            // 
            // textNombre
            // 
            textNombre.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNombre.Location = new Point(32, 63);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(216, 46);
            textNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaludar.ForeColor = SystemColors.InfoText;
            btnSaludar.Location = new Point(330, 63);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(148, 46);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += Saludar_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(427, 159);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(0, 25);
            lblSaludo.TabIndex = 3;
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(-1, 178);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(92, 25);
            lblN1.TabIndex = 4;
            lblN1.Text = "Numero 1";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(-1, 224);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(92, 25);
            lblN2.TabIndex = 5;
            lblN2.Text = "Numero 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Enabled = false;
            lblResultado.Location = new Point(-1, 274);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(283, 192);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(117, 34);
            btnSuma.TabIndex = 7;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += btnSuma_Click;
            // 
            // btnResta
            // 
            btnResta.Location = new Point(427, 192);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(125, 30);
            btnResta.TabIndex = 8;
            btnResta.Text = "-";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(283, 247);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(117, 34);
            btnMultiplicar.TabIndex = 9;
            btnMultiplicar.Text = "*";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicacion_Click;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(109, 274);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(130, 31);
            txtResultado.TabIndex = 10;
            // 
            // txtn2
            // 
            txtn2.Location = new Point(108, 221);
            txtn2.Name = "txtn2";
            txtn2.Size = new Size(131, 31);
            txtn2.TabIndex = 11;
            // 
            // txtn1
            // 
            txtn1.Location = new Point(109, 172);
            txtn1.Name = "txtn1";
            txtn1.Size = new Size(130, 31);
            txtn1.TabIndex = 12;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(427, 247);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(125, 34);
            btnDivision.TabIndex = 13;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDivision);
            Controls.Add(txtn1);
            Controls.Add(txtn2);
            Controls.Add(txtResultado);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnResta);
            Controls.Add(btnSuma);
            Controls.Add(lblResultado);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(lblSaludo);
            Controls.Add(btnSaludar);
            Controls.Add(textNombre);
            Controls.Add(lblPregunta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private TextBox textNombre;
        private Button btnSaludar;
        private Label lblSaludo;
        private Label lblN1;
        private Label lblN2;
        private Label lblResultado;
        private Button btnSuma;
        private Button btnResta;
        private Button btnMultiplicar;
        private TextBox txtResultado;
        private TextBox txtn2;
        private TextBox txtn1;
        private Button btnDivision;
    }
}