namespace FloreriaOrquideas2
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            panelSuperior = new Panel();
            btnCancelar = new Button();
            btnGuardarVenta = new Button();
            btnNuevaVenta = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            DatosCliente = new GroupBox();
            cmbCliente = new ComboBox();
            dtpEntrega = new DateTimePicker();
            dtpPedido = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtPrecioU = new TextBox();
            txtCantidad = new TextBox();
            button1 = new Button();
            label10 = new Label();
            label9 = new Label();
            cmbFlor = new ComboBox();
            label8 = new Label();
            dgvVenta = new DataGridView();
            Flor = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio_U = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            lblTotalUnidades = new Label();
            lblnumFlores = new Label();
            label12 = new Label();
            label11 = new Label();
            groupBox3 = new GroupBox();
            txtEspecificaciones = new TextBox();
            btnEliminar = new Button();
            groupBox4 = new GroupBox();
            lblTotal = new Label();
            txtboxDescuento = new TextBox();
            lblSubtotal = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            txtNombre = new TextBox();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            DatosCliente.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.MistyRose;
            panelSuperior.Controls.Add(btnCancelar);
            panelSuperior.Controls.Add(btnGuardarVenta);
            panelSuperior.Controls.Add(btnNuevaVenta);
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(624, 101);
            panelSuperior.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 141, 40);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ButtonHighlight;
            btnCancelar.Location = new Point(505, 21);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 36);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarVenta
            // 
            btnGuardarVenta.BackColor = Color.FromArgb(107, 144, 102);
            btnGuardarVenta.FlatStyle = FlatStyle.Flat;
            btnGuardarVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardarVenta.ForeColor = SystemColors.Control;
            btnGuardarVenta.Location = new Point(391, 21);
            btnGuardarVenta.Name = "btnGuardarVenta";
            btnGuardarVenta.Size = new Size(108, 36);
            btnGuardarVenta.TabIndex = 4;
            btnGuardarVenta.Text = "Guardar Venta";
            btnGuardarVenta.UseVisualStyleBackColor = false;
            btnGuardarVenta.Click += btnGuardarVenta_Click;
            // 
            // btnNuevaVenta
            // 
            btnNuevaVenta.BackColor = Color.FromArgb(161, 63, 73);
            btnNuevaVenta.FlatStyle = FlatStyle.Flat;
            btnNuevaVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNuevaVenta.ForeColor = Color.White;
            btnNuevaVenta.Location = new Point(277, 21);
            btnNuevaVenta.Name = "btnNuevaVenta";
            btnNuevaVenta.Size = new Size(108, 36);
            btnNuevaVenta.TabIndex = 3;
            btnNuevaVenta.Text = "+ Nueva Venta";
            btnNuevaVenta.UseVisualStyleBackColor = false;
            btnNuevaVenta.Click += btnNuevaVenta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 61);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Registro de ventas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 19);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 1;
            label1.Text = "Ventas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DatosCliente
            // 
            DatosCliente.Controls.Add(txtNombre);
            DatosCliente.Controls.Add(cmbCliente);
            DatosCliente.Controls.Add(dtpEntrega);
            DatosCliente.Controls.Add(dtpPedido);
            DatosCliente.Controls.Add(label7);
            DatosCliente.Controls.Add(label6);
            DatosCliente.Controls.Add(txtDireccion);
            DatosCliente.Controls.Add(txtTelefono);
            DatosCliente.Controls.Add(label5);
            DatosCliente.Controls.Add(label4);
            DatosCliente.Controls.Add(label3);
            DatosCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatosCliente.Location = new Point(3, 107);
            DatosCliente.Name = "DatosCliente";
            DatosCliente.Size = new Size(391, 175);
            DatosCliente.TabIndex = 1;
            DatosCliente.TabStop = false;
            DatosCliente.Text = "Datos del Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(259, 126);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(107, 25);
            cmbCliente.TabIndex = 10;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            // 
            // dtpEntrega
            // 
            dtpEntrega.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEntrega.CustomFormat = "dd/MM/yyyy";
            dtpEntrega.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpEntrega.Format = DateTimePickerFormat.Custom;
            dtpEntrega.Location = new Point(259, 75);
            dtpEntrega.Name = "dtpEntrega";
            dtpEntrega.Size = new Size(105, 25);
            dtpEntrega.TabIndex = 9;
            // 
            // dtpPedido
            // 
            dtpPedido.CalendarFont = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPedido.CustomFormat = "dd/MM/yyyy";
            dtpPedido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpPedido.Format = DateTimePickerFormat.Custom;
            dtpPedido.Location = new Point(259, 28);
            dtpPedido.Name = "dtpPedido";
            dtpPedido.Size = new Size(105, 25);
            dtpPedido.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(172, 78);
            label7.Name = "label7";
            label7.Size = new Size(90, 17);
            label7.TabIndex = 7;
            label7.Text = "Fecha Entrega";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 31);
            label6.Name = "label6";
            label6.Size = new Size(87, 17);
            label6.TabIndex = 6;
            label6.Text = "Fecha pedido";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(66, 123);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(181, 25);
            txtDireccion.TabIndex = 5;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(66, 78);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 25);
            txtTelefono.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 126);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 2;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 78);
            label4.Name = "label4";
            label4.Size = new Size(58, 17);
            label4.TabIndex = 1;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 31);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtPrecioU);
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbFlor);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(3, 288);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 164);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // txtPrecioU
            // 
            txtPrecioU.Location = new Point(96, 69);
            txtPrecioU.Name = "txtPrecioU";
            txtPrecioU.Size = new Size(78, 23);
            txtPrecioU.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(96, 43);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(77, 23);
            txtCantidad.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(49, 117);
            button1.Name = "button1";
            button1.Size = new Size(92, 33);
            button1.TabIndex = 4;
            button1.Text = "+ Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 72);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 3;
            label10.Text = "Precio U";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 46);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 2;
            label9.Text = "Cantidad (U)";
            // 
            // cmbFlor
            // 
            cmbFlor.FormattingEnabled = true;
            cmbFlor.Location = new Point(66, 17);
            cmbFlor.Name = "cmbFlor";
            cmbFlor.Size = new Size(107, 23);
            cmbFlor.TabIndex = 1;
            cmbFlor.SelectedIndexChanged += cmbFlor_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 20);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 0;
            label8.Text = "Flor";
            // 
            // dgvVenta
            // 
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Columns.AddRange(new DataGridViewColumn[] { Flor, Cantidad, Precio_U, Subtotal });
            dgvVenta.Location = new Point(209, 288);
            dgvVenta.MultiSelect = false;
            dgvVenta.Name = "dgvVenta";
            dgvVenta.RowHeadersVisible = false;
            dgvVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVenta.Size = new Size(403, 166);
            dgvVenta.TabIndex = 3;
            // 
            // Flor
            // 
            Flor.HeaderText = "Flor";
            Flor.Name = "Flor";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio_U
            // 
            Precio_U.HeaderText = "PrecioUni";
            Precio_U.Name = "Precio_U";
            // 
            // Subtotal
            // 
            Subtotal.HeaderText = "Subtotal";
            Subtotal.Name = "Subtotal";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblTotalUnidades);
            groupBox1.Controls.Add(lblnumFlores);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(3, 458);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 117);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resumen de la venta";
            // 
            // lblTotalUnidades
            // 
            lblTotalUnidades.AutoSize = true;
            lblTotalUnidades.Location = new Point(147, 61);
            lblTotalUnidades.Name = "lblTotalUnidades";
            lblTotalUnidades.Size = new Size(13, 15);
            lblTotalUnidades.TabIndex = 3;
            lblTotalUnidades.Text = "0";
            // 
            // lblnumFlores
            // 
            lblnumFlores.AutoSize = true;
            lblnumFlores.Location = new Point(147, 28);
            lblnumFlores.Name = "lblnumFlores";
            lblnumFlores.Size = new Size(13, 15);
            lblnumFlores.TabIndex = 2;
            lblnumFlores.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(9, 61);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 1;
            label12.Text = "Total de Unidades";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 28);
            label11.Name = "label11";
            label11.Size = new Size(115, 15);
            label11.TabIndex = 0;
            label11.Text = "No. Flores diferentes";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtEspecificaciones);
            groupBox3.Location = new Point(400, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(211, 145);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Especificaciones de ramo";
            // 
            // txtEspecificaciones
            // 
            txtEspecificaciones.Location = new Point(3, 22);
            txtEspecificaciones.Multiline = true;
            txtEspecificaciones.Name = "txtEspecificaciones";
            txtEspecificaciones.Size = new Size(206, 116);
            txtEspecificaciones.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(556, 458);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(55, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "-";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblTotal);
            groupBox4.Controls.Add(txtboxDescuento);
            groupBox4.Controls.Add(lblSubtotal);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label13);
            groupBox4.Location = new Point(262, 458);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(288, 117);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Totales";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.ForestGreen;
            lblTotal.Location = new Point(233, 92);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 25);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "0.00";
            // 
            // txtboxDescuento
            // 
            txtboxDescuento.Location = new Point(87, 58);
            txtboxDescuento.Name = "txtboxDescuento";
            txtboxDescuento.Size = new Size(100, 23);
            txtboxDescuento.TabIndex = 4;
            txtboxDescuento.TextChanged += txtboxDescuento_TextChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(233, 28);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(13, 15);
            lblSubtotal.TabIndex = 3;
            lblSubtotal.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(15, 94);
            label15.Name = "label15";
            label15.Size = new Size(48, 20);
            label15.TabIndex = 2;
            label15.Text = "Total:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(15, 61);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 1;
            label14.Text = "Descuento:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 28);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 0;
            label13.Text = "Subtotal:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(66, 28);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 25);
            txtNombre.TabIndex = 11;
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 587);
            Controls.Add(groupBox4);
            Controls.Add(btnEliminar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(dgvVenta);
            Controls.Add(groupBox2);
            Controls.Add(DatosCliente);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTAS";
            Load += Ventas_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            DatosCliente.ResumeLayout(false);
            DatosCliente.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private GroupBox DatosCliente;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpPedido;
        private Label label7;
        private Label label6;
        private DateTimePicker dtpEntrega;
        private GroupBox groupBox2;
        private ComboBox cmbFlor;
        private Label label8;
        private DataGridView dgvVenta;
        private Label label9;
        private Label label10;
        private DataGridViewTextBoxColumn Flor;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio_U;
        private DataGridViewTextBoxColumn Subtotal;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnEliminar;
        private Label lblTotalUnidades;
        private Label lblnumFlores;
        private Label label12;
        private Label label11;
        private GroupBox groupBox4;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label lblTotal;
        private TextBox txtboxDescuento;
        private Label lblSubtotal;
        private TextBox txtPrecioU;
        private TextBox txtCantidad;
        private TextBox txtEspecificaciones;
        private Button btnGuardarVenta;
        private Button btnNuevaVenta;
        private Button btnCancelar;
        private ComboBox cmbCliente;
        private TextBox txtNombre;
    }
}