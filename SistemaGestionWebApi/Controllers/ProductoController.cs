using CapaDatos;
using CapaEntidades;
using CapaNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ProductoController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet("ObtenerProductos", Name = "GetProductos")]
        public IEnumerable<Producto> Get()
        {
            // Obtén la cadena de conexión desde appsettings.json
            string conexion = _configuration.GetConnectionString("cadena_conexion");

            // Aquí puedes utilizar la cadena de conexión y consultar la lista de usuarios
            List<Producto> productos = new CN_Producto().ListarProductos(conexion);

            return productos.ToArray();
        }
        [HttpDelete("EliminarProducto", Name = "EliminarProducto")]
        public void Delete([FromBody] int idProducto)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            ProductoData.EliminarProductoById(idProducto, conexion);
        }

        [HttpPut("ModificarProducto", Name = "ModificarProducto")]
        public void Put([FromBody] Producto Producto)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            ProductoData.ModificarProducto(Producto, conexion);
        }

        [HttpPost("AltaProducto", Name = "AltaProducto")]
        public void Post([FromBody] Producto Producto)
        {
            string conexion = _configuration.GetConnectionString("cadena_conexion");
            ProductoData.CrearProducto(Producto, conexion);
        }
    }
}
