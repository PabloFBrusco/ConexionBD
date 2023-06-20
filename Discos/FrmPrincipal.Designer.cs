namespace Discos
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DgvDiscos = new System.Windows.Forms.DataGridView();
            this.ptbTapa = new System.Windows.Forms.PictureBox();
            this.GpbDatos = new System.Windows.Forms.GroupBox();
            this.CmbArtista = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmdCancelar = new System.Windows.Forms.Button();
            this.CmdAceptar = new System.Windows.Forms.Button();
            this.CmbEdicion = new System.Windows.Forms.ComboBox();
            this.CmbEstilo = new System.Windows.Forms.ComboBox();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.NumCanciones = new System.Windows.Forms.NumericUpDown();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.CmdModificarNuevo = new System.Windows.Forms.Button();
            this.cmdAgregarNuevo = new System.Windows.Forms.Button();
            this.BtnEliminarLogico = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtFiltroRapido = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CboCampo = new System.Windows.Forms.ComboBox();
            this.CboCriterio = new System.Windows.Forms.ComboBox();
            this.TxtParametro = new System.Windows.Forms.TextBox();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTapa)).BeginInit();
            this.GpbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCanciones)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvDiscos
            // 
            this.DgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgvDiscos.Location = new System.Drawing.Point(15, 48);
            this.DgvDiscos.MultiSelect = false;
            this.DgvDiscos.Name = "DgvDiscos";
            this.DgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvDiscos.Size = new System.Drawing.Size(662, 245);
            this.DgvDiscos.TabIndex = 0;
            this.DgvDiscos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDiscos_CellClick);
            this.DgvDiscos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDiscos_CellContentClick);
            this.DgvDiscos.SelectionChanged += new System.EventHandler(this.DgvDiscos_SelectionChanged);
            // 
            // ptbTapa
            // 
            this.ptbTapa.Location = new System.Drawing.Point(683, 48);
            this.ptbTapa.Name = "ptbTapa";
            this.ptbTapa.Size = new System.Drawing.Size(294, 242);
            this.ptbTapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbTapa.TabIndex = 1;
            this.ptbTapa.TabStop = false;
            // 
            // GpbDatos
            // 
            this.GpbDatos.Controls.Add(this.CmbArtista);
            this.GpbDatos.Controls.Add(this.label7);
            this.GpbDatos.Controls.Add(this.CmdCancelar);
            this.GpbDatos.Controls.Add(this.CmdAceptar);
            this.GpbDatos.Controls.Add(this.CmbEdicion);
            this.GpbDatos.Controls.Add(this.CmbEstilo);
            this.GpbDatos.Controls.Add(this.TxtFoto);
            this.GpbDatos.Controls.Add(this.DtpFecha);
            this.GpbDatos.Controls.Add(this.NumCanciones);
            this.GpbDatos.Controls.Add(this.TxtTitulo);
            this.GpbDatos.Controls.Add(this.label6);
            this.GpbDatos.Controls.Add(this.label5);
            this.GpbDatos.Controls.Add(this.label4);
            this.GpbDatos.Controls.Add(this.label3);
            this.GpbDatos.Controls.Add(this.label2);
            this.GpbDatos.Controls.Add(this.label1);
            this.GpbDatos.Location = new System.Drawing.Point(16, 297);
            this.GpbDatos.Name = "GpbDatos";
            this.GpbDatos.Size = new System.Drawing.Size(581, 202);
            this.GpbDatos.TabIndex = 2;
            this.GpbDatos.TabStop = false;
            this.GpbDatos.Text = "Discos";
            // 
            // CmbArtista
            // 
            this.CmbArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbArtista.FormattingEnabled = true;
            this.CmbArtista.Location = new System.Drawing.Point(146, 168);
            this.CmbArtista.Name = "CmbArtista";
            this.CmbArtista.Size = new System.Drawing.Size(203, 21);
            this.CmbArtista.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Artista:";
            // 
            // CmdCancelar
            // 
            this.CmdCancelar.Location = new System.Drawing.Point(385, 115);
            this.CmdCancelar.Name = "CmdCancelar";
            this.CmdCancelar.Size = new System.Drawing.Size(177, 46);
            this.CmdCancelar.TabIndex = 13;
            this.CmdCancelar.Text = "Cancelar";
            this.CmdCancelar.UseVisualStyleBackColor = true;
            this.CmdCancelar.Click += new System.EventHandler(this.CmdCancelar_Click);
            // 
            // CmdAceptar
            // 
            this.CmdAceptar.Location = new System.Drawing.Point(385, 23);
            this.CmdAceptar.Name = "CmdAceptar";
            this.CmdAceptar.Size = new System.Drawing.Size(178, 43);
            this.CmdAceptar.TabIndex = 12;
            this.CmdAceptar.Text = "Aceptar";
            this.CmdAceptar.UseVisualStyleBackColor = true;
            this.CmdAceptar.Click += new System.EventHandler(this.CmdAceptar_Click);
            // 
            // CmbEdicion
            // 
            this.CmbEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEdicion.FormattingEnabled = true;
            this.CmbEdicion.Location = new System.Drawing.Point(146, 141);
            this.CmbEdicion.Name = "CmbEdicion";
            this.CmbEdicion.Size = new System.Drawing.Size(203, 21);
            this.CmbEdicion.TabIndex = 11;
            // 
            // CmbEstilo
            // 
            this.CmbEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbEstilo.FormattingEnabled = true;
            this.CmbEstilo.Location = new System.Drawing.Point(146, 116);
            this.CmbEstilo.Name = "CmbEstilo";
            this.CmbEstilo.Size = new System.Drawing.Size(203, 21);
            this.CmbEstilo.TabIndex = 10;
            // 
            // TxtFoto
            // 
            this.TxtFoto.Location = new System.Drawing.Point(146, 91);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(203, 20);
            this.TxtFoto.TabIndex = 9;
            this.TxtFoto.Leave += new System.EventHandler(this.TxtFoto_Leave);
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(146, 66);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(203, 20);
            this.DtpFecha.TabIndex = 8;
            // 
            // NumCanciones
            // 
            this.NumCanciones.Location = new System.Drawing.Point(146, 41);
            this.NumCanciones.Name = "NumCanciones";
            this.NumCanciones.Size = new System.Drawing.Size(203, 20);
            this.NumCanciones.TabIndex = 7;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(146, 16);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(203, 20);
            this.TxtTitulo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estilo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Edición:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foto de Tapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Lanzamiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Canciones:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo: ";
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.Location = new System.Drawing.Point(620, 308);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(219, 29);
            this.CmdAgregar.TabIndex = 3;
            this.CmdAgregar.Text = "Agregar";
            this.CmdAgregar.UseVisualStyleBackColor = true;
            this.CmdAgregar.Click += new System.EventHandler(this.CmdAgregar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(620, 361);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(219, 29);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(620, 421);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(219, 29);
            this.cmdEliminar.TabIndex = 5;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // CmdModificarNuevo
            // 
            this.CmdModificarNuevo.Location = new System.Drawing.Point(845, 361);
            this.CmdModificarNuevo.Name = "CmdModificarNuevo";
            this.CmdModificarNuevo.Size = new System.Drawing.Size(132, 29);
            this.CmdModificarNuevo.TabIndex = 7;
            this.CmdModificarNuevo.Text = "Modificar";
            this.CmdModificarNuevo.UseVisualStyleBackColor = true;
            this.CmdModificarNuevo.Click += new System.EventHandler(this.CmdModificarNuevo_Click);
            // 
            // cmdAgregarNuevo
            // 
            this.cmdAgregarNuevo.Location = new System.Drawing.Point(845, 308);
            this.cmdAgregarNuevo.Name = "cmdAgregarNuevo";
            this.cmdAgregarNuevo.Size = new System.Drawing.Size(132, 29);
            this.cmdAgregarNuevo.TabIndex = 6;
            this.cmdAgregarNuevo.Text = "Agregar";
            this.cmdAgregarNuevo.UseVisualStyleBackColor = true;
            this.cmdAgregarNuevo.Click += new System.EventHandler(this.cmdAgregarNuevo_Click);
            // 
            // BtnEliminarLogico
            // 
            this.BtnEliminarLogico.Location = new System.Drawing.Point(625, 459);
            this.BtnEliminarLogico.Name = "BtnEliminarLogico";
            this.BtnEliminarLogico.Size = new System.Drawing.Size(213, 26);
            this.BtnEliminarLogico.TabIndex = 8;
            this.BtnEliminarLogico.Text = "Eliminar logico";
            this.BtnEliminarLogico.UseVisualStyleBackColor = true;
            this.BtnEliminarLogico.Click += new System.EventHandler(this.BtnEliminarLogico_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Filtro Rápido:";
            // 
            // TxtFiltroRapido
            // 
            this.TxtFiltroRapido.Location = new System.Drawing.Point(95, 18);
            this.TxtFiltroRapido.Name = "TxtFiltroRapido";
            this.TxtFiltroRapido.Size = new System.Drawing.Size(172, 20);
            this.TxtFiltroRapido.TabIndex = 11;
            this.TxtFiltroRapido.TextChanged += new System.EventHandler(this.TxtFiltroRapido_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(273, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Campo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Criterio:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(617, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Parámetro:";
            // 
            // CboCampo
            // 
            this.CboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCampo.FormattingEnabled = true;
            this.CboCampo.Location = new System.Drawing.Point(318, 17);
            this.CboCampo.Name = "CboCampo";
            this.CboCampo.Size = new System.Drawing.Size(121, 21);
            this.CboCampo.TabIndex = 15;
            this.CboCampo.SelectedIndexChanged += new System.EventHandler(this.CboCampo_SelectedIndexChanged);
            // 
            // CboCriterio
            // 
            this.CboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCriterio.FormattingEnabled = true;
            this.CboCriterio.Location = new System.Drawing.Point(489, 16);
            this.CboCriterio.Name = "CboCriterio";
            this.CboCriterio.Size = new System.Drawing.Size(121, 21);
            this.CboCriterio.TabIndex = 16;
            // 
            // TxtParametro
            // 
            this.TxtParametro.Location = new System.Drawing.Point(678, 18);
            this.TxtParametro.Name = "TxtParametro";
            this.TxtParametro.Size = new System.Drawing.Size(147, 20);
            this.TxtParametro.TabIndex = 17;
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(839, 16);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(106, 21);
            this.BtnFiltrar.TabIndex = 18;
            this.BtnFiltrar.Text = "Buscar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 509);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.TxtParametro);
            this.Controls.Add(this.CboCriterio);
            this.Controls.Add(this.CboCampo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtFiltroRapido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnEliminarLogico);
            this.Controls.Add(this.CmdModificarNuevo);
            this.Controls.Add(this.cmdAgregarNuevo);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.CmdAgregar);
            this.Controls.Add(this.GpbDatos);
            this.Controls.Add(this.ptbTapa);
            this.Controls.Add(this.DgvDiscos);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discoteca";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTapa)).EndInit();
            this.GpbDatos.ResumeLayout(false);
            this.GpbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumCanciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvDiscos;
        private System.Windows.Forms.PictureBox ptbTapa;
        private System.Windows.Forms.GroupBox GpbDatos;
        private System.Windows.Forms.ComboBox CmbEdicion;
        private System.Windows.Forms.ComboBox CmbEstilo;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.NumericUpDown NumCanciones;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdCancelar;
        private System.Windows.Forms.Button CmdAceptar;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.ComboBox CmbArtista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CmdModificarNuevo;
        private System.Windows.Forms.Button cmdAgregarNuevo;
        private System.Windows.Forms.Button BtnEliminarLogico;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtFiltroRapido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboCampo;
        private System.Windows.Forms.ComboBox CboCriterio;
        private System.Windows.Forms.TextBox TxtParametro;
        private System.Windows.Forms.Button BtnFiltrar;
    }
}

