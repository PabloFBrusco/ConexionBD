namespace Discos
{
    partial class FrmAltaDisco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.TxtUrl = new System.Windows.Forms.TextBox();
            this.TxtCantCanciones = new System.Windows.Forms.TextBox();
            this.DtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.CboEstilo = new System.Windows.Forms.ComboBox();
            this.CboArtista = new System.Windows.Forms.ComboBox();
            this.CboEdicion = new System.Windows.Forms.ComboBox();
            this.PtBFoto = new System.Windows.Forms.PictureBox();
            this.CmdAceptar = new System.Windows.Forms.Button();
            this.CmdCancela = new System.Windows.Forms.Button();
            this.BtnAgregarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PtBFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Artista:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Edicion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Estilo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Url Imagen Tapa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fecha Lanzamiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cant. Canciones:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(132, 13);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(322, 20);
            this.TxtTitulo.TabIndex = 8;
            // 
            // TxtUrl
            // 
            this.TxtUrl.Location = new System.Drawing.Point(132, 89);
            this.TxtUrl.Name = "TxtUrl";
            this.TxtUrl.Size = new System.Drawing.Size(322, 20);
            this.TxtUrl.TabIndex = 9;
            this.TxtUrl.Leave += new System.EventHandler(this.TxtUrl_Leave);
            // 
            // TxtCantCanciones
            // 
            this.TxtCantCanciones.Location = new System.Drawing.Point(132, 37);
            this.TxtCantCanciones.Name = "TxtCantCanciones";
            this.TxtCantCanciones.Size = new System.Drawing.Size(322, 20);
            this.TxtCantCanciones.TabIndex = 10;
            // 
            // DtpFechaLanzamiento
            // 
            this.DtpFechaLanzamiento.Location = new System.Drawing.Point(132, 63);
            this.DtpFechaLanzamiento.Name = "DtpFechaLanzamiento";
            this.DtpFechaLanzamiento.Size = new System.Drawing.Size(321, 20);
            this.DtpFechaLanzamiento.TabIndex = 11;
            // 
            // CboEstilo
            // 
            this.CboEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstilo.FormattingEnabled = true;
            this.CboEstilo.Location = new System.Drawing.Point(132, 113);
            this.CboEstilo.Name = "CboEstilo";
            this.CboEstilo.Size = new System.Drawing.Size(322, 21);
            this.CboEstilo.TabIndex = 12;
            // 
            // CboArtista
            // 
            this.CboArtista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboArtista.FormattingEnabled = true;
            this.CboArtista.Location = new System.Drawing.Point(132, 168);
            this.CboArtista.Name = "CboArtista";
            this.CboArtista.Size = new System.Drawing.Size(322, 21);
            this.CboArtista.TabIndex = 13;
            // 
            // CboEdicion
            // 
            this.CboEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEdicion.FormattingEnabled = true;
            this.CboEdicion.Location = new System.Drawing.Point(132, 141);
            this.CboEdicion.Name = "CboEdicion";
            this.CboEdicion.Size = new System.Drawing.Size(322, 21);
            this.CboEdicion.TabIndex = 14;
            // 
            // PtBFoto
            // 
            this.PtBFoto.Location = new System.Drawing.Point(491, 12);
            this.PtBFoto.Name = "PtBFoto";
            this.PtBFoto.Size = new System.Drawing.Size(232, 200);
            this.PtBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PtBFoto.TabIndex = 15;
            this.PtBFoto.TabStop = false;
            // 
            // CmdAceptar
            // 
            this.CmdAceptar.Location = new System.Drawing.Point(132, 195);
            this.CmdAceptar.Name = "CmdAceptar";
            this.CmdAceptar.Size = new System.Drawing.Size(106, 22);
            this.CmdAceptar.TabIndex = 16;
            this.CmdAceptar.Text = "Aceptar";
            this.CmdAceptar.UseVisualStyleBackColor = true;
            this.CmdAceptar.Click += new System.EventHandler(this.CmdAceptar_Click);
            // 
            // CmdCancela
            // 
            this.CmdCancela.Location = new System.Drawing.Point(348, 195);
            this.CmdCancela.Name = "CmdCancela";
            this.CmdCancela.Size = new System.Drawing.Size(106, 22);
            this.CmdCancela.TabIndex = 17;
            this.CmdCancela.Text = "Cancelar";
            this.CmdCancela.UseVisualStyleBackColor = true;
            this.CmdCancela.Click += new System.EventHandler(this.CmdCancela_Click);
            // 
            // BtnAgregarFoto
            // 
            this.BtnAgregarFoto.Location = new System.Drawing.Point(460, 90);
            this.BtnAgregarFoto.Name = "BtnAgregarFoto";
            this.BtnAgregarFoto.Size = new System.Drawing.Size(22, 19);
            this.BtnAgregarFoto.TabIndex = 18;
            this.BtnAgregarFoto.Text = "+";
            this.BtnAgregarFoto.UseVisualStyleBackColor = true;
            this.BtnAgregarFoto.Click += new System.EventHandler(this.BtnAgregarFoto_Click);
            // 
            // FrmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 227);
            this.Controls.Add(this.BtnAgregarFoto);
            this.Controls.Add(this.CmdCancela);
            this.Controls.Add(this.CmdAceptar);
            this.Controls.Add(this.PtBFoto);
            this.Controls.Add(this.CboEdicion);
            this.Controls.Add(this.CboArtista);
            this.Controls.Add(this.CboEstilo);
            this.Controls.Add(this.DtpFechaLanzamiento);
            this.Controls.Add(this.TxtCantCanciones);
            this.Controls.Add(this.TxtUrl);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.FrmAltaDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PtBFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.TextBox TxtUrl;
        private System.Windows.Forms.TextBox TxtCantCanciones;
        private System.Windows.Forms.DateTimePicker DtpFechaLanzamiento;
        private System.Windows.Forms.ComboBox CboEstilo;
        private System.Windows.Forms.ComboBox CboArtista;
        private System.Windows.Forms.ComboBox CboEdicion;
        private System.Windows.Forms.PictureBox PtBFoto;
        private System.Windows.Forms.Button CmdAceptar;
        private System.Windows.Forms.Button CmdCancela;
        private System.Windows.Forms.Button BtnAgregarFoto;
    }
}