using Microsoft.Win32;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WinAppMenu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        // Verificar usuario y contraseña contra el archivo de registros
        private bool VerificarUsuario(string usuario, string contrasena)
        {
            // Obtener la ruta generalizada del archivo de usuarios
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Usuario.txt");

            // Verificar si el archivo existe
            if (File.Exists(filePath))
            {
                string[] lineas = File.ReadAllLines(filePath);

                foreach (string linea in lineas)
                {
                    // Separar el usuario y la contraseña
                    string[] datos = linea.Split(new string[] { "Usuario: ", ", Contraseña: " }, StringSplitOptions.None);
                    if (datos.Length >= 2)
                    {
                        string usuarioGuardado = datos[1].Trim();
                        string contrasenaGuardada = datos[2].Trim();

                        // Comparar si el usuario y la contraseña coinciden, respetando mayúsculas y minúsculas
                        if (usuarioGuardado == usuario && contrasenaGuardada == contrasena)
                        {
                            return true; // Usuario y contraseña correctos
                        }
                    }
                }
            }
            return false; // Usuario o contraseña incorrectos
        }

        // Manejo de eventos para el campo de texto del nombre de usuario
        private void nombre_Enter(object sender, EventArgs e)
        {
          
        }

        private void nombre_Leave(object sender, EventArgs e)
        {
            
        }

        // Manejo de eventos para el campo de texto de la contraseña
        private void contraseña_Enter(object sender, EventArgs e)
        {
           
        }

        private void contraseña_Leave(object sender, EventArgs e)
        {
         
        }

        // Mostrar u ocultar la contraseña
        private void muestra_CheckedChanged(object sender, EventArgs e)
        {
          
        }

   

        // Evento para abrir la ventana de registro
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMochila_Click_1(object sender, EventArgs e)
        {
            string usuario = nombre.Text.Trim();
            string contrasena = contraseña.Text;

            // Validar campos vacíos o con texto por defecto
            if (string.IsNullOrEmpty(usuario) || usuario == "Ingrese su usuario")
            {
                MessageBox.Show("Por favor ingrese su usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombre.Focus();
                return;
            }

            if (string.IsNullOrEmpty(contrasena) || contrasena == "Ingrese la contraseña")
            {
                MessageBox.Show("Por favor ingrese su contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contraseña.Focus();
                return;
            }

            // Validar que la contraseña no contenga espacios
            if (contrasena.Contains(" "))
            {
                MessageBox.Show("La contraseña no debe contener espacios.", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contraseña.Focus();
                return;
            }

            // Si pasó las validaciones, verificar usuario y contraseña
            if (VerificarUsuario(usuario, contrasena))
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                contraseña.Clear();
                contraseña.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            registro rg = new registro();
            rg.ShowDialog();
        }

        private void muestra_CheckedChanged_1(object sender, EventArgs e)
        {
            if (muestra.Checked == true)
            {
                contraseña.UseSystemPasswordChar = false; // Mostrar la contraseña
            }
            else
            {
                contraseña.UseSystemPasswordChar = true; // Ocultar la contraseña
            }
        }

        private void nombre_Leave_1(object sender, EventArgs e)
        {
            if (nombre.Text == "")
            {
                nombre.Text = "Ingrese su usuario";
                nombre.ForeColor = Color.Black;
            }
        }

        private void nombre_Enter_1(object sender, EventArgs e)
        {
            if (nombre.Text == "Ingrese su usuario")
            {
                nombre.Text = "";
                nombre.ForeColor = Color.Black;
            }
        }

        private void contraseña_Enter_1(object sender, EventArgs e)
        {
            if (contraseña.Text == "Ingrese la contraseña")
            {
                contraseña.Text = "";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = true;
            }
        }

        private void contraseña_Leave_1(object sender, EventArgs e)
        {
            if (contraseña.Text == "")
            {
                contraseña.Text = "Ingrese la contraseña";
                contraseña.ForeColor = Color.Black;
                contraseña.UseSystemPasswordChar = false;
            }
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                contraseña.Focus();
            }
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregarMochila.Focus();
            }
        }

        private void btnAgregarMochila_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter) {
                string usuario = nombre.Text.Trim();
                string contrasena = contraseña.Text;

                // Validar campos vacíos o con texto por defecto
                if (string.IsNullOrEmpty(usuario) || usuario == "Ingrese su usuario")
                {
                    MessageBox.Show("Por favor ingrese su usuario.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nombre.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(contrasena) || contrasena == "Ingrese la contraseña")
                {
                    MessageBox.Show("Por favor ingrese su contraseña.", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contraseña.Focus();
                    return;
                }

                // Validar que la contraseña no contenga espacios
                if (contrasena.Contains(" "))
                {
                    MessageBox.Show("La contraseña no debe contener espacios.", "Contraseña inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    contraseña.Focus();
                    return;
                }

                // Si pasó las validaciones, verificar usuario y contraseña
                if (VerificarUsuario(usuario, contrasena))
                {
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    contraseña.Clear();
                    contraseña.Focus();
                }
            }
        }
    }
}
