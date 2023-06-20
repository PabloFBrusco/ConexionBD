namespace Discos
{
    partial class FrmTipoEdicion
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
            this.GpbEdicion = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtEdicion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvEdicion = new System.Windows.Forms.DataGridView();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.GpbEdicion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEdicion)).BeginInit();
            this.SuspendLayout();
            // 
            // GpbEdicion
            // 
            this.GpbEdicion.Controls.Add(this.BtnCancelar);
            this.GpbEdicion.Controls.Add(this.BtnAceptar);
            this.GpbEdicion.Controls.Add(this.TxtEdicion);
            this.GpbEdicion.Controls.Add(this.label1);
            this.GpbEdicion.Location = new System.Drawing.Point(11, 339);
            this.GpbEdicion.Name = "GpbEdicion";
            this.GpbEdicion.Size = new System.Drawing.Size(349, 88);
            this.GpbEdicion.TabIndex = 6;
            this.GpbEdicion.TabStop = false;
            this.GpbEdicion.Text = "Tipo Edición:";
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
            // TxtEdicion
            // 
            this.TxtEdicion.Location = new System.Drawing.Point(82, 26);
            this.TxtEdicion.Name = "TxtEdicion";
            this.TxtEdicion.Size = new System.Drawing.Size(261, 20);
            this.TxtEdicion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            // 
            // DgvEdicion
            // 
            this.DgvEdicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEdicion.Location = new System.Drawing.Point(12, 12);
            this.DgvEdicion.Name = "DgvEdicion";
            this.DgvEdicion.Size = new System.Drawing.Size(349, 314);
            this.DgvEdicion.TabIndex = 5;
            this.DgvEdicion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEdicion_CellClick);
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
            // FrmTipoEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 472);
            this.Controls.Add(this.GpbEdicion);
            this.Controls.Add(this.DgvEdicion);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Name = "FrmTipoEdicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipoEdicion";
            this.Load += new System.EventHandler(this.FrmTipoEdicion_Load);
            this.GpbEdicion.ResumeLayout(false);
            this.GpbEdicion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEdicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbEdicion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtEdicion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvEdicion;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnAgregar;
    }
}