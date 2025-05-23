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

namespace InvSis.Views
{
    public partial class frmMDI : Form
    {
        private Dictionary<string, Form> openForms = new Dictionary<string, Form>();
        public frmMDI()
        {
            InitializeComponent();
            ConfigurarPermisosBotones();
        }

        private void btnRepAud_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmVReportesAuditoria");
        }
        private void btnAdmProd_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmAdminProd");
        }

        private void btnGesRoles_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmGestionRoles");
        }

        private void btnAdmUsr_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmUsuarios");
        }

        private void btnAPI_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmRepAPI");
        }

        private void btnRegMov_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmRegMov");
        }

        private void btnRepInv_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmRepInv");
        }

        private void btnGestionarPermisos_Click(object sender, EventArgs e)
        {
            OpenFormInPanel("frmGestrionPermisos");
        }

        // En el formulario principal, después de iniciar sesión:
        private void ConfigurarPermisosBotones()
        {
            // Si es administrador, habilita todo
            if (Sesion.EsAdministrador)
            {
                btnAdmUsr.Enabled = true;
                btnGesRoles.Enabled = true;
                btnRepAud.Enabled = true;
                btnAPI.Enabled = true;
                // habilita otros botones si es necesario
                return;
            }

            // Si no es admin, habilita botones según permisos

            // Ejemplo: botón para administrar usuarios requiere permiso "Alta" o "Actualizacion"
            btnAdmUsr.Enabled = TienePermiso("Alta") || TienePermiso("Actualizacion");

            btnGesRoles.Enabled = TienePermiso("Actualizacion");

            btnRepAud.Enabled = TienePermiso("Consulta");

            btnAPI.Enabled = false; // Deshabilitado para todos excepto admin (ejemplo)

            // Agrega condiciones para los demás botones según permisos
        }

        // Método auxiliar para checar si el usuario tiene cierto permiso
        private bool TienePermiso(string nombrePermiso)
        {
            return Sesion.PermisosActuales.Any(p => p.Descripcion.Equals(nombrePermiso, StringComparison.OrdinalIgnoreCase));
        }


        private void OpenFormInPanel(string formName)
        {
            Form formToShow;

            // Verificar si la ventana ya existe
            if (openForms.ContainsKey(formName))
            {
                // Obtener la referencia al formulario existente
                formToShow = openForms[formName];

                // Traer la ventana al frente
                formToShow.BringToFront();
            }
            else
            {
                // Crear una nueva instancia de la ventana según el nombre
                formToShow = CrearForma(formName);

                if (formToShow == null)
                {
                    return;
                }

                // Configurar propiedades de la ventana
                formToShow.TopLevel = false;
                formToShow.FormBorderStyle = FormBorderStyle.None;
                formToShow.Dock = DockStyle.Fill;

                // Agregar la ventana al panel 2
                splitMDI.Panel2.Controls.Add(formToShow);

                // Agregar la ventana al diccionario
                openForms.Add(formName, formToShow);

                // Mostrar la ventana
                formToShow.Show();
                formToShow.BringToFront();
            }
        }

        private Form CrearForma(string formName)
        {
            switch (formName)
            {
                case "frmAdminProd":
                    return new frmAdminProd();
                case "frmGestionRoles":
                    return new frmGestionRoles();
                case "frmGestrionPermisos":
                    return new frmGestrionPermisos();
                case "frmVReportesAuditoria":
                    return new frmVReportesAuditoria();
                case "frmUsuarios":
                    return new frmUsuarios();
                case "frmRepAPI":
                    return new frmRepAPI();
                case "frmRegMov":
                    return new frmRegMov();
                case "frmRepInv":
                    return new frmRepInv();
                default:
                    MessageBox.Show($"No se reconoce el formulario: {formName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            foreach (Form form in openForms.Values)
            {
                form.Close();
                form.Dispose();
            }
            openForms.Clear();
        }

        private void btnCambiarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        $"¿Está seguro que desea cerrar la sesión de {Sesion.UsuarioActual}?",
        "Cerrar Sesión",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Cerrar todas las ventanas abiertas
                foreach (Form form in openForms.Values)
                {
                    form.Close();
                    form.Dispose();
                }
                openForms.Clear();

                Sesion.CerrarSesion();

                // Mostrar formulario de login
                frmLogIn login = new frmLogIn();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    // Después de iniciar sesión, configurar los permisos
                    ConfigurarPermisosBotones();
                }
                else
                {
                    // Si canceló el login, cerrar la aplicación
                    this.Close();
                }
            }
        }

        
    }
}
