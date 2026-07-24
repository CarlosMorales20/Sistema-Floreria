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


        private void CargarInventario()
        {
            dgvInventario.Rows.Clear();

            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            string consulta = @"SELECT
                        nombre,
                        SUM(stock) AS Existencias,
                        MIN(stockMinimo) AS StockMinimo
                        FROM Flores
                        GROUP BY nombre";

            SqlCommand cmd = new SqlCommand(consulta, cn);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string estado = "";

                int existencias = Convert.ToInt32(dr["Existencias"]);
                int minimo = Convert.ToInt32(dr["StockMinimo"]);

                if (existencias == 0)
                    estado = "Agotado";
                else if (existencias <= minimo)
                    estado = "Stock Bajo";
                else
                    estado = "Disponible";

                dgvInventario.Rows.Add(
                    dr["nombre"],
                    dr["Existencias"],
                    dr["StockMinimo"],
                    estado
                );
            }

            dr.Close();
            cn.Close();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarInventario();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvInventario.Rows.Clear();

            SqlConnection cn = Conexion.obtenerConexion();
            cn.Open();

            string consulta = @"SELECT
                        nombre,
                        SUM(stock) AS Existencias,
                        MIN(stockMinimo) AS StockMinimo
                        FROM Flores
                        WHERE nombre LIKE @nombre
                        GROUP BY nombre";

            SqlCommand cmd = new SqlCommand(consulta, cn);

            cmd.Parameters.AddWithValue("@nombre", "%" + txtBuscar.Text + "%");

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                int existencias = Convert.ToInt32(dr["Existencias"]);
                int minimo = Convert.ToInt32(dr["StockMinimo"]);

                string estado;

                if (existencias == 0)
                    estado = "Agotado";
                else if (existencias <= minimo)
                    estado = "Stock Bajo";
                else
                    estado = "Disponible";

                dgvInventario.Rows.Add(
                    dr["nombre"],
                    existencias,
                    minimo,
                    estado
                );
            }

            dr.Close();
            cn.Close();
        }

    }
}
