using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Resources;

namespace FloreriaOrquideas2
{
    public partial class Ventas : Form
    {

        public Ventas()
        {
            InitializeComponent();

        }

        private void CargarFlores()
        {
            cmbFlor.Items.Clear();

            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand("SELECT DISTINCT nombre FROM Flores ORDER BY nombre", cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmbFlor.Items.Add(dr["nombre"].ToString());
            }

            dr.Close();
            cn.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbFlor.Text == "")
            {
                MessageBox.Show("Seleccione una flor.");
                return;
            }

            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad.");
                return;
            }

            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal precio = Convert.ToDecimal(txtPrecioU.Text);

            decimal subtotal = cantidad * precio;

            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            SqlCommand cmd = new SqlCommand(
            @"SELECT ISNULL(SUM(stock),0)
            FROM Flores
            WHERE nombre=@nombre", cn);

            cmd.Parameters.AddWithValue("@nombre", cmbFlor.Text);

            int stock = Convert.ToInt32(cmd.ExecuteScalar());

            cn.Close();

            if (cantidad > stock)
            {
                MessageBox.Show("No hay suficiente stock.");

                return;
            }

            // Verificar si la flor ya fue agregada
            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                if (fila.Cells[0].Value.ToString() == cmbFlor.Text)
                {
                    MessageBox.Show("La flor ya fue agregada.");
                    return;
                }
            }

            dgvVenta.Rows.Add(
                cmbFlor.Text,
                cantidad,
                precio,
                subtotal
            );

            txtCantidad.Clear();
            txtPrecioU.Clear();
            cmbFlor.SelectedIndex = -1;

            CalcularTotal();
            CalcularTotal();
            ActualizarResumen();
        }

        public class DetalleVenta
        {
            public string Flor { get; set; }
            public int Cantidad { get; set; }
            public double PrecioUnitario { get; set; }
            public double subtotal { get; set; }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            CargarFlores();
        }

        private void cmbFlor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            string query = "SELECT precio FROM Flores WHERE nombre = @nombre";

            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@nombre", cmbFlor.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtPrecioU.Text = dr["precio"].ToString();
            }

            dr.Close();
            cn.Close();

        }
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells[3].Value != null)
                {
                    total += Convert.ToDecimal(fila.Cells[3].Value);
                }
            }

            lblSubtotal.Text = total.ToString("0.00");

            decimal descuento = 0;

            if (txtboxDescuento.Text != "")
                descuento = Convert.ToDecimal(txtboxDescuento.Text);

            lblTotal.Text = (total - descuento).ToString("0.00");
        }

        private void txtboxDescuento_TextChanged(object sender, EventArgs e)
        {
            decimal subtotal = 0;

            decimal.TryParse(lblSubtotal.Text, out subtotal);

            decimal descuento = 0;

            decimal.TryParse(txtboxDescuento.Text, out descuento);

            lblTotal.Text = (subtotal - descuento).ToString("0.00");
        }
        private void ActualizarResumen()
        {
            // Número de flores diferentes
            lblnumFlores.Text = dgvVenta.Rows.Count.ToString();

            // Total de unidades
            int totalUnidades = 0;

            foreach (DataGridViewRow fila in dgvVenta.Rows)
            {
                if (fila.Cells[1].Value != null)
                {
                    totalUnidades += Convert.ToInt32(fila.Cells[1].Value);
                }
            }

            lblTotalUnidades.Text = totalUnidades.ToString();
        }

        private void btnGuardarVenta_Click(object sender, EventArgs e)
        {
            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            SqlTransaction trans = cn.BeginTransaction();

            try
            {
                int idCliente = 0;

                // ==========================
                // BUSCAR CLIENTE
                // ==========================

                string buscarCliente =
                "SELECT idCliente FROM Clientes WHERE telefono=@telefono";

                SqlCommand cmdBuscar = new SqlCommand(buscarCliente, cn, trans);

                cmdBuscar.Parameters.AddWithValue("@telefono", txtTelefono.Text);

                object resultado = cmdBuscar.ExecuteScalar();

                if (resultado == null)
                {
                    string insertarCliente = @"INSERT INTO Clientes
            (nombre,telefono,direccion)
            VALUES
            (@nombre,@telefono,@direccion);

            SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdCliente =
                    new SqlCommand(insertarCliente, cn, trans);

                    cmdCliente.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmdCliente.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                    cmdCliente.Parameters.AddWithValue("@direccion", txtDireccion.Text);

                    idCliente = Convert.ToInt32(cmdCliente.ExecuteScalar());
                }
                else
                {
                    idCliente = Convert.ToInt32(resultado);
                }

                // ==========================
                // RECORRER EL DATAGRIDVIEW
                // ==========================

                foreach (DataGridViewRow fila in dgvVenta.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    string nombreFlor = fila.Cells[0].Value.ToString();
                    int cantidad = Convert.ToInt32(fila.Cells[1].Value);
                    decimal precio = Convert.ToDecimal(fila.Cells[2].Value);
                    decimal subtotal = Convert.ToDecimal(fila.Cells[3].Value);

                    // ==========================
                    // DESCONTAR INVENTARIO FIFO
                    // ==========================

                    // Verificar stock total
                    SqlCommand cmdVerificar = new SqlCommand(
                    @"SELECT ISNULL(SUM(stock),0)
FROM Flores
WHERE nombre=@nombre", cn, trans);

                    cmdVerificar.Parameters.AddWithValue("@nombre", nombreFlor);

                    int stockTotal = Convert.ToInt32(cmdVerificar.ExecuteScalar());

                    if (cantidad > stockTotal)
                    {
                        throw new Exception("No hay suficiente stock para la flor: " + nombreFlor);
                    }

                    // Obtener lotes ordenados por fecha
                    SqlCommand cmdLotes = new SqlCommand(
                    @"SELECT idFlor, stock
FROM Flores
WHERE nombre=@nombre
AND stock>0
ORDER BY fechaIngreso ASC", cn, trans);

                    cmdLotes.Parameters.AddWithValue("@nombre", nombreFlor);

                    SqlDataReader dr = cmdLotes.ExecuteReader();

                    List<(int idFlor, int stock)> lotes = new List<(int, int)>();

                    while (dr.Read())
                    {
                        lotes.Add((
                            Convert.ToInt32(dr["idFlor"]),
                            Convert.ToInt32(dr["stock"])
                        ));
                    }

                    dr.Close();

                    int restante = cantidad;

                    foreach (var lote in lotes)
                    {
                        if (restante == 0)
                            break;

                        int descontar = Math.Min(restante, lote.stock);

                        // Registrar el ramo usando el lote correspondiente
                        string insertarRamo = @"
    INSERT INTO Ramos
    (
        idCliente,
        idFlor,
        fechaPedido,
        fechaEntrega,
        cantidad,
        precioUnitario,
        subtotal,
        descuento,
        total,
        especificaciones
    )
    VALUES
    (
        @idCliente,
        @idFlor,
        @fechaPedido,
        @fechaEntrega,
        @cantidad,
        @precio,
        @subtotal,
        @descuento,
        @total,
        @especificaciones
    )";

                        SqlCommand cmdRamo = new SqlCommand(insertarRamo, cn, trans);

                        cmdRamo.Parameters.AddWithValue("@idCliente", idCliente);
                        cmdRamo.Parameters.AddWithValue("@idFlor", lote.idFlor);
                        cmdRamo.Parameters.AddWithValue("@fechaPedido", dtpPedido.Value.Date);
                        cmdRamo.Parameters.AddWithValue("@fechaEntrega", dtpEntrega.Value.Date);
                        cmdRamo.Parameters.AddWithValue("@cantidad", descontar);
                        cmdRamo.Parameters.AddWithValue("@precio", precio);
                        cmdRamo.Parameters.AddWithValue("@subtotal", descontar * precio);
                        cmdRamo.Parameters.AddWithValue("@descuento", Convert.ToDecimal(txtboxDescuento.Text));
                        cmdRamo.Parameters.AddWithValue("@total", Convert.ToDecimal(lblTotal.Text));
                        cmdRamo.Parameters.AddWithValue("@especificaciones", txtEspecificaciones.Text);

                        cmdRamo.ExecuteNonQuery();

                        // Descontar stock del lote
                        SqlCommand cmdActualizar = new SqlCommand(
                        @"UPDATE Flores
      SET stock = stock - @cantidad
      WHERE idFlor=@idFlor", cn, trans);

                        cmdActualizar.Parameters.AddWithValue("@cantidad", descontar);
                        cmdActualizar.Parameters.AddWithValue("@idFlor", lote.idFlor);

                        cmdActualizar.ExecuteNonQuery();

                        restante -= descontar;
                    }
                }

                trans.Commit();

                MessageBox.Show("Venta registrada correctamente.");

                dgvVenta.Rows.Clear();

                txtNombre.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                txtEspecificaciones.Clear();
                txtboxDescuento.Clear();
                lblTotal.Text = "0";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                MessageBox.Show(ex.Message);
            }

            cn.Close();

            LimpiarVenta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count > 0)
            {
                dgvVenta.Rows.RemoveAt(dgvVenta.SelectedRows[0].Index);

                CalcularTotal();
                ActualizarResumen();
            }
            else
            {
                MessageBox.Show("Seleccione una flor.");
            }
        }

        private void LimpiarVenta()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            txtCantidad.Clear();
            txtPrecioU.Clear();

            lblSubtotal.Text = "0";
            txtboxDescuento.Clear();
            lblTotal.Text = "0";

            txtEspecificaciones.Clear();

            cmbFlor.SelectedIndex = -1;

            dgvVenta.Rows.Clear();

            lblnumFlores.Text = "0";
            lblTotalUnidades.Text = "0";
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            LimpiarVenta();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}


