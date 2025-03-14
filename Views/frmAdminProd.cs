using InvSis.Business;

namespace InvSis
{
    public partial class frmAdminProd : Form
    {


        public frmAdminProd()
        {
            InitializeComponent();
            spcProductos.Panel2Collapsed = true;
            cmbxCat.SelectedIndex = 0;
            cmbxUbi.SelectedIndex = 0;
            cmbxStatus.SelectedIndex = 0;
            cmbxImpuesto.SelectedIndex = 0;

        }

        private void btnEdittemp_Click(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = false;
            txtClave.ReadOnly = true;
            spcProductos.Panel1.Enabled = false;
            //frmEditarAgregarProducto editarProducto = new frmEditarAgregarProducto();
            //editarProducto.ShowDialog();

        }

        private void btnCrg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Tag = "Selecciona el archivo";
            openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv|Archivos Excel (*.xls)|*.xls|Archivos Excel (*.xlsx)|*.xlsx";
            openFileDialog.ReadOnlyChecked = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string extension = Path.GetExtension(filePath).ToLower();
                if (extension == ".xls" || extension == ".xlsx" || extension == ".csv")
                {
                    //Cargar el archivo
                    MessageBox.Show("Archivo valido " + filePath, "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Archivo INVALIDO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ClaveProducto.ValidarCodigoProducto(txtClave.Text))
            {
                MessageBox.Show("La clave no es v�lida.",
                    "C�digo inv�lido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            // Validar que el campo nombre no este vacio
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El campo de nombre no puede de estar vacio. ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el campo precio no este vacio
            if (string.IsNullOrWhiteSpace(txtCosto.Text))
            {
                MessageBox.Show("El campo de precio no puede de estar vacio. ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("El Producto es valido para guardado ", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            spcProductos.Panel2Collapsed = true;

            spcProductos.Panel1.Enabled = true;
            ReiniciarCampos();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = false;
            txtClave.ReadOnly = false;
            spcProductos.Panel1.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            spcProductos.Panel2Collapsed = true;

            spcProductos.Panel1.Enabled = true;
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo d�gitos, punto decimal y teclas de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar la entrada del car�cter
            }

            // Asegurar que solo haya un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Para la clave, solo permitir d�gitos y teclas de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ReiniciarCampos()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtCosto.Text = "";
            nmupdnStock.Value = 0;
            cmbxCat.SelectedIndex = 0;
            cmbxUbi.SelectedIndex = 0;
            cmbxStatus.SelectedIndex = 0;
            cmbxImpuesto.SelectedIndex = 0;
        }
    }
}
