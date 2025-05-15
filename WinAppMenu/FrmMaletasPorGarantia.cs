using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class FrmMaletasPorGarantia : Form
    {
        DataTable mochilasTable;
        public FrmMaletasPorGarantia()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath,"XML", "Mochilas.xml");
            dataSet1.ReadXml(rutaXml);
            mochilasTable = dataSet1.Tables[0];

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void FrmMaletasPorGarantia_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            int garantiaSeleccionada = Convert.ToInt32(comboBox1.SelectedItem);

            DataView vistaFiltrada = new DataView(mochilasTable);
            vistaFiltrada.RowFilter = $"Garantia = {garantiaSeleccionada}";

            var rds = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", vistaFiltrada);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
