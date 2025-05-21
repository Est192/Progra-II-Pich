
namespace InvSis.Views
{
    partial class frmGestionRoles
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
            lblTitulo = new Label();
            btnAgregarRol = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dataGridView1 = new DataGridView();
            NombrePermiso = new DataGridViewTextBoxColumn();
            EstatusPermiso = new DataGridViewTextBoxColumn();
            lblSelección = new Label();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Descripcion_Permiso = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridView3 = new DataGridView();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1347, 33);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE ROLES";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAgregarRol
            // 
            btnAgregarRol.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarRol.Location = new Point(300, 672);
            btnAgregarRol.Margin = new Padding(3, 2, 3, 2);
            btnAgregarRol.Name = "btnAgregarRol";
            btnAgregarRol.Size = new Size(102, 27);
            btnAgregarRol.TabIndex = 5;
            btnAgregarRol.Text = "Agregar rol";
            btnAgregarRol.UseVisualStyleBackColor = true;
            btnAgregarRol.Click += btnAgregarRol_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NombrePermiso, EstatusPermiso });
            dataGridView1.Location = new Point(48, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(354, 565);
            dataGridView1.TabIndex = 19;
            // 
            // NombrePermiso
            // 
            NombrePermiso.DataPropertyName = "Nombre";
            NombrePermiso.HeaderText = "Nombre";
            NombrePermiso.MinimumWidth = 150;
            NombrePermiso.Name = "NombrePermiso";
            NombrePermiso.Resizable = DataGridViewTriState.False;
            NombrePermiso.Width = 150;
            // 
            // EstatusPermiso
            // 
            EstatusPermiso.DataPropertyName = "Estatus";
            EstatusPermiso.HeaderText = "Estatus";
            EstatusPermiso.MinimumWidth = 150;
            EstatusPermiso.Name = "EstatusPermiso";
            EstatusPermiso.Width = 150;
            // 
            // lblSelección
            // 
            lblSelección.AutoSize = true;
            lblSelección.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelección.Location = new Point(48, 80);
            lblSelección.Name = "lblSelección";
            lblSelección.Size = new Size(268, 19);
            lblSelección.TabIndex = 21;
            lblSelección.Text = "Seleccione rol para asignación de permisos";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Descripcion_Permiso, dataGridViewTextBoxColumn2 });
            dataGridView2.Location = new Point(464, 419);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(829, 248);
            dataGridView2.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            dataGridViewTextBoxColumn1.MinimumWidth = 250;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // Descripcion_Permiso
            // 
            Descripcion_Permiso.DataPropertyName = "Descripcion";
            Descripcion_Permiso.HeaderText = "Descripcion";
            Descripcion_Permiso.MinimumWidth = 400;
            Descripcion_Permiso.Name = "Descripcion_Permiso";
            Descripcion_Permiso.Resizable = DataGridViewTriState.False;
            Descripcion_Permiso.Width = 400;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Estatus";
            dataGridViewTextBoxColumn2.HeaderText = "Estatus";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView3.Location = new Point(464, 102);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(829, 248);
            dataGridView3.TabIndex = 23;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.MinimumWidth = 250;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Descripcion";
            dataGridViewTextBoxColumn4.HeaderText = "Descripcion";
            dataGridViewTextBoxColumn4.MinimumWidth = 400;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Resizable = DataGridViewTriState.False;
            dataGridViewTextBoxColumn4.Width = 400;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Estatus";
            dataGridViewTextBoxColumn5.HeaderText = "Estatus";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(464, 397);
            label1.Name = "label1";
            label1.Size = new Size(223, 19);
            label1.TabIndex = 24;
            label1.Text = "Eliminar permisos asignados del rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(464, 80);
            label2.Name = "label2";
            label2.Size = new Size(151, 19);
            label2.TabIndex = 25;
            label2.Text = "Agregar permisos al rol";
            // 
            // frmGestionRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1347, 722);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Controls.Add(dataGridView2);
            Controls.Add(lblSelección);
            Controls.Add(dataGridView1);
            Controls.Add(lblTitulo);
            Controls.Add(btnAgregarRol);
            ForeColor = SystemColors.Desktop;
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmGestionRoles";
            Text = "frmGestionRoles";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lblNombreEliminacionRol_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAgregarRol;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NombrePermiso;
        private DataGridViewTextBoxColumn EstatusPermiso;
        private Label lblSelección;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Descripcion_Permiso;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridView dataGridView3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label1;
        private Label label2;
    }
}