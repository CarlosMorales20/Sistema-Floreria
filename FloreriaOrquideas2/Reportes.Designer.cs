namespace FloreriaOrquideas2
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            panelSuperior = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Filtros = new GroupBox();
            dtpFin = new DateTimePicker();
            dtpInicio = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            cmbReporte = new ComboBox();
            label3 = new Label();
            btnGenerarExcel = new Button();
            button3 = new Button();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Filtros.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.MistyRose;
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(453, 82);
            panelSuperior.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 50);
            label2.Name = "label2";
            label2.Size = new Size(297, 20);
            label2.TabIndex = 2;
            label2.Text = "Consulta de ventas, inventario y estadísticas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(104, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 32);
            label1.TabIndex = 1;
            label1.Text = "REPORTES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(84, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Filtros
            // 
            Filtros.Controls.Add(dtpFin);
            Filtros.Controls.Add(dtpInicio);
            Filtros.Controls.Add(label5);
            Filtros.Controls.Add(label4);
            Filtros.Controls.Add(cmbReporte);
            Filtros.Controls.Add(label3);
            Filtros.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Filtros.Location = new Point(0, 88);
            Filtros.Name = "Filtros";
            Filtros.Size = new Size(246, 187);
            Filtros.TabIndex = 1;
            Filtros.TabStop = false;
            Filtros.Text = "Filtros";
            // 
            // dtpFin
            // 
            dtpFin.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(108, 126);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(128, 25);
            dtpFin.TabIndex = 5;
            // 
            // dtpInicio
            // 
            dtpInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpInicio.Format = DateTimePickerFormat.Custom;
            dtpInicio.Location = new Point(108, 84);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(128, 25);
            dtpInicio.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(11, 132);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 3;
            label5.Text = "Fecha de fin:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(11, 90);
            label4.Name = "label4";
            label4.Size = new Size(100, 17);
            label4.TabIndex = 2;
            label4.Text = "Fecha de inicio:";
            // 
            // cmbReporte
            // 
            cmbReporte.FormattingEnabled = true;
            cmbReporte.Items.AddRange(new object[] { "Venta", "Inventario", "Mermas" });
            cmbReporte.Location = new Point(27, 50);
            cmbReporte.Name = "cmbReporte";
            cmbReporte.Size = new Size(185, 25);
            cmbReporte.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 30);
            label3.Name = "label3";
            label3.Size = new Size(108, 17);
            label3.TabIndex = 0;
            label3.Text = "Tipo de Reporte:";
            // 
            // btnGenerarExcel
            // 
            btnGenerarExcel.BackColor = Color.FromArgb(89, 177, 139);
            btnGenerarExcel.FlatStyle = FlatStyle.Flat;
            btnGenerarExcel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGenerarExcel.ForeColor = SystemColors.ButtonHighlight;
            btnGenerarExcel.Location = new Point(275, 131);
            btnGenerarExcel.Name = "btnGenerarExcel";
            btnGenerarExcel.Size = new Size(126, 32);
            btnGenerarExcel.TabIndex = 5;
            btnGenerarExcel.Text = "Generar Excel";
            btnGenerarExcel.UseVisualStyleBackColor = false;
            btnGenerarExcel.Click += btnGenerarExcel_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(353, 255);
            button3.Name = "button3";
            button3.Size = new Size(88, 32);
            button3.TabIndex = 7;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 299);
            Controls.Add(button3);
            Controls.Add(btnGenerarExcel);
            Controls.Add(Filtros);
            Controls.Add(panelSuperior);
            Name = "Reportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Filtros.ResumeLayout(false);
            Filtros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private GroupBox Filtros;
        private Label label3;
        private DateTimePicker dtpFin;
        private DateTimePicker dtpInicio;
        private Label label5;
        private Label label4;
        private ComboBox cmbReporte;
        private Button btnGenerarExcel;
        private Button button3;
    }
}