using CapaDatos;
using CapaEntidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public class LoginRequest
        {
            public string? Usuario { get; set; }
            public string? Contrasenia { get; set; }
        }

        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("ValidarInicioSesion", Name = "ValidarLogin")]
        public bool ValidarUsuario([FromBody] LoginRequest UsuarioLogueado)
        {

            try
            {
                // Obtén la cadena de conexión desde appsettings.json
                string conexion = _configuration.GetConnectionString("cadena_conexion");

                // Aquí puedes utilizar la cadena de conexión y consultar la lista de usuarios
                bool encontrado = UsuarioData.ValidarLoginUsuario(UsuarioLogueado.Usuario, UsuarioLogueado.Contrasenia, conexion);

                return encontrado;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return false;
            }
        }
        [HttpPost("TraerNombre", Name = "TraerNombre")]
        public string TraerNombre([FromBody] int idUsuario)
        {

            try
            {
                // Obtén la cadena de conexión desde appsettings.json
                string conexion = _configuration.GetConnectionString("cadena_conexion");

                // Aquí puedes utilizar la cadena de conexión y consultar la lista de usuarios
                string nombre = UsuarioData.TraerNombre(idUsuario,conexion);

                return nombre;
            }
            catch (Exception ex)
            {
                ex.ToString();
                return "Usuario No encontrado";
            }
        }
    }
}
