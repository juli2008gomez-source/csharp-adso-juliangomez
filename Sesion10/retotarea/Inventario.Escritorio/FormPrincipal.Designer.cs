namespace Inventario.Escritorio_
{
    partial class FormPrincipal
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
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            lblValor = new Label();
            btnAgregar = new Button();
            btnEliminar = new Button();
            nudCantidad = new NumericUpDown();
            btnVender = new Button();
            btnAgregarStock = new Button();
            btnReportes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 22);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 31);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(40, 110);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(360, 225);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(473, 110);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(52, 25);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor";
            lblValor.Click += lblValor_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(284, 22);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(138, 34);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(439, 22);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(132, 39);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(591, 168);
            nudCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(180, 31);
            nudCantidad.TabIndex = 5;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnVender
            // 
            btnVender.Location = new Point(459, 165);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(112, 34);
            btnVender.TabIndex = 6;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(459, 220);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(141, 34);
            btnAgregarStock.TabIndex = 7;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += button1_Click_1;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(459, 276);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(136, 34);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Ver reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportes);
            Controls.Add(btnAgregarStock);
            Controls.Add(btnVender);
            Controls.Add(nudCantidad);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblValor);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscar);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private Label lblValor;
        private Button btnAgregar;
        private Button btnEliminar;
        private NumericUpDown nudCantidad;
        private Button btnVender;
        private Button btnAgregarStock;
        private Button btnReportes;
    }
}
