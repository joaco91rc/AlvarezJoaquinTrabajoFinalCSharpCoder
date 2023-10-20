using CapaDatos;
using CapaEntidades;
using CapaNegocio;
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
    public partial class frmLogin : Form
    {
        private string conexion = Conexion.ObtenerCadenaConexion();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<Usuario> test = new CN_Usuario().ListarUsuarios(conexion);

            Usuario oUsuario = new CN_Usuario().ListarUsuarios(conexion).Where(u => u.nombreUsuario == txtUsuario.Text && u.contrasenia == txtContrasenia.Text).FirstOrDefault();

            if (oUsuario != null)
            {
                Form form1 = new Inicio(oUsuario);
                form1.Show();
                this.Hide();
                form1.FormClosing += form_closing;
            }



            else
            {
                MessageBox.Show("Nombre de Usuario o Contraseña invalidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            this.Show();
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
        }

        private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter) {
                List<Usuario> test = new CN_Usuario().ListarUsuarios(conexion);

                Usuario oUsuario = new CN_Usuario().ListarUsuarios(conexion).Where(u => u.nombreUsuario == txtUsuario.Text && u.contrasenia == txtContrasenia.Text).FirstOrDefault();

                if (oUsuario != null)
                {
                    Form form1 = new Inicio(oUsuario);
                    form1.Show();
                    this.Hide();
                    form1.FormClosing += form_closing;
                }



                else
                {
                    MessageBox.Show("Nombre de Usuario o Contraseña invalidos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }




            }
        }
    }
}
