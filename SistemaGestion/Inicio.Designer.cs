namespace SistemaGestion
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panel1 = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            btnMinimizar = new FontAwesome.Sharp.IconPictureBox();
            menu = new MenuStrip();
            menuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            menuProductos = new FontAwesome.Sharp.IconMenuItem();
            MenuVentas = new FontAwesome.Sharp.IconMenuItem();
            MenuProductosVendidos = new FontAwesome.Sharp.IconMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            contenedor = new Panel();
            menuTitulo = new MenuStrip();
            label2 = new Label();
            lblNombreUsuario = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(8, 83, 150);
            panel1.Controls.Add(lblNombreUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(btnMinimizar);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1350, 38);
            panel1.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(8, 83, 150);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.Location = new Point(1304, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 32);
            iconPictureBox1.TabIndex = 1;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(8, 83, 150);
            btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimizar.IconColor = Color.White;
            btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimizar.Location = new Point(1256, 3);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(32, 32);
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.FromArgb(8, 83, 150);
            menu.Items.AddRange(new ToolStripItem[] { menuUsuarios, menuProductos, MenuVentas, MenuProductosVendidos });
            menu.Location = new Point(0, 163);
            menu.Name = "menu";
            menu.Size = new Size(1350, 79);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // menuUsuarios
            // 
            menuUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuUsuarios.ForeColor = Color.White;
            menuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menuUsuarios.IconColor = Color.FromArgb(128, 128, 255);
            menuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuUsuarios.IconSize = 50;
            menuUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            menuUsuarios.Name = "menuUsuarios";
            menuUsuarios.Size = new Size(88, 75);
            menuUsuarios.Text = "Usuarios";
            menuUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            menuUsuarios.Click += menuUsuarios_Click;
            // 
            // menuProductos
            // 
            menuProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuProductos.ForeColor = Color.White;
            menuProductos.IconChar = FontAwesome.Sharp.IconChar.Box;
            menuProductos.IconColor = Color.Goldenrod;
            menuProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuProductos.ImageScaling = ToolStripItemImageScaling.None;
            menuProductos.Name = "menuProductos";
            menuProductos.Size = new Size(99, 75);
            menuProductos.Text = "Productos";
            menuProductos.TextImageRelation = TextImageRelation.ImageAboveText;
            menuProductos.Click += menuProductos_Click;
            // 
            // MenuVentas
            // 
            MenuVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MenuVentas.ForeColor = Color.White;
            MenuVentas.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            MenuVentas.IconColor = Color.ForestGreen;
            MenuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuVentas.IconSize = 50;
            MenuVentas.ImageScaling = ToolStripItemImageScaling.None;
            MenuVentas.Name = "MenuVentas";
            MenuVentas.Size = new Size(73, 75);
            MenuVentas.Text = "Ventas";
            MenuVentas.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuVentas.Click += MenuVentas_Click;
            // 
            // MenuProductosVendidos
            // 
            MenuProductosVendidos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MenuProductosVendidos.ForeColor = Color.White;
            MenuProductosVendidos.IconChar = FontAwesome.Sharp.IconChar.Dolly;
            MenuProductosVendidos.IconColor = Color.DarkOrange;
            MenuProductosVendidos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuProductosVendidos.ImageScaling = ToolStripItemImageScaling.None;
            MenuProductosVendidos.Name = "MenuProductosVendidos";
            MenuProductosVendidos.Size = new Size(174, 75);
            MenuProductosVendidos.Text = "Productos Vendidos";
            MenuProductosVendidos.TextImageRelation = TextImageRelation.ImageAboveText;
            MenuProductosVendidos.Click += MenuProductosVendidos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(145, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(214, 81);
            label1.Name = "label1";
            label1.Size = new Size(424, 32);
            label1.TabIndex = 3;
            label1.Text = "SISTEMA GESTION C# NET CORE 6.0";
            // 
            // contenedor
            // 
            contenedor.BackColor = Color.White;
            contenedor.Dock = DockStyle.Fill;
            contenedor.Location = new Point(0, 242);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(1350, 487);
            contenedor.TabIndex = 4;
            // 
            // menuTitulo
            // 
            menuTitulo.AutoSize = false;
            menuTitulo.BackColor = Color.FromArgb(30, 30, 30);
            menuTitulo.Location = new Point(0, 0);
            menuTitulo.Name = "menuTitulo";
            menuTitulo.Size = new Size(1350, 163);
            menuTitulo.TabIndex = 5;
            menuTitulo.ItemClicked += menuTitulo_ItemClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(101, 21);
            label2.TabIndex = 2;
            label2.Text = "Bienvenido:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreUsuario.ForeColor = Color.White;
            lblNombreUsuario.Location = new Point(138, 9);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(136, 21);
            lblNombreUsuario.TabIndex = 3;
            lblNombreUsuario.Text = "Nombre Usuario";
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1350, 729);
            Controls.Add(contenedor);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(menu);
            Controls.Add(menuTitulo);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menu;
            MinimizeBox = false;
            Name = "Inicio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Inicio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox btnMinimizar;
        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuUsuarios;
        private FontAwesome.Sharp.IconMenuItem menuProductos;
        private FontAwesome.Sharp.IconMenuItem MenuVentas;
        private FontAwesome.Sharp.IconMenuItem MenuProductosVendidos;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel contenedor;
        private MenuStrip menuTitulo;
        private Label lblNombreUsuario;
        private Label label2;
    }
}