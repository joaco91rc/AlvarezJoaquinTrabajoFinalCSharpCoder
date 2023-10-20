namespace SistemaGestion
{
    partial class frmUsuarios
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
            txtIdUsuario = new Label();
            txtIndice = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            Contrasenia = new DataGridViewTextBoxColumn();
            Mail = new DataGridViewTextBoxColumn();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            cboBusqueda = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtUsuarioSeleccionado = new TextBox();
            label8 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblOperacion = new Label();
            txtMail = new TextBox();
            txtContrasenia = new TextBox();
            txtNombreUsuario = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.AutoSize = true;
            txtIdUsuario.BackColor = Color.FromArgb(30, 30, 30);
            txtIdUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdUsuario.ForeColor = Color.FromArgb(111, 212, 216);
            txtIdUsuario.Location = new Point(426, 75);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(15, 17);
            txtIdUsuario.TabIndex = 52;
            txtIdUsuario.Text = "0";
            txtIdUsuario.TextChanged += txtIdUsuario_TextChanged;
            // 
            // txtIndice
            // 
            txtIndice.AutoSize = true;
            txtIndice.BackColor = Color.FromArgb(30, 30, 30);
            txtIndice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIndice.ForeColor = Color.FromArgb(111, 212, 216);
            txtIndice.Location = new Point(381, 75);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(20, 17);
            txtIndice.TabIndex = 51;
            txtIndice.Text = "-1";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, Nombre, Apellido, NombreUsuario, Contrasenia, Mail });
            dgvData.Cursor = Cursors.Hand;
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(558, 177);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(8, 83, 150);
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(760, 396);
            dgvData.TabIndex = 50;
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
            Id.HeaderText = "ID USUARIO";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "NOMBRE";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 180;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "APELLIDO";
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            NombreUsuario.HeaderText = "USUARIO";
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            // 
            // Contrasenia
            // 
            Contrasenia.HeaderText = "CONTRASEÑA";
            Contrasenia.Name = "Contrasenia";
            Contrasenia.ReadOnly = true;
            Contrasenia.Visible = false;
            // 
            // Mail
            // 
            Mail.HeaderText = "MAIL";
            Mail.Name = "Mail";
            Mail.ReadOnly = true;
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
            btnLimpiar.Location = new Point(1152, 103);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(35, 26);
            btnLimpiar.TabIndex = 49;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            btnBuscar.Location = new Point(1100, 103);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 26);
            btnBuscar.TabIndex = 48;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.CharacterCasing = CharacterCasing.Upper;
            txtBusqueda.Location = new Point(892, 106);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(192, 23);
            txtBusqueda.TabIndex = 47;
            // 
            // cboBusqueda
            // 
            cboBusqueda.FormattingEnabled = true;
            cboBusqueda.Location = new Point(670, 106);
            cboBusqueda.Name = "cboBusqueda";
            cboBusqueda.Size = new Size(190, 23);
            cboBusqueda.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(50, 50, 50);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(111, 212, 216);
            label10.Location = new Point(558, 112);
            label10.Name = "label10";
            label10.Size = new Size(78, 17);
            label10.TabIndex = 45;
            label10.Text = "Buscar por:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(50, 50, 50);
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(613, 23);
            label9.Name = "label9";
            label9.Size = new Size(239, 32);
            label9.TabIndex = 44;
            label9.Text = "LISTA DE USUARIOS";
            // 
            // txtUsuarioSeleccionado
            // 
            txtUsuarioSeleccionado.BackColor = Color.FromArgb(50, 50, 50);
            txtUsuarioSeleccionado.BorderStyle = BorderStyle.None;
            txtUsuarioSeleccionado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuarioSeleccionado.ForeColor = Color.FromArgb(111, 212, 216);
            txtUsuarioSeleccionado.Location = new Point(208, 684);
            txtUsuarioSeleccionado.Name = "txtUsuarioSeleccionado";
            txtUsuarioSeleccionado.Size = new Size(285, 18);
            txtUsuarioSeleccionado.TabIndex = 43;
            txtUsuarioSeleccionado.Text = "Ninguno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(50, 50, 50);
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(111, 212, 216);
            label8.Location = new Point(38, 685);
            label8.Name = "label8";
            label8.Size = new Size(152, 17);
            label8.TabIndex = 42;
            label8.Text = "Producto Seleccionado:";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Firebrick;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            btnEliminar.IconColor = Color.White;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEliminar.IconSize = 28;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(353, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 31);
            btnEliminar.TabIndex = 41;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
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
            btnLimpiarDatos.Location = new Point(195, 439);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(140, 31);
            btnLimpiarDatos.TabIndex = 40;
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
            btnGuardar.Location = new Point(44, 439);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 31);
            btnGuardar.TabIndex = 39;
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
            lblOperacion.Location = new Point(90, 23);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(272, 32);
            lblOperacion.TabIndex = 38;
            lblOperacion.Text = "ALTA NUEVO USUARIO";
            // 
            // txtMail
            // 
            txtMail.CharacterCasing = CharacterCasing.Upper;
            txtMail.Location = new Point(195, 358);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(192, 23);
            txtMail.TabIndex = 37;
            // 
            // txtContrasenia
            // 
            txtContrasenia.Location = new Point(195, 289);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.Size = new Size(192, 23);
            txtContrasenia.TabIndex = 36;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.CharacterCasing = CharacterCasing.Upper;
            txtNombreUsuario.Location = new Point(195, 230);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(192, 23);
            txtNombreUsuario.TabIndex = 35;
            // 
            // txtApellido
            // 
            txtApellido.CharacterCasing = CharacterCasing.Upper;
            txtApellido.Location = new Point(195, 171);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(192, 23);
            txtApellido.TabIndex = 34;
            // 
            // txtNombre
            // 
            txtNombre.CharacterCasing = CharacterCasing.Upper;
            txtNombre.Location = new Point(195, 112);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 33;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(111, 212, 216);
            label6.Location = new Point(62, 236);
            label6.Name = "label6";
            label6.Size = new Size(59, 17);
            label6.TabIndex = 32;
            label6.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(30, 30, 30);
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(111, 212, 216);
            label5.Location = new Point(62, 295);
            label5.Name = "label5";
            label5.Size = new Size(81, 17);
            label5.TabIndex = 31;
            label5.Text = "Contraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(111, 212, 216);
            label3.Location = new Point(62, 364);
            label3.Name = "label3";
            label3.Size = new Size(39, 17);
            label3.TabIndex = 30;
            label3.Text = "Mail:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(111, 212, 216);
            label4.Location = new Point(62, 177);
            label4.Name = "label4";
            label4.Size = new Size(64, 17);
            label4.TabIndex = 29;
            label4.Text = "Apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(111, 212, 216);
            label2.Location = new Point(62, 118);
            label2.Name = "label2";
            label2.Size = new Size(62, 17);
            label2.TabIndex = 28;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(509, 729);
            label1.TabIndex = 27;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1350, 729);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtIndice);
            Controls.Add(dgvData);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(cboBusqueda);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtUsuarioSeleccionado);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiarDatos);
            Controls.Add(btnGuardar);
            Controls.Add(lblOperacion);
            Controls.Add(txtMail);
            Controls.Add(txtContrasenia);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            Load += frmUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIdUsuario;
        private Label txtIndice;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private ComboBox cboBusqueda;
        private Label label10;
        private Label label9;
        private TextBox txtUsuarioSeleccionado;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblOperacion;
        private TextBox txtMail;
        private TextBox txtContrasenia;
        private TextBox txtNombreUsuario;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn NombreUsuario;
        private DataGridViewTextBoxColumn Contrasenia;
        private DataGridViewTextBoxColumn Mail;
    }
}