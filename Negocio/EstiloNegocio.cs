using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Configuration;

namespace Negocio
{
    public class EstiloNegocio
    {
        string servidor, basedatos, usuario, pasword;
        public void buscarParametros()
        {
            servidor = ConfigurationManager.AppSettings["server"];
            basedatos = ConfigurationManager.AppSettings["db"];
            usuario = ConfigurationManager.AppSettings["user"];
            pasword = ConfigurationManager.AppSettings["pass"];
        }   
        public List<Estilo> listar()
        {
            List<Estilo> lista = new List<Estilo>();
            buscarParametros();
            AccesoDatos datos = new AccesoDatos(servidor, basedatos, usuario, pasword);
            try
            {
                
                datos.setearConsulta("select id, descripcion from estilos order by descripcion");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Estilo aux = new Estilo();

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
        public void AgregarEstilo(Estilo nuevo)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);
            try
            {
                dato.setearConsulta("INsert Into Estilos (descripcion) values ('" + nuevo.descripcion + "') ");
                dato.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { 
                dato.cerrarConexion();
            }  

        }

        public void ModificarEstilo(string estilo, string valor)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);

            try
            {
                dato.setearConsulta("Update Estilos set descripcion = '"+ estilo + "' where id = " + int.Parse(valor));
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

        public void EliminarEstilo(string valor)
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
