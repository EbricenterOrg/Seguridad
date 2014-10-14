namespace Control_de_Usuario.Capas.Presentacion
{
    partial class InicioSesion
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSesion = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lklPregunta = new System.Windows.Forms.LinkLabel();
            this.btnCancelarSesion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.pcbPass = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSesion.Location = new System.Drawing.Point(183, 256);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(107, 31);
            this.btnSesion.TabIndex = 20;
            this.btnSesion.Text = "Inciar Sesión";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lblTitulo1);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 47);
            this.panel2.TabIndex = 19;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo1.Location = new System.Drawing.Point(3, 0);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(114, 39);
            this.lblTitulo1.TabIndex = 17;
            this.lblTitulo1.Text = "Sesion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 159);
            this.panel1.TabIndex = 12;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(183, 176);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(232, 20);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(183, 107);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(232, 21);
            this.cmbUsuario.TabIndex = 14;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPassword.Location = new System.Drawing.Point(224, 154);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 16);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblUsuario.Location = new System.Drawing.Point(223, 85);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 11;
            this.lblUsuario.Text = "Usuario";
            // 
            // lklPregunta
            // 
            this.lklPregunta.AutoSize = true;
            this.lklPregunta.Location = new System.Drawing.Point(180, 215);
            this.lklPregunta.Name = "lklPregunta";
            this.lklPregunta.Size = new System.Drawing.Size(148, 13);
            this.lklPregunta.TabIndex = 21;
            this.lklPregunta.TabStop = true;
            this.lklPregunta.Text = "¿Has olvidado la contraseña?";
            // 
            // btnCancelarSesion
            // 
            this.btnCancelarSesion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelarSesion.Location = new System.Drawing.Point(308, 256);
            this.btnCancelarSesion.Name = "btnCancelarSesion";
            this.btnCancelarSesion.Size = new System.Drawing.Size(107, 31);
            this.btnCancelarSesion.TabIndex = 22;
            this.btnCancelarSesion.Text = "Cancelar";
            this.btnCancelarSesion.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 150);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::Control_de_Usuario.Properties.Resources.User;
            this.pcbUser.Location = new System.Drawing.Point(183, 71);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(33, 30);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 18;
            this.pcbUser.TabStop = false;
            // 
            // pcbPass
            // 
            this.pcbPass.Image = global::Control_de_Usuario.Properties.Resources.Password;
            this.pcbPass.Location = new System.Drawing.Point(183, 134);
            this.pcbPass.Name = "pcbPass";
            this.pcbPass.Size = new System.Drawing.Size(35, 36);
            this.pcbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPass.TabIndex = 17;
            this.pcbPass.TabStop = false;
            // 
            // cuInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnCancelarSesion);
            this.Controls.Add(this.lklPregunta);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbUser);
            this.Controls.Add(this.pcbPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbUsuario);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Name = "cuInicioSesion";
            this.Size = new System.Drawing.Size(469, 299);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.PictureBox pcbPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.LinkLabel lklPregunta;
        private System.Windows.Forms.Button btnCancelarSesion;

    }
}
