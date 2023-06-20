using Negocio;
using Dominio;
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
    public partial class FrmEstilo : Form
    {
        private List<Estilo> listaEstilos;
        EstiloNegocio Negocio = new EstiloNegocio();
        string boton;
        public FrmEstilo()
        {
            InitializeComponent();
        }

        private void FrmEstilo_Load(object sender, EventArgs e)
        {

            LlenarGrilla();
            EstadoCampos(false);
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Estilo NuevoEstilo = new Estilo();
            EstiloNegocio negocio = new EstiloNegocio();
            string estiloActu;
            try
            {   
                if (boton == "Agregar")
                {
                    NuevoEstilo.descripcion = TxtEstilo.Text;
                    negocio.AgregarEstilo(NuevoEstilo);
                    MessageBox.Show("Se cargo el estilo correctamente");
                }
                else
                {
                    estiloActu = TxtEstilo.Text;
                    negocio.ModificarEstilo(estiloActu, Convert.ToString(DgvEstilo.CurrentRow.Cells["Id"].Value));
                    MessageBox.Show("Se modificó el estilo correctamente");
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
        private void LlenarGrilla()
        {
            listaEstilos = Negocio.listar();
            DgvEstilo.DataSource = listaEstilos;
            DgvEstilo.Columns["Id"].Visible = false;
            DgvEstilo.Columns["Descripcion"].HeaderText = "Descripción";
            
        }

        private void EstadoCampos (Boolean Estado)
        {
            GpbEstilo.Enabled = Estado;
            BtnAgregar.Enabled = !Estado;
            BtnModificar.Enabled = !Estado;
            BtnEliminar.Enabled = !Estado;
            DgvEstilo.Enabled = !Estado;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtEstilo.Text = "";
            TxtEstilo.Focus();
            boton = "Agregar";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            EstadoCampos(false);

        }

        private void DgvEstilo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtEstilo.Text = Convert.ToString(DgvEstilo.CurrentRow.Cells["Descripcion"].Value);
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            EstadoCampos(true);
            TxtEstilo.Focus();
            boton = "Modificar";
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            EstiloNegocio negocio = new EstiloNegocio();
            try
            {
                DialogResult result = MessageBox.Show("Seguro que desea Eliminar el estilo? " + TxtEstilo.Text, "Eliminar Estilo", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    negocio.EliminarEstilo(Convert.ToString(DgvEstilo.CurrentRow.Cells["Id"].Value));
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
