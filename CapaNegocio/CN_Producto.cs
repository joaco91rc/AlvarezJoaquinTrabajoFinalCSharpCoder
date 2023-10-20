using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Producto
    {
        public List<Producto> ListarProductos(string conexion)
        {
            return ProductoData.ListarProductos(conexion);
        }

        public static void CrearProducto(Producto objProducto, string conexion)
        {
            ProductoData.CrearProducto(objProducto,conexion);
        }
        public static Producto ObtenerProducto(int idProducto,string conexion)
        {
            return ProductoData.ObtenerProducto(idProducto, conexion);
        }

        public static void ModificarProducto(Producto objProducto, string conexion)
        {
            ProductoData.ModificarProducto(objProducto, conexion);
        }

        public static void EliminarProducto(Producto objProducto, string conexion)
        {
            ProductoData.EliminarProducto(objProducto, conexion);
        }
    }
}
