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
    public partial class FormAgregarProd : Form
    {
        public FormAgregarProd()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            if (cbTipo.SelectedIndex == -1 ||
                cbUso.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtPrecio.Text) ||
                cbColor.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                string.IsNullOrWhiteSpace(txtProveedor.Text) ||
                string.IsNullOrWhiteSpace(txtCapacidad.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor complete todos los campos.");
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return false;
            }

            // Verificar el valor de "Meses de Garantía" (puede ser 0 o mayor a 0)
            if (nMeses.Value < 0)
            {
                MessageBox.Show("Los meses de garantía deben ser al menos 0.");
                return false;
            }

            return true;
        }

        private void IniciaContador()
        {
            try
            {
                // Ruta relativa para acceder al archivo XML en la carpeta "XML"
                string rutaXml = Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");

                // Verificar si la carpeta "XML" existe, si no, crearla
                if (!Directory.Exists(Path.Combine(Application.StartupPath, "XML")))
                {
                    Directory.CreateDirectory(Path.Combine(Application.StartupPath, "XML"));
                }

                if (File.Exists(rutaXml))
                {
                    dataSet11.ReadXml(rutaXml);

                    // Obtener todos los códigos existentes en la tabla
                    var codigos = dataSet11.TblDatos.Rows.Cast<DataRow>()
                        .Select(row => Convert.ToInt32(row["Codigo"])).ToList();

                    // Buscar el siguiente número disponible en la secuencia
                    int nextCodigo = 1;
                    while (codigos.Contains(nextCodigo))
                    {
                        nextCodigo++; // Continuar incrementando hasta encontrar un código libre
                    }

                    lblCodigo.Text = nextCodigo.ToString(); // Asignar el siguiente código disponible
                }
                else
                {
                    // Si el archivo no existe, comenzar con el código 1
                    lblCodigo.Text = "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el código: {ex.Message}");
                lblCodigo.Text = "1"; // Establecer el código como 1 si hay un error
            }
        }

        private void btnAgregarMochila_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            // Ruta para el archivo XML en la carpeta "XML"
            string rutaXml = Path.Combine(Application.StartupPath, "XML", "Mochilas.xml");

            // Verificar si la carpeta "XML" existe, si no, crearla
            if (!Directory.Exists(Path.Combine(Application.StartupPath, "XML")))
            {
                Directory.CreateDirectory(Path.Combine(Application.StartupPath, "XML"));
            }
            if (!File.Exists(rutaXml))
            {

                using (StreamWriter writer = new StreamWriter(rutaXml))
                {
                    writer.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    writer.WriteLine("<DataSet1 xmlns=\"http://tempuri.org/DataSet1.xsd\">");
                    writer.WriteLine("</DataSet1>");

                }
            }
            dataSet11.ReadXml(rutaXml);

            // Crear un nuevo objeto para agregar la mochila
            object[] Vector = new object[10];

            // Llenar el vector con los datos del formulario
            Vector[0] = lblCodigo.Text; // Código
            Vector[1] = cbTipo.SelectedItem.ToString();
            Vector[2] = cbUso.SelectedItem.ToString();
            Vector[3] = decimal.Parse(txtPrecio.Text);
            Vector[4] = cbColor.SelectedItem.ToString();
            Vector[5] = txtMarca.Text;
            Vector[6] = txtProveedor.Text;
            Vector[7] = txtCapacidad.Text;
            Vector[8] = nMeses.Value.ToString();  // Usar el valor de NumericUpDown para "Meses de Garantía"
            Vector[9] = txtDescripcion.Text;

            // Agregar el nuevo producto a la tabla
            dataSet11.TblDatos.Rows.Add(Vector);

            // Escribir los datos en el archivo XML
            dataSet11.WriteXml(rutaXml);

            // Mostrar mensaje de éxito
            MessageBox.Show("Mochila agregada correctamente.");

            // Actualizar el contador para el próximo producto
     
            LimpiarCampos();
        }

        private void nMeses_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormAgregarProd_Load(object sender, EventArgs e)
        {
            nMeses.Minimum = 0;    
            nMeses.Maximum = 24;  
            nMeses.Increment = 1;  
            nMeses.Value = 0;      
            IniciaContador();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                double precio;
                
                if (e.KeyChar == (char)Keys.Enter)
                {
                    precio = double.Parse(txtPrecio.Text);

                    if (precio < 0)
                    {
                        txtPrecio.Clear();
                        MessageBox.Show("El precio no puede ser negativo.");
                        txtPrecio.Focus();
                        return;
                    }
                        cbColor.Focus();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar el precio: {ex.Message}");
            }
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
         
        }

        private void cbColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbColor.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar un color para la mochila.");
                }
                else
                {
                    txtMarca.Focus();
                }
            }
        }
        private void LimpiarCampos()
        {
            // Resetear todos los campos a sus valores iniciales
            cbTipo.SelectedIndex = -1;
            cbUso.SelectedIndex = -1;
            txtPrecio.Clear();
            cbColor.SelectedIndex = -1;
            txtMarca.Clear();
            txtProveedor.Clear();
            txtCapacidad.Clear();
            txtDescripcion.Clear();
            nMeses.Value = 0;

            // Actualizar el código para el siguiente producto
            IniciaContador();

            // Enfocar el primer campo para el siguiente ingreso
            if (cbTipo.Items.Count > 0)
                cbTipo.Focus();
        }
        private void txtMarca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    MessageBox.Show("La marca es un campo obligatorio.");
                }
                else
                {
                    txtProveedor.Focus();
                }
            }
        }

        private void txtProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtProveedor.Text))
                {
                    MessageBox.Show("El proveedor es un campo obligatorio.");
                }
                else
                {
                    txtCapacidad.Focus();
                }
            }
        }

        private void txtCapacidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                
                if (e.KeyChar == (char)Keys.Enter)
                {
                    
                        nMeses.Focus();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar la capacidad: {ex.Message}");
            }
        }

        private void nMeses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtDescripcion.Focus();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción es un campo obligatorio.");
                }
                else
                {
                    btnAgregarMochila_Click(sender, e);
                }
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
