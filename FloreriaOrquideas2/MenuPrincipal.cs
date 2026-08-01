using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloreriaOrquideas2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            ven.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            reportes.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inventario Inv = new Inventario();
            Inv.Show();
            this.Hide();
        }

        private void VerificarCaducidad()
        {
            SqlConnection cn = Conexion.obtenerConexion(); //Obtener la conexion a la BD
            cn.Open();

            // Contar lotes ya caducados
            string consultaCaducados = @" SELECT COUNT(*) FROM Flores
            WHERE stock > 0 AND fechaCaducidad < CAST(GETDATE() AS DATE)";

            SqlCommand cmdCaducados = new SqlCommand(consultaCaducados, cn);
            int caducados = Convert.ToInt32(cmdCaducados.ExecuteScalar()); //Guarda la cantidad de lotes caducados

            // Contar los lotes próximos a caducar (hoy hasta 7 días)
            string consultaProximos = @" SELECT COUNT(*) FROM Flores
            WHERE stock > 0 AND fechaCaducidad >= CAST(GETDATE() AS DATE) AND fechaCaducidad <= DATEADD(DAY,7,CAST(GETDATE() AS DATE))";

            SqlCommand cmdProximos = new SqlCommand(consultaProximos, cn);
            int proximos = Convert.ToInt32(cmdProximos.ExecuteScalar()); //Guarda la cantidad de lotes proximos

            cn.Close(); //Cerrar la conexion

            //Mostrar en el panel
            if (caducados > 0 || proximos > 0)     // Si existen lotes caducados o próximos a vencer
            {
                pnlCaducidad.Visible = true;  // Mostrar panel

                lblCaducidad.Text = ""; // Limpia el texto del Label

                if (caducados > 0) // Mostrar mensaje de lotes caducados
                    lblCaducidad.Text += "Hay " + caducados + " lote(s) caducado(s).\n";

                if (proximos > 0) // Mostrar mensaje de lotes próximos a caducar
                    lblCaducidad.Text += "Hay " + proximos + " lote(s) próximos a caducar.";
            }
            else
            {
                pnlCaducidad.Visible = false; // Si no existen alertas, ocultar el panel
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            VerificarCaducidad(); // Revisar automáticamente la caducidad de los lotes
        }

        private void pnlCaducidad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Productos prod = new Productos();
            prod.Show();
            this.Hide();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas ven = new Ventas();
            ven.Show();
            this.Hide();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
            this.Hide();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Reportes rep = new Reportes();
            rep.Show();
            this.Hide();
        }
    }
}
