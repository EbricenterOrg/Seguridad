namespace Modulo_de_Seguridad_2._1.Presentacion
{
    partial class wfInicioSesion
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
            this.btnCancelarSesion = new System.Windows.Forms.Button();
            this.lklPregunta = new System.Windows.Forms.LinkLabel();
            this.btnSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pcbFotoUsuario = new System.Windows.Forms.PictureBox();
            this.pcbUser = new System.Windows.Forms.PictureBox();
            this.pcbPass = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarSesion
            // 
            this.btnCancelarSesion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelarSesion.Location = new System.Drawing.Point(360, 171);
            this.btnCancelarSesion.Name = "btnCancelarSesion";
            this.btnCancelarSesion.Size = new System.Drawing.Size(107, 31);
            this.btnCancelarSesion.TabIndex = 44;
            this.btnCancelarSesion.Text = "Cancelar";
            this.btnCancelarSesion.UseVisualStyleBackColor = false;
            this.btnCancelarSesion.Click += new System.EventHandler(this.btnCancelarSesion_Click);
            // 
            // lklPregunta
            // 
            this.lklPregunta.AutoSize = true;
            this.lklPregunta.Location = new System.Drawing.Point(342, 131);
            this.lklPregunta.Name = "lklPregunta";
            this.lklPregunta.Size = new System.Drawing.Size(148, 13);
            this.lklPregunta.TabIndex = 43;
            this.lklPregunta.TabStop = true;
            this.lklPregunta.Text = "¿Has olvidado la contraseña?";
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSesion.Location = new System.Drawing.Point(234, 171);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(107, 31);
            this.btnSesion.TabIndex = 42;
            this.btnSesion.Text = "Inciar Sesión";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pcbFotoUsuario);
            this.panel1.Location = new System.Drawing.Point(15, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 159);
            this.panel1.TabIndex = 35;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(308, 95);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(182, 20);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblPassword.Location = new System.Drawing.Point(209, 99);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 16);
            this.lblPassword.TabIndex = 36;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblUsuario.Location = new System.Drawing.Point(208, 46);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(55, 16);
            this.lblUsuario.TabIndex = 34;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(308, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(182, 20);
            this.txtUsuario.TabIndex = 45;
            // 
            // pcbFotoUsuario
            // 
            this.pcbFotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pcbFotoUsuario.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.HotelSanCarlos;
            this.pcbFotoUsuario.Location = new System.Drawing.Point(3, 3);
            this.pcbFotoUsuario.Name = "pcbFotoUsuario";
            this.pcbFotoUsuario.Size = new System.Drawing.Size(123, 150);
            this.pcbFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFotoUsuario.TabIndex = 0;
            this.pcbFotoUsuario.TabStop = false;
            // 
            // pcbUser
            // 
            this.pcbUser.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.User;
            this.pcbUser.Location = new System.Drawing.Point(168, 32);
            this.pcbUser.Name = "pcbUser";
            this.pcbUser.Size = new System.Drawing.Size(33, 30);
            this.pcbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser.TabIndex = 40;
            this.pcbUser.TabStop = false;
            // 
            // pcbPass
            // 
            this.pcbPass.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.Password;
            this.pcbPass.Location = new System.Drawing.Point(168, 95);
            this.pcbPass.Name = "pcbPass";
            this.pcbPass.Size = new System.Drawing.Size(35, 36);
            this.pcbPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPass.TabIndex = 39;
            this.pcbPass.TabStop = false;
            // 
            // wfInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 227);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnCancelarSesion);
            this.Controls.Add(this.lklPregunta);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pcbUser);
            this.Controls.Add(this.pcbPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Name = "wfInicioSesion";
            this.Text = "wfInicioSesion";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarSesion;
        private System.Windows.Forms.LinkLabel lklPregunta;
        private System.Windows.Forms.Button btnSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbFotoUsuario;
        private System.Windows.Forms.PictureBox pcbUser;
        private System.Windows.Forms.PictureBox pcbPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}