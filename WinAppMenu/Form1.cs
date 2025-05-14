using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            FormBuscarProd ObjBuscar = new FormBuscarProd();
            ObjBuscar.ShowDialog();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditarProd ObjEditar = new FormEditarProd();    
            ObjEditar.ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            FrmAcercaDe ObjAcercade = new FrmAcercaDe();
            ObjAcercade.ShowDialog();
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

        }

        private void maletasPorUsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarMaletasPorUso ObjMaletasUso = new FrmMostrarMaletasPorUso();
            ObjMaletasUso.ShowDialog();
        }

        private void porMesesDeGarantíaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaletasPorGarantia ObjMaletasGarantia = new FrmMaletasPorGarantia();
            ObjMaletasGarantia.ShowDialog();
        }

        private void maletasPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaletasPorProveedor ObjMaletasPorProveedor = new FrmMaletasPorProveedor();
            ObjMaletasPorProveedor.ShowDialog();
        }

        private void maletasPorColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaletasPorColor ObjMaletasPorColor = new FrmMaletasPorColor();
            ObjMaletasPorColor.ShowDialog();
        }

        private void mochilasPorPrecioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaletasPorPrecio ObjMaletasPorPrecio = new FrmMaletasPorPrecio();
            ObjMaletasPorPrecio.ShowDialog();

        }

        private void mochilasPorCapacidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMaletasPorCapacidad ObjMaletasPorCapacidad = new FrmMaletasPorCapacidad();
            ObjMaletasPorCapacidad.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
