using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloreriaOrquideas2
{
    public partial class Productos : Form
    {
        private void CargarProductos()
        {
            dgvProductos.Rows.Clear();

            SqlConnection cn = Conexion.obtenerConexion(); //Se crea el objeto para la conexion
            cn.Open();

            string query = "SELECT * FROM Flores";

            SqlCommand cmd = new SqlCommand(query, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvProductos.Rows.Add(
                    dr["idFlor"],
                    dr["nombre"],
                    dr["categoria"],
                    dr["precio"],
                    dr["stock"],
                    dr["stockMinimo"],
                    dr["unidad"],
                    dr["fechaIngreso"],
                    dr["fechaCaducidad"]
                );
            }

            dr.Close();
            cn.Close();
        }

        int idProducto = 1;
        int filaSeleccionada = -1;

        public Productos()
        {
            InitializeComponent();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cn = Conexion.obtenerConexion();
                cn.Open();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CargarProductos();

            txtID.ReadOnly = true;

            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProductos.AllowUserToAddRows = false;

            dgvProductos.RowHeadersVisible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            cmbCategoria.SelectedIndex = -1;
            txtPrecio.Clear();
            txtStock.Clear();
            txtStockMinimo.Clear();
            cmbUnidad.SelectedIndex = -1;
        }

        private void MostrarProductos()
        {
            dgvProductos.Rows.Clear();

            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            string query = "SELECT * FROM Flores";

            SqlCommand cmd = new SqlCommand(query, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvProductos.Rows.Add(
                    dr["idProducto"],
                    dr["nombre"],
                    dr["categoria"],
                    dr["precio"],
                    dr["stock"],
                    dr["stockMinimo"],
                    dr["unidad"]
                );
            }

            dr.Close();
            cn.Close();
        }

        public class Venta
        {
            public int IdVenta { get; set; }
            public string Cliente { get; set; }
            public DateTime Fecha { get; set; }
            public double Total { get; set; }
        }

        public class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Categoria { get; set; }
            public double Precio { get; set; }
            public int Stock { get; set; }
            public int StockMinimo { get; set; }
            public string Unidad { get; set; }
        }

        private bool Validar()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre.");
                return false;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una categoría.");
                return false;
            }

            double precio;

            if (!double.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio incorrecto.");
                return false;
            }

            int stock;

            if (!int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Stock incorrecto.");
                return false;
            }

            int minimo;

            if (!int.TryParse(txtStockMinimo.Text, out minimo))
            {
                MessageBox.Show("Stock mínimo incorrecto.");
                return false;
            }

            if (cmbUnidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una unidad.");
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            SqlCommand cmd;

            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                // INSERTAR
                string query = @"INSERT INTO Flores
        (nombre,categoria,precio,stock,stockMinimo,unidad,fechaIngreso,fechaCaducidad)
        VALUES
        (@nombre,@categoria,@precio,@stock,@stockMinimo,@unidad,@fechaIngreso,@fechaCaducidad)";

                cmd = new SqlCommand(query, cn);
            }
            else
            {
                // ACTUALIZAR
                string query = @"UPDATE Flores SET
        nombre=@nombre,
        categoria=@categoria,
        precio=@precio,
        stock=@stock,
        stockMinimo=@stockMinimo,
        unidad=@unidad,
        fechaIngreso=@fechaIngreso,
        fechaCaducidad=@fechaCaducidad
        WHERE idFlor=@id";

                cmd = new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));
            }

            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@categoria", cmbCategoria.Text);
            cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
            cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
            cmd.Parameters.AddWithValue("@stockMinimo", int.Parse(txtStockMinimo.Text));
            cmd.Parameters.AddWithValue("@unidad", cmbUnidad.Text);
            cmd.Parameters.AddWithValue("@fechaIngreso", dtpIngreso.Value.Date);
            cmd.Parameters.AddWithValue("@fechaCaducidad", dtpCaducidad.Value.Date);

            cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Datos guardados correctamente.");

            CargarProductos();
            Limpiar();

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbCategoria.Text = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecio.Text = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStock.Text = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtStockMinimo.Text = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
                cmbUnidad.Text = dgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString();

                dtpIngreso.Value = Convert.ToDateTime(dgvProductos.Rows[e.RowIndex].Cells[7].Value);
                dtpCaducidad.Value = Convert.ToDateTime(dgvProductos.Rows[e.RowIndex].Cells[8].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            string query = "DELETE FROM Flores WHERE idFlor=@id";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text));

            cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Producto eliminado");

            CargarProductos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            dgvProductos.Rows.Clear();

            SqlConnection cn = Conexion.obtenerConexion(); //Se crea el objeto para la conexion
            cn.Open(); //Se ejecuta

            string query = "SELECT * FROM Flores WHERE nombre LIKE @nombre"; //

            SqlCommand cmd = new SqlCommand(query, cn); //Se ejecuta la consulta

            cmd.Parameters.AddWithValue("@nombre", "%" + txtBuscar.Text + "%");

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvProductos.Rows.Add(
                    dr["idFlor"],
                    dr["nombre"],
                    dr["categoria"],
                    dr["precio"],
                    dr["stock"],
                    dr["stockMinimo"],
                    dr["unidad"],
                    dr["FechaIngreso"],
                    dr["FechaCaducidad"]
                );
            }

            dr.Close();
            cn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
