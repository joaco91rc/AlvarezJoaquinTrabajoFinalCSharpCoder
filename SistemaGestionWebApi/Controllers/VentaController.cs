using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public VentaController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ObtenerVentas", Name = "GetVenta")]
        public IEnumerable<Venta> Get()
        {
            // Obtén la cadena de conexión desde appsettings.json
            string conexion = _configuration.GetConnectionString("cadena_conexion");

            // Aquí puedes utilizar la cadena de conexión y consultar la lista de usuarios
            List<Venta> ventas = new CN_Venta().ListarVentas(conexion);

            return ventas.ToArray();
        }
        [HttpDelete("EliminarVenta", Name = "EliminarVenta")]
        public void Delete([FromBody] int idVenta)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            VentaData.EliminarVentaById(idVenta, conexion);
        }

        [HttpPut("ModificarVenta", Name = "ModificarVenta")]
        public void Put([FromBody] Venta Venta)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            VentaData.ModificarVenta(Venta, conexion);
        }

        [HttpPost("AltaVenta", Name = "AltaVenta")]
        public void Post([FromBody] Venta Venta)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            VentaData.CrearVenta(Venta, conexion);
        }
    }
}
