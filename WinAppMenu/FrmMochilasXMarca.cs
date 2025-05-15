using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class FrmMochilasXMarca : Form
    {
        DataTable mochilasTable;

        public FrmMochilasXMarca()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");
            dataSet1.ReadXml(rutaXml);
            mochilasTable = dataSet1.Tables[0];

            // Configurar el evento para el botón de búsqueda
           // BtnBuscar.Click += BtnBuscar_Click;
        }

        private void FrmMochilasXMarca_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre de la marca.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string marcaBuscado = textBox1.Text.Trim();

            DataView vistaFiltrada = new DataView(mochilasTable);
            vistaFiltrada.RowFilter = $"Marca LIKE '%{marcaBuscado}%'";

            if (vistaFiltrada.Count == 0)
            {
                MessageBox.Show($"No se encontraron mochilas de la marca '{marcaBuscado}'.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Microsoft.Reporting.WinForms.ReportDataSource rds =
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", vistaFiltrada);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
            reportViewer1.Visible = true;
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.OK;
           this.Close();
        }
    }
}
