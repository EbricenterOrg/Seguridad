namespace HSC_gestionUsuarios
{
    partial class wftabm_SGusuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabm_SGusuario));
            this.navegador1 = new Navegador.Navegador();
            this.txtestado_usr = new System.Windows.Forms.TextBox();
            this.cboestado_usr = new System.Windows.Forms.ComboBox();
            this.txtipdir_usr = new System.Windows.Forms.TextBox();
            this.txthost_usr = new System.Windows.Forms.TextBox();
            this.txtfechmodif_usr = new System.Windows.Forms.TextBox();
            this.txtfechcreado_usr = new System.Windows.Forms.TextBox();
            this.lblestado_usr = new System.Windows.Forms.Label();
            this.lblipdir_usr = new System.Windows.Forms.Label();
            this.lblhost_usr = new System.Windows.Forms.Label();
            this.lblfechmodif_usr = new System.Windows.Forms.Label();
            this.lblfechcreado_usr = new System.Windows.Forms.Label();
            this.txtpass_usr = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btncodpreg = new System.Windows.Forms.Button();
            this.txtresp_usur = new System.Windows.Forms.TextBox();
            this.txtcuenta_usr = new System.Windows.Forms.TextBox();
            this.txtcod_preg = new System.Windows.Forms.TextBox();
            this.txtcod_priv = new System.Windows.Forms.TextBox();
            this.txtcod_usr = new System.Windows.Forms.TextBox();
            this.lblcod_preg = new System.Windows.Forms.Label();
            this.lblresp_usur = new System.Windows.Forms.Label();
            this.lblcuenta_usr = new System.Windows.Forms.Label();
            this.lblcod_priv = new System.Windows.Forms.Label();
            this.txtcod_emp = new System.Windows.Forms.TextBox();
            this.lblcod_emp = new System.Windows.Forms.Label();
            this.lblcod_usr = new System.Windows.Forms.Label();
            this.btncodemp = new System.Windows.Forms.Button();
            this.btncodpriv = new System.Windows.Forms.Button();
            this.lblGestionUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(86, 94);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = " tabm_sgusuario";
            this.navegador1.TabIndex = 12;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            // 
            // txtestado_usr
            // 
            this.txtestado_usr.Location = new System.Drawing.Point(412, 495);
            this.txtestado_usr.Name = "txtestado_usr";
            this.txtestado_usr.Size = new System.Drawing.Size(100, 20);
            this.txtestado_usr.TabIndex = 99;
            this.txtestado_usr.Tag = "estado_usr";
            this.txtestado_usr.Visible = false;
            this.txtestado_usr.TextChanged += new System.EventHandler(this.txtestado_usr_TextChanged);
            // 
            // cboestado_usr
            // 
            this.cboestado_usr.Enabled = false;
            this.cboestado_usr.FormattingEnabled = true;
            this.cboestado_usr.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_usr.Location = new System.Drawing.Point(255, 495);
            this.cboestado_usr.Name = "cboestado_usr";
            this.cboestado_usr.Size = new System.Drawing.Size(141, 21);
            this.cboestado_usr.TabIndex = 25;
            this.cboestado_usr.Tag = "estado_usr";
            this.cboestado_usr.SelectedIndexChanged += new System.EventHandler(this.cboestado_usr_SelectedIndexChanged);
            // 
            // txtipdir_usr
            // 
            this.txtipdir_usr.Location = new System.Drawing.Point(255, 466);
            this.txtipdir_usr.Name = "txtipdir_usr";
            this.txtipdir_usr.Size = new System.Drawing.Size(141, 20);
            this.txtipdir_usr.TabIndex = 24;
            this.txtipdir_usr.Tag = "ipdir_usr";
            // 
            // txthost_usr
            // 
            this.txthost_usr.Location = new System.Drawing.Point(255, 436);
            this.txthost_usr.Name = "txthost_usr";
            this.txthost_usr.Size = new System.Drawing.Size(141, 20);
            this.txthost_usr.TabIndex = 23;
            this.txthost_usr.Tag = "host_usr";
            // 
            // txtfechmodif_usr
            // 
            this.txtfechmodif_usr.Location = new System.Drawing.Point(255, 408);
            this.txtfechmodif_usr.Name = "txtfechmodif_usr";
            this.txtfechmodif_usr.Size = new System.Drawing.Size(141, 20);
            this.txtfechmodif_usr.TabIndex = 22;
            this.txtfechmodif_usr.Tag = "fechmodif_usr";
            // 
            // txtfechcreado_usr
            // 
            this.txtfechcreado_usr.Location = new System.Drawing.Point(255, 381);
            this.txtfechcreado_usr.Name = "txtfechcreado_usr";
            this.txtfechcreado_usr.Size = new System.Drawing.Size(141, 20);
            this.txtfechcreado_usr.TabIndex = 21;
            this.txtfechcreado_usr.Tag = "fechcreado_usr";
            // 
            // lblestado_usr
            // 
            this.lblestado_usr.AutoSize = true;
            this.lblestado_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado_usr.ForeColor = System.Drawing.Color.Black;
            this.lblestado_usr.Location = new System.Drawing.Point(83, 495);
            this.lblestado_usr.Name = "lblestado_usr";
            this.lblestado_usr.Size = new System.Drawing.Size(92, 15);
            this.lblestado_usr.TabIndex = 93;
            this.lblestado_usr.Tag = "estado_usr";
            this.lblestado_usr.Text = "Estado usuario:";
            // 
            // lblipdir_usr
            // 
            this.lblipdir_usr.AutoSize = true;
            this.lblipdir_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblipdir_usr.ForeColor = System.Drawing.Color.Black;
            this.lblipdir_usr.Location = new System.Drawing.Point(83, 467);
            this.lblipdir_usr.Name = "lblipdir_usr";
            this.lblipdir_usr.Size = new System.Drawing.Size(73, 15);
            this.lblipdir_usr.TabIndex = 92;
            this.lblipdir_usr.Tag = "ipdir_usr";
            this.lblipdir_usr.Text = "Direccion IP";
            // 
            // lblhost_usr
            // 
            this.lblhost_usr.AutoSize = true;
            this.lblhost_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhost_usr.ForeColor = System.Drawing.Color.Black;
            this.lblhost_usr.Location = new System.Drawing.Point(83, 436);
            this.lblhost_usr.Name = "lblhost_usr";
            this.lblhost_usr.Size = new System.Drawing.Size(137, 15);
            this.lblhost_usr.TabIndex = 91;
            this.lblhost_usr.Text = "Nombre de la maquina:";
            // 
            // lblfechmodif_usr
            // 
            this.lblfechmodif_usr.AutoSize = true;
            this.lblfechmodif_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechmodif_usr.ForeColor = System.Drawing.Color.Black;
            this.lblfechmodif_usr.Location = new System.Drawing.Point(83, 409);
            this.lblfechmodif_usr.Name = "lblfechmodif_usr";
            this.lblfechmodif_usr.Size = new System.Drawing.Size(108, 15);
            this.lblfechmodif_usr.TabIndex = 90;
            this.lblfechmodif_usr.Text = "Fecha modificado:";
            // 
            // lblfechcreado_usr
            // 
            this.lblfechcreado_usr.AutoSize = true;
            this.lblfechcreado_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechcreado_usr.ForeColor = System.Drawing.Color.Black;
            this.lblfechcreado_usr.Location = new System.Drawing.Point(83, 382);
            this.lblfechcreado_usr.Name = "lblfechcreado_usr";
            this.lblfechcreado_usr.Size = new System.Drawing.Size(87, 15);
            this.lblfechcreado_usr.TabIndex = 89;
            this.lblfechcreado_usr.Text = "Fecha Creado:";
            // 
            // txtpass_usr
            // 
            this.txtpass_usr.Location = new System.Drawing.Point(255, 352);
            this.txtpass_usr.Name = "txtpass_usr";
            this.txtpass_usr.Size = new System.Drawing.Size(141, 20);
            this.txtpass_usr.TabIndex = 20;
            this.txtpass_usr.Tag = "pass_usr";
            this.txtpass_usr.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.ForeColor = System.Drawing.Color.Black;
            this.lblContrasena.Location = new System.Drawing.Point(83, 353);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(73, 15);
            this.lblContrasena.TabIndex = 87;
            this.lblContrasena.Tag = "lblpass_usr";
            this.lblContrasena.Text = "Contraseña:";
            // 
            // btncodpreg
            // 
            this.btncodpreg.Enabled = false;
            this.btncodpreg.Location = new System.Drawing.Point(314, 262);
            this.btncodpreg.Name = "btncodpreg";
            this.btncodpreg.Size = new System.Drawing.Size(131, 23);
            this.btncodpreg.TabIndex = 17;
            this.btncodpreg.Text = "Seleccionar Pregunta";
            this.btncodpreg.UseVisualStyleBackColor = true;
            this.btncodpreg.Click += new System.EventHandler(this.btncod_preg_Click);
            // 
            // txtresp_usur
            // 
            this.txtresp_usur.Location = new System.Drawing.Point(255, 326);
            this.txtresp_usur.Name = "txtresp_usur";
            this.txtresp_usur.Size = new System.Drawing.Size(141, 20);
            this.txtresp_usur.TabIndex = 19;
            this.txtresp_usur.Tag = "resp_usur";
            // 
            // txtcuenta_usr
            // 
            this.txtcuenta_usr.Location = new System.Drawing.Point(255, 297);
            this.txtcuenta_usr.Name = "txtcuenta_usr";
            this.txtcuenta_usr.Size = new System.Drawing.Size(141, 20);
            this.txtcuenta_usr.TabIndex = 18;
            this.txtcuenta_usr.Tag = "cuenta_usr";
            // 
            // txtcod_preg
            // 
            this.txtcod_preg.Enabled = false;
            this.txtcod_preg.Location = new System.Drawing.Point(255, 264);
            this.txtcod_preg.Name = "txtcod_preg";
            this.txtcod_preg.Size = new System.Drawing.Size(53, 20);
            this.txtcod_preg.TabIndex = 75;
            this.txtcod_preg.Tag = "cod_preg";
            // 
            // txtcod_priv
            // 
            this.txtcod_priv.Enabled = false;
            this.txtcod_priv.Location = new System.Drawing.Point(255, 234);
            this.txtcod_priv.Name = "txtcod_priv";
            this.txtcod_priv.Size = new System.Drawing.Size(53, 20);
            this.txtcod_priv.TabIndex = 74;
            this.txtcod_priv.Tag = "cod_priv";
            // 
            // txtcod_usr
            // 
            this.txtcod_usr.Location = new System.Drawing.Point(255, 179);
            this.txtcod_usr.Name = "txtcod_usr";
            this.txtcod_usr.Size = new System.Drawing.Size(53, 20);
            this.txtcod_usr.TabIndex = 13;
            this.txtcod_usr.Tag = "cod_usr";
            this.txtcod_usr.TextChanged += new System.EventHandler(this.txtcod_usr_TextChanged);
            // 
            // lblcod_preg
            // 
            this.lblcod_preg.AutoSize = true;
            this.lblcod_preg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_preg.ForeColor = System.Drawing.Color.Black;
            this.lblcod_preg.Location = new System.Drawing.Point(83, 271);
            this.lblcod_preg.Name = "lblcod_preg";
            this.lblcod_preg.Size = new System.Drawing.Size(101, 15);
            this.lblcod_preg.TabIndex = 80;
            this.lblcod_preg.Text = "Codigo pregunta:";
            // 
            // lblresp_usur
            // 
            this.lblresp_usur.AutoSize = true;
            this.lblresp_usur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresp_usur.ForeColor = System.Drawing.Color.Black;
            this.lblresp_usur.Location = new System.Drawing.Point(83, 327);
            this.lblresp_usur.Name = "lblresp_usur";
            this.lblresp_usur.Size = new System.Drawing.Size(121, 15);
            this.lblresp_usur.TabIndex = 81;
            this.lblresp_usur.Text = "Respuesta pregunta:";
            // 
            // lblcuenta_usr
            // 
            this.lblcuenta_usr.AutoSize = true;
            this.lblcuenta_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuenta_usr.ForeColor = System.Drawing.Color.Black;
            this.lblcuenta_usr.Location = new System.Drawing.Point(83, 301);
            this.lblcuenta_usr.Name = "lblcuenta_usr";
            this.lblcuenta_usr.Size = new System.Drawing.Size(156, 15);
            this.lblcuenta_usr.TabIndex = 79;
            this.lblcuenta_usr.Text = "Nombre de cuenta usuario:";
            // 
            // lblcod_priv
            // 
            this.lblcod_priv.AutoSize = true;
            this.lblcod_priv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_priv.ForeColor = System.Drawing.Color.Black;
            this.lblcod_priv.Location = new System.Drawing.Point(83, 241);
            this.lblcod_priv.Name = "lblcod_priv";
            this.lblcod_priv.Size = new System.Drawing.Size(99, 15);
            this.lblcod_priv.TabIndex = 78;
            this.lblcod_priv.Text = "Codigo Privilegio";
            // 
            // txtcod_emp
            // 
            this.txtcod_emp.Enabled = false;
            this.txtcod_emp.Location = new System.Drawing.Point(255, 206);
            this.txtcod_emp.Name = "txtcod_emp";
            this.txtcod_emp.Size = new System.Drawing.Size(53, 20);
            this.txtcod_emp.TabIndex = 72;
            this.txtcod_emp.Tag = "cod_emp";
            // 
            // lblcod_emp
            // 
            this.lblcod_emp.AutoSize = true;
            this.lblcod_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_emp.ForeColor = System.Drawing.Color.Black;
            this.lblcod_emp.Location = new System.Drawing.Point(83, 214);
            this.lblcod_emp.Name = "lblcod_emp";
            this.lblcod_emp.Size = new System.Drawing.Size(108, 15);
            this.lblcod_emp.TabIndex = 77;
            this.lblcod_emp.Text = "Codigo empleado:";
            // 
            // lblcod_usr
            // 
            this.lblcod_usr.AutoSize = true;
            this.lblcod_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_usr.ForeColor = System.Drawing.Color.Black;
            this.lblcod_usr.Location = new System.Drawing.Point(83, 187);
            this.lblcod_usr.Name = "lblcod_usr";
            this.lblcod_usr.Size = new System.Drawing.Size(92, 15);
            this.lblcod_usr.TabIndex = 73;
            this.lblcod_usr.Text = "Codigo Usuario";
            // 
            // btncodemp
            // 
            this.btncodemp.Enabled = false;
            this.btncodemp.Location = new System.Drawing.Point(314, 204);
            this.btncodemp.Name = "btncodemp";
            this.btncodemp.Size = new System.Drawing.Size(75, 23);
            this.btncodemp.TabIndex = 100;
            this.btncodemp.Text = "Agregar";
            this.btncodemp.UseVisualStyleBackColor = true;
            this.btncodemp.Click += new System.EventHandler(this.btncodemp_Click);
            // 
            // btncodpriv
            // 
            this.btncodpriv.Enabled = false;
            this.btncodpriv.Location = new System.Drawing.Point(314, 233);
            this.btncodpriv.Name = "btncodpriv";
            this.btncodpriv.Size = new System.Drawing.Size(75, 23);
            this.btncodpriv.TabIndex = 101;
            this.btncodpriv.Text = "Agregar";
            this.btncodpriv.UseVisualStyleBackColor = true;
            this.btncodpriv.Click += new System.EventHandler(this.btncodpriv_Click);
            // 
            // lblGestionUsuarios
            // 
            this.lblGestionUsuarios.AutoSize = true;
            this.lblGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblGestionUsuarios.Location = new System.Drawing.Point(89, 44);
            this.lblGestionUsuarios.Name = "lblGestionUsuarios";
            this.lblGestionUsuarios.Size = new System.Drawing.Size(275, 33);
            this.lblGestionUsuarios.TabIndex = 102;
            this.lblGestionUsuarios.Text = "Gestión de usuarios";
            this.lblGestionUsuarios.Click += new System.EventHandler(this.label2_Click);
            // 
            // wftabm_SGusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 557);
            this.Controls.Add(this.lblGestionUsuarios);
            this.Controls.Add(this.btncodpriv);
            this.Controls.Add(this.btncodemp);
            this.Controls.Add(this.txtestado_usr);
            this.Controls.Add(this.cboestado_usr);
            this.Controls.Add(this.txtipdir_usr);
            this.Controls.Add(this.txthost_usr);
            this.Controls.Add(this.txtfechmodif_usr);
            this.Controls.Add(this.txtfechcreado_usr);
            this.Controls.Add(this.lblestado_usr);
            this.Controls.Add(this.lblipdir_usr);
            this.Controls.Add(this.lblhost_usr);
            this.Controls.Add(this.lblfechmodif_usr);
            this.Controls.Add(this.lblfechcreado_usr);
            this.Controls.Add(this.txtpass_usr);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.btncodpreg);
            this.Controls.Add(this.txtresp_usur);
            this.Controls.Add(this.txtcuenta_usr);
            this.Controls.Add(this.txtcod_preg);
            this.Controls.Add(this.txtcod_priv);
            this.Controls.Add(this.txtcod_usr);
            this.Controls.Add(this.lblcod_preg);
            this.Controls.Add(this.lblresp_usur);
            this.Controls.Add(this.lblcuenta_usr);
            this.Controls.Add(this.lblcod_priv);
            this.Controls.Add(this.txtcod_emp);
            this.Controls.Add(this.lblcod_emp);
            this.Controls.Add(this.lblcod_usr);
            this.Controls.Add(this.navegador1);
            this.Name = "wftabm_SGusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Usuarios";
            this.Load += new System.EventHandler(this.wfprincipalUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtestado_usr;
        private System.Windows.Forms.ComboBox cboestado_usr;
        private System.Windows.Forms.TextBox txtipdir_usr;
        private System.Windows.Forms.TextBox txthost_usr;
        private System.Windows.Forms.TextBox txtfechmodif_usr;
        private System.Windows.Forms.TextBox txtfechcreado_usr;
        private System.Windows.Forms.Label lblestado_usr;
        private System.Windows.Forms.Label lblipdir_usr;
        private System.Windows.Forms.Label lblhost_usr;
        private System.Windows.Forms.Label lblfechmodif_usr;
        private System.Windows.Forms.Label lblfechcreado_usr;
        private System.Windows.Forms.TextBox txtpass_usr;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btncodpreg;
        private System.Windows.Forms.TextBox txtresp_usur;
        private System.Windows.Forms.TextBox txtcuenta_usr;
        private System.Windows.Forms.TextBox txtcod_preg;
        private System.Windows.Forms.TextBox txtcod_priv;
        private System.Windows.Forms.TextBox txtcod_usr;
        private System.Windows.Forms.Label lblcod_preg;
        private System.Windows.Forms.Label lblresp_usur;
        private System.Windows.Forms.Label lblcuenta_usr;
        private System.Windows.Forms.Label lblcod_priv;
        private System.Windows.Forms.TextBox txtcod_emp;
        private System.Windows.Forms.Label lblcod_emp;
        private System.Windows.Forms.Label lblcod_usr;
        private System.Windows.Forms.Button btncodemp;
        private System.Windows.Forms.Button btncodpriv;
        private System.Windows.Forms.Label lblGestionUsuarios;
    }
}