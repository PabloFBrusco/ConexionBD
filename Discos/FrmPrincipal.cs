using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Discos
{
    public partial class FrmPrincipal : Form
    {
        private List<Disco> listaDiscos;
        DiscoNegocio Negocio = new DiscoNegocio();
        string boton;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void formatearGrilla()
        {
            CargarImagen(listaDiscos[0].UrlImagenTapa);
            DgvDiscos.Columns["urlimagentapa"].Visible = false;
            DgvDiscos.Columns["id"].Visible = false;
            DgvDiscos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void llenarGrilla()
        {
            try
            {
                listaDiscos = Negocio.listar();
                DgvDiscos.DataSource = listaDiscos;
                formatearGrilla();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            EstiloNegocio estilo = new EstiloNegocio();
            EdicionNegocio edicion = new EdicionNegocio();
            ArtistaNegocio artista = new ArtistaNegocio();
            
            try
            {
                
                llenarGrilla();
                CmbEstilo.DataSource = estilo.listar();
                CmbEdicion.DataSource = edicion.listar();
                CmbArtista.DataSource = artista.listar();
                CboCampo.Items.Clear();
                CboCampo.Items.Add("Titulo");
                CboCampo.Items.Add("Artista");
                CboCampo.Items.Add("Estilo");
                CboCampo.Items.Add("Cant. Canciones");
                CboCampo.Items.Add("Tipo Edicion");
                EstadoCampos(false);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void DgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)DgvDiscos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagenTapa);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                ptbTapa.Load(imagen);
            }
            catch (Exception)
            {

                ptbTapa.Load("https://img.freepik.com/vector-premium/icono-marco-fotos-foto-vacia-blanco-vector-sobre-fondo-transparente-aislado-eps-10_399089-1290.jpg?w=740");

            }
        }

        private void CmdAceptar_Click(object sender, EventArgs e)
        {
            Disco NuevoDisco = new Disco();
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                if (boton == "Agregar")
                {
                    NuevoDisco.Titulo = TxtTitulo.Text;
                    NuevoDisco.CantCanciones = int.Parse(NumCanciones.Value.ToString());
                    NuevoDisco.UrlImagenTapa = TxtFoto.Text;
                    NuevoDisco.FechaLanzamiento = DateTime.Parse(DtpFecha.Value.ToString());
                    NuevoDisco.estilo = (Estilo)CmbEstilo.SelectedItem;
                    NuevoDisco.Edicion = (TipoEdicion)CmbEdicion.SelectedItem;
                    NuevoDisco.artista = (Artista)CmbArtista.SelectedItem;
                    negocio.AgregarDisco(NuevoDisco);
                    MessageBox.Show("Se cargo el disco correctamente");
                }
                else
                {
                    NuevoDisco.Titulo = TxtTitulo.Text;
                    NuevoDisco.CantCanciones = int.Parse(NumCanciones.Value.ToString());
                    NuevoDisco.UrlImagenTapa = TxtFoto.Text;
                    NuevoDisco.FechaLanzamiento = DateTime.Parse(DtpFecha.Value.ToString());
                    NuevoDisco.estilo = (Estilo)CmbEstilo.SelectedItem;
                    NuevoDisco.Edicion = (TipoEdicion)CmbEdicion.SelectedItem;
                    NuevoDisco.artista = (Artista)CmbArtista.SelectedItem;
                    negocio.ModificarDisco(NuevoDisco, Convert.ToString(DgvDiscos.CurrentRow.Cells["Id"].Value));
                    MessageBox.Show("Se modificó el disco correctamente");
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                EstadoCampos(false);
                llenarGrilla();

            }

        }
        private void EstadoCampos(Boolean Estado)
        {
            GpbDatos.Enabled = Estado;
            CmdAgregar.Enabled = !Estado;
            cmdModificar.Enabled = !Estado;
            cmdEliminar.Enabled = !Estado;
            DgvDiscos.Enabled = !Estado;
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtTitulo.Text = "";
            NumCanciones.Value = 0;
            TxtTitulo.Text = "";
            TxtFoto.Text = "";
            boton = "Agregar";
            DtpFecha.Value = DateTime.Now;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtTitulo.Focus();
            boton = "Modificar";
        }

        private void DgvDiscos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTitulo.Text = Convert.ToString(DgvDiscos.CurrentRow.Cells["Titulo"].Value);
            NumCanciones.Value = Convert.ToInt16(DgvDiscos.CurrentRow.Cells["CantCanciones"].Value);
            DtpFecha.Value = Convert.ToDateTime(DgvDiscos.CurrentRow.Cells["Fechalanzamiento"].Value);
            TxtFoto.Text = Convert.ToString(DgvDiscos.CurrentRow.Cells["urlimagentapa"].Value);
            CmbEstilo.Text = Convert.ToString(DgvDiscos.CurrentRow.Cells["estilo"].Value);
            CmbEdicion.Text = Convert.ToString(DgvDiscos.CurrentRow.Cells["edicion"].Value);
            CmbArtista.Text = Convert.ToString(DgvDiscos.CurrentRow.Cells["artista"].Value);
        }

        

        private void CmdCancelar_Click(object sender, EventArgs e)
        {
            EstadoCampos(false);
            llenarGrilla();
        }

        private void DgvDiscos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtFoto_Leave(object sender, EventArgs e)
        {
            CargarImagen(TxtFoto.Text);
        }

        private void cmdAgregarNuevo_Click(object sender, EventArgs e)
        {
            FrmAltaDisco FormularioNuevoDisco = new FrmAltaDisco();
            FormularioNuevoDisco.ShowDialog();
            llenarGrilla();
        }

        private void CmdModificarNuevo_Click(object sender, EventArgs e)
        {
            Disco Seleccionado;
            Seleccionado = (Disco)DgvDiscos.CurrentRow.DataBoundItem;
            FrmAltaDisco FormularioModificarDisco = new FrmAltaDisco(Seleccionado);
            FormularioModificarDisco.ShowDialog();
            llenarGrilla();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            EliminarD();
        }
        private void BtnEliminarLogico_Click(object sender, EventArgs e)
        {
            EliminarD(true);
        }

        private void EliminarD(bool logico = false)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea Eliminar el disco? " + TxtTitulo.Text, "Eliminar Disco", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    if (logico)
                        negocio.EliminarLogico(Convert.ToString(DgvDiscos.CurrentRow.Cells["Id"].Value));
                    else
                        negocio.EliminarDisco(Convert.ToString(DgvDiscos.CurrentRow.Cells["Id"].Value));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                EstadoCampos(false);
                llenarGrilla();
            }
        }
        private void filtrarLista()
        {
            List<Disco> ListaFiltrada;
            ListaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToLower().Contains(TxtFiltroRapido.Text.ToLower()) || x.artista.Nombre.ToLower().Contains(TxtFiltroRapido.Text.ToLower()) || x.estilo.descripcion.ToLower().Contains(TxtFiltroRapido.Text.ToLower()) || x.Edicion.descripcion.ToLower().Contains(TxtFiltroRapido.Text.ToLower()));
            DgvDiscos.DataSource = null;
            if (TxtFiltroRapido.Text == "")
                llenarGrilla();

            else
                DgvDiscos.DataSource = ListaFiltrada;
            formatearGrilla();
        }

        private void TxtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            filtrarLista();
        }

        private void CboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboCampo.Text == "Cant. Canciones")
            {
                CboCriterio.Items.Clear();
                CboCriterio.Items.Add("Mayor a:");
                CboCriterio.Items.Add("Menor a:");
                CboCriterio.Items.Add("Igual a:");
            }
            else
            {
                CboCriterio.Items.Clear();
                CboCriterio.Items.Add("Empieza:");
                CboCriterio.Items.Add("Termina:");
                CboCriterio.Items.Add("Contiene:");
            }
        }

        private void BtnFiltrar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();
            try
            {
                string campo = CboCampo.SelectedItem.ToString();
                string criterio = CboCriterio.SelectedItem.ToString();
                string filtro = TxtParametro.Text;
                DgvDiscos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

    }
}
