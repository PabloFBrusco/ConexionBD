using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using Negocio;
using System.Net;
using System.Configuration;

namespace Negocio
{
    public class DiscoNegocio
    {
        string servidor, basedatos, usuario, pasword;
        AccesoDatos datos;
        public void establecerConexion()
        {
            servidor = ConfigurationManager.AppSettings["server"];
            basedatos = ConfigurationManager.AppSettings["db"];
            usuario = ConfigurationManager.AppSettings["user"];
            pasword = ConfigurationManager.AppSettings["pass"];
            datos = new AccesoDatos(servidor, basedatos, usuario, pasword);
        }

        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();
            establecerConexion();
            try
            {
                datos.setearConsulta("Select d.id, titulo Titulo, fechalanzamiento as \"Fecha lanzamiento\", cantidadcanciones \"Cantidad Canciones\", urlimagentapa, e.Descripcion Estilo, t.Descripcion \"Tipo Edicion\", a.nombre, d.IdEstilo, d.IdTipoEdicion, d.IdArtista from discos d inner join estilos e ON d.IdEstilo = e.Id inner join TIPOSEDICION t on d.IdTipoEdicion = t.Id inner join ARTISTAS a ON d.IdArtista = a.Id where d.activo = 1");
                datos.ejecutarLector();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["Fecha Lanzamiento"];
                    aux.CantCanciones = (int)datos.Lector["Cantidad Canciones"];
                    if (!(datos.Lector["urlimagentapa"] is DBNull))
                    aux.UrlImagenTapa = (string)datos.Lector["urlimagentapa"];
                    aux.estilo = new Estilo();
                    aux.estilo.id = (int)datos.Lector["IdEstilo"];
                    aux.estilo.descripcion = (string)datos.Lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Edicion.descripcion = (string)datos.Lector["Tipo Edicion"];
                    aux.id = (int)datos.Lector["id"];
                    aux.artista = new Artista();
                    aux.artista.Id = (int)datos.Lector["idArtista"];
                    aux.artista.Nombre = (string)datos.Lector["Nombre"];
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

        public void AgregarDisco (Disco NuevoDisco)
        {
            establecerConexion();
            try
            {
                datos.setearConsulta("insert into discos (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion, IdArtista, activo) values ('" + NuevoDisco.Titulo + "', '" + NuevoDisco.FechaLanzamiento + "', "+ NuevoDisco.CantCanciones + ", '" + NuevoDisco.UrlImagenTapa + "', @IdEstilo,@IdEdicion,@IdArtista,1)");
                datos.seterarParametros("@IdEstilo",NuevoDisco.estilo.id);
                datos.seterarParametros("@IdEdicion",NuevoDisco.Edicion.id);
                datos.seterarParametros("@IdArtista", NuevoDisco.artista.Id);
                datos.ejecutarAccion();
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

        public void ModificarDisco(Disco ModificarDisco, string valor)
        {
            establecerConexion();
            try
            {
                datos.setearConsulta("update discos set titulo = @titulo,FechaLanzamiento = @fechaLanzamiento, CantidadCanciones = @cantCanciones, UrlImagenTapa = @url, idEstilo = @IdEstilo, IdTipoEdicion = @IdEdicion, IdArtista = @IdArtista where id = @iD");
                datos.seterarParametros("@titulo", ModificarDisco.Titulo);
                datos.seterarParametros("@fechaLanzamiento", ModificarDisco.FechaLanzamiento);
                datos.seterarParametros("@cantCanciones", ModificarDisco.CantCanciones);
                datos.seterarParametros("@url", ModificarDisco.UrlImagenTapa);
                datos.seterarParametros("@IdEstilo", ModificarDisco.estilo.id);
                datos.seterarParametros("@IdEdicion", ModificarDisco.Edicion.id);
                datos.seterarParametros("@IdArtista", ModificarDisco.artista.Id);
                datos.seterarParametros("@Id", ModificarDisco.id);

                datos.ejecutarAccion();
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

        public void EliminarDisco(string valor)
        {
            establecerConexion();
            try
            {
                datos.setearConsulta("Delete Discos where id = " + int.Parse(valor));
                datos.ejecutarAccion();
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

        public void EliminarLogico (string valor)
        {
            establecerConexion();
            try
            {
                datos.setearConsulta("Update discos set Activo = 0 where id=@id");
                datos.seterarParametros("@id", valor);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Disco> filtrar(string campo, string criterio, string filtro)
        {
            List<Disco> lista = new List<Disco>();
            establecerConexion();
            string valor;
            try
            {
                switch (campo)
                {
                    case "Titulo":
                        valor = "titulo";
                        break;
                    case "Artista":
                        valor = "a.nombre";
                        break;
                    case "Estilo":
                        valor = "e.descripcion";
                        break;
                    case "Tipo Edicion":
                        valor = "t.descripcion";
                        break;

                    default:
                        valor = "cantidadcanciones";
                        break;
                }
                string consulta = "Select d.id, titulo Titulo, fechalanzamiento as \"Fecha lanzamiento\", cantidadcanciones \"Cantidad Canciones\", urlimagentapa, e.Descripcion Estilo, t.Descripcion \"Tipo Edicion\", a.nombre, d.IdEstilo, d.IdTipoEdicion, d.IdArtista from discos d inner join estilos e ON d.IdEstilo = e.Id inner join TIPOSEDICION t on d.IdTipoEdicion = t.Id inner join ARTISTAS a ON d.IdArtista = a.Id where d.activo = 1 and ";
                if (campo == "Cant. Canciones")
                {
                    switch (criterio)
                    {
                        case "Mayor a:":
                            consulta = consulta + valor + " > " + filtro;
                        break;

                        case"Menor a:":
                            consulta = consulta + valor +" < " + filtro;
                            break;
                        case "Igual a:":
                            consulta = consulta + valor + " = " + filtro;
                            break;

                        default:
                            break;
                    }

                }
                else 
                {
                    switch (criterio)
                    {
                        case "Empieza:":
                            consulta = consulta + valor + " like '" + filtro+ "%'";
                            break;

                        case "Termina:":
                            consulta = consulta + valor + " like '%" + filtro + "'";
                            break;
                        case "Contiene:":
                            consulta = consulta + valor + " like '%" + filtro + "%'";
                            break;

                        default:
                            break;
                    }

                }

                datos.setearConsulta(consulta);
                datos.ejecutarLector();
                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["Fecha Lanzamiento"];
                    aux.CantCanciones = (int)datos.Lector["Cantidad Canciones"];
                    if (!(datos.Lector["urlimagentapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["urlimagentapa"];
                    aux.estilo = new Estilo();
                    aux.estilo.id = (int)datos.Lector["IdEstilo"];
                    aux.estilo.descripcion = (string)datos.Lector["Estilo"];
                    aux.Edicion = new TipoEdicion();
                    aux.Edicion.id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Edicion.descripcion = (string)datos.Lector["Tipo Edicion"];
                    aux.id = (int)datos.Lector["id"];
                    aux.artista = new Artista();
                    aux.artista.Id = (int)datos.Lector["idArtista"];
                    aux.artista.Nombre = (string)datos.Lector["Nombre"];
                    lista.Add(aux);
                }
                return lista ;

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

        private void ejecutarConsulta(string cadena)
        {
            List<Disco> lista = new List<Disco>();
            establecerConexion();
            
        }

    }

    
}
