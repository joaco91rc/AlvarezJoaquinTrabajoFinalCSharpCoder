namespace SistemaGestion
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContrasenia = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(224, 291);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(8, 83, 150);
            label1.Location = new Point(45, 237);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 1;
            label1.Text = "CURSO C#";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 206);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(298, 78);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(298, 137);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 2;
            label3.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(8, 83, 150);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.CharacterCasing = CharacterCasing.Upper;
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(421, 77);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(257, 22);
            txtUsuario.TabIndex = 3;
            // 
            // txtContrasenia
            // 
            txtContrasenia.BackColor = Color.FromArgb(8, 83, 150);
            txtContrasenia.BorderStyle = BorderStyle.None;
            txtContrasenia.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtContrasenia.ForeColor = Color.White;
            txtContrasenia.Location = new Point(421, 139);
            txtContrasenia.Name = "txtContrasenia";
            txtContrasenia.PasswordChar = '*';
            txtContrasenia.Size = new Size(257, 22);
            txtContrasenia.TabIndex = 4;
            txtContrasenia.KeyDown += txtContrasenia_KeyDown;
            // 
            // iconButton1
            // 
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(298, 214);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(380, 40);
            iconButton1.TabIndex = 5;
            iconButton1.Text = "ACCEDER";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(8, 83, 150);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconPictureBox1.IconColor = Color.White;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 19;
            iconPictureBox1.Location = new Point(742, 0);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(19, 22);
            iconPictureBox1.TabIndex = 6;
            iconPictureBox1.TabStop = false;
            iconPictureBox1.Click += iconPictureBox1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 83, 150);
            ClientSize = new Size(764, 291);
            Controls.Add(iconPictureBox1);
            Controls.Add(iconButton1);
            Controls.Add(txtContrasenia);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContrasenia;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}