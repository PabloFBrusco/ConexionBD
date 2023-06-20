using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Configuration;

namespace Negocio
{
    public class ArtistaNegocio
    {
        string servidor, basedatos, usuario, pasword;
        public void buscarParametros()
        {
            servidor = ConfigurationManager.AppSettings["server"];
            basedatos = ConfigurationManager.AppSettings["db"];
            usuario = ConfigurationManager.AppSettings["user"];
            pasword = ConfigurationManager.AppSettings["pass"];
        }
        public List<Artista> listar()
        {
            List<Artista> lista = new List<Artista>();
            buscarParametros();
            AccesoDatos datos = new AccesoDatos(servidor, basedatos, usuario, pasword);
            try
            {
                datos.setearConsulta("select id, nombre from artistas order by nombre");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Artista aux = new Artista();

                    aux.Id = (int)datos.Lector["id"];
                    aux.Nombre = (string)datos.Lector["nombre"];

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
        public void AgregarArtista(Artista nuevo)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);
            try
            {
                dato.setearConsulta("Insert Into Artistas (nombre) values ('" + nuevo.Nombre + "') ");
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

        public void ModificarArtista(string Nombre, string valor)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);

            try
            {
                dato.setearConsulta("Update Artistas set nombre = '" + Nombre + "' where id = " + int.Parse(valor));
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

        public void EliminarArtista(string valor)
        {
            buscarParametros();
            AccesoDatos dato = new AccesoDatos(servidor, basedatos, usuario, pasword);

            try
            {
                dato.setearConsulta("Delete Artistas where id = " + int.Parse(valor));
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
