namespace FloreriaOrquideas2
{
    partial class Productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
            panelSuperior = new Panel();
            btnSalir = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dtpCaducidad = new DateTimePicker();
            dtpIngreso = new DateTimePicker();
            label12 = new Label();
            label11 = new Label();
            cmbUnidad = new ComboBox();
            txtStockMinimo = new TextBox();
            txtStock = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            cmbCategoria = new ComboBox();
            label6 = new Label();
            txtPrecio = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtID = new TextBox();
            label3 = new Label();
            label10 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            StockMinimo = new DataGridViewTextBoxColumn();
            Unidad = new DataGridViewTextBoxColumn();
            FechaIngreso = new DataGridViewTextBoxColumn();
            FechaCaducidad = new DataGridViewTextBoxColumn();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.MistyRose;
            panelSuperior.Controls.Add(btnSalir);
            panelSuperior.Controls.Add(btnEliminar);
            panelSuperior.Controls.Add(btnGuardar);
            panelSuperior.Controls.Add(btnNuevo);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(853, 119);
            panelSuperior.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(255, 61, 65);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(731, 60);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(95, 41);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += button1_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Orange;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(731, 13);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 40);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(107, 144, 102);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(607, 13);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(95, 40);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(161, 63, 73);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(492, 13);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 40);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "+ Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(149, 71);
            label2.Name = "label2";
            label2.Size = new Size(280, 30);
            label2.TabIndex = 2;
            label2.Text = "Administración de productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 12);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 1;
            label1.Text = "Productos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpCaducidad);
            groupBox1.Controls.Add(dtpIngreso);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbUnidad);
            groupBox1.Controls.Add(txtStockMinimo);
            groupBox1.Controls.Add(txtStock);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cmbCategoria);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtPrecio);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 197);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // dtpCaducidad
            // 
            dtpCaducidad.Format = DateTimePickerFormat.Short;
            dtpCaducidad.Location = new Point(662, 148);
            dtpCaducidad.Name = "dtpCaducidad";
            dtpCaducidad.Size = new Size(120, 27);
            dtpCaducidad.TabIndex = 17;
            // 
            // dtpIngreso
            // 
            dtpIngreso.Format = DateTimePickerFormat.Short;
            dtpIngreso.Location = new Point(403, 146);
            dtpIngreso.Name = "dtpIngreso";
            dtpIngreso.Size = new Size(116, 27);
            dtpIngreso.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(534, 151);
            label12.Name = "label12";
            label12.Size = new Size(125, 20);
            label12.TabIndex = 15;
            label12.Text = "Fecha Caducidad:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(281, 151);
            label11.Name = "label11";
            label11.Size = new Size(103, 20);
            label11.TabIndex = 14;
            label11.Text = "Fecha Ingreso:";
            // 
            // cmbUnidad
            // 
            cmbUnidad.FormattingEnabled = true;
            cmbUnidad.Items.AddRange(new object[] { "Unidad", "", "Docena", "", "Ramo", "", "Caja" });
            cmbUnidad.Location = new Point(403, 108);
            cmbUnidad.Name = "cmbUnidad";
            cmbUnidad.Size = new Size(121, 28);
            cmbUnidad.TabIndex = 13;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(403, 68);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(100, 27);
            txtStockMinimo.TabIndex = 12;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(403, 30);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 27);
            txtStock.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(279, 111);
            label9.Name = "label9";
            label9.Size = new Size(60, 20);
            label9.TabIndex = 10;
            label9.Text = "Unidad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(279, 75);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 9;
            label8.Text = "Stock Minimo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 33);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 8;
            label7.Text = "Stock:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Rosas", "", "Tulipanes", "", "Lirios", "", "Claveles", "", "Girasoles", "", "Orquídeas" });
            cmbCategoria.Location = new Point(93, 108);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(144, 28);
            cmbCategoria.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 151);
            label6.Name = "label6";
            label6.Size = new Size(53, 20);
            label6.TabIndex = 6;
            label6.Text = "Precio:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(93, 148);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(129, 27);
            txtPrecio.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 116);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 4;
            label5.Text = "Categoria:";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 75);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(93, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(144, 27);
            txtNombre.TabIndex = 2;
            // 
            // txtID
            // 
            txtID.Location = new Point(93, 30);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(129, 27);
            txtID.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 37);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 0;
            label3.Text = "ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 332);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 2;
            label10.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(96, 329);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar por nombre";
            txtBuscar.Size = new Size(261, 27);
            txtBuscar.TabIndex = 3;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(363, 329);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(26, 27);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "🔍";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Categoria, Precio, Stock, StockMinimo, Unidad, FechaIngreso, FechaCaducidad });
            dgvProductos.Location = new Point(12, 372);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(830, 342);
            dgvProductos.TabIndex = 5;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 50F;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoría";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // StockMinimo
            // 
            StockMinimo.FillWeight = 140F;
            StockMinimo.HeaderText = "Stock Mínimo";
            StockMinimo.Name = "StockMinimo";
            StockMinimo.ReadOnly = true;
            // 
            // Unidad
            // 
            Unidad.HeaderText = "Unidad";
            Unidad.Name = "Unidad";
            Unidad.ReadOnly = true;
            // 
            // FechaIngreso
            // 
            FechaIngreso.HeaderText = "Fecha Ingreso";
            FechaIngreso.Name = "FechaIngreso";
            FechaIngreso.ReadOnly = true;
            // 
            // FechaCaducidad
            // 
            FechaCaducidad.HeaderText = "Fecha Caducidad";
            FechaCaducidad.Name = "FechaCaducidad";
            FechaCaducidad.ReadOnly = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(853, 749);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(panelSuperior);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            Load += Productos_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnNuevo;
        private Label label2;
        private Button btnGuardar;
        private Button btnEliminar;
        private GroupBox groupBox1;
        private TextBox txtID;
        private Label label3;
        private Label label5;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private ComboBox cmbCategoria;
        private Label label6;
        private Label label7;
        private TextBox txtStockMinimo;
        private TextBox txtStock;
        private Label label9;
        private Label label8;
        private ComboBox cmbUnidad;
        private Label label10;
        private TextBox txtBuscar;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private DateTimePicker dtpIngreso;
        private Label label12;
        private Label label11;
        private DateTimePicker dtpCaducidad;
        private Button btnSalir;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn StockMinimo;
        private DataGridViewTextBoxColumn Unidad;
        private DataGridViewTextBoxColumn FechaIngreso;
        private DataGridViewTextBoxColumn FechaCaducidad;
    }
}