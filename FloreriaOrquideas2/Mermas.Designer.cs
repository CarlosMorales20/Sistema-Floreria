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
            SuspendLayout();
            // 
            // txtFlor
            // 
            txtFlor.Location = new Point(136, 66);
            txtFlor.Name = "txtFlor";
            txtFlor.ReadOnly = true;
            txtFlor.Size = new Size(100, 23);
            txtFlor.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 69);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 111);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 153);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 3;
            label3.Text = "Motivo: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 192);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 4;
            label4.Text = "Fecha: ";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(136, 108);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 5;
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(136, 150);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(100, 23);
            txtMotivo.TabIndex = 6;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(136, 186);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(100, 23);
            dtpFecha.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(47, 249);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(180, 249);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "Cancelar";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 28);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 10;
            label5.Text = "Registrar Merma";
            // 
            // Mermas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 303);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(btnGuardar);
            Controls.Add(dtpFecha);
            Controls.Add(txtMotivo);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFlor);
            Name = "Mermas";
            Text = "Mermas";
            Load += Mermas_Load;
            ResumeLayout(false);
            PerformLayout();
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
    }
}