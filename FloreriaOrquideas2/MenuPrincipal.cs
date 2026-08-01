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
            // Establecer el título del resumen con el mes y año actual
            lblTitulo.Text ="RESUMEN DE " + DateTime.Now.ToString("MMMM yyyy").ToUpper();

            CargarIngresosMes(); // Cargar los ingresos del mes actual
            CargarFloresVendidasMes(); // Cargar la cantidad de flores vendidas en el mes actual
            CargarClientesMes(); // Cargar la cantidad de clientes que han realizado pedidos en el mes actual
            CargarMermasMes(); // Cargar la cantidad de mermas en el mes actual
            CargarFlorMasVendida(); // Cargar la flor más vendida en el mes actual
            CargarExistencias(); // Cargar la cantidad de existencias de flores visibles
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


        //MEEEEEEEEEEEEEEEEEEEEEEEEEES
        private void CargarIngresosMes()// Cargar los ingresos del mes actual
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();
            // Consulta SQL para obtener la suma de los ingresos del mes actual
            string query = @"SELECT ISNULL(SUM(total),0)
            FROM Ramos
            WHERE MONTH(fechaPedido)=MONTH(GETDATE()) AND YEAR(fechaPedido)=YEAR(GETDATE())";

            SqlCommand cmd = new SqlCommand(query, cn); // Crear un comando SQL con la consulta y la conexión
            // Ejecutar el comando y obtener el resultado como un objeto
            decimal total =
            Convert.ToDecimal(cmd.ExecuteScalar());

            lblingresos.Text = total.ToString("C"); // Mostrar el total en el label con formato de moneda
            cn.Close();
        }

        private void CargarFloresVendidasMes()
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();
            // Consulta SQL para obtener la suma de las flores vendidas en el mes actual
            string query = @"SELECT ISNULL(SUM(cantidad),0)
            FROM Ramos
            WHERE MONTH(fechaPedido)=MONTH(GETDATE()) AND YEAR(fechaPedido)=YEAR(GETDATE())";
            SqlCommand cmd = new SqlCommand(query, cn);// Crear un comando SQL con la consulta y la conexión
            // Ejecutar el comando y obtener el resultado como un objeto
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblFV.Text = total.ToString();
            cn.Close();
        }
        private void CargarClientesMes()
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();
            // Consulta SQL para obtener la cantidad de clientes distintos que han realizado pedidos en el mes actual
            string query = @"SELECT COUNT(DISTINCT idCliente)
            FROM Ramos
            WHERE MONTH(fechaPedido)=MONTH(GETDATE()) AND YEAR(fechaPedido)=YEAR(GETDATE())";
            SqlCommand cmd = new SqlCommand(query, cn);
            // Ejecutar el comando y obtener el resultado como un objeto
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblCA.Text = total.ToString();
            cn.Close();
        }
        private void CargarMermasMes()
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();
            // Consulta SQL para obtener la suma de las mermas en el mes actual
            string query = @"SELECT ISNULL(SUM(cantidad),0)
            FROM Mermas
            WHERE MONTH(fecha)=MONTH(GETDATE()) AND YEAR(fecha)=YEAR(GETDATE())";
            SqlCommand cmd = new SqlCommand(query, cn);
            // Ejecutar el comando y obtener el resultado como un objeto
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblMermas.Text = total.ToString();
            cn.Close();
        }
        private void CargarFlorMasVendida()
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();
            // Consulta SQL para obtener la flor más vendida en el mes actual
            string query = @"SELECT TOP 1 F.nombre FROM Ramos R
            INNER JOIN Flores F ON R.idFlor = F.idFlor
            WHERE MONTH(R.fechaPedido)=MONTH(GETDATE()) AND YEAR(R.fechaPedido)=YEAR(GETDATE())
            GROUP BY F.nombre ORDER BY SUM(R.cantidad) DESC";
            SqlCommand cmd = new SqlCommand(query, cn); // Crear un comando SQL con la consulta y la conexión
            // Ejecutar el comando y obtener el resultado como un objeto
            object resultado = cmd.ExecuteScalar();
            if (resultado != null)
                lblFMV.Text = resultado.ToString();// Mostrar el nombre de la flor más vendida en el label
            else
                lblFMV.Text = "Sin ventas";// Si no hay ventas, mostrar "Sin ventas"
            cn.Close();
        }
        private void CargarExistencias()
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();
            // Consulta SQL para obtener la suma de las existencias de flores visibles
            string query = @"SELECT ISNULL(SUM(stock),0) FROM Flores
            WHERE visible = 1";
            SqlCommand cmd = new SqlCommand(query, cn);
            // Ejecutar el comando y obtener el resultado como un objeto
            int total = Convert.ToInt32(cmd.ExecuteScalar());
            lblExistencias.Text = total.ToString();
            cn.Close();
        }
    }
}
