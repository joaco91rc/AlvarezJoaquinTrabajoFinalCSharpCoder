using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ProductoVendidoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ObtenerProductosVendidos", Name = "GetProductosVendidos")]
        public IEnumerable<ProductoVendido> Get()
        {
            // Obtén la cadena de conexión desde appsettings.json
            string conexion = _configuration.GetConnectionString("cadena_conexion");

            // Aquí puedes utilizar la cadena de conexión y consultar la lista de usuarios
            List<ProductoVendido> productosVendidos = new CN_ProductoVendido().ListarProductoVendidos(conexion);

            return productosVendidos.ToArray();
        }
        [HttpDelete("EliminarProductoVendido", Name = "EliminarProductoVendido")]
        public void Delete([FromBody] int idProductoVendido)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            ProductoVendidoData.EliminarProductoVendidoById(idProductoVendido, conexion);
        }

        [HttpPut("ModificarProductoVendido", Name = "ModificarProductoVendido")]
        public void Put([FromBody] ProductoVendido ProductoVendido)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            ProductoVendidoData.ModificarProductoVendido(ProductoVendido, conexion);
        }

        [HttpPost("AltaProductoVendido", Name = "AltaProductoVendido")]
        public void Post([FromBody] ProductoVendido ProductoVendido)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            ProductoVendidoData.CrearProductoVendido(ProductoVendido, conexion);
        }
    }
}
