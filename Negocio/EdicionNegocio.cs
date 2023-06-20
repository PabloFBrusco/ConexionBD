using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class EdicionNegocio
    {
        string servidor, basedatos, usuario, pasword;
        public void buscarParametros()
        {
            servidor = ConfigurationManager.AppSettings["server"];
            basedatos = ConfigurationManager.AppSettings["db"];
            usuario = ConfigurationManager.AppSettings["user"];
            pasword = ConfigurationManager.AppSettings["pass"];
        }
        public List<TipoEdicion> listar()
        {
            List<TipoEdicion> lista = new List<TipoEdicion>();
            
            buscarParametros();
            AccesoDatos datos = new AccesoDatos(servidor,basedatos,usuario,pasword);
            try
            {
                datos.setearConsulta("select id, descripcion from tiposedicion order by descripcion");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    TipoEdicion aux = new TipoEdicion();

                    aux.id = (int)datos.Lector["id"];
                    aux.descripcion = (string)datos.Lector["descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }
        public void AgregarEdicion(TipoEdicion nuevo)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);
            try
            {
                dato.setearConsulta("Insert Into TiposEdicion (descripcion) values ('" + nuevo.descripcion + "') ");
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }

        }

        public void ModificarEdicion(string edicion, string valor)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);

            try
            {
                dato.setearConsulta("Update Tiposedicion set descripcion = '" + edicion + "' where id = " + int.Parse(valor));
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }

        }

        public void EliminarEdicion(string valor)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);

            try
            {
                dato.setearConsulta("Delete TiposEdicion where id = " + int.Parse(valor));
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                dato.cerrarConexion();
            }
        }
    }
}
