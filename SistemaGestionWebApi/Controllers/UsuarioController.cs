using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public UsuarioController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ObtenerUsuarios", Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            // Obtén la cadena de conexión desde appsettings.json
            string conexion = _configuration.GetConnectionString("cadena_conexion");

            // Aquí puedes utilizar la cadena de conexión y consultar la lista de usuarios
            List<Usuario> usuarios = new CN_Usuario().ListarUsuarios(conexion);

            return usuarios.ToArray();
        }

        



        [HttpDelete("EliminarUsuario",Name = "EliminarUsuario")]
        public void Delete([FromBody] int idUsuario)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            UsuarioData.EliminarUsuarioById(idUsuario, conexion);
        }

        [HttpPut("ModificarUsuario", Name = "ModificarUsuario")]
        public void Put([FromBody] Usuario Usuario)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            UsuarioData.ModificarUsuario(Usuario, conexion);
        }

        [HttpPost("AltaUsuario", Name = "AltaUsuario")]
        public void Post([FromBody] Usuario Usuario)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            UsuarioData.CrearUsuario(Usuario, conexion);
        }
    }
}
