namespace InvSis
{
    partial class frmAdminProd
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            dgvProductos = new DataGridView();
            colClave = new DataGridViewTextBoxColumn();
            colNombre = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colEstatus = new DataGridViewTextBoxColumn();
            detalle = new DataGridViewButtonColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            btnEdittemp = new Button();
            btnCarga = new Button();
            spcProductos = new SplitContainer();
            groupBox1 = new GroupBox();
            lblFilCat = new Label();
            lblFilStatus = new Label();
            cmbCat = new ComboBox();
            btnDetalle = new Button();
            btnApF = new Button();
            cmbEstatus = new ComboBox();
            btnAgregar = new Button();
            groupBox2 = new GroupBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            cmbxImpuesto = new ComboBox();
            cmbxStatus = new ComboBox();
            nmupdnStock = new NumericUpDown();
            txtCosto = new TextBox();
            txtClave = new TextBox();
            cmbxUbi = new ComboBox();
            cmbxCat = new ComboBox();
            txtNombre = new TextBox();
            lblImpuesto = new Label();
            lblEstatus = new Label();
            lblClave = new Label();
            lblUbicacion = new Label();
            lblStock = new Label();
            lblCosto = new Label();
            lblCat = new Label();
            lblNombre = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spcProductos).BeginInit();
            spcProductos.Panel1.SuspendLayout();
            spcProductos.Panel2.SuspendLayout();
            spcProductos.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).BeginInit();
            SuspendLayout();
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeColumns = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.BackgroundColor = Color.FromArgb(42, 34, 58);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { colClave, colNombre, colCategoria, colStock, colEstatus, detalle, colEdit, colDelete });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(232, 218, 255);
            dataGridViewCellStyle11.SelectionForeColor = Color.MediumPurple;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle11;
            dgvProductos.GridColor = SystemColors.Info;
            dgvProductos.ImeMode = ImeMode.Disable;
            dgvProductos.Location = new Point(79, 228);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 62;
            dgvProductos.Size = new Size(803, 262);
            dgvProductos.TabIndex = 0;
            // 
            // colClave
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle3.ForeColor = Color.White;
            colClave.DefaultCellStyle = dataGridViewCellStyle3;
            colClave.HeaderText = "Clave";
            colClave.MinimumWidth = 8;
            colClave.Name = "colClave";
            colClave.ReadOnly = true;
            colClave.Width = 150;
            // 
            // colNombre
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle4.ForeColor = Color.White;
            colNombre.DefaultCellStyle = dataGridViewCellStyle4;
            colNombre.HeaderText = "Nombre";
            colNombre.MinimumWidth = 8;
            colNombre.Name = "colNombre";
            colNombre.ReadOnly = true;
            colNombre.Width = 150;
            // 
            // colCategoria
            // 
            dataGridViewCellStyle5.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle5.ForeColor = Color.White;
            colCategoria.DefaultCellStyle = dataGridViewCellStyle5;
            colCategoria.HeaderText = "Categoria";
            colCategoria.MinimumWidth = 8;
            colCategoria.Name = "colCategoria";
            colCategoria.ReadOnly = true;
            colCategoria.Width = 150;
            // 
            // colStock
            // 
            dataGridViewCellStyle6.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle6.ForeColor = Color.White;
            colStock.DefaultCellStyle = dataGridViewCellStyle6;
            colStock.HeaderText = "Stock";
            colStock.MinimumWidth = 8;
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            colStock.Width = 150;
            // 
            // colEstatus
            // 
            dataGridViewCellStyle7.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle7.ForeColor = Color.White;
            colEstatus.DefaultCellStyle = dataGridViewCellStyle7;
            colEstatus.HeaderText = "Estatus";
            colEstatus.MinimumWidth = 8;
            colEstatus.Name = "colEstatus";
            colEstatus.ReadOnly = true;
            colEstatus.Width = 150;
            // 
            // detalle
            // 
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(74, 60, 96);
            dataGridViewCellStyle8.ForeColor = Color.White;
            detalle.DefaultCellStyle = dataGridViewCellStyle8;
            detalle.HeaderText = "Detalle";
            detalle.MinimumWidth = 8;
            detalle.Name = "detalle";
            detalle.ReadOnly = true;
            detalle.Width = 150;
            // 
            // colEdit
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(159, 122, 234);
            dataGridViewCellStyle9.ForeColor = Color.Black;
            colEdit.DefaultCellStyle = dataGridViewCellStyle9;
            colEdit.HeaderText = "Editar";
            colEdit.MinimumWidth = 8;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Text = "Editar";
            colEdit.Width = 150;
            // 
            // colDelete
            // 
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(255, 111, 97);
            dataGridViewCellStyle10.ForeColor = Color.Black;
            colDelete.DefaultCellStyle = dataGridViewCellStyle10;
            colDelete.HeaderText = "Eliminar";
            colDelete.MinimumWidth = 8;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Text = "Eliminar";
            colDelete.Width = 150;
            // 
            // btnEdittemp
            // 
            btnEdittemp.BackColor = Color.FromArgb(159, 122, 234);
            btnEdittemp.Cursor = Cursors.Hand;
            btnEdittemp.FlatAppearance.BorderSize = 0;
            btnEdittemp.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 80, 140);
            btnEdittemp.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 95, 160);
            btnEdittemp.FlatStyle = FlatStyle.Flat;
            btnEdittemp.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnEdittemp.ForeColor = Color.Black;
            btnEdittemp.Location = new Point(805, 522);
            btnEdittemp.Name = "btnEdittemp";
            btnEdittemp.Size = new Size(78, 36);
            btnEdittemp.TabIndex = 1;
            btnEdittemp.Text = "Editar";
            btnEdittemp.UseVisualStyleBackColor = false;
            btnEdittemp.Click += btnEdittemp_Click;
            // 
            // btnCarga
            // 
            btnCarga.BackColor = Color.FromArgb(159, 122, 234);
            btnCarga.FlatAppearance.BorderSize = 0;
            btnCarga.FlatStyle = FlatStyle.Flat;
            btnCarga.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            btnCarga.ForeColor = Color.Black;
            btnCarga.Location = new Point(80, 528);
            btnCarga.Name = "btnCarga";
            btnCarga.Size = new Size(153, 36);
            btnCarga.TabIndex = 2;
            btnCarga.Text = "Carga Excel";
            btnCarga.UseVisualStyleBackColor = false;
            btnCarga.Click += btnCrg_Click;
            // 
            // spcProductos
            // 
            spcProductos.Location = new Point(0, 40);
            spcProductos.Name = "spcProductos";
            // 
            // spcProductos.Panel1
            // 
            spcProductos.Panel1.Controls.Add(groupBox1);
            // 
            // spcProductos.Panel2
            // 
            spcProductos.Panel2.Controls.Add(groupBox2);
            spcProductos.Size = new Size(1355, 744);
            spcProductos.SplitterDistance = 972;
            spcProductos.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.FromArgb(230, 242, 248);
            groupBox1.Controls.Add(lblFilCat);
            groupBox1.Controls.Add(lblFilStatus);
            groupBox1.Controls.Add(cmbCat);
            groupBox1.Controls.Add(btnDetalle);
            groupBox1.Controls.Add(btnApF);
            groupBox1.Controls.Add(cmbEstatus);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(btnEdittemp);
            groupBox1.Controls.Add(btnCarga);
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7, 6, 7, 6);
            groupBox1.Size = new Size(967, 741);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblFilCat
            // 
            lblFilCat.AutoSize = true;
            lblFilCat.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFilCat.ForeColor = Color.MediumPurple;
            lblFilCat.Location = new Point(400, 85);
            lblFilCat.Name = "lblFilCat";
            lblFilCat.Size = new Size(223, 30);
            lblFilCat.TabIndex = 14;
            lblFilCat.Text = "Filtrar Por Categoría";
            lblFilCat.Click += lblFilCat_Click;
            // 
            // lblFilStatus
            // 
            lblFilStatus.AutoSize = true;
            lblFilStatus.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblFilStatus.ForeColor = Color.MediumPurple;
            lblFilStatus.Location = new Point(101, 85);
            lblFilStatus.Name = "lblFilStatus";
            lblFilStatus.Size = new Size(197, 30);
            lblFilStatus.TabIndex = 13;
            lblFilStatus.Text = "Filtrar Por Estatus";
            // 
            // cmbCat
            // 
            cmbCat.BackColor = Color.Lavender;
            cmbCat.ForeColor = Color.Black;
            cmbCat.FormattingEnabled = true;
            cmbCat.Items.AddRange(new object[] { "Todo", "Cat X", "Cat Y", "Cat Z" });
            cmbCat.Location = new Point(410, 122);
            cmbCat.Name = "cmbCat";
            cmbCat.Size = new Size(200, 23);
            cmbCat.TabIndex = 12;
            // 
            // btnDetalle
            // 
            btnDetalle.BackColor = Color.MediumPurple;
            btnDetalle.FlatStyle = FlatStyle.Flat;
            btnDetalle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnDetalle.ForeColor = Color.White;
            btnDetalle.Location = new Point(738, 567);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(145, 56);
            btnDetalle.TabIndex = 11;
            btnDetalle.Text = "Detalle del Producto";
            btnDetalle.UseVisualStyleBackColor = false;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // btnApF
            // 
            btnApF.BackColor = Color.MediumPurple;
            btnApF.FlatStyle = FlatStyle.Flat;
            btnApF.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnApF.ForeColor = Color.White;
            btnApF.Location = new Point(787, 115);
            btnApF.Name = "btnApF";
            btnApF.Size = new Size(144, 27);
            btnApF.TabIndex = 10;
            btnApF.Text = "Aplicar Filtro";
            btnApF.UseVisualStyleBackColor = false;
            btnApF.Click += btnApF_Click;
            // 
            // cmbEstatus
            // 
            cmbEstatus.BackColor = Color.Lavender;
            cmbEstatus.ForeColor = Color.Black;
            cmbEstatus.FormattingEnabled = true;
            cmbEstatus.Items.AddRange(new object[] { "Activo", "Inactivo" });
            cmbEstatus.Location = new Point(131, 115);
            cmbEstatus.Name = "cmbEstatus";
            cmbEstatus.Size = new Size(121, 23);
            cmbEstatus.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.MediumPurple;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(412, 522);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(134, 48);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Productos";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(230, 242, 248);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(cmbxImpuesto);
            groupBox2.Controls.Add(cmbxStatus);
            groupBox2.Controls.Add(nmupdnStock);
            groupBox2.Controls.Add(txtCosto);
            groupBox2.Controls.Add(txtClave);
            groupBox2.Controls.Add(cmbxUbi);
            groupBox2.Controls.Add(cmbxCat);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(lblImpuesto);
            groupBox2.Controls.Add(lblEstatus);
            groupBox2.Controls.Add(lblClave);
            groupBox2.Controls.Add(lblUbicacion);
            groupBox2.Controls.Add(lblStock);
            groupBox2.Controls.Add(lblCosto);
            groupBox2.Controls.Add(lblCat);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.ForeColor = Color.FromArgb(159, 122, 234);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(367, 741);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(245, 245, 245);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(159, 122, 234);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.FromArgb(159, 122, 234);
            btnCancelar.Location = new Point(36, 667);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(159, 122, 234);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(36, 627);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 34;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // cmbxImpuesto
            // 
            cmbxImpuesto.BackColor = Color.White;
            cmbxImpuesto.FlatStyle = FlatStyle.Flat;
            cmbxImpuesto.ForeColor = Color.FromArgb(42, 34, 58);
            cmbxImpuesto.FormattingEnabled = true;
            cmbxImpuesto.Items.AddRange(new object[] { "No Aplica", "Impuesto A", "Impuesto B", "Impuesto C" });
            cmbxImpuesto.Location = new Point(36, 587);
            cmbxImpuesto.Name = "cmbxImpuesto";
            cmbxImpuesto.Size = new Size(253, 23);
            cmbxImpuesto.TabIndex = 33;
            // 
            // cmbxStatus
            // 
            cmbxStatus.BackColor = Color.White;
            cmbxStatus.FlatStyle = FlatStyle.Flat;
            cmbxStatus.ForeColor = Color.FromArgb(42, 34, 58);
            cmbxStatus.FormattingEnabled = true;
            cmbxStatus.Items.AddRange(new object[] { "Inactivo", "Activo" });
            cmbxStatus.Location = new Point(36, 511);
            cmbxStatus.Name = "cmbxStatus";
            cmbxStatus.Size = new Size(253, 23);
            cmbxStatus.TabIndex = 32;
            // 
            // nmupdnStock
            // 
            nmupdnStock.BackColor = Color.White;
            nmupdnStock.BorderStyle = BorderStyle.FixedSingle;
            nmupdnStock.Font = new Font("MS PGothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nmupdnStock.ForeColor = Color.FromArgb(42, 34, 58);
            nmupdnStock.Location = new Point(36, 283);
            nmupdnStock.Name = "nmupdnStock";
            nmupdnStock.Size = new Size(120, 22);
            nmupdnStock.TabIndex = 31;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.FromArgb(245, 245, 245);
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.ForeColor = Color.FromArgb(159, 122, 234);
            txtCosto.Location = new Point(36, 207);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(253, 23);
            txtCosto.TabIndex = 30;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.White;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.ForeColor = Color.FromArgb(42, 34, 58);
            txtClave.Location = new Point(36, 435);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(253, 23);
            txtClave.TabIndex = 29;
            txtClave.KeyPress += txtClave_KeyPress;
            // 
            // cmbxUbi
            // 
            cmbxUbi.BackColor = Color.FromArgb(245, 245, 245);
            cmbxUbi.FlatStyle = FlatStyle.Flat;
            cmbxUbi.Font = new Font("Segoe UI", 10F);
            cmbxUbi.ForeColor = Color.FromArgb(159, 122, 234);
            cmbxUbi.FormattingEnabled = true;
            cmbxUbi.Items.AddRange(new object[] { "Tijuana", "CDMX", "Toluca", "Durango", "SLP", "Cancún" });
            cmbxUbi.Location = new Point(36, 359);
            cmbxUbi.Name = "cmbxUbi";
            cmbxUbi.Size = new Size(253, 25);
            cmbxUbi.TabIndex = 28;
            // 
            // cmbxCat
            // 
            cmbxCat.BackColor = Color.FromArgb(245, 245, 245);
            cmbxCat.FlatStyle = FlatStyle.Flat;
            cmbxCat.Font = new Font("Segoe UI", 10F);
            cmbxCat.ForeColor = Color.FromArgb(159, 122, 234);
            cmbxCat.FormattingEnabled = true;
            cmbxCat.Items.AddRange(new object[] { "Cat X", "Cat Y", "Cat Z" });
            cmbxCat.Location = new Point(36, 131);
            cmbxCat.Name = "cmbxCat";
            cmbxCat.Size = new Size(253, 25);
            cmbxCat.Sorted = true;
            cmbxCat.TabIndex = 27;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(245, 245, 245);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.ForeColor = Color.FromArgb(159, 122, 234);
            txtNombre.Location = new Point(36, 55);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(253, 25);
            txtNombre.TabIndex = 26;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblImpuesto.ForeColor = Color.FromArgb(159, 122, 234);
            lblImpuesto.Location = new Point(36, 551);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(86, 21);
            lblImpuesto.TabIndex = 25;
            lblImpuesto.Text = "Impuesto:";
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEstatus.ForeColor = Color.FromArgb(159, 122, 234);
            lblEstatus.Location = new Point(36, 475);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(68, 21);
            lblEstatus.TabIndex = 24;
            lblEstatus.Text = "Estatus:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblClave.ForeColor = Color.FromArgb(159, 122, 234);
            lblClave.Location = new Point(36, 399);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(56, 21);
            lblClave.TabIndex = 23;
            lblClave.Text = "Clave:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblUbicacion.ForeColor = Color.FromArgb(159, 122, 234);
            lblUbicacion.Location = new Point(36, 323);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(101, 19);
            lblUbicacion.TabIndex = 22;
            lblUbicacion.Text = "Ubicacion:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblStock.ForeColor = Color.FromArgb(159, 122, 234);
            lblStock.Location = new Point(36, 247);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(66, 19);
            lblStock.TabIndex = 21;
            lblStock.Text = "Stock:";
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblCosto.ForeColor = Color.FromArgb(159, 122, 234);
            lblCosto.Location = new Point(36, 171);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(68, 19);
            lblCosto.TabIndex = 20;
            lblCosto.Text = "Costo:";
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblCat.ForeColor = Color.FromArgb(159, 122, 234);
            lblCat.Location = new Point(36, 95);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(108, 19);
            lblCat.TabIndex = 19;
            lblCat.Text = "Categoria: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("MS PGothic", 14.25F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(159, 122, 234);
            lblNombre.Location = new Point(36, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 19);
            lblNombre.TabIndex = 18;
            lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(159, 122, 234);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(1347, 42);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = " ADMINISTRACIÓN DE PRODUCTOS ";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmAdminProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(230, 242, 248);
            ClientSize = new Size(1347, 794);
            Controls.Add(lblTitulo);
            Controls.Add(spcProductos);
            Name = "frmAdminProd";
            Text = "Administración de Inventarios";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            spcProductos.Panel1.ResumeLayout(false);
            spcProductos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)spcProductos).EndInit();
            spcProductos.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmupdnStock).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvProductos;
        private Button btnEdittemp;
        private Button btnCarga;
        private SplitContainer spcProductos;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cmbxImpuesto;
        private ComboBox cmbxStatus;
        private NumericUpDown nmupdnStock;
        private TextBox txtClave;
        private ComboBox cmbxUbi;
        private ComboBox cmbxCat;
        private TextBox txtNombre;
        private Label lblImpuesto;
        private Label lblEstatus;
        private Label lblClave;
        private Label lblUbicacion;
        private Label lblStock;
        private Label lblCosto;
        private Label lblCat;
        private Label lblNombre;
        private Button btnAgregar;
        private Label lblTitulo;
        private ComboBox cmbEstatus;
        private Button btnApF;
        private Button btnDetalle;
        private ComboBox cmbCat;
        private Label lblFilCat;
        private Label lblFilStatus;
        private DataGridViewTextBoxColumn colClave;
        private DataGridViewTextBoxColumn colNombre;
        private DataGridViewTextBoxColumn colCategoria;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colEstatus;
        private DataGridViewButtonColumn detalle;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private TextBox txtCosto;
    }
}
