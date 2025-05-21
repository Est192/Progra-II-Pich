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
        }



        // Método para mostrar mensajes
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                ShowMessage("Selecciona un permiso en la lista para inhabilitar.");
                return;
            }

            string nombre = dataGridView1.CurrentRow.Cells["NombrePermiso"].Value?.ToString();

            if (string.IsNullOrEmpty(nombre))
            {
                ShowMessage("No se pudo obtener el nombre del permiso seleccionado.");
                return;
            }

            var permiso = _controller.GetPermisoByNombre(nombre);

            if (permiso == null)
            {
                ShowMessage("El permiso seleccionado no existe.");
                return;
            }

            permiso.Estatus = false; // Inhabilitar

            bool resultado = _controller.ActualizarPermiso(permiso);

            if (resultado)
            {
                ShowMessage("Permiso inhabilitado correctamente.");
                ActualizarListadoPermisos();
            }
            else
            {
                ShowMessage("Error al inhabilitar el permiso.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombrePermiso.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                ShowMessage("Por favor, ingresa el nombre del permiso.");
                return;
            }

            if (string.IsNullOrEmpty(descripcion))
            {
                ShowMessage("Por favor, ingresa la descripción del permiso.");
                return;
            }

            // Aquí puedes decidir si agregas o editas dependiendo si el permiso ya existe
            var permisoExistente = _controller.GetPermisoByNombre(nombre);

            if (permisoExistente == null)
            {
                // No existe: agregar
                bool agregado = _controller.AgregarPermiso(new Permiso
                {
                    Nombre = nombre,
                    Descripcion = descripcion,
                    Estatus = true // Activo al agregar
                });

                if (agregado)
                    ShowMessage("Permiso agregado correctamente.");
                else
                    ShowMessage("Error al agregar el permiso.");
            }
            else
            {
                // Existe: actualizar
                permisoExistente.Descripcion = descripcion;
                permisoExistente.Estatus = true; // También podrías mantener el estatus original

                bool actualizado = _controller.ActualizarPermiso(permisoExistente);

                if (actualizado)
                    ShowMessage("Permiso actualizado correctamente.");
                else
                    ShowMessage("Error al actualizar el permiso.");
            }

            // Actualizar la lista mostrada en el DataGridView
            ActualizarListadoPermisos();

            // Limpiar los campos
            txtNombrePermiso.Text = "";
            txtDescripcion.Text = "";
        }

        public void ActualizarListadoPermisos()
        {
            var listaPermisos = _controller.ObtenerPermisos(); // Debe regresar lista completa o filtrada
            permisosControllerBindingSource.DataSource = listaPermisos;
            dataGridView1.Refresh();
        }

    }
}