using CapaEntidades;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem menuActivo;
        private static Form formularioActivo;
        private static Usuario usuarioActual;
        public Inicio(Usuario objUsuario)
        {
            Environment.SetEnvironmentVariable("usuario", objUsuario.nombre);
            

            usuarioActual = objUsuario;
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
            {
                menuActivo.BackColor = Color.FromArgb(8, 83, 150);
                menuActivo.ForeColor = Color.FromArgb(224, 224, 224);
            }
            menu.BackColor = Color.FromArgb(178, 214, 243);
            menu.ForeColor = Color.FromArgb(8, 83, 150);
            menuActivo = menu;

            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(50, 50, 50);
            contenedor.Controls.Add(formulario);
            formulario.Show();

        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            lblNombreUsuario.Text = Environment.GetEnvironmentVariable("usuario");
            

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea cerrar la Aplicacion?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuarios());
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProducto());
        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVentas());
        }

        private void MenuProductosVendidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmProductosVendidos());
        }

        private void menuTitulo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
