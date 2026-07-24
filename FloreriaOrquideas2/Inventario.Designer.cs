namespace FloreriaOrquideas2
{
    partial class Inventario
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
            panelSuperior = new Panel();
            button1 = new Button();
            btnRegisEntrada = new Button();
            btnActualizar = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            lblEstado = new Label();
            txtStockMinimo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            cmbFlor = new ComboBox();
            txtCantidad = new TextBox();
            txtEntradas = new TextBox();
            txtSalidas = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label9 = new Label();
            txtBuscar = new TextBox();
            dgvInventario = new DataGridView();
            Flor = new DataGridViewTextBoxColumn();
            Existencias = new DataGridViewTextBoxColumn();
            StockMinimo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSuperior.Controls.Add(button1);
            panelSuperior.Controls.Add(btnRegisEntrada);
            panelSuperior.Controls.Add(btnActualizar);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(800, 100);
            panelSuperior.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(663, 47);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 5;
            button1.Text = "Registrar Merma";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRegisEntrada
            // 
            btnRegisEntrada.Location = new Point(525, 47);
            btnRegisEntrada.Name = "btnRegisEntrada";
            btnRegisEntrada.Size = new Size(107, 23);
            btnRegisEntrada.TabIndex = 4;
            btnRegisEntrada.Text = "Registar Entrada";
            btnRegisEntrada.UseVisualStyleBackColor = true;
            btnRegisEntrada.Click += btnRegisEntrada_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(418, 47);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 62);
            label2.Name = "label2";
            label2.Size = new Size(265, 20);
            label2.TabIndex = 2;
            label2.Text = "Control de existencias y stock de flores";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 40);
            label1.TabIndex = 1;
            label1.Text = "Inventario";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblEstado);
            groupBox1.Controls.Add(txtStockMinimo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbFlor);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(txtEntradas);
            groupBox1.Controls.Add(txtSalidas);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.ForestGreen;
            groupBox1.Location = new Point(0, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 175);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Control de Inventario";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(393, 77);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(99, 21);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "labelEstado";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(393, 36);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(100, 29);
            txtStockMinimo.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(276, 77);
            label8.Name = "label8";
            label8.Size = new Size(51, 17);
            label8.TabIndex = 9;
            label8.Text = "Estado:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(276, 40);
            label7.Name = "label7";
            label7.Size = new Size(89, 17);
            label7.TabIndex = 8;
            label7.Text = "Stock minimo:";
            // 
            // cmbFlor
            // 
            cmbFlor.FormattingEnabled = true;
            cmbFlor.Location = new Point(119, 36);
            cmbFlor.Name = "cmbFlor";
            cmbFlor.Size = new Size(121, 29);
            cmbFlor.TabIndex = 7;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(119, 71);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.ReadOnly = true;
            txtCantidad.Size = new Size(100, 29);
            txtCantidad.TabIndex = 6;
            // 
            // txtEntradas
            // 
            txtEntradas.Location = new Point(119, 104);
            txtEntradas.Name = "txtEntradas";
            txtEntradas.ReadOnly = true;
            txtEntradas.Size = new Size(100, 29);
            txtEntradas.TabIndex = 5;
            // 
            // txtSalidas
            // 
            txtSalidas.Location = new Point(119, 142);
            txtSalidas.Name = "txtSalidas";
            txtSalidas.ReadOnly = true;
            txtSalidas.Size = new Size(100, 29);
            txtSalidas.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 148);
            label6.Name = "label6";
            label6.Size = new Size(52, 17);
            label6.TabIndex = 3;
            label6.Text = "Salidas:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 110);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 2;
            label5.Text = "Entradas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 77);
            label4.Name = "label4";
            label4.Size = new Size(101, 17);
            label4.TabIndex = 1;
            label4.Text = "Cantidad actual:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 40);
            label3.Name = "label3";
            label3.Size = new Size(33, 17);
            label3.TabIndex = 0;
            label3.Text = "Flor:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 294);
            label9.Name = "label9";
            label9.Size = new Size(49, 17);
            label9.TabIndex = 2;
            label9.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(67, 293);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(317, 23);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { Flor, Existencias, StockMinimo, Estado });
            dgvInventario.Location = new Point(30, 322);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(593, 150);
            dgvInventario.TabIndex = 4;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            // 
            // Flor
            // 
            Flor.HeaderText = "Flor";
            Flor.Name = "Flor";
            Flor.Width = 200;
            // 
            // Existencias
            // 
            Existencias.HeaderText = "Existencias";
            Existencias.Name = "Existencias";
            // 
            // StockMinimo
            // 
            StockMinimo.HeaderText = "Stock mínimo";
            StockMinimo.Name = "StockMinimo";
            StockMinimo.Width = 150;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 511);
            Controls.Add(dgvInventario);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            Controls.Add(groupBox1);
            Controls.Add(panelSuperior);
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            Load += Inventario_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button btnRegisEntrada;
        private Button btnActualizar;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtSalidas;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private ComboBox cmbFlor;
        private TextBox txtCantidad;
        private TextBox txtEntradas;
        private Label lblEstado;
        private TextBox txtStockMinimo;
        private Label label8;
        private Label label9;
        private TextBox txtBuscar;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn Flor;
        private DataGridViewTextBoxColumn Existencias;
        private DataGridViewTextBoxColumn StockMinimo;
        private DataGridViewTextBoxColumn Estado;
    }
}