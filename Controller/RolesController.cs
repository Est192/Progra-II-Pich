namespace InvSis.Controllers
{
    using InvSis.Data;
    using InvSis.Model;
    using InvSis.Views;
    using System;
    using System.Collections.Generic;

    public class RolesController
    {
        private readonly frmGestionRoles _view;
        private readonly RolesDataAccess _dataAccess;

        // Constructor que recibe la vista y la capa de acceso a datos
        public RolesController(frmGestionRoles view)
        {
            _view = view;
            _dataAccess = new RolesDataAccess();
        }

        // Método para cargar todos los roles en el ComboBox de la vista
        public void LoadRolesForComboBox()
        {
            List<Rol> roles = _dataAccess.ObtenerTodosLosRoles();
            _view.PopulateRolesComboBox(roles); // Método que debe estar en la vista
        }

        // Método para cargar todos los permisos en el ComboBox de la vista
        public void LoadPermissionsForComboBox()
        {
            List<Permiso> permisos = _dataAccess.ObtenerPermisosDeRol(0); // Obtener todos los permisos (puedes modificar el ID del rol)
            _view.PopulatePermissionsComboBox(permisos); // Método que debe estar en la vista
        }

        // Método para agregar un nuevo rol
        public void AddRole(string nombreRol, string estatus)
        {
            var rol = new Rol
            {
                NombreRol = nombreRol,
                Estatus = estatus == "Activo" ? 1 : 2 // Mapea "Activo" a 1 y "Inactivo" a 2
            };

            int idGenerado = _dataAccess.InsertarRol(rol);
            if (idGenerado > 0)
            {
                _view.ShowMessage("Rol agregado exitosamente.");
            }
            else
            {
                _view.ShowMessage("Error al agregar el rol.");
            }
        }

        // Método para eliminar un rol (cambiar el estatus a inactivo)
        public void DeleteRole(int idRol)
        {
            bool exito = _dataAccess.EliminarRol(idRol);
            if (exito)
            {
                _view.ShowMessage("Rol desactivado exitosamente.");
            }
            else
            {
                _view.ShowMessage("Error al desactivar el rol.");
            }
        }

        // Método para asignar un permiso a un rol
        public void AssignPermissionToRole(int idRol, int idPermiso)
        {
            bool exito = _dataAccess.AsignarPermisoARol(idRol, idPermiso);
            if (exito)
            {
                _view.ShowMessage("Permiso asignado correctamente.");
            }
            else
            {
                _view.ShowMessage("Error al asignar el permiso.");
            }
        }

        // Método para remover un permiso de un rol
        public void RemovePermissionFromRole(int idRol, int idPermiso)
        {
            bool exito = _dataAccess.RemoverPermisoDeRol(idRol, idPermiso);
            if (exito)
            {
                _view.ShowMessage("Permiso removido correctamente.");
            }
            else
            {
                _view.ShowMessage("Error al remover el permiso.");
            }
        }
    }
}