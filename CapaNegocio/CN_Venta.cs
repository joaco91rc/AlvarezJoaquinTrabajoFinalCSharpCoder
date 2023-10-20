using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Venta
    {
        public List<Venta> ListarVentas(string conexion)
        {
            return VentaData.ListarVentas(conexion);
        }

        public static void CrearVenta(Venta objVenta, string conexion)
        {
            VentaData.CrearVenta(objVenta,conexion);
        }

        public static void ModificarVenta(Venta objVenta, string conexion)
        {
            VentaData.ModificarVenta(objVenta, conexion);
        }

        public static void EliminarVenta(Venta objVenta, string conexion)
        {
            VentaData.EliminarVenta(objVenta, conexion);
        }
    }
}
