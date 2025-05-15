using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WinAppMenu
{
    public partial class FrmReporteTotal : Form
    {
        DataTable mochilasTable;

        public FrmReporteTotal()
        {
            InitializeComponent();
            string rutaXml = Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");

            // Carga el XML en el DataSet (asegúrate que dataSet1 está declarado en el diseñador)
            dataSet1.ReadXml(rutaXml);

            mochilasTable = dataSet1.Tables[0]; // Guarda la tabla principal

            // Configura el reporte con la tabla completa (sin filtro)
            Microsoft.Reporting.WinForms.ReportDataSource rds =
                new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", mochilasTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            // Establece el nombre del archivo .rdlc (ajusta ruta/nombre si es necesario)
            reportViewer1.LocalReport.ReportEmbeddedResource = "WinAppMenu.ReporteTotal.rdlc";
        }

        private void FrmReporteTotal_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            // Opcionalmente puedes dejarlo vacío o poner lógica aquí
        }
    }
}