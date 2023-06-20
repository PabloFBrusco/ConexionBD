using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Discos
{
    public partial class FrmContenedor : Form
    {
        public FrmContenedor()
        {
            InitializeComponent();
        }

        private void verDiscosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmPrincipal))
                    return;
            }

            FrmPrincipal Formulario = new FrmPrincipal();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void verEstilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmEstilo))
                    return;
            }

            FrmEstilo Formulario = new FrmEstilo();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void verTipoEdicionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmTipoEdicion))
                    return;
            }

            FrmTipoEdicion Formulario = new FrmTipoEdicion();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void verArtistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmArtista))
                    return;
            }

            FrmArtista Formulario = new FrmArtista();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void parametrosConexiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FrmParametros))
                    return;
            }

            FrmParametros Formulario = new FrmParametros();
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void FrmContenedor_Load(object sender, EventArgs e)
        {
            //string servidor;
            //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //servidor = ConfigurationManager.AppSettings["server"];// config.AppSettings["server"].Value.ToString();
            //MessageBox.Show(servidor);
            //if (servidor == "")
            //{
            //    parametrosConexiónToolStripMenuItem_Click(sender, e);
            //}
        }
    }
}
