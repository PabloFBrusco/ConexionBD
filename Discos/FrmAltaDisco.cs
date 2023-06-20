using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Discos
{
    public partial class FrmAltaDisco : Form
    {
        private Disco ndisco = null;
        public FrmAltaDisco()
        {
            InitializeComponent();
            Text = "Nuevo Disco";
        }

        public FrmAltaDisco (Disco NDisco)
        {
            InitializeComponent();
            ndisco = NDisco;
            Text = "Modificar Disco";
        }

        private void CmdCancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloNegocio estilo = new EstiloNegocio();
            EdicionNegocio edicion = new EdicionNegocio();
            ArtistaNegocio artista = new ArtistaNegocio();
            CboEstilo.DataSource = estilo.listar();
            CboEstilo.ValueMember = "id";
            CboEstilo.DisplayMember = "Descripcion";
            CboEdicion.DataSource = edicion.listar();
            CboEdicion.ValueMember = "id";
            CboEdicion.DisplayMember = "Descripcion";
            CboArtista.DataSource = artista.listar();
            CboArtista.ValueMember = "Id";
            CboArtista.DisplayMember = "Nombre";
            if (ndisco != null)
            {
                TxtCantCanciones.Text = ndisco.CantCanciones.ToString();
                TxtTitulo.Text = ndisco.Titulo;
                TxtUrl.Text = ndisco.UrlImagenTapa;
                DtpFechaLanzamiento.Value = DateTime.Parse(ndisco.FechaLanzamiento.ToString());
                CargarImagen(TxtUrl.Text);
                CboEstilo.SelectedValue = ndisco.estilo.id;
                CboEdicion.SelectedValue = ndisco.Edicion.id;
                CboArtista.SelectedValue = ndisco.artista.Id;
            }

        }

        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (ndisco == null) ndisco = new Disco();
                ndisco.Titulo = TxtTitulo.Text;
                ndisco.CantCanciones = int.Parse(TxtCantCanciones.Text);
                ndisco.UrlImagenTapa = TxtUrl.Text;
                ndisco.FechaLanzamiento = DateTime.Parse(DtpFechaLanzamiento.Value.ToString());
                ndisco.estilo = (Estilo)CboEstilo.SelectedItem;
                ndisco.Edicion = (TipoEdicion)CboEdicion.SelectedItem;
                ndisco.artista = (Artista)CboArtista.SelectedItem;

                if (ndisco.id != 0)
                {
                    negocio.ModificarDisco(ndisco, ndisco.id.ToString());
                    MessageBox.Show("Se modificó el disco correctamente");
                    
                }

                else
                {
                    negocio.AgregarDisco(ndisco);
                    MessageBox.Show("Se cargo el disco correctamente");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }
        private void CargarImagen(string imagen)
        {
            try
            {
                PtBFoto.Load(imagen);
            }
            catch (Exception)
            {

                PtBFoto.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg?w=740");

            }
        }

        private void TxtUrl_Leave(object sender, EventArgs e)
        {
            CargarImagen(TxtUrl.Text);
        }

        private void BtnAgregarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog imagen = new OpenFileDialog();
            imagen.Filter = "jpg|*.jpg|png|*.png";
            imagen.ShowDialog();
            if (imagen.ShowDialog() == DialogResult.OK)
            {
                TxtUrl.Text = imagen.FileName;
                CargarImagen(TxtUrl.Text);

                File.Copy(imagen.FileName, ConfigurationManager.AppSettings["images"]+imagen.SafeFileName);

            }


        }
    }
}
