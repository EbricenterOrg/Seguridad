namespace Inicio_de_Sesion
{
    partial class wfSesion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDatos = new System.Windows.Forms.Panel();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.pcbPass = new System.Windows.Forms.PictureBox();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDatos
            // 
            this.pnlDatos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlDatos.Controls.Add(this.pcbUser);
            this.pnlDatos.Controls.Add(this.pcbPass);
            this.pnlDatos.Controls.Add(this.lblTitulo1);
            this.pnlDatos.Controls.Add(this.btnAceptar);
            this.pnlDatos.Controls.Add(this.txtPassword);
            this.pnlDatos.Controls.Add(this.cmbUsuario);
            this.pnlDatos.Controls.Add(this.lblPassword);
            this.pnlDatos.Controls.Add(this.lblUsuario);
            this.pnlDatos.Location = new System.Drawing.Point(567, 0);
            this.pnlDatos.Name = "pnlDatos";
            this.pnlDatos.Size = new System.Drawing.Size(279, 562);
            this.pnlDatos.TabIndex = 0;
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::Inicio_de_Sesion.Properties.Resources.User;
            this.pcbUser.Location = new System.Drawing.Point(11, 197);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(46, 41);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 8;
            this.pcbUser.TabStop = false;
            // 
            // pcbPass
            // 
            this.pcbPass.Image = global::Inicio_de_Sesion.Properties.Resources.Password;
            this.pcbPass.Location = new System.Drawing.Point(9, 280);
            this.pcbPass.Name = "pcbPass";
            this.pcbPass.Size = new System.Drawing.Size(48, 48);
            this.pcbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPass.TabIndex = 7;
            this.pcbPass.TabStop = false;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitulo1.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(131, 44);
            this.lblTitulo1.TabIndex = 6;
            this.lblTitulo1.Text = "Sesion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAceptar.Location = new System.Drawing.Point(11, 412);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 32);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Iniciar Sesion";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(11, 349);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(206, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(11, 244);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(206, 21);
            this.cmbUsuario.TabIndex = 3;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPassword.Location = new System.Drawing.Point(63, 295);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(169, 33);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblUsuario.Location = new System.Drawing.Point(63, 208);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(108, 33);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Conexión";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(70, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Remota";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // wfSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(844, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlDatos);
            this.Name = "wfSesion";
            this.Text = "Form1";
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.PictureBox pcbPass;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

