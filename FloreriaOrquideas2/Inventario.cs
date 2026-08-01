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
    public partial class Inventario : Form
    {
        // Variable global para guardar la flor seleccionada
        string florSeleccionada = "";

        public Inventario()
        {
            InitializeComponent();

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegisEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarInventario();
        }


        private void CargarInventario() // Método para cargar el inventario en el DataGridView
        {
            dgvInventario.Rows.Clear(); // Limpiar el DataGridView antes de cargar los datos

            SqlConnection cn = Conexion.obtenerConexion(); // Obtener la conexión a la base de datos
            cn.Open(); // Abrir la conexión

            // Consulta SQL para obtener el inventario agrupado por nombre de flor
            string consulta = @"SELECT nombre,
                        SUM(stock) AS Existencias,
                        MIN(stockMinimo) AS StockMinimo
                        FROM Flores
                        GROUP BY nombre";

            SqlCommand cmd = new SqlCommand(consulta, cn); // Crear un comando SQL con la consulta y la conexión

            SqlDataReader dr = cmd.ExecuteReader(); // Ejecutar la consulta y obtener un SqlDataReader para leer los resultados

            while (dr.Read()) // Iterar sobre cada fila del resultado
            {
                string estado = ""; // Variable para almacenar el estado del inventario

                int existencias = Convert.ToInt32(dr["Existencias"]); // Obtener el valor de existencias del SqlDataReader
                int minimo = Convert.ToInt32(dr["StockMinimo"]); // Obtener el valor de stock mínimo del SqlDataReader

                if (existencias == 0)
                    estado = "Agotado";
                else if (existencias <= minimo)
                    estado = "Stock Bajo";
                else
                    estado = "Disponible";

                // Agregar una nueva fila al DataGridView con los datos obtenidos
                dgvInventario.Rows.Add(
                    dr["nombre"],
                    dr["Existencias"],
                    dr["StockMinimo"],
                    estado
                );
            }

            dr.Close(); // Cerrar el SqlDataReader
            cn.Close(); // Cerrar la conexión a la base de datos
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) // Método para buscar flores por nombre en el DataGridView
        {
            dgvInventario.Rows.Clear(); // Limpiar el DataGridView antes de cargar los datos filtrados

            SqlConnection cn = Conexion.obtenerConexion(); // Obtener la conexión a la base de datos
            cn.Open(); // Abrir la conexión

            // Consulta SQL para obtener el inventario filtrado por nombre de flor
            string consulta = @"SELECT nombre,
                        SUM(stock) AS Existencias,
                        MIN(stockMinimo) AS StockMinimo
                        FROM Flores
                        WHERE nombre LIKE @nombre
                        GROUP BY nombre";

            SqlCommand cmd = new SqlCommand(consulta, cn); // Crear un comando SQL con la consulta y la conexión

            cmd.Parameters.AddWithValue("@nombre", "%" + txtBuscar.Text + "%"); // Agregar el parámetro para la búsqueda por nombre

            SqlDataReader dr = cmd.ExecuteReader(); // Ejecutar la consulta y obtener un SqlDataReader para leer los resultados

            while (dr.Read())
            {
                int existencias = Convert.ToInt32(dr["Existencias"]); // Obtener el valor de existencias del SqlDataReader
                int minimo = Convert.ToInt32(dr["StockMinimo"]); // Obtener el valor de stock mínimo del SqlDataReader

                string estado; // Variable para almacenar el estado del inventario

                if (existencias == 0)
                    estado = "Agotado";
                else if (existencias <= minimo)
                    estado = "Stock Bajo";
                else
                    estado = "Disponible";

                // Agregar una nueva fila al DataGridView con los datos obtenidos
                dgvInventario.Rows.Add(
                    dr["nombre"],
                    existencias,
                    minimo,
                    estado
                );
            }

            dr.Close(); // Cerrar el SqlDataReader
            cn.Close(); // Cerrar la conexión a la base de datos
        }

        // Método para abrir el formulario de Mermas y pasarle la flor seleccionada
        private void button1_Click(object sender, EventArgs e)
        {
            if (florSeleccionada == "")
            {
                MessageBox.Show("Seleccione una flor.");
                return;
            }

            Mermas frm = new Mermas();
            frm.NombreFlor = florSeleccionada;
            frm.ShowDialog(); // Abrir el formulario de Mermas como un cuadro de diálogo modal

            CargarInventario(); // Recargar el inventario después de cerrar el formulario de Mermas para reflejar los cambios
        }

        private void dgvInventario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvInventario.Rows[e.RowIndex].Selected = true; // Seleccionar la fila completa al hacer clic en cualquier celda

                florSeleccionada = dgvInventario.Rows[e.RowIndex].Cells[0].Value.ToString(); // Guardar el nombre de la flor seleccionada en la variable global
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();   
            menu.Show();
            this.Hide();
        }
    }
}
