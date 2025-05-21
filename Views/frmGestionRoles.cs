using InvSis.Controllers;
using InvSis.Model;

namespace InvSis.Views
{
    public partial class frmGestionRoles : Form
    {
        private RolesController _controller;

        public frmGestionRoles()
        {
            InitializeComponent();
            _controller = new RolesController(this); // Asignamos el controlador
            _controller.LoadRolesForComboBox(); // Cargamos los roles al inicio
            _controller.LoadPermissionsForComboBox(); // Cargamos los permisos al inicio
        }

        // Método para mostrar mensajes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnAgregarRol_Click_1(object sender, EventArgs e)
        {

        }
    }
}
