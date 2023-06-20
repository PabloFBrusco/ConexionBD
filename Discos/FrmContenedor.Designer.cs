namespace Discos
{
    partial class FrmContenedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.discosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verDiscosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstilosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verTipoEdicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verArtistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.parametrosConexiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // discosToolStripMenuItem
            // 
            this.discosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verDiscosToolStripMenuItem,
            this.verEstilosToolStripMenuItem,
            this.verTipoEdicionToolStripMenuItem,
            this.verArtistasToolStripMenuItem,
            this.toolStripMenuItem1,
            this.parametrosConexiónToolStripMenuItem,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.discosToolStripMenuItem.Name = "discosToolStripMenuItem";
            this.discosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.discosToolStripMenuItem.Text = "Discos";
            // 
            // verDiscosToolStripMenuItem
            // 
            this.verDiscosToolStripMenuItem.Name = "verDiscosToolStripMenuItem";
            this.verDiscosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verDiscosToolStripMenuItem.Text = "Ver Discos";
            this.verDiscosToolStripMenuItem.Click += new System.EventHandler(this.verDiscosToolStripMenuItem_Click);
            // 
            // verEstilosToolStripMenuItem
            // 
            this.verEstilosToolStripMenuItem.Name = "verEstilosToolStripMenuItem";
            this.verEstilosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verEstilosToolStripMenuItem.Text = "Ver Estilos";
            this.verEstilosToolStripMenuItem.Click += new System.EventHandler(this.verEstilosToolStripMenuItem_Click);
            // 
            // verTipoEdicionToolStripMenuItem
            // 
            this.verTipoEdicionToolStripMenuItem.Name = "verTipoEdicionToolStripMenuItem";
            this.verTipoEdicionToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verTipoEdicionToolStripMenuItem.Text = "Ver Tipo Edicion";
            this.verTipoEdicionToolStripMenuItem.Click += new System.EventHandler(this.verTipoEdicionToolStripMenuItem_Click);
            // 
            // verArtistasToolStripMenuItem
            // 
            this.verArtistasToolStripMenuItem.Name = "verArtistasToolStripMenuItem";
            this.verArtistasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.verArtistasToolStripMenuItem.Text = "Ver Artistas";
            this.verArtistasToolStripMenuItem.Click += new System.EventHandler(this.verArtistasToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // parametrosConexiónToolStripMenuItem
            // 
            this.parametrosConexiónToolStripMenuItem.Name = "parametrosConexiónToolStripMenuItem";
            this.parametrosConexiónToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.parametrosConexiónToolStripMenuItem.Text = "Parametros Conexión";
            this.parametrosConexiónToolStripMenuItem.Click += new System.EventHandler(this.parametrosConexiónToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // FrmContenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmContenedor";
            this.Text = "Discoteca Pablo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmContenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem discosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verDiscosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstilosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verTipoEdicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verArtistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrosConexiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    }
}