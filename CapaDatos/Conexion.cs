
using System.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CapaDatos
{
    public class Conexion
    {
        public static string ObtenerCadenaConexion()
        {
            return ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
        }

    }
}
