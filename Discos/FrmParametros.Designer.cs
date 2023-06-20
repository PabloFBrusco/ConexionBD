namespace Discos
{
    partial class FrmParametros
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
            this.TxtServidor = new System.Windows.Forms.TextBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtBase = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnTestear = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Base:";
            // 
            // TxtServidor
            // 
            this.TxtServidor.Location = new System.Drawing.Point(87, 15);
            this.TxtServidor.Name = "TxtServidor";
            this.TxtServidor.Size = new System.Drawing.Size(187, 20);
            this.TxtServidor.TabIndex = 0;
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(87, 93);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(187, 20);
            this.TxtPass.TabIndex = 3;
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(87, 67);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(187, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtBase
            // 
            this.TxtBase.Location = new System.Drawing.Point(87, 41);
            this.TxtBase.Name = "TxtBase";
            this.TxtBase.Size = new System.Drawing.Size(187, 20);
            this.TxtBase.TabIndex = 1;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(203, 135);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(71, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnTestear
            // 
            this.BtnTestear.Location = new System.Drawing.Point(280, 15);
            this.BtnTestear.Name = "BtnTestear";
            this.BtnTestear.Size = new System.Drawing.Size(71, 46);
            this.BtnTestear.TabIndex = 5;
            this.BtnTestear.Text = "Testear Conexión";
            this.BtnTestear.UseVisualStyleBackColor = true;
            this.BtnTestear.Click += new System.EventHandler(this.BtnTestear_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(283, 135);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(71, 23);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnver
            // 
            this.btnver.Location = new System.Drawing.Point(285, 94);
            this.btnver.Name = "btnver";
            this.btnver.Size = new System.Drawing.Size(68, 19);
            this.btnver.TabIndex = 7;
            this.btnver.Text = "Ver datos";
            this.btnver.UseVisualStyleBackColor = true;
            this.btnver.Click += new System.EventHandler(this.btnver_Click);
            // 
            // FrmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 170);
            this.Controls.Add(this.btnver);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnTestear);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtBase);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtServidor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setear Acceso a Server";
            this.Load += new System.EventHandler(this.FrmParametros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtServidor;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtBase;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnTestear;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnver;
    }
}