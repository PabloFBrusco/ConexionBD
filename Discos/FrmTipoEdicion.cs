using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Discos
{
    public partial class FrmTipoEdicion : Form
    {
        private List<TipoEdicion> listaEdicion;
        EdicionNegocio Negocio = new EdicionNegocio();
        string boton;
        public FrmTipoEdicion()
        {
            InitializeComponent();
        }

        private void FrmTipoEdicion_Load(object sender, EventArgs e)
        {
            LlenarGrilla();
            EstadoCampos(false);
        }
        private void LlenarGrilla()
        {
            listaEdicion = Negocio.listar();
            DgvEdicion.DataSource = listaEdicion;
            DgvEdicion.Columns["Id"].Visible = false;
            DgvEdicion.Columns["Descripcion"].HeaderText = "Descripción";

        }

        private void EstadoCampos(Boolean Estado)
        {
            GpbEdicion.Enabled = Estado;
            BtnAgregar.Enabled = !Estado;
            BtnModificar.Enabled = !Estado;
            BtnEliminar.Enabled = !Estado;
            DgvEdicion.Enabled = !Estado;
        }

        private void DgvEdicion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtEdicion.Text = Convert.ToString(DgvEdicion.CurrentRow.Cells["Descripcion"].Value);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            TipoEdicion NuevoEdicion = new TipoEdicion();
            EdicionNegocio negocio = new EdicionNegocio();
            string estiloActu;
            try
            {
                if (boton == "Agregar")
                {
                    NuevoEdicion.descripcion = TxtEdicion.Text;
                    negocio.AgregarEdicion(NuevoEdicion);
                    MessageBox.Show("Se cargo el Tipo de Edición correctamente");
                }
                else
                {
                    estiloActu = TxtEdicion.Text;
                    negocio.ModificarEdicion(estiloActu, Convert.ToString(DgvEdicion.CurrentRow.Cells["Id"].Value));
                    MessageBox.Show("Se modificó el Tipo de Edicion correctamente");
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
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            EstadoCampos(false);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtEdicion.Text = "";
            TxtEdicion.Focus();
            boton = "Agregar";

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtEdicion.Focus();
            boton = "Modificar";

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EstiloNegocio negocio = new EstiloNegocio();
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea Eliminar el Tipo de Edición? " + TxtEdicion.Text, "Eliminar Tipo Edición", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    negocio.EliminarEstilo(Convert.ToString(DgvEdicion.CurrentRow.Cells["Id"].Value));
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
    }
}
