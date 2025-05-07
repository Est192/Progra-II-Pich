
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
            txtDescripcionPermiso = new TextBox();
            lbDescripciopn = new Label();
            txtNombrePermiso = new TextBox();
            lblNombrePermiso = new Label();
            lbAgregarEditarPermiso = new Label();
            button1 = new Button();
            lblEstatus = new Label();
            lblEstatusEliminar = new Label();
            lbDescripcionPermiso = new Label();
            LBdESCpERMISO = new Label();
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
            splitContainer1.Panel1.Controls.Add(txtDescripcionPermiso);
            splitContainer1.Panel1.Controls.Add(lbDescripciopn);
            splitContainer1.Panel1.Controls.Add(txtNombrePermiso);
            splitContainer1.Panel1.Controls.Add(lblNombrePermiso);
            splitContainer1.Panel1.Controls.Add(lbAgregarEditarPermiso);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(lblEstatus);
            splitContainer1.Panel2.Controls.Add(lblEstatusEliminar);
            splitContainer1.Panel2.Controls.Add(lbDescripcionPermiso);
            splitContainer1.Panel2.Controls.Add(LBdESCpERMISO);
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
            btnAgregar.Location = new Point(532, 174);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 33);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbxEstatus
            // 
            cbxEstatus.FormattingEnabled = true;
            cbxEstatus.Location = new Point(219, 140);
            cbxEstatus.Margin = new Padding(3, 2, 3, 2);
            cbxEstatus.Name = "cbxEstatus";
            cbxEstatus.Size = new Size(133, 23);
            cbxEstatus.TabIndex = 6;
            // 
            // lbEstatuS
            // 
            lbEstatuS.AutoSize = true;
            lbEstatuS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEstatuS.Location = new Point(19, 137);
            lbEstatuS.Name = "lbEstatuS";
            lbEstatuS.Size = new Size(59, 21);
            lbEstatuS.TabIndex = 5;
            lbEstatuS.Text = "Estatus";
            // 
            // txtDescripcionPermiso
            // 
            txtDescripcionPermiso.Location = new Point(219, 98);
            txtDescripcionPermiso.Margin = new Padding(3, 2, 3, 2);
            txtDescripcionPermiso.Name = "txtDescripcionPermiso";
            txtDescripcionPermiso.Size = new Size(407, 23);
            txtDescripcionPermiso.TabIndex = 4;
            // 
            // lbDescripciopn
            // 
            lbDescripciopn.AutoSize = true;
            lbDescripciopn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescripciopn.Location = new Point(19, 94);
            lbDescripciopn.Name = "lbDescripciopn";
            lbDescripciopn.Size = new Size(177, 21);
            lbDescripciopn.TabIndex = 3;
            lbDescripciopn.Text = "Descripcion del permiso";
            // 
            // txtNombrePermiso
            // 
            txtNombrePermiso.Location = new Point(219, 56);
            txtNombrePermiso.Margin = new Padding(3, 2, 3, 2);
            txtNombrePermiso.Name = "txtNombrePermiso";
            txtNombrePermiso.Size = new Size(407, 23);
            txtNombrePermiso.TabIndex = 2;
            // 
            // lblNombrePermiso
            // 
            lblNombrePermiso.AutoSize = true;
            lblNombrePermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombrePermiso.Location = new Point(19, 56);
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(552, 233);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 33);
            button1.TabIndex = 8;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(241, 194);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(220, 21);
            lblEstatus.TabIndex = 7;
            lblEstatus.Text = "AQUI VA EL ESTATUS DEL ROL";
            // 
            // lblEstatusEliminar
            // 
            lblEstatusEliminar.AutoSize = true;
            lblEstatusEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstatusEliminar.Location = new Point(32, 194);
            lblEstatusEliminar.Name = "lblEstatusEliminar";
            lblEstatusEliminar.Size = new Size(59, 21);
            lblEstatusEliminar.TabIndex = 6;
            lblEstatusEliminar.Text = "Estatus";
            // 
            // lbDescripcionPermiso
            // 
            lbDescripcionPermiso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDescripcionPermiso.Location = new Point(241, 94);
            lbDescripcionPermiso.Name = "lbDescripcionPermiso";
            lbDescripcionPermiso.Size = new Size(405, 83);
            lbDescripcionPermiso.TabIndex = 5;
            // 
            // LBdESCpERMISO
            // 
            LBdESCpERMISO.AutoSize = true;
            LBdESCpERMISO.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBdESCpERMISO.Location = new Point(32, 122);
            LBdESCpERMISO.Name = "LBdESCpERMISO";
            LBdESCpERMISO.Size = new Size(177, 21);
            LBdESCpERMISO.TabIndex = 4;
            LBdESCpERMISO.Text = "Descripcion del permiso";
            // 
            // cbxPermisoElimicar
            // 
            cbxPermisoElimicar.FormattingEnabled = true;
            cbxPermisoElimicar.Location = new Point(241, 56);
            cbxPermisoElimicar.Margin = new Padding(3, 2, 3, 2);
            cbxPermisoElimicar.Name = "cbxPermisoElimicar";
            cbxPermisoElimicar.Size = new Size(406, 23);
            cbxPermisoElimicar.TabIndex = 3;
            // 
            // LBpERMISOeLIMINAR
            // 
            LBpERMISOeLIMINAR.AutoSize = true;
            LBpERMISOeLIMINAR.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBpERMISOeLIMINAR.Location = new Point(32, 56);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox txtDescripcionPermiso;
        private Label lbDescripciopn;
        private TextBox txtNombrePermiso;
        private Label lblNombrePermiso;
        private ComboBox cbxEstatus;
        private Button btnAgregar;
        private Label lblEstatus;
        private Label lblEstatusEliminar;
        private Label lbDescripcionPermiso;
        private Label LBdESCpERMISO;
        private ComboBox cbxPermisoElimicar;
        private Label LBpERMISOeLIMINAR;
        private Button button1;
    }
}