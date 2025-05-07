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

        // Llamar al controlador para agregar un rol
        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            string nombreRol = txtNombreRol.Text;
            string estatus = cbxEstatus.SelectedItem.ToString();
            _controller.AddRole(nombreRol, estatus); // Llama al controlador para agregar el rol
        }

        // Llamar al controlador para eliminar un rol
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idRol = (int)cbxRolEliminar.SelectedValue; // Asumiendo que tienes un campo para el ID
            _controller.DeleteRole(idRol); // Llama al controlador para eliminar el rol
        }

        // Llamar al controlador para asignar un permiso a un rol
        private void btnAgregarPermiso_Click(object sender, EventArgs e)
        {
            int idRol = (int)cbxRolAgregarPermisos.SelectedValue;
            int idPermiso = (int)cbxPermiso.SelectedValue;
            _controller.AssignPermissionToRole(idRol, idPermiso); // Llama al controlador para agregar el permiso
        }

        // Llamar al controlador para remover un permiso de un rol
        private void btnRemoverPermiso_Click(object sender, EventArgs e)
        {
            int idRol = (int)cbxRolRemoverPermisos.SelectedValue;
            int idPermiso = (int)cbxPermisoAremover.SelectedValue;
            _controller.RemovePermissionFromRole(idRol, idPermiso); // Llama al controlador para remover el permiso
        }

        // Método para poblar el ComboBox de roles
        public void PopulateRolesComboBox(List<Rol> roles)
        {
            cbxRolEliminar.Items.Clear(); // Limpiamos el ComboBox
            cbxRolAgregarPermisos.Items.Clear(); // Limpiamos el ComboBox
            foreach (var rol in roles)
            {
                cbxRolEliminar.Items.Add(rol.NombreRol); // Agregamos los roles al ComboBox
                cbxRolAgregarPermisos.Items.Add(rol.NombreRol); // Agregamos los roles al ComboBox
            }
        }

        // Método para poblar el ComboBox de permisos
        public void PopulatePermissionsComboBox(List<Permiso> permisos)
        {
            cbxPermiso.Items.Clear(); // Limpiamos el ComboBox
            cbxPermisoAremover.Items.Clear(); // Limpiamos el ComboBox
            foreach (var permiso in permisos)
            {
                cbxPermiso.Items.Add(permiso.Descripcion); // Agregamos los permisos al ComboBox
                cbxPermisoAremover.Items.Add(permiso.Descripcion); // Agregamos los permisos al ComboBox
            }
        }

        // Método para mostrar mensajes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
