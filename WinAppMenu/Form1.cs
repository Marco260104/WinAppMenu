using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool HayDatosRegistrados()
        {
            string rutaXml = Path.Combine(Application.StartupPath,"XML" ,"Mochilas.xml");

            if (!File.Exists(rutaXml))
                return false;

            DataSet ds = new DataSet();
            ds.ReadXml(rutaXml);

            return ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vANToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregarProd ObjAgregar = new FormAgregarProd(); 
            ObjAgregar.ShowDialog();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormBuscarProd ObjBuscar = new FormBuscarProd();
            ObjBuscar.ShowDialog();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormEditarProd ObjEditar = new FormEditarProd();    
            ObjEditar.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormEliminarProd ObjEliminar = new FormEliminarProd();
            ObjEliminar.ShowDialog();
        }

        private void bienvenidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBienvenida ObjBienvenida = new FormBienvenida();
            ObjBienvenida.ShowDialog(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void totalProductosRegistradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FormTotalProductos ObjTotal = new FormTotalProductos();
            ObjTotal.ShowDialog();
        }

        private void cambiarFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.Font = fontDialog.Font;
            }
        }
    

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string rutaHtml = Path.Combine(Application.StartupPath, "Html", "acerca_de.html");

            if (File.Exists(rutaHtml))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = rutaHtml,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show("No se encontró el archivo acerca_de.html", "Error");
            }
        }

        private void actualizarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Solo es una simulacion, ustedes programen que se guarde en la ruta que ustedes quieran
            MessageBox.Show("Datos Actualizados Correctamente");
        }

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void verTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void maletasPorUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMostrarMaletasPorUso ObjMaletasUso = new FrmMostrarMaletasPorUso();
            ObjMaletasUso.ShowDialog();
        }

        private void porMesesDeGarantíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMaletasPorGarantia ObjMaletasGarantia = new FrmMaletasPorGarantia();
            ObjMaletasGarantia.ShowDialog();
        }

        private void maletasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMaletasPorProveedor ObjMaletasPorProveedor = new FrmMaletasPorProveedor();
            ObjMaletasPorProveedor.ShowDialog();
        }

        private void maletasPorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMaletasPorColor ObjMaletasPorColor = new FrmMaletasPorColor();
            ObjMaletasPorColor.ShowDialog();
        }

        private void mochilasPorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMaletasPorPrecio ObjMaletasPorPrecio = new FrmMaletasPorPrecio();
            ObjMaletasPorPrecio.ShowDialog();

        }

        private void mochilasPorCapacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMaletasPorCapacidad ObjMaletasPorCapacidad = new FrmMaletasPorCapacidad();
            ObjMaletasPorCapacidad.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mochilasPorMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HayDatosRegistrados())
            {
                MessageBox.Show("No hay datos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            FrmMaletasXMarca Obj = new FrmMaletasXMarca();
            Obj.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
