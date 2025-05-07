

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
            splitContainer1 = new SplitContainer();
            btnAgregar = new Button();
            cbxEstatus = new ComboBox();
            lbEstatuS = new Label();
            txtNombrePermiso = new TextBox();
            lblNombrePermiso = new Label();
            lbAgregarEditarPermiso = new Label();
            btnEliminar = new Button();
            cbxPermisoElimicar = new ComboBox();
            LBpERMISOeLIMINAR = new Label();
            lbEliminarPermiso = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.ForeColor = Color.FromArgb(159, 122, 234);
            splitContainer1.Location = new Point(2, 40);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregar);
            splitContainer1.Panel1.Controls.Add(cbxEstatus);
            splitContainer1.Panel1.Controls.Add(lbEstatuS);
            splitContainer1.Panel1.Controls.Add(txtNombrePermiso);
            splitContainer1.Panel1.Controls.Add(lblNombrePermiso);
            splitContainer1.Panel1.Controls.Add(lbAgregarEditarPermiso);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnEliminar);
            splitContainer1.Panel2.Controls.Add(cbxPermisoElimicar);
            splitContainer1.Panel2.Controls.Add(LBpERMISOeLIMINAR);
            splitContainer1.Panel2.Controls.Add(lbEliminarPermiso);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1340, 287);
            splitContainer1.SplitterDistance = 667;
            splitContainer1.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(530, 168);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 33);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cbxEstatus
            // 
            cbxEstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(217, 120);
            cbxEstatus.Margin = new Padding(3, 2, 3, 2);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(133, 23);
            cbxEstatus.TabIndex = 6;
            // 
            // lbEstatuS
            // 
            lbEstatuS.AutoSize = true;
            lbEstatuS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstatuS.Location = new Point(17, 118);
            lbEstatuS.Name = "lbEstatuS";
            lbEstatuS.Size = new Size(59, 21);
            lbEstatuS.TabIndex = 5;
            lbEstatuS.Text = "Estatus";
            // 
            // txtNombrePermiso
            // 
            txtNombrePermiso.Location = new Point(217, 71);
            txtNombrePermiso.Margin = new Padding(3, 2, 3, 2);
            txtNombrePermiso.Name = "txtNombrePermiso";
            txtNombrePermiso.Size = new Size(407, 23);
            txtNombrePermiso.TabIndex = 2;
            txtNombrePermiso.Leave += txtNombrePermiso_Leave;
            // 
            // lblNombrePermiso
            // 
            lblNombrePermiso.AutoSize = true;
            lblNombrePermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePermiso.Location = new Point(17, 71);
            lblNombrePermiso.Name = "lblNombrePermiso";
            lblNombrePermiso.Size = new Size(154, 21);
            lblNombrePermiso.TabIndex = 1;
            lblNombrePermiso.Text = "Nombre del permiso";
            // 
            // lbAgregarEditarPermiso
            // 
            lbAgregarEditarPermiso.AutoSize = true;
            lbAgregarEditarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAgregarEditarPermiso.Location = new Point(158, 10);
            lbAgregarEditarPermiso.Name = "lbAgregarEditarPermiso";
            lbAgregarEditarPermiso.Size = new Size(258, 30);
            lbAgregarEditarPermiso.TabIndex = 0;
            lbAgregarEditarPermiso.Text = "Agregar o editar permiso";
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(553, 168);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 33);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += button_Click_1;
            // 
            // cbxPermisoElimicar
            // 
            cbxPermisoElimicar.FormattingEnabled = true;
            cbxPermisoElimicar.Location = new Point(241, 73);
            cbxPermisoElimicar.Margin = new Padding(3, 2, 3, 2);
            cbxPermisoElimicar.Name = "cbxPermisoElimicar";
            cbxPermisoElimicar.Size = new Size(406, 23);
            cbxPermisoElimicar.TabIndex = 3;
            // 
            // LBpERMISOeLIMINAR
            // 
            LBpERMISOeLIMINAR.AutoSize = true;
            LBpERMISOeLIMINAR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBpERMISOeLIMINAR.Location = new Point(32, 73);
            LBpERMISOeLIMINAR.Name = "LBpERMISOeLIMINAR";
            LBpERMISOeLIMINAR.Size = new Size(139, 21);
            LBpERMISOeLIMINAR.TabIndex = 2;
            LBpERMISOeLIMINAR.Text = "Permiso a eliminar";
            // 
            // lbEliminarPermiso
            // 
            lbEliminarPermiso.AutoSize = true;
            lbEliminarPermiso.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEliminarPermiso.Location = new Point(241, 10);
            lbEliminarPermiso.Name = "lbEliminarPermiso";
            lbEliminarPermiso.Size = new Size(174, 30);
            lbEliminarPermiso.TabIndex = 1;
            lbEliminarPermiso.Text = "Eliminar permiso";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1347, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE PERMISOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmGestrionPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1347, 337);
            Controls.Add(splitContainer1);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGestrionPermisos";
            Text = "frmGestionPermisos";
            Load += frmGestionPermisos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            string nombrePermiso = cbxPermisoElimicar.SelectedItem.ToString();

            // Eliminar el permiso
            _controller.DeletePermission(int.Parse(nombrePermiso));

            // Actualizar el ComboBox con los permisos actuales
           

            MessageBox.Show("Permiso eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private Label lblTitulo;
        private SplitContainer splitContainer1;
        private Label lbAgregarEditarPermiso;
        private Label lbEliminarPermiso;
        private Label lbEstatuS;
        private TextBox txtNombrePermiso;
        private Label lblNombrePermiso;
        private ComboBox cbxEstatus;
        private Button btnAgregar;
        private ComboBox cbxPermisoElimicar;
        private Label LBpERMISOeLIMINAR;
        private Button btnEliminar;
    }
}