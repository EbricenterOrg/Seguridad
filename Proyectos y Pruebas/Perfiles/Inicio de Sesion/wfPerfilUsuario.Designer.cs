namespace Inicio_de_Sesion
{
    partial class wfPerfilUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPerfilUsuario));
            this.navegador1 = new Navegador.Navegador();
            this.lblPerfilUser = new System.Windows.Forms.Label();
            this.txtCodPer = new System.Windows.Forms.TextBox();
            this.lblCodPer = new System.Windows.Forms.Label();
            this.txtCodUser = new System.Windows.Forms.TextBox();
            this.lblCodUsur = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblFechCreacion = new System.Windows.Forms.Label();
            this.lblCodPUser = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtFechCreado = new System.Windows.Forms.TextBox();
            this.txtCodPerUser = new System.Windows.Forms.TextBox();
            this.lblFechModif = new System.Windows.Forms.Label();
            this.txtFechModif = new System.Windows.Forms.TextBox();
            this.cboEstadoUsr = new System.Windows.Forms.ComboBox();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnElegirPerfil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(28, 36);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabt_sgperfilusuario";
            this.navegador1.TabIndex = 0;
            // 
            // lblPerfilUser
            // 
            this.lblPerfilUser.AutoSize = true;
            this.lblPerfilUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilUser.Location = new System.Drawing.Point(23, 9);
            this.lblPerfilUser.Name = "lblPerfilUser";
            this.lblPerfilUser.Size = new System.Drawing.Size(141, 25);
            this.lblPerfilUser.TabIndex = 20;
            this.lblPerfilUser.Text = "Perfil Usuario";
            // 
            // txtCodPer
            // 
            this.txtCodPer.Location = new System.Drawing.Point(325, 178);
            this.txtCodPer.Name = "txtCodPer";
            this.txtCodPer.Size = new System.Drawing.Size(100, 20);
            this.txtCodPer.TabIndex = 41;
            this.txtCodPer.Tag = "cod_pfl";
            // 
            // lblCodPer
            // 
            this.lblCodPer.AutoSize = true;
            this.lblCodPer.Location = new System.Drawing.Point(228, 178);
            this.lblCodPer.Name = "lblCodPer";
            this.lblCodPer.Size = new System.Drawing.Size(66, 13);
            this.lblCodPer.TabIndex = 40;
            this.lblCodPer.Tag = "";
            this.lblCodPer.Text = "Codigo Perfil";
            this.lblCodPer.Click += new System.EventHandler(this.lblCodApp_Click);
            // 
            // txtCodUser
            // 
            this.txtCodUser.Location = new System.Drawing.Point(325, 155);
            this.txtCodUser.Name = "txtCodUser";
            this.txtCodUser.Size = new System.Drawing.Size(100, 20);
            this.txtCodUser.TabIndex = 39;
            this.txtCodUser.Tag = "cod_usr";
            // 
            // lblCodUsur
            // 
            this.lblCodUsur.AutoSize = true;
            this.lblCodUsur.Location = new System.Drawing.Point(218, 155);
            this.lblCodUsur.Name = "lblCodUsur";
            this.lblCodUsur.Size = new System.Drawing.Size(77, 13);
            this.lblCodUsur.TabIndex = 38;
            this.lblCodUsur.Tag = "";
            this.lblCodUsur.Text = "Codigo usuario";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(255, 262);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 37;
            this.lblEstado.Text = "Estado";
            // 
            // lblFechCreacion
            // 
            this.lblFechCreacion.AutoSize = true;
            this.lblFechCreacion.Location = new System.Drawing.Point(214, 202);
            this.lblFechCreacion.Name = "lblFechCreacion";
            this.lblFechCreacion.Size = new System.Drawing.Size(81, 13);
            this.lblFechCreacion.TabIndex = 31;
            this.lblFechCreacion.Text = "Fecha creacion";
            // 
            // lblCodPUser
            // 
            this.lblCodPUser.AutoSize = true;
            this.lblCodPUser.Location = new System.Drawing.Point(193, 127);
            this.lblCodPUser.Name = "lblCodPUser";
            this.lblCodPUser.Size = new System.Drawing.Size(102, 13);
            this.lblCodPUser.TabIndex = 30;
            this.lblCodPUser.Text = "Codigo perfil usuario";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(445, 262);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(87, 20);
            this.txtEstado.TabIndex = 29;
            this.txtEstado.Tag = "estado_pflusr";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtFechCreado
            // 
            this.txtFechCreado.Location = new System.Drawing.Point(325, 202);
            this.txtFechCreado.Name = "txtFechCreado";
            this.txtFechCreado.Size = new System.Drawing.Size(100, 20);
            this.txtFechCreado.TabIndex = 23;
            this.txtFechCreado.Tag = "fechcreado_plfusr";
            // 
            // txtCodPerUser
            // 
            this.txtCodPerUser.Location = new System.Drawing.Point(325, 124);
            this.txtCodPerUser.Name = "txtCodPerUser";
            this.txtCodPerUser.Size = new System.Drawing.Size(100, 20);
            this.txtCodPerUser.TabIndex = 22;
            this.txtCodPerUser.Tag = "cod_pusr";
            this.txtCodPerUser.TextChanged += new System.EventHandler(this.txtCodPerUser_TextChanged);
            // 
            // lblFechModif
            // 
            this.lblFechModif.AutoSize = true;
            this.lblFechModif.Location = new System.Drawing.Point(196, 228);
            this.lblFechModif.Name = "lblFechModif";
            this.lblFechModif.Size = new System.Drawing.Size(99, 13);
            this.lblFechModif.TabIndex = 42;
            this.lblFechModif.Text = "Fecha modificacion";
            // 
            // txtFechModif
            // 
            this.txtFechModif.Location = new System.Drawing.Point(325, 228);
            this.txtFechModif.Name = "txtFechModif";
            this.txtFechModif.Size = new System.Drawing.Size(100, 20);
            this.txtFechModif.TabIndex = 43;
            this.txtFechModif.Tag = "fechmodf_pflusr";
            // 
            // cboEstadoUsr
            // 
            this.cboEstadoUsr.FormattingEnabled = true;
            this.cboEstadoUsr.Location = new System.Drawing.Point(325, 261);
            this.cboEstadoUsr.Name = "cboEstadoUsr";
            this.cboEstadoUsr.Size = new System.Drawing.Size(100, 21);
            this.cboEstadoUsr.TabIndex = 44;
            this.cboEstadoUsr.Tag = "estado_pflusr";
            this.cboEstadoUsr.SelectedIndexChanged += new System.EventHandler(this.cboEstadoUsr_SelectedIndexChanged);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(445, 150);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnUsuario.TabIndex = 45;
            this.btnUsuario.Text = "Usuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElegirPerfil
            // 
            this.btnElegirPerfil.Location = new System.Drawing.Point(445, 176);
            this.btnElegirPerfil.Name = "btnElegirPerfil";
            this.btnElegirPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnElegirPerfil.TabIndex = 46;
            this.btnElegirPerfil.Text = "Elegir Perfil";
            this.btnElegirPerfil.UseVisualStyleBackColor = true;
            this.btnElegirPerfil.Click += new System.EventHandler(this.btnElegirPerfil_Click);
            // 
            // wfPerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 359);
            this.Controls.Add(this.btnElegirPerfil);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.cboEstadoUsr);
            this.Controls.Add(this.txtFechModif);
            this.Controls.Add(this.lblFechModif);
            this.Controls.Add(this.txtCodPer);
            this.Controls.Add(this.lblCodPer);
            this.Controls.Add(this.txtCodUser);
            this.Controls.Add(this.lblCodUsur);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechCreacion);
            this.Controls.Add(this.lblCodPUser);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtFechCreado);
            this.Controls.Add(this.txtCodPerUser);
            this.Controls.Add(this.lblPerfilUser);
            this.Controls.Add(this.navegador1);
            this.Name = "wfPerfilUsuario";
            this.Text = "wfPerfilUsuario";
            this.Load += new System.EventHandler(this.wfPerfilUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblPerfilUser;
        private System.Windows.Forms.TextBox txtCodPer;
        private System.Windows.Forms.Label lblCodPer;
        private System.Windows.Forms.TextBox txtCodUser;
        private System.Windows.Forms.Label lblCodUsur;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblFechCreacion;
        private System.Windows.Forms.Label lblCodPUser;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtFechCreado;
        private System.Windows.Forms.TextBox txtCodPerUser;
        private System.Windows.Forms.Label lblFechModif;
        private System.Windows.Forms.TextBox txtFechModif;
        private System.Windows.Forms.ComboBox cboEstadoUsr;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnElegirPerfil;
    }
}