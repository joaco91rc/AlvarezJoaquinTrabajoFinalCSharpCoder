using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_ProductoVendido
    {
        public List<ProductoVendido> ListarProductoVendidos(string conexion)
        {
            return ProductoVendidoData.ListarProductoVendidos(conexion);
        }

        public static void CrearProductoVendido(ProductoVendido objProductoVendido, string conexion)
        {
            ProductoVendidoData.CrearProductoVendido(objProductoVendido,conexion);
        }

        public static void ModificarProductoVendido(ProductoVendido objProductoVendido, string conexion)
        {
            ProductoVendidoData.ModificarProductoVendido(objProductoVendido, conexion);
        }

        public static void EliminarProductoVendido(ProductoVendido objProductoVendido, string conexion)
        {
            ProductoVendidoData.EliminarProductoVendido(objProductoVendido, conexion);
        }

    }
}
