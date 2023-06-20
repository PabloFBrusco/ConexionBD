using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Disco
    {
        [DisplayName ("Número")]
        public string Titulo { get; set; }

        [DisplayName("Cant. Canciones")]
        public int CantCanciones { get; set; }
        [DisplayName("Fecha Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        public string  UrlImagenTapa { get; set; }
        [DisplayName("Estilo")]
        public Estilo estilo { get; set; }
        public int id { get; set; }

        public TipoEdicion Edicion { get; set; }

        [DisplayName("Artista")]
        public Artista artista { get; set; }
    }
}
