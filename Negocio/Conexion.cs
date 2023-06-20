using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Conexion
    {
        string servidor, basedatos, usuario, pasword;
        AccesoDatos datos;
        public void establecerConexion(AccesoDatos datos)
        {
            servidor = ConfigurationManager.AppSettings["server"];
            basedatos = ConfigurationManager.AppSettings["db"];
            usuario = ConfigurationManager.AppSettings["user"];
            pasword = ConfigurationManager.AppSettings["pass"];


        }

    }
}
