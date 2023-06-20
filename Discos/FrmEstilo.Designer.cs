namespace Discos
{
    partial class FrmEstilo
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
            this.DgvEstilo = new System.Windows.Forms.DataGridView();
            this.GpbEstilo = new System.Windows.Forms.GroupBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.TxtEstilo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstilo)).BeginInit();
            this.GpbEstilo.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvEstilo
            // 
            this.DgvEstilo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEstilo.Location = new System.Drawing.Point(17, 16);
            this.DgvEstilo.Name = "DgvEstilo";
            this.DgvEstilo.Size = new System.Drawing.Size(349, 314);
            this.DgvEstilo.TabIndex = 0;
            this.DgvEstilo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEstilo_CellClick);
            // 
            // GpbEstilo
            // 
            this.GpbEstilo.Controls.Add(this.BtnCancelar);
            this.GpbEstilo.Controls.Add(this.BtnAceptar);
            this.GpbEstilo.Controls.Add(this.TxtEstilo);
            this.GpbEstilo.Controls.Add(this.label1);
            this.GpbEstilo.Location = new System.Drawing.Point(16, 343);
            this.GpbEstilo.Name = "GpbEstilo";
            this.GpbEstilo.Size = new System.Drawing.Size(349, 88);
            this.GpbEstilo.TabIndex = 1;
            this.GpbEstilo.TabStop = false;
            this.GpbEstilo.Text = "Estilo:";
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
            // TxtEstilo
            // 
            this.TxtEstilo.Location = new System.Drawing.Point(82, 26);
            this.TxtEstilo.Name = "TxtEstilo";
            this.TxtEstilo.Size = new System.Drawing.Size(261, 20);
            this.TxtEstilo.TabIndex = 1;
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
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(17, 437);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 28);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(147, 437);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 28);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(290, 437);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 28);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // FrmEstilo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 474);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.GpbEstilo);
            this.Controls.Add(this.DgvEstilo);
            this.Name = "FrmEstilo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estilos";
            this.Load += new System.EventHandler(this.FrmEstilo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEstilo)).EndInit();
            this.GpbEstilo.ResumeLayout(false);
            this.GpbEstilo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvEstilo;
        private System.Windows.Forms.GroupBox GpbEstilo;
        private System.Windows.Forms.TextBox TxtEstilo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
    }
}