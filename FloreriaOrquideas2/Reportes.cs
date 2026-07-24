using ClosedXML.Excel;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloreriaOrquideas2
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();
            this.Hide();
        }

        private void btnGenerarExcel_Click(object sender, EventArgs e)
        {
            if (cmbReporte.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de reporte.");
                return;
            }

            string tipo = cmbReporte.SelectedItem.ToString();

            switch (tipo)
            {
                case "Venta":
                    ExportarVentas();
                    break;

                case "Inventario":
                    ExportarInventario();
                    break;

                case "Mermas":
                    ExportarMermas();
                    break;
            }
        }
        private void ExportarVentas()
        {
            MessageBox.Show("Entró al botón");
            SqlConnection cn = Conexion.obtenerConexion();

            cn.Open();

            string consulta = @"
SELECT
    C.nombre AS Cliente,
    F.nombre AS Flor,
    R.fechaPedido,
    R.fechaEntrega,
    R.cantidad,
    R.precioUnitario,
    R.subtotal,
    R.descuento,
    R.total
FROM Ramos R
INNER JOIN Clientes C
    ON R.idCliente = C.idCliente
INNER JOIN Flores F
    ON R.idFlor = F.idFlor
WHERE R.fechaPedido BETWEEN @inicio AND @fin
ORDER BY R.fechaPedido";

            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

            da.SelectCommand.Parameters.AddWithValue("@inicio", dtpInicio.Value.Date);

            da.SelectCommand.Parameters.AddWithValue("@fin", dtpFin.Value.Date);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cn.Close();

            XLWorkbook libro = new XLWorkbook();

            var hoja = libro.Worksheets.Add("Ventas");

            // Encabezados
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                hoja.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
            }

            // Datos
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    hoja.Cell(fila + 2, col + 1).Value = dt.Rows[fila][col].ToString();
                }
            }

            hoja.Columns().AdjustToContents();

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.Filter = "Excel (*.xlsx)|*.xlsx";
            guardar.FileName = "ReporteVentas.xlsx";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                libro.SaveAs(guardar.FileName);

                MessageBox.Show("Reporte generado correctamente.");
            }
        }

        private void ExportarInventario()
        {
            SqlConnection cn = Conexion.obtenerConexion();

            cn.Open();

            string consulta = @"
SELECT
    nombre AS Flor,
    SUM(stock) AS Stock,
    unidad AS Unidad
FROM Flores
GROUP BY nombre, unidad
ORDER BY nombre";

            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cn.Close();

            XLWorkbook libro = new XLWorkbook();

            var hoja = libro.Worksheets.Add("Inventario");

            // Encabezados
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                hoja.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
            }

            // Datos
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    hoja.Cell(fila + 2, col + 1).Value = dt.Rows[fila][col].ToString();
                }
            }

            hoja.Columns().AdjustToContents();

            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Excel (*.xlsx)|*.xlsx";
            guardar.FileName = "ReporteInventario.xlsx";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                libro.SaveAs(guardar.FileName);

                MessageBox.Show("Reporte de inventario generado correctamente.");
            }
        }

        private void ExportarMermas()
        {
            SqlConnection cn = Conexion.obtenerConexion();

            cn.Open();

            string consulta = @"
SELECT F.nombre AS Flor,M.cantidad,M.motivo,M.fecha
FROM Mermas M
INNER JOIN Flores F
ON M.idFlor = F.idFlor
WHERE M.fecha BETWEEN @inicio AND @fin
ORDER BY M.fecha";

            SqlDataAdapter da = new SqlDataAdapter(consulta, cn);

            da.SelectCommand.Parameters.AddWithValue("@inicio", dtpInicio.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@fin", dtpFin.Value.Date);

            DataTable dt = new DataTable();

            da.Fill(dt);

            cn.Close();

            XLWorkbook libro = new XLWorkbook();

            var hoja = libro.Worksheets.Add("Mermas");

            // Encabezados
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                hoja.Cell(1, i + 1).Value = dt.Columns[i].ColumnName;
            }

            // Datos
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    hoja.Cell(fila + 2, col + 1).Value = dt.Rows[fila][col].ToString();
                }
            }

            hoja.Columns().AdjustToContents();

            SaveFileDialog guardar = new SaveFileDialog();

            guardar.Filter = "Excel (*.xlsx)|*.xlsx";
            guardar.FileName = "ReporteMermas.xlsx";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                libro.SaveAs(guardar.FileName);

                MessageBox.Show("Reporte de mermas generado correctamente.");
            }
        }
    }
}
