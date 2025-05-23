using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventariosCore.Business;
using InventariosCore.Controllers;
using InvSis.Views;

namespace InvSis.Views
{
    public partial class frmLogIn : Form
    {
        private UsuariosController _usuariosController;

        public frmLogIn()
        {
            InitializeComponent();
            _usuariosController = new UsuariosController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("El campo de usuario no puede estar vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                MessageBox.Show("El campo de contraseña no puede estar vacío.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuarioIngresado = txtUsuario.Text.Trim();
            string contrasenaIngresada = txtContraseña.Text;

            // Si es admin (especial)
            if (usuarioIngresado.ToLower() == "admin")
            {
                Sesion.IniciarSesion(usuarioIngresado);
                MessageBox.Show("Ha iniciado sesión como administrador.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            try
            {
                var usuario = _usuariosController.AutenticarUsuario(usuarioIngresado, contrasenaIngresada);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, o el usuario está inactivo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Guardar en Sesion
                Sesion.IniciarSesion(usuario.Nickname);

                MessageBox.Show($"Bienvenido {usuario.Nickname}.", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado durante la autenticación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
