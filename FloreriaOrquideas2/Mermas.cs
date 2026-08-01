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
using System.Collections.Generic;

namespace FloreriaOrquideas2
{
    public partial class Mermas : Form
    {
        public string NombreFlor { get; set; }
        public Mermas()
        {
            InitializeComponent();
        }

        private void Mermas_Load(object sender, EventArgs e)
        {
            txtFlor.Text = NombreFlor;
            dtpFecha.Value = DateTime.Now;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            txtMotivo.Clear();
            txtCantidad.Clear();
            dtpFecha.Value = DateTime.Now;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // 
            if (txtCantidad.Text == "" || txtMotivo.Text == "")
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            int cantidadMerma = Convert.ToInt32(txtCantidad.Text);

            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            // Verificar stock total de la flor
            SqlCommand cmdStock = new SqlCommand(
                "SELECT SUM(stock) FROM Flores WHERE nombre=@nombre", cn);

            cmdStock.Parameters.AddWithValue("@nombre", txtFlor.Text);

            int stockTotal = Convert.ToInt32(cmdStock.ExecuteScalar());

            if (cantidadMerma > stockTotal)
            {
                MessageBox.Show("No hay suficiente stock.");
                cn.Close();
                return;
            }

            // Obtener los lotes ordenados por fecha (FIFO)
            SqlCommand cmdLotes = new SqlCommand(
                @"SELECT idFlor, stock
          FROM Flores
          WHERE nombre=@nombre AND stock>0
          ORDER BY fechaIngreso ASC", cn);

            cmdLotes.Parameters.AddWithValue("@nombre", txtFlor.Text);

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

            int restante = cantidadMerma;

            foreach (var lote in lotes)
            {
                if (restante == 0)
                    break;

                int descontar = Math.Min(restante, lote.stock);

                // Actualizar stock del lote
                SqlCommand cmdActualizar = new SqlCommand(
                    @"UPDATE Flores
              SET stock = stock - @cantidad
              WHERE idFlor = @idFlor", cn);

                cmdActualizar.Parameters.AddWithValue("@cantidad", descontar);
                cmdActualizar.Parameters.AddWithValue("@idFlor", lote.idFlor);

                cmdActualizar.ExecuteNonQuery();

                // Registrar la merma
                SqlCommand cmdMerma = new SqlCommand(
                    @"INSERT INTO Mermas(idFlor,cantidad,motivo,fecha)
              VALUES(@idFlor,@cantidad,@motivo,@fecha)", cn);

                cmdMerma.Parameters.AddWithValue("@idFlor", lote.idFlor);
                cmdMerma.Parameters.AddWithValue("@cantidad", descontar);
                cmdMerma.Parameters.AddWithValue("@motivo", txtMotivo.Text);
                cmdMerma.Parameters.AddWithValue("@fecha", dtpFecha.Value);

                cmdMerma.ExecuteNonQuery();

                restante -= descontar;
            }

            cn.Close();

            MessageBox.Show("Merma registrada correctamente.");

            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonsalir_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.Show();
            this.Close();
        }
    }
}
