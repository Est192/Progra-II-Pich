namespace InvSis.Controllers
{
    using InvSis.Data;
    using InvSis.Model;
    using InvSis.Views;
    using System;
    using System.Collections.Generic;

    public class PermisosController
    {
        private readonly frmGestrionPermisos _view;
        private readonly PermisosDataAccess _dataAccess;
         private readonly PermisosDataAccess _permisosDataAccess;  // Instancia de PermisosDataAccess

        public PermisosController(frmGestrionPermisos view)
        {
            _view = view;
            _dataAccess = new PermisosDataAccess();
        }

        // Cargar permisos en el ComboBox para eliminar
        public void LoadPermissionsForDeletionComboBox()
        {
            List<Permiso> permisos = _dataAccess.ObtenerTodosLosPermisos();
            _view.PopulatePermissionComboBox(permisos); // Llamamos a un método en la vista
        }

        // Agregar un permiso
        public void AddPermission(string nombrePermiso, string estatus)
        {
            var permiso = new Permiso
            {
                Descripcion = nombrePermiso, // Usar Descripcion en lugar de NombrePermiso
                Estatus = estatus == "Activo" ? 1 : 2
            };

            int idGenerado = _dataAccess.InsertarPermiso(permiso);
            if (idGenerado > 0)
            {
                _view.ShowMessage("Permiso agregado exitosamente.");
            }
            else
            {
                _view.ShowMessage("Error al agregar el permiso.");
            }
        }


        // Eliminar un permiso
        public void DeletePermission(int idPermiso)
        {
            bool exito = _dataAccess.EliminarPermiso(idPermiso);
            if (exito)
            {
                _view.ShowMessage("Permiso desactivado exitosamente.");
            }
            else
            {
                _view.ShowMessage("Error al desactivar el permiso.");
            }
        }

        // Obtener un permiso por su descripción
        public Permiso? GetPermissionByDescription(string descripcion)
        {
            // Aquí realizamos la búsqueda por descripción
            return _permisosDataAccess.ObtenerPermisoPorDescripcion(descripcion);  // Método de acceso a datos que retorna un objeto Permiso
        }

        public void UpdatePermission(string nombrePermiso, string estatus)
        {
            // Verifica si el permiso existe en la base de datos
            var permisoExistente = _permisosDataAccess.ObtenerPermisoPorDescripcion(nombrePermiso);

            if (permisoExistente != null)
            {
                // Si el permiso existe, se crea un objeto Permiso con el nuevo estatus
                permisoExistente.Estatus = estatus == "Activo" ? 1 : 2; // Asumiendo 1 para activo y 2 para inactivo

                // Llamar al método de acceso a datos para actualizar el permiso
                bool exito = _permisosDataAccess.ActualizarPermiso(permisoExistente);

                // Notificar si la actualización fue exitosa
                if (exito)
                {
                    MessageBox.Show("Permiso editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo editar el permiso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el permiso no existe
                MessageBox.Show("El permiso no existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Permiso> GetActivePermissions()
        {
            return _permisosDataAccess.ObtenerTodosLosPermisos(true);  // Solo obtener los permisos activos
        }

        public bool DeletePermissionByDescription(string descripcion)
        {
            // Llamamos al método en el DataAccess para eliminar el permiso
            bool permisoEliminado = _permisosDataAccess.EliminarPermisoPorDescripcion(descripcion);

            if (permisoEliminado)
            {
                // Si la eliminación fue exitosa, actualizamos el ComboBox
                
                MessageBox.Show("Permiso eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Si no se pudo eliminar, mostramos un mensaje de error
                MessageBox.Show("No se pudo eliminar el permiso. Intenta nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return permisoEliminado;
        }

        




    }
}
