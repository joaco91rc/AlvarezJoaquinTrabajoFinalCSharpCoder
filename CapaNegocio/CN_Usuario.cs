using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        public List<Usuario> ListarUsuarios(string conexion)
        {
            return UsuarioData.ListarUsuarios(conexion);
        }

        public static void CrearUsuario(Usuario objUsuario, string conexion)
        {
            UsuarioData.CrearUsuario(objUsuario,conexion);
        }
        public static Usuario ObtenerUsuario(int idUsuario, string conexion)
        {
            return UsuarioData.ObtenerUsuario(idUsuario, conexion);
        }

        public static void ModificarUsuario(Usuario objUsuario, string conexion)
        {
            UsuarioData.ModificarUsuario(objUsuario, conexion);
        }

        public static void EliminarUsuario(Usuario objUsuario, string conexion)
        {
            UsuarioData.EliminarUsuario(objUsuario, conexion);
        }
    }
}
