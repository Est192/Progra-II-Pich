using InvSis.Controllers;
using InvSis.Model;

namespace InvSis.Views
{
    public partial class frmGestrionPermisos : Form
    {
        private PermisosController _controller;

        public frmGestrionPermisos()
        {
            InitializeComponent();
            _controller = new PermisosController(this); // Asignamos el controlador
            _controller.LoadPermissionsForDeletionComboBox(); // Cargamos los permisos al inicio
        }

        // Método para poblar el ComboBox con los permisos
        public void PopulatePermissionComboBox(List<Permiso> permisos)
        {
            cbxPermisoElimicar.Items.Clear(); // Limpiamos el ComboBox
            foreach (var permiso in permisos)
            {
                cbxPermisoElimicar.Items.Add(permiso.Descripcion); // Añadimos las descripciones de permisos al ComboBox
            }
        }

        // Método para mostrar mensajes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        // Método para agregar permiso
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombrePermiso = txtNombrePermiso.Text;
            string estatus = cbxEstatus.SelectedItem.ToString();

            // Verificamos si el permiso ya existe
            bool existePermiso = _controller.GetPermissionByDescription(nombrePermiso) != null;

            if (existePermiso)
            {
                // Si el permiso existe, lo editamos
                _controller.UpdatePermission(nombrePermiso, estatus);
                MessageBox.Show("Permiso editado correctamente.");
            }
            else
            {
                // Si no existe, lo agregamos
                _controller.AddPermission(nombrePermiso, estatus);
                MessageBox.Show("Permiso agregado correctamente.");
            }

            // Actualizar el ComboBox de permisos
            ActualizarComboBoxPermisos();
        }

        // Método para eliminar un permiso
        private void button1_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un permiso
            if (cbxPermisoElimicar.SelectedItem == null)
            {
                MessageBox.Show("Por favor seleccione un permiso para eliminar.");
                return;
            }

            // Obtener el nombre del permiso seleccionado
            string nombrePermiso = cbxPermisoElimicar.SelectedItem.ToString();

            // Llamar al controlador para eliminar el permiso
            bool eliminado = _controller.DeletePermissionByDescription(nombrePermiso);

            if (eliminado)
            {
                MessageBox.Show("Permiso eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("Hubo un problema al eliminar el permiso.");
            }

            // Actualizar el ComboBox de permisos
            ActualizarComboBoxPermisos();
        }




        private void frmGestionPermisos_Load(object sender, EventArgs e)
        {
            // Poblamos el ComboBox con los valores de "ACTIVO" e "INACTIVO"
            cbxEstatus.Items.Clear();
            cbxEstatus.Items.Add("ACTIVO");
            cbxEstatus.Items.Add("INACTIVO");

            // Seleccionamos "ACTIVO" por defecto
            cbxEstatus.SelectedIndex = 0;  // Esto selecciona el primer valor "ACTIVO"
        }

        // Definir el evento Leave para el TextBox txtNombrePermiso
        private void txtNombrePermiso_Leave(object sender, EventArgs e)
        {
            string nombrePermiso = txtNombrePermiso.Text.Trim();

            if (string.IsNullOrEmpty(nombrePermiso))
            {
                // Si el nombre del permiso está vacío, no hacemos nada
                return;
            }

            // Buscar el permiso en la base de datos
            var permiso = _controller.GetPermissionByDescription(nombrePermiso);

            if (permiso != null)
            {
                // Si el permiso existe, cambiar el texto del botón y actualizar el ComboBox
                btnAgregar.Text = "Editar";  // Cambiar el texto del botón a "Editar"
                cbxEstatus.SelectedItem = permiso.Estatus == 1 ? "ACTIVO" : "INACTIVO";  // Actualizar el ComboBox con el estatus
            }
            else
            {
                // Si el permiso no existe, restablecer el botón y el ComboBox
                btnAgregar.Text = "Agregar";
                cbxEstatus.SelectedIndex = 0;  // Establecer el primer item como selección predeterminada (ACTIVO)
            }
        }


        private void ActualizarComboBoxPermisos()
        {
            // Limpiar el ComboBox actual
            cbxPermisoElimicar.Items.Clear();

            // Obtener la lista de permisos activos
            var permisosActivos = _controller.GetActivePermissions();

            // Agregar los permisos al ComboBox
            foreach (var permiso in permisosActivos)
            {
                cbxPermisoElimicar.Items.Add(permiso.Descripcion);
            }

            // Si hay elementos, seleccionar el primero
            if (cbxPermisoElimicar.Items.Count > 0)
            {
                cbxPermisoElimicar.SelectedIndex = 0;
            }
        }


        public void ActualizarComboBoxPermisos(List<string> permisos)
        {
            cbxPermisoElimicar.Items.Clear();
            foreach (var permiso in permisos)
            {
                cbxPermisoElimicar.Items.Add(permiso);
            }

            if (cbxPermisoElimicar.Items.Count > 0)
            {
                cbxPermisoElimicar.SelectedIndex = 0;
            }
        }

    }
}