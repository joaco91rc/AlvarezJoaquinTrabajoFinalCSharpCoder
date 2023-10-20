namespace SistemaGestion
{
    partial class frmProducto
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtDescripciones = new TextBox();
            txtCosto = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStock = new TextBox();
            txtIdUsuario = new TextBox();
            lblOperacion = new Label();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            txtProductoSeleccionado = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cboBusqueda = new ComboBox();
            txtBusqueda = new TextBox();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            IdUsuario = new DataGridViewTextBoxColumn();
            txtIndice = new Label();
            txtIdProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 729);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(111, 212, 216);
            label2.Location = new Point(30, 118);
            label2.Name = "label2";
            label2.Size = new Size(84, 17);
            label2.TabIndex = 1;
            label2.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(111, 212, 216);
            label4.Location = new Point(30, 177);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 3;
            label4.Text = "Costo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(111, 212, 216);
            label3.Location = new Point(30, 364);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 4;
            label3.Text = "Id Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(30, 30, 30);
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(111, 212, 216);
            label5.Location = new Point(30, 295);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 5;
            label5.Text = "Stock";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(111, 212, 216);
            label6.Location = new Point(30, 236);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 6;
            label6.Text = "Precio Venta:";
            // 
            // txtDescripciones
            // 
            txtDescripciones.CharacterCasing = CharacterCasing.Upper;
            txtDescripciones.Location = new Point(163, 112);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(192, 23);
            txtDescripciones.TabIndex = 7;
            // 
            // txtCosto
            // 
            txtCosto.CharacterCasing = CharacterCasing.Upper;
            txtCosto.Location = new Point(163, 171);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(192, 23);
            txtCosto.TabIndex = 8;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.CharacterCasing = CharacterCasing.Upper;
            txtPrecioVenta.Location = new Point(163, 230);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(192, 23);
            txtPrecioVenta.TabIndex = 9;
            txtPrecioVenta.TextChanged += txtPrecioVenta_TextChanged;
            // 
            // txtStock
            // 
            txtStock.CharacterCasing = CharacterCasing.Upper;
            txtStock.Location = new Point(163, 289);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(192, 23);
            txtStock.TabIndex = 10;
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.CharacterCasing = CharacterCasing.Upper;
            txtIdUsuario.Location = new Point(163, 358);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(192, 23);
            txtIdUsuario.TabIndex = 11;
            // 
            // lblOperacion
            // 
            lblOperacion.AutoSize = true;
            lblOperacion.BackColor = Color.FromArgb(30, 30, 30);
            lblOperacion.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblOperacion.ForeColor = Color.FromArgb(224, 224, 224);
            lblOperacion.Location = new Point(58, 23);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(297, 32);
            lblOperacion.TabIndex = 12;
            lblOperacion.Text = "ALTA NUEVO PRODUCTO";
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
            btnGuardar.Location = new Point(12, 439);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 31);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
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
            btnLimpiarDatos.Location = new Point(163, 439);
            btnLimpiarDatos.Name = "btnLimpiarDatos";
            btnLimpiarDatos.Size = new Size(140, 31);
            btnLimpiarDatos.TabIndex = 14;
            btnLimpiarDatos.Text = "Limpiar";
            btnLimpiarDatos.UseVisualStyleBackColor = false;
            btnLimpiarDatos.Click += btnLimpiarDatos_Click;
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
            btnEliminar.Location = new Point(321, 439);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 31);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(50, 50, 50);
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(111, 212, 216);
            label8.Location = new Point(6, 685);
            label8.Name = "label8";
            label8.Size = new Size(152, 17);
            label8.TabIndex = 16;
            label8.Text = "Producto Seleccionado:";
            // 
            // txtProductoSeleccionado
            // 
            txtProductoSeleccionado.BackColor = Color.FromArgb(50, 50, 50);
            txtProductoSeleccionado.BorderStyle = BorderStyle.None;
            txtProductoSeleccionado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductoSeleccionado.ForeColor = Color.FromArgb(111, 212, 216);
            txtProductoSeleccionado.Location = new Point(176, 684);
            txtProductoSeleccionado.Name = "txtProductoSeleccionado";
            txtProductoSeleccionado.Size = new Size(285, 18);
            txtProductoSeleccionado.TabIndex = 17;
            txtProductoSeleccionado.Text = "Ninguno";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(50, 50, 50);
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(581, 23);
            label9.Name = "label9";
            label9.Size = new Size(264, 32);
            label9.TabIndex = 18;
            label9.Text = "LISTA DE PRODUCTOS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(50, 50, 50);
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(111, 212, 216);
            label10.Location = new Point(526, 112);
            label10.Name = "label10";
            label10.Size = new Size(78, 17);
            label10.TabIndex = 19;
            label10.Text = "Buscar por:";
            // 
            // cboBusqueda
            // 
            cboBusqueda.FormattingEnabled = true;
            cboBusqueda.Location = new Point(638, 106);
            cboBusqueda.Name = "cboBusqueda";
            cboBusqueda.Size = new Size(190, 23);
            cboBusqueda.TabIndex = 20;
            // 
            // txtBusqueda
            // 
            txtBusqueda.CharacterCasing = CharacterCasing.Upper;
            txtBusqueda.Location = new Point(860, 106);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(192, 23);
            txtBusqueda.TabIndex = 21;
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
            btnBuscar.Location = new Point(1068, 103);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(35, 26);
            btnBuscar.TabIndex = 22;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
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
            btnLimpiar.Location = new Point(1120, 103);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(35, 26);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario });
            dgvData.Cursor = Cursors.Hand;
            dgvData.GridColor = Color.White;
            dgvData.Location = new Point(526, 177);
            dgvData.MultiSelect = false;
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(8, 83, 150);
            dgvData.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(760, 396);
            dgvData.TabIndex = 24;
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
            Id.HeaderText = "ID PRODUCTO";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Descripciones
            // 
            Descripciones.HeaderText = "DESCRIPCION";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            Descripciones.Width = 180;
            // 
            // Costo
            // 
            Costo.HeaderText = "COSTO";
            Costo.Name = "Costo";
            Costo.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PRECIO VENTA";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "STOCK";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // IdUsuario
            // 
            IdUsuario.HeaderText = "ID USUARIO";
            IdUsuario.Name = "IdUsuario";
            IdUsuario.ReadOnly = true;
            // 
            // txtIndice
            // 
            txtIndice.AutoSize = true;
            txtIndice.BackColor = Color.FromArgb(30, 30, 30);
            txtIndice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIndice.ForeColor = Color.FromArgb(111, 212, 216);
            txtIndice.Location = new Point(349, 75);
            txtIndice.Name = "txtIndice";
            txtIndice.Size = new Size(20, 17);
            txtIndice.TabIndex = 25;
            txtIndice.Text = "-1";
            txtIndice.Visible = false;
            // 
            // txtIdProducto
            // 
            txtIdProducto.AutoSize = true;
            txtIdProducto.BackColor = Color.FromArgb(30, 30, 30);
            txtIdProducto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdProducto.ForeColor = Color.FromArgb(111, 212, 216);
            txtIdProducto.Location = new Point(394, 75);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(15, 17);
            txtIdProducto.TabIndex = 26;
            txtIdProducto.Text = "0";
            txtIdProducto.Visible = false;
            txtIdProducto.TextChanged += txtIdProducto_TextChanged;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1350, 729);
            Controls.Add(txtIdProducto);
            Controls.Add(txtIndice);
            Controls.Add(dgvData);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(cboBusqueda);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtProductoSeleccionado);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiarDatos);
            Controls.Add(btnGuardar);
            Controls.Add(lblOperacion);
            Controls.Add(txtIdUsuario);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtCosto);
            Controls.Add(txtDescripciones);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtDescripciones;
        private TextBox txtCosto;
        private TextBox txtPrecioVenta;
        private TextBox txtStock;
        private TextBox txtIdUsuario;
        private Label lblOperacion;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private Label label8;
        private TextBox txtProductoSeleccionado;
        private Label label9;
        private Label label10;
        private ComboBox cboBusqueda;
        private TextBox txtBusqueda;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private DataGridView dgvData;
        private Label txtIndice;
        private Label txtIdProducto;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn IdUsuario;
    }
}