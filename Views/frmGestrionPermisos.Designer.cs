

namespace InvSis.Views
{
    partial class frmGestrionPermisos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnAgregar = new Button();
            txtNombrePermiso = new TextBox();
            lblNombrePermiso = new Label();
            lbAgregarEditarPermiso = new Label();
            lblTitulo = new Label();
            dataGridView1 = new DataGridView();
            permisosControllerBindingSource = new BindingSource(components);
            btnEliminar = new Button();
            lbDescripcion = new Label();
            txtDescripcion = new TextBox();
            NombrePermiso = new DataGridViewTextBoxColumn();
            Descripcion_Permiso = new DataGridViewTextBoxColumn();
            EstatusPermiso = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)permisosControllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(991, 320);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 33);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // txtNombrePermiso
            // 
            txtNombrePermiso.Location = new Point(766, 192);
            txtNombrePermiso.Margin = new Padding(3, 2, 3, 2);
            txtNombrePermiso.Name = "txtNombrePermiso";
            txtNombrePermiso.Size = new Size(319, 23);
            txtNombrePermiso.TabIndex = 2;
            // 
            // lblNombrePermiso
            // 
            lblNombrePermiso.AutoSize = true;
            lblNombrePermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePermiso.Location = new Point(586, 192);
            lblNombrePermiso.Name = "lblNombrePermiso";
            lblNombrePermiso.Size = new Size(154, 21);
            lblNombrePermiso.TabIndex = 1;
            lblNombrePermiso.Text = "Nombre del permiso";
            // 
            // lbAgregarEditarPermiso
            // 
            lbAgregarEditarPermiso.AutoSize = true;
            lbAgregarEditarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarEditarPermiso.Location = new Point(693, 129);
            lbAgregarEditarPermiso.Name = "lbAgregarEditarPermiso";
            lbAgregarEditarPermiso.Size = new Size(258, 30);
            lbAgregarEditarPermiso.TabIndex = 0;
            lbAgregarEditarPermiso.Text = "Agregar o editar permiso";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1133, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE PERMISOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombrePermiso, Descripcion_Permiso, EstatusPermiso });
            dataGridView1.DataSource = permisosControllerBindingSource;
            dataGridView1.Location = new Point(39, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(541, 596);
            dataGridView1.TabIndex = 9;
            // 
            // permisosControllerBindingSource
            // 
            permisosControllerBindingSource.DataSource = typeof(Controllers.PermisosController);
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(766, 320);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 33);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // lbDescripcion
            // 
            lbDescripcion.AutoSize = true;
            lbDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescripcion.Location = new Point(586, 254);
            lbDescripcion.Name = "lbDescripcion";
            lbDescripcion.Size = new Size(177, 21);
            lbDescripcion.TabIndex = 10;
            lbDescripcion.Text = "Descripcion del permiso";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(766, 256);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(319, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // NombrePermiso
            // 
            NombrePermiso.HeaderText = "Nombre";
            NombrePermiso.MinimumWidth = 200;
            NombrePermiso.Name = "NombrePermiso";
            NombrePermiso.Resizable = DataGridViewTriState.False;
            NombrePermiso.Width = 200;
            // 
            // Descripcion_Permiso
            // 
            Descripcion_Permiso.HeaderText = "Descripcion";
            Descripcion_Permiso.MinimumWidth = 200;
            Descripcion_Permiso.Name = "Descripcion_Permiso";
            Descripcion_Permiso.Resizable = DataGridViewTriState.False;
            Descripcion_Permiso.Width = 200;
            // 
            // EstatusPermiso
            // 
            EstatusPermiso.HeaderText = "Estatus";
            EstatusPermiso.Name = "EstatusPermiso";
            // 
            // frmGestrionPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1133, 681);
            Controls.Add(txtDescripcion);
            Controls.Add(lbDescripcion);
            Controls.Add(dataGridView1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTitulo);
            Controls.Add(lbAgregarEditarPermiso);
            Controls.Add(lblNombrePermiso);
            Controls.Add(txtNombrePermiso);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGestrionPermisos";
            Text = "frmGestionPermisos";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)permisosControllerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private Label lblTitulo;
        private Label lbAgregarEditarPermiso;
        private TextBox txtNombrePermiso;
        private Label lblNombrePermiso;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private BindingSource permisosControllerBindingSource;
        private Button btnEliminar;
        private Label lbDescripcion;
        private TextBox txtDescripcion;
        private DataGridViewTextBoxColumn NombrePermiso;
        private DataGridViewTextBoxColumn Descripcion_Permiso;
        private DataGridViewTextBoxColumn EstatusPermiso;
    }
}