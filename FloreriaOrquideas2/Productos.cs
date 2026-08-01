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
        private void CargarProductos() // Carga todos los productos registrados en la tabla Flores
        {
            dgvProductos.Rows.Clear();

            SqlConnection cn = Conexion.obtenerConexion(); // Abrir conexión con la base de datos
            cn.Open();

            string query = "SELECT * FROM Flores"; // Consulta para obtener todos los registros

            SqlCommand cmd = new SqlCommand(query, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) // Llenar el DataGridView con los datos obtenidos
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
                SqlConnection cn = Conexion.obtenerConexion(); // Crear la conexión con la base de datos
                cn.Open();// Abrir la conexión con la base de datos
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CargarProductos(); //Mostrar los productos al cargar el formulario

            txtID.ReadOnly = true; //El ID del producto no se puede modificar, ya que es autoincremental en la base de datos

            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Seleccionar toda la fila al hacer clic en una celda

            dgvProductos.AllowUserToAddRows = false; //No permitir agregar filas manualmente en el DataGridView 

            dgvProductos.RowHeadersVisible = false; //Ocultar la columna de encabezado de fila en el DataGridView
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar(); // Limpiar los campos del formulario para ingresar un nuevo producto
        }

        private void Limpiar() // Limpiar los campos del formulario
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
            if (!Validar()) // Validar los campos antes de guardar
            {
                return; 
            }

            SqlConnection cn = Conexion.obtenerConexion(); // Crear la conexión con la base de datos
            cn.Open(); // Abrir la conexión con la base de datos

            SqlCommand cmd;

            if (string.IsNullOrWhiteSpace(txtID.Text)) // Si el campo ID está vacío, significa que se va a insertar un nuevo producto
            {
                // Consulta para insertar un nuevo producto en la tabla Flores
                string query = @"INSERT INTO Flores (nombre,categoria,precio,stock,stockMinimo,unidad,fechaIngreso,fechaCaducidad)
        VALUES (@nombre,@categoria,@precio,@stock,@stockMinimo,@unidad,@fechaIngreso,@fechaCaducidad)";

                cmd = new SqlCommand(query, cn); // Crear el comando SQL para insertar un nuevo producto
            }
            else 
            {
                // Consulta para actualizar un producto existente en la tabla Flores
                string query = @"UPDATE Flores SET nombre=@nombre, categoria=@categoria, precio=@precio, stock=@stock, stockMinimo=@stockMinimo, unidad=@unidad, fechaIngreso=@fechaIngreso, fechaCaducidad=@fechaCaducidad
                WHERE idFlor=@id";

                cmd = new SqlCommand(query, cn); // Crear el comando SQL para actualizar un producto existente

                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text)); // Agregar el parámetro @id con el valor del ID del producto a actualizar
            }
            // Agregar los parámetros a los valores de la consulta SQL para insertar o actualizar un producto
            cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
            cmd.Parameters.AddWithValue("@categoria", cmbCategoria.Text);
            cmd.Parameters.AddWithValue("@precio", decimal.Parse(txtPrecio.Text));
            cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
            cmd.Parameters.AddWithValue("@stockMinimo", int.Parse(txtStockMinimo.Text));
            cmd.Parameters.AddWithValue("@unidad", cmbUnidad.Text);
            cmd.Parameters.AddWithValue("@fechaIngreso", dtpIngreso.Value.Date);
            cmd.Parameters.AddWithValue("@fechaCaducidad", dtpCaducidad.Value.Date);

            cmd.ExecuteNonQuery(); // Ejecutar la consulta SQL para insertar o actualizar un producto
            cn.Close(); // Cerrar la conexión con la base de datos
            MessageBox.Show("Datos guardados correctamente.");

            CargarProductos(); // Recargar los productos en el DataGridView después de guardar los cambios
            Limpiar(); // Limpiar los campos del formulario después de guardar los cambios

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (e.RowIndex >= 0) // Verificar que se haya hecho clic en una fila válida
            {
                // Llenar los campos del formulario con los datos del producto seleccionado en el DataGridView
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

            try
            {
                SqlConnection cn = Conexion.obtenerConexion(); // Crear la conexión con la base de datos
                cn.Open(); // Abrir la conexión con la base de datos

                string query = "DELETE FROM Flores WHERE idFlor=@id"; // Consulta para eliminar un producto de la tabla Flores

                SqlCommand cmd = new SqlCommand(query, cn); // Crear el comando SQL para eliminar un producto
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text)); // Agregar el parámetro @id con el valor del ID del producto a eliminar

                int filas = cmd.ExecuteNonQuery(); // Ejecutar la consulta SQL para eliminar un producto

                cn.Close(); // Cerrar la conexión con la base de datos

                MessageBox.Show("Filas eliminadas: " + filas);

                CargarProductos(); // Recargar los productos en el DataGridView después de eliminar un producto
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            dgvProductos.Rows.Clear();

            SqlConnection cn = Conexion.obtenerConexion(); //Se crea el objeto para la conexion
            cn.Open(); //Se abre la conexion

            string query = "SELECT * FROM Flores WHERE nombre LIKE @nombre"; //Se crea la consulta para buscar el producto por nombre

            SqlCommand cmd = new SqlCommand(query, cn); //Se crea el objeto para ejecutar la consulta

            cmd.Parameters.AddWithValue("@nombre", "%" + txtBuscar.Text + "%"); //Se agrega el parametro para la consulta

            SqlDataReader dr = cmd.ExecuteReader(); //Se ejecuta la consulta y se obtiene el resultado

            while (dr.Read()) //Se recorre el resultado y se agrega al DataGridView
            {
                //Se agregan los datos al DataGridView
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
            dr.Close(); //Se cierra el DataReader
            cn.Close(); //Se cierra la conexion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }
    }
}
