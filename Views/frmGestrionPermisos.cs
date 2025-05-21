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

        

        




        


        


        

        
    }
}