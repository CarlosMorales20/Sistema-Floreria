namespace FloreriaOrquideas2
{
    partial class Mermas
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
            txtFlor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtCantidad = new TextBox();
            txtMotivo = new TextBox();
            dtpFecha = new DateTimePicker();
            btnGuardar = new Button();
            btnSalir = new Button();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            botonsalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtFlor
            // 
            txtFlor.Font = new Font("Segoe UI", 9.75F);
            txtFlor.Location = new Point(132, 17);
            txtFlor.Name = "txtFlor";
            txtFlor.ReadOnly = true;
            txtFlor.Size = new Size(111, 25);
            txtFlor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.Location = new Point(52, 18);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(48, 90);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 2;
            label2.Text = "Cantidad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.Location = new Point(59, 52);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 3;
            label3.Text = "Motivo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.Location = new Point(67, 130);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 4;
            label4.Text = "Fecha: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 9.75F);
            txtCantidad.Location = new Point(132, 90);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(111, 25);
            txtCantidad.TabIndex = 5;
            // 
            // txtMotivo
            // 
            txtMotivo.Font = new Font("Segoe UI", 9.75F);
            txtMotivo.Location = new Point(132, 51);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(111, 25);
            txtMotivo.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Font = new Font("Segoe UI", 9.75F);
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(132, 126);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(111, 25);
            dtpFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(107, 144, 102);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(60, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(186, 39, 67);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(180, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 9);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 10;
            label5.Text = "Registro de Mermas";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MistyRose;
            panel1.Controls.Add(botonsalir);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 60);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 36);
            label6.Name = "label6";
            label6.Size = new Size(210, 15);
            label6.TabIndex = 12;
            label6.Text = "Control de existencias y stock de flores";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_07_31_at_8_53_43_PM__1_;
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnSalir);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(312, 47);
            panel2.TabIndex = 12;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dtpFecha);
            panel3.Controls.Add(txtMotivo);
            panel3.Controls.Add(txtCantidad);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtFlor);
            panel3.Location = new Point(12, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 189);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint;
            // 
            // botonsalir
            // 
            botonsalir.BackColor = Color.FromArgb(122, 164, 212);
            botonsalir.FlatStyle = FlatStyle.Flat;
            botonsalir.ForeColor = Color.White;
            botonsalir.Location = new Point(251, 9);
            botonsalir.Name = "botonsalir";
            botonsalir.Size = new Size(58, 23);
            botonsalir.TabIndex = 13;
            botonsalir.Text = "Salir";
            botonsalir.UseVisualStyleBackColor = false;
            botonsalir.Click += botonsalir_Click;
            // 
            // Mermas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(312, 308);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Mermas";
            Text = "Mermas";
            Load += Mermas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtFlor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtCantidad;
        private TextBox txtMotivo;
        private DateTimePicker dtpFecha;
        private Button btnGuardar;
        private Button btnSalir;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Label label6;
        private Button botonsalir;
    }
}