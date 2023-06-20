using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Runtime.InteropServices;

namespace Negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos(string servidor, string basedatos, string usuario, string contrasena)
        {
            conexion = new SqlConnection("server= "+ servidor + "; database=" + basedatos+" ; user="+ usuario+ "; password=" +contrasena);
            comando = new SqlCommand();
        }

        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        public void ejecutarLector()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void seterarParametros (string parametro, object valor)
        {
            comando.Parameters.AddWithValue(parametro, valor);
        }

        public void probarConexion()
        {
            try
            {
                conexion.Open();
                conexion.Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
