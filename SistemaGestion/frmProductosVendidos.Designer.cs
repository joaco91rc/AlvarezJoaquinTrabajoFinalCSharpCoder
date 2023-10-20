namespace SistemaGestion
{
    partial class frmProductosVendidos
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
            txtIdProductoVendido = new Label();
            txtIndice = new Label();
            dgvData = new DataGridView();
            btnSeleccionar = new DataGridViewButtonColumn();
            Id = new DataGridViewTextBoxColumn();
            IdProducto = new DataGridViewTextBoxColumn();
            Descripciones = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            IdVenta = new DataGridViewTextBoxColumn();
            btnBuscar = new FontAwesome.Sharp.IconButton();
            txtBusqueda = new TextBox();
            cboBusqueda = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            txtProductoSeleccionado = new TextBox();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnLimpiarDatos = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            lblOperacion = new Label();
            txtIdVenta = new TextBox();
            txtStock = new TextBox();
            txtPrecioVenta = new TextBox();
            txtDescripciones = new TextBox();
            txtIdProducto = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // txtIdProductoVendido
            // 
            txtIdProductoVendido.AutoSize = true;
            txtIdProductoVendido.BackColor = Color.FromArgb(30, 30, 30);
            txtIdProductoVendido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtIdProductoVendido.ForeColor = Color.FromArgb(111, 212, 216);
            txtIdProductoVendido.Location = new Point(426, 75);
            txtIdProductoVendido.Name = "txtIdProductoVendido";
            txtIdProductoVendido.Size = new Size(15, 17);
            txtIdProductoVendido.TabIndex = 52;
            txtIdProductoVendido.Text = "0";
            txtIdProductoVendido.Visible = false;
            txtIdProductoVendido.TextChanged += txtIdProductoVendido_TextChanged;
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
            txtIndice.Visible = false;
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.BackgroundColor = Color.FromArgb(50, 50, 50);
            dgvData.BorderStyle = BorderStyle.None;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { btnSeleccionar, Id, IdProducto, Descripciones, Stock, PrecioVenta, IdVenta });
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
            Id.HeaderText = "ID PRODUCTO VENIDO";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // IdProducto
            // 
            IdProducto.HeaderText = "ID PRODUCTO";
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 180;
            // 
            // Descripciones
            // 
            Descripciones.HeaderText = "DESCRIPCION";
            Descripciones.Name = "Descripciones";
            Descripciones.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "STOCK";
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PRECIO VENTA";
            PrecioVenta.Name = "PrecioVenta";
            PrecioVenta.ReadOnly = true;
            PrecioVenta.Width = 150;
            // 
            // IdVenta
            // 
            IdVenta.HeaderText = "ID VENTA";
            IdVenta.Name = "IdVenta";
            IdVenta.ReadOnly = true;
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
            label9.Size = new Size(394, 32);
            label9.TabIndex = 44;
            label9.Text = "LISTA DE PRODUCTOS VENDIDOS";
            // 
            // txtProductoSeleccionado
            // 
            txtProductoSeleccionado.BackColor = Color.FromArgb(50, 50, 50);
            txtProductoSeleccionado.BorderStyle = BorderStyle.None;
            txtProductoSeleccionado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductoSeleccionado.ForeColor = Color.FromArgb(111, 212, 216);
            txtProductoSeleccionado.Location = new Point(208, 684);
            txtProductoSeleccionado.Name = "txtProductoSeleccionado";
            txtProductoSeleccionado.Size = new Size(285, 18);
            txtProductoSeleccionado.TabIndex = 43;
            txtProductoSeleccionado.Text = "Ninguno";
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
            btnEliminar.Location = new Point(321, 438);
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
            btnLimpiarDatos.Location = new Point(163, 438);
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
            btnGuardar.Location = new Point(12, 438);
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
            lblOperacion.Location = new Point(44, 23);
            lblOperacion.Name = "lblOperacion";
            lblOperacion.Size = new Size(287, 32);
            lblOperacion.TabIndex = 38;
            lblOperacion.Text = "PRODUCTOS VENDIDOS";
            // 
            // txtIdVenta
            // 
            txtIdVenta.CharacterCasing = CharacterCasing.Upper;
            txtIdVenta.Location = new Point(195, 358);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.Size = new Size(192, 23);
            txtIdVenta.TabIndex = 37;
            // 
            // txtStock
            // 
            txtStock.CharacterCasing = CharacterCasing.Upper;
            txtStock.Location = new Point(195, 289);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(192, 23);
            txtStock.TabIndex = 36;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.CharacterCasing = CharacterCasing.Upper;
            txtPrecioVenta.Enabled = false;
            txtPrecioVenta.Location = new Point(195, 230);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(192, 23);
            txtPrecioVenta.TabIndex = 35;
            // 
            // txtDescripciones
            // 
            txtDescripciones.CharacterCasing = CharacterCasing.Upper;
            txtDescripciones.Enabled = false;
            txtDescripciones.Location = new Point(195, 171);
            txtDescripciones.Name = "txtDescripciones";
            txtDescripciones.Size = new Size(192, 23);
            txtDescripciones.TabIndex = 34;
            // 
            // txtIdProducto
            // 
            txtIdProducto.CharacterCasing = CharacterCasing.Upper;
            txtIdProducto.Location = new Point(195, 112);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(192, 23);
            txtIdProducto.TabIndex = 33;
            txtIdProducto.KeyDown += txtIdProducto_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(30, 30, 30);
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(111, 212, 216);
            label6.Location = new Point(44, 236);
            label6.Name = "label6";
            label6.Size = new Size(89, 17);
            label6.TabIndex = 32;
            label6.Text = "Precio Venta:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(30, 30, 30);
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(111, 212, 216);
            label5.Location = new Point(44, 295);
            label5.Name = "label5";
            label5.Size = new Size(41, 17);
            label5.TabIndex = 31;
            label5.Text = "Stock";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(30, 30, 30);
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(111, 212, 216);
            label3.Location = new Point(44, 364);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 30;
            label3.Text = "Venta Numero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(30, 30, 30);
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(111, 212, 216);
            label4.Location = new Point(44, 177);
            label4.Name = "label4";
            label4.Size = new Size(84, 17);
            label4.TabIndex = 29;
            label4.Text = "Descripcion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(30, 30, 30);
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(111, 212, 216);
            label2.Location = new Point(44, 118);
            label2.Name = "label2";
            label2.Size = new Size(139, 17);
            label2.TabIndex = 28;
            label2.Text = "Id Producto Vendido:";
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 30, 30);
            label1.Dock = DockStyle.Left;
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(483, 729);
            label1.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(30, 30, 30);
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(111, 212, 216);
            label7.Location = new Point(195, 138);
            label7.Name = "label7";
            label7.Size = new Size(242, 13);
            label7.TabIndex = 53;
            label7.Text = "Escribir el id del Producto Vendido y apretar Enter";
            // 
            // frmProductosVendidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 50);
            ClientSize = new Size(1350, 729);
            Controls.Add(label7);
            Controls.Add(txtIdProductoVendido);
            Controls.Add(txtIndice);
            Controls.Add(dgvData);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(cboBusqueda);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(txtProductoSeleccionado);
            Controls.Add(btnLimpiar);
            Controls.Add(label8);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiarDatos);
            Controls.Add(btnGuardar);
            Controls.Add(lblOperacion);
            Controls.Add(txtIdVenta);
            Controls.Add(txtStock);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtDescripciones);
            Controls.Add(txtIdProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProductosVendidos";
            Text = "frmProductosVendidos";
            Load += frmProductosVendidos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtIdProductoVendido;
        private Label txtIndice;
        private DataGridView dgvData;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private TextBox txtBusqueda;
        private ComboBox cboBusqueda;
        private Label label10;
        private Label label9;
        private TextBox txtProductoSeleccionado;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private Label label8;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiarDatos;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private Label lblOperacion;
        private TextBox txtIdVenta;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtDescripciones;
        private TextBox txtIdProducto;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private DataGridViewButtonColumn btnSeleccionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Descripciones;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn IdVenta;
        private Label label7;
    }
}