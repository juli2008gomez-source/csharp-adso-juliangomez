namespace Inventario.Escritorio_
{
    partial class FormReportes
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
            lblMasValiosos = new Label();
            dgvMasValiosos = new DataGridView();
            lblStockBajo = new Label();
            dgvStockBajo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            SuspendLayout();
            // 
            // lblMasValiosos
            // 
            lblMasValiosos.AutoSize = true;
            lblMasValiosos.Location = new Point(259, 33);
            lblMasValiosos.Name = "lblMasValiosos";
            lblMasValiosos.Size = new Size(200, 25);
            lblMasValiosos.TabIndex = 0;
            lblMasValiosos.Text = "Productos más valiosos";
            // 
            // dgvMasValiosos
            // 
            dgvMasValiosos.AllowUserToAddRows = false;
            dgvMasValiosos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMasValiosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasValiosos.Location = new Point(57, 61);
            dgvMasValiosos.Name = "dgvMasValiosos";
            dgvMasValiosos.ReadOnly = true;
            dgvMasValiosos.RowHeadersWidth = 62;
            dgvMasValiosos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMasValiosos.Size = new Size(691, 134);
            dgvMasValiosos.TabIndex = 1;
            // 
            // lblStockBajo
            // 
            lblStockBajo.AutoSize = true;
            lblStockBajo.Location = new Point(245, 219);
            lblStockBajo.Name = "lblStockBajo";
            lblStockBajo.Size = new Size(214, 25);
            lblStockBajo.TabIndex = 2;
            lblStockBajo.Text = "Productos con stock bajo";
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.AllowUserToAddRows = false;
            dgvStockBajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockBajo.Location = new Point(57, 269);
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.ReadOnly = true;
            dgvStockBajo.RowHeadersWidth = 62;
            dgvStockBajo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStockBajo.Size = new Size(691, 147);
            dgvStockBajo.TabIndex = 3;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStockBajo);
            Controls.Add(lblStockBajo);
            Controls.Add(dgvMasValiosos);
            Controls.Add(lblMasValiosos);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMasValiosos;
        private DataGridView dgvMasValiosos;
        private Label lblStockBajo;
        private DataGridView dgvStockBajo;
    }
}