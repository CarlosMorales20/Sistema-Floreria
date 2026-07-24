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
            btnActualizar = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            txtBuscar = new TextBox();
            dgvInventario = new DataGridView();
            Flor = new DataGridViewTextBoxColumn();
            Existencias = new DataGridViewTextBoxColumn();
            StockMinimo = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            btnSalir = new Button();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSuperior.Controls.Add(btnSalir);
            panelSuperior.Controls.Add(button1);
            panelSuperior.Controls.Add(btnActualizar);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(644, 100);
            panelSuperior.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(512, 26);
            button1.Name = "button1";
            button1.Size = new Size(111, 23);
            button1.TabIndex = 5;
            button1.Text = "Registrar Merma";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(395, 26);
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(12, 124);
            label9.Name = "label9";
            label9.Size = new Size(49, 17);
            label9.TabIndex = 2;
            label9.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(67, 123);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(317, 23);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // dgvInventario
            // 
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Columns.AddRange(new DataGridViewColumn[] { Flor, Existencias, StockMinimo, Estado });
            dgvInventario.Location = new Point(30, 152);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.Size = new Size(593, 150);
            dgvInventario.TabIndex = 4;
            dgvInventario.CellContentClick += dgvInventario_CellContentClick;
            dgvInventario.CellMouseClick += dgvInventario_CellMouseClick;
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
            // btnSalir
            // 
            btnSalir.Location = new Point(578, 62);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(45, 23);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 325);
            Controls.Add(dgvInventario);
            Controls.Add(txtBuscar);
            Controls.Add(label9);
            Controls.Add(panelSuperior);
            Name = "Inventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            Load += Inventario_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button btnActualizar;
        private Label label9;
        private TextBox txtBuscar;
        private DataGridView dgvInventario;
        private DataGridViewTextBoxColumn Flor;
        private DataGridViewTextBoxColumn Existencias;
        private DataGridViewTextBoxColumn StockMinimo;
        private DataGridViewTextBoxColumn Estado;
        private Button btnSalir;
    }
}