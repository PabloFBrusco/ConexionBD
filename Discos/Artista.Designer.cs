namespace Discos
{
    partial class FrmArtista
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
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GpbArtista = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvArtista = new System.Windows.Forms.DataGridView();
            this.GpbArtista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtista)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(285, 433);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 28);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(142, 433);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 28);
            this.BtnModificar.TabIndex = 8;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(12, 433);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 28);
            this.BtnAgregar.TabIndex = 7;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // GpbArtista
            // 
            this.GpbArtista.Controls.Add(this.BtnCancelar);
            this.GpbArtista.Controls.Add(this.BtnAceptar);
            this.GpbArtista.Controls.Add(this.TxtNombre);
            this.GpbArtista.Controls.Add(this.label1);
            this.GpbArtista.Location = new System.Drawing.Point(11, 339);
            this.GpbArtista.Name = "GpbArtista";
            this.GpbArtista.Size = new System.Drawing.Size(349, 88);
            this.GpbArtista.TabIndex = 6;
            this.GpbArtista.TabStop = false;
            this.GpbArtista.Text = "Artista:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(261, 54);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(82, 19);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(184, 53);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(71, 21);
            this.BtnAceptar.TabIndex = 2;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(82, 26);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(261, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // DgvArtista
            // 
            this.DgvArtista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvArtista.Location = new System.Drawing.Point(12, 12);
            this.DgvArtista.Name = "DgvArtista";
            this.DgvArtista.Size = new System.Drawing.Size(349, 314);
            this.DgvArtista.TabIndex = 5;
            this.DgvArtista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvArtista_CellClick);
            // 
            // FrmArtista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 474);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GpbArtista);
            this.Controls.Add(this.DgvArtista);
            this.Name = "FrmArtista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artista";
            this.Load += new System.EventHandler(this.FrmArtista_Load);
            this.GpbArtista.ResumeLayout(false);
            this.GpbArtista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvArtista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.GroupBox GpbArtista;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvArtista;
    }
}