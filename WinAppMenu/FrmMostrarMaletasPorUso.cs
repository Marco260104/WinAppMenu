using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinAppMenu
{
    public partial class FrmMostrarMaletasPorUso : Form
    {
        DataTable mochilasTable;
        public FrmMostrarMaletasPorUso()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath, "Mochilas.xml");
            dataSet1.ReadXml(rutaXml);
            mochilasTable = dataSet1.Tables[0];
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void FrmMostrarMaletasPorUso_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            string usoSeleccionado = comboBox1.SelectedItem.ToString();

            DataView vistaFiltrada = new DataView(mochilasTable);
            vistaFiltrada.RowFilter = $"Uso = '{usoSeleccionado}'";

            // Cargar el informe con los datos filtrados
            Microsoft.Reporting.WinForms.ReportDataSource rds =
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", vistaFiltrada);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
