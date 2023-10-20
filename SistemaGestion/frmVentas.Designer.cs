namespace SistemaGestion
{
    partial class frmVentas
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtIdVenta = new Label();
            txtIndice = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            Comentarios = new DataGridViewTextBoxColumn();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            cboBusqueda = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtVentaSeleccionada = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblOperacion = new Label();
            txtNombreUsuario = new TextBox();
            txtIdUsuario = new TextBox();
            txtComentarios = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtIdVenta
            // 
            txtIdVenta.AutoSize = true;
            txtIdVenta.BackColor = Color.FromArgb(30, 30, 30);
            txtIdVenta.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdVenta.ForeColor = Color.FromArgb(111, 212, 216);
            txtIdVenta.Location = new Point(442, 75);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(15, 17);
            txtIdVenta.TabIndex = 78;
            txtIdVenta.Text = "0";
            txtIdVenta.Visible = false;
            txtIdVenta.TextChanged += txtIdVenta_TextChanged;
            // 
            // txtIndice
            // 
            txtIndice.AutoSize = true;
            txtIndice.BackColor = Color.FromArgb(30, 30, 30);
            txtIndice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIndice.ForeColor = Color.FromArgb(111, 212, 216);
            txtIndice.Location = new Point(397, 75);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(20, 17);
            txtIndice.TabIndex = 77;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, NombreUsuario, IdUsuario, Comentarios });
            dgvData.Cursor = Cursors.Hand;
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(574, 177);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(8, 83, 150);
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(760, 396);
            dgvData.TabIndex = 76;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellPainting += dgvData_CellPainting;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.HeaderText = "";
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.ReadOnly = true;
            btnSeleccionar.Resizable = DataGridViewTriState.True;
            btnSeleccionar.SortMode = DataGridViewColumnSortMode.Automatic;
            btnSeleccionar.Width = 30;
            // 
            // Id
            // 
            Id.HeaderText = "ID VENTA";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "NOMBRE USUARIO";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 180;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "ID USUARIO";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            // 
            // Comentarios
            // 
            Comentarios.HeaderText = "COMENTARIOS";
            Comentarios.Name = "Comentarios";
            Comentarios.ReadOnly = true;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            btnBuscar.IconColor = Color.FromArgb(8, 83, 150);
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 28;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(1116, 103);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 26);
            btnBuscar.TabIndex = 74;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.CharacterCasing = CharacterCasing.Upper;
            txtBusqueda.Location = new Point(908, 106);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(192, 23);
            txtBusqueda.TabIndex = 73;
            // 
            // cboBusqueda
            // 
            cboBusqueda.FormattingEnabled = true;
            cboBusqueda.Location = new Point(686, 106);
            cboBusqueda.Name = "cboBusqueda";
            cboBusqueda.Size = new Size(190, 23);
            cboBusqueda.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(50, 50, 50);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(111, 212, 216);
            label10.Location = new Point(574, 112);
            label10.Name = "label10";
            label10.Size = new Size(78, 17);
            label10.TabIndex = 71;
            label10.Text = "Buscar por:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(50, 50, 50);
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(629, 23);
            label9.Name = "label9";
            label9.Size = new Size(211, 32);
            label9.TabIndex = 70;
            label9.Text = "LISTA DE VENTAS";
            // 
            // txtVentaSeleccionada
            // 
            txtVentaSeleccionada.BackColor = Color.FromArgb(30, 30, 30);
            txtVentaSeleccionada.BorderStyle = BorderStyle.None;
            txtVentaSeleccionada.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtVentaSeleccionada.ForeColor = Color.FromArgb(111, 212, 216);
            txtVentaSeleccionada.Location = new Point(152, 702);
            txtVentaSeleccionada.Name = "txtVentaSeleccionada";
            txtVentaSeleccionada.Size = new Size(285, 18);
            txtVentaSeleccionada.TabIndex = 69;
            txtVentaSeleccionada.Text = "Ninguno";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.BroomBall;
            btnLimpiar.IconColor = Color.FromArgb(8, 83, 150);
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiar.IconSize = 28;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(1168, 103);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(35, 26);
            btnLimpiar.TabIndex = 75;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(30, 30, 30);
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(111, 212, 216);
            label8.Location = new Point(12, 703);
            label8.Name = "label8";
            label8.Size = new Size(134, 17);
            label8.TabIndex = 68;
            label8.Text = "Venta  Seleccionada:";
            // 
            // btnLimpiarDatos
            // 
            btnLimpiarDatos.BackColor = Color.FromArgb(8, 83, 150);
            btnLimpiarDatos.FlatStyle = FlatStyle.Flat;
            btnLimpiarDatos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLimpiarDatos.ForeColor = Color.White;
            btnLimpiarDatos.IconChar = FontAwesome.Sharp.IconChar.Broom;
            btnLimpiarDatos.IconColor = Color.White;
            btnLimpiarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLimpiarDatos.IconSize = 28;
            btnLimpiarDatos.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiarDatos.Location = new Point(179, 438);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(140, 31);
            btnLimpiarDatos.TabIndex = 66;
            btnLimpiarDatos.Text = "Limpiar";
            btnLimpiarDatos.UseVisualStyleBackColor = false;
            btnLimpiarDatos.Click += btnLimpiarDatos_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.ForestGreen;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FileShield;
            btnGuardar.IconColor = Color.White;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnGuardar.IconSize = 28;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(28, 438);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 31);
            btnGuardar.TabIndex = 65;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.BackColor = Color.FromArgb(30, 30, 30);
            lblOperacion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.ForeColor = Color.FromArgb(224, 224, 224);
            lblOperacion.Location = new Point(106, 23);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(242, 32);
            lblOperacion.TabIndex = 64;
            lblOperacion.Text = "ALTA NUEVA VENTA";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.CharacterCasing = CharacterCasing.Upper;
            txtNombreUsuario.Location = new Point(211, 230);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(192, 23);
            txtNombreUsuario.TabIndex = 61;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.CharacterCasing = CharacterCasing.Upper;
            txtIdUsuario.Location = new Point(211, 171);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(192, 23);
            txtIdUsuario.TabIndex = 60;
            txtIdUsuario.KeyDown += txtIdUsuario_KeyDown;
            // 
            // txtComentarios
            // 
            txtComentarios.CharacterCasing = CharacterCasing.Upper;
            txtComentarios.Location = new Point(211, 112);
            txtComentarios.Name = "txtComentarios";
            txtComentarios.Size = new Size(192, 23);
            txtComentarios.TabIndex = 59;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(111, 212, 216);
            label6.Location = new Point(60, 236);
            label6.Name = "label6";
            label6.Size = new Size(113, 17);
            label6.TabIndex = 58;
            label6.Text = "Nombre Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(111, 212, 216);
            label4.Location = new Point(60, 177);
            label4.Name = "label4";
            label4.Size = new Size(77, 17);
            label4.TabIndex = 55;
            label4.Text = "ID Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(111, 212, 216);
            label2.Location = new Point(60, 118);
            label2.Name = "label2";
            label2.Size = new Size(90, 17);
            label2.TabIndex = 54;
            label2.Text = "Comentarios:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 729);
            label1.TabIndex = 53;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(30, 30, 30);
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(111, 212, 216);
            label7.Location = new Point(211, 197);
            label7.Name = "label7";
            label7.Size = new Size(194, 13);
            label7.TabIndex = 79;
            label7.Text = "Escribir el id del Usuario y apretar Enter";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1350, 729);
            Controls.Add(label7);
            Controls.Add(txtIdVenta);
            Controls.Add(txtIndice);
            Controls.Add(dgvData);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(cboBusqueda);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtVentaSeleccionada);
            Controls.Add(btnLimpiar);
            Controls.Add(label8);
            Controls.Add(btnLimpiarDatos);
            Controls.Add(btnGuardar);
            Controls.Add(lblOperacion);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtComentarios);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmVentas";
            Text = "frmVentas";
            Load += frmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIdVenta;
        private Label txtIndice;
        private DataGridView dgvData;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn IdUsuario;
        private DataGridViewTextBoxColumn Comentarios;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private ComboBox cboBusqueda;
        private Label label10;
        private Label label9;
        private TextBox txtVentaSeleccionada;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblOperacion;
        private TextBox txtNombreUsuario;
        private TextBox txtIdUsuario;
        private TextBox txtComentarios;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
    }
}