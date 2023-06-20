using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discos
{
    public partial class FrmArtista : Form
    {
        private List<Artista> listaArtistas;
        ArtistaNegocio Negocio = new ArtistaNegocio();
        string boton;
        public FrmArtista()
        {
            InitializeComponent();
        }

        private void FrmArtista_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
            EstadoCampos(false);
        }
        private void LlenarGrilla()
        {
            listaArtistas = Negocio.listar();
            DgvArtista.DataSource = listaArtistas;
            DgvArtista.Columns["Id"].Visible = false;
            DgvArtista.Columns["Nombre"].HeaderText = "Nombre";

        }

        private void EstadoCampos(Boolean Estado)
        {
            GpbArtista.Enabled = Estado;
            BtnAgregar.Enabled = !Estado;
            BtnModificar.Enabled = !Estado;
            BtnEliminar.Enabled = !Estado;
            DgvArtista.Enabled = !Estado;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtNombre.Text = "";
            TxtNombre.Focus();
            boton = "Agregar";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            EstadoCampos(false);
        }

        private void DgvArtista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtNombre.Text = Convert.ToString(DgvArtista.CurrentRow.Cells["Nombre"].Value);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtNombre.Focus();
            boton = "Modificar";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            ArtistaNegocio negocio = new ArtistaNegocio();
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea Eliminar el Artista? " + TxtNombre.Text, "Eliminar Artista", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    negocio.EliminarArtista(Convert.ToString(DgvArtista.CurrentRow.Cells["Id"].Value));
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                EstadoCampos(false);
                LlenarGrilla();
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Artista NuevoArtista = new Artista();
            ArtistaNegocio negocio = new ArtistaNegocio();
            string ArtistaActu;
            try
            {
                if (boton == "Agregar")
                {
                    NuevoArtista.Nombre = TxtNombre.Text;
                    negocio.AgregarArtista(NuevoArtista);
                    MessageBox.Show("Se cargo el Artista correctamente");
                }
                else
                {
                    ArtistaActu = TxtNombre.Text;
                    negocio.ModificarArtista(ArtistaActu, Convert.ToString(DgvArtista.CurrentRow.Cells["Id"].Value));
                    MessageBox.Show("Se modificó el Artista correctamente");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                EstadoCampos(false);
                LlenarGrilla();

            }
        }
    }
}
