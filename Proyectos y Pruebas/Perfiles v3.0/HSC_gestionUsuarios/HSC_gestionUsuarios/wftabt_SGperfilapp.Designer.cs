namespace HSC_gestionUsuarios
{
    partial class wftabt_SGperfilapp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabt_SGperfilapp));
            this.navegador1 = new Navegador.Navegador();
            this.txtestado_perfapp = new System.Windows.Forms.TextBox();
            this.cboestado_perfapp = new System.Windows.Forms.ComboBox();
            this.txtimprimir = new System.Windows.Forms.TextBox();
            this.txtdelete = new System.Windows.Forms.TextBox();
            this.txtupdate = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lblimprimir = new System.Windows.Forms.Label();
            this.lbldelete = new System.Windows.Forms.Label();
            this.lblupdate = new System.Windows.Forms.Label();
            this.txtinsert = new System.Windows.Forms.TextBox();
            this.lblinsert = new System.Windows.Forms.Label();
            this.txtselect = new System.Windows.Forms.TextBox();
            this.cbocod_app = new System.Windows.Forms.ComboBox();
            this.cbocod_perfil = new System.Windows.Forms.ComboBox();
            this.txtfechcreac_perfapp = new System.Windows.Forms.TextBox();
            this.txtcod_app = new System.Windows.Forms.TextBox();
            this.txtcod_perfapp = new System.Windows.Forms.TextBox();
            this.lblselect = new System.Windows.Forms.Label();
            this.lblfech_perfapp = new System.Windows.Forms.Label();
            this.lblcod_app = new System.Windows.Forms.Label();
            this.txtcod_perfil = new System.Windows.Forms.TextBox();
            this.lblcod_perfil = new System.Windows.Forms.Label();
            this.lblcod_perfapp = new System.Windows.Forms.Label();
            this.btnCodPerf = new System.Windows.Forms.Button();
            this.btnCodAp = new System.Windows.Forms.Button();
            this.lblGestionUsuarios = new System.Windows.Forms.Label();
            this.btnObtener = new System.Windows.Forms.Button();
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
            this.navegador1.sNombreTabla = " tabt_sgperfilapp";
            this.navegador1.TabIndex = 12;
            // 
            // txtestado_perfapp
            // 
            this.txtestado_perfapp.Location = new System.Drawing.Point(412, 455);
            this.txtestado_perfapp.Name = "txtestado_perfapp";
            this.txtestado_perfapp.Size = new System.Drawing.Size(100, 20);
            this.txtestado_perfapp.TabIndex = 99;
            this.txtestado_perfapp.Tag = "estado_papp";
            this.txtestado_perfapp.Visible = false;
            this.txtestado_perfapp.TextChanged += new System.EventHandler(this.txtestado_usr_TextChanged);
            // 
            // cboestado_perfapp
            // 
            this.cboestado_perfapp.FormattingEnabled = true;
            this.cboestado_perfapp.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_perfapp.Location = new System.Drawing.Point(255, 455);
            this.cboestado_perfapp.Name = "cboestado_perfapp";
            this.cboestado_perfapp.Size = new System.Drawing.Size(141, 21);
            this.cboestado_perfapp.TabIndex = 25;
            this.cboestado_perfapp.Tag = "estado_papp";
            this.cboestado_perfapp.SelectedIndexChanged += new System.EventHandler(this.cboestado_usr_SelectedIndexChanged);
            // 
            // txtimprimir
            // 
            this.txtimprimir.Location = new System.Drawing.Point(255, 413);
            this.txtimprimir.Name = "txtimprimir";
            this.txtimprimir.Size = new System.Drawing.Size(141, 20);
            this.txtimprimir.TabIndex = 23;
            this.txtimprimir.Tag = "imprimir_papp";
            // 
            // txtdelete
            // 
            this.txtdelete.Location = new System.Drawing.Point(255, 385);
            this.txtdelete.Name = "txtdelete";
            this.txtdelete.Size = new System.Drawing.Size(141, 20);
            this.txtdelete.TabIndex = 22;
            this.txtdelete.Tag = "delete_papp";
            // 
            // txtupdate
            // 
            this.txtupdate.Location = new System.Drawing.Point(255, 358);
            this.txtupdate.Name = "txtupdate";
            this.txtupdate.Size = new System.Drawing.Size(141, 20);
            this.txtupdate.TabIndex = 21;
            this.txtupdate.Tag = "update_papp";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.Black;
            this.lblestado.Location = new System.Drawing.Point(83, 455);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(92, 15);
            this.lblestado.TabIndex = 93;
            this.lblestado.Tag = "estado_usr";
            this.lblestado.Text = "Estado usuario:";
            // 
            // lblimprimir
            // 
            this.lblimprimir.AutoSize = true;
            this.lblimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimprimir.ForeColor = System.Drawing.Color.Black;
            this.lblimprimir.Location = new System.Drawing.Point(83, 413);
            this.lblimprimir.Name = "lblimprimir";
            this.lblimprimir.Size = new System.Drawing.Size(50, 15);
            this.lblimprimir.TabIndex = 91;
            this.lblimprimir.Text = "Imprmir";
            // 
            // lbldelete
            // 
            this.lbldelete.AutoSize = true;
            this.lbldelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldelete.ForeColor = System.Drawing.Color.Black;
            this.lbldelete.Location = new System.Drawing.Point(83, 386);
            this.lbldelete.Name = "lbldelete";
            this.lbldelete.Size = new System.Drawing.Size(43, 15);
            this.lbldelete.TabIndex = 90;
            this.lbldelete.Text = "Delete";
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblupdate.ForeColor = System.Drawing.Color.Black;
            this.lblupdate.Location = new System.Drawing.Point(83, 359);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(47, 15);
            this.lblupdate.TabIndex = 89;
            this.lblupdate.Text = "Update";
            // 
            // txtinsert
            // 
            this.txtinsert.Location = new System.Drawing.Point(255, 329);
            this.txtinsert.Name = "txtinsert";
            this.txtinsert.Size = new System.Drawing.Size(141, 20);
            this.txtinsert.TabIndex = 20;
            this.txtinsert.Tag = "insert_paap";
            this.txtinsert.UseSystemPasswordChar = true;
            // 
            // lblinsert
            // 
            this.lblinsert.AutoSize = true;
            this.lblinsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinsert.ForeColor = System.Drawing.Color.Black;
            this.lblinsert.Location = new System.Drawing.Point(83, 330);
            this.lblinsert.Name = "lblinsert";
            this.lblinsert.Size = new System.Drawing.Size(37, 15);
            this.lblinsert.TabIndex = 87;
            this.lblinsert.Tag = "lblpass_usr";
            this.lblinsert.Text = "Insert";
            // 
            // txtselect
            // 
            this.txtselect.Location = new System.Drawing.Point(255, 303);
            this.txtselect.Name = "txtselect";
            this.txtselect.Size = new System.Drawing.Size(141, 20);
            this.txtselect.TabIndex = 19;
            this.txtselect.Tag = "select_papp";
            // 
            // cbocod_app
            // 
            this.cbocod_app.FormattingEnabled = true;
            this.cbocod_app.Location = new System.Drawing.Point(255, 232);
            this.cbocod_app.Name = "cbocod_app";
            this.cbocod_app.Size = new System.Drawing.Size(82, 21);
            this.cbocod_app.TabIndex = 15;
            this.cbocod_app.Tag = "cod_app";
            // 
            // cbocod_perfil
            // 
            this.cbocod_perfil.FormattingEnabled = true;
            this.cbocod_perfil.Location = new System.Drawing.Point(255, 205);
            this.cbocod_perfil.Name = "cbocod_perfil";
            this.cbocod_perfil.Size = new System.Drawing.Size(82, 21);
            this.cbocod_perfil.TabIndex = 14;
            this.cbocod_perfil.Tag = "cod_pfl";
            // 
            // txtfechcreac_perfapp
            // 
            this.txtfechcreac_perfapp.Enabled = false;
            this.txtfechcreac_perfapp.Location = new System.Drawing.Point(255, 274);
            this.txtfechcreac_perfapp.Name = "txtfechcreac_perfapp";
            this.txtfechcreac_perfapp.Size = new System.Drawing.Size(141, 20);
            this.txtfechcreac_perfapp.TabIndex = 18;
            this.txtfechcreac_perfapp.Tag = "fechcreado_papp";
            // 
            // txtcod_app
            // 
            this.txtcod_app.Location = new System.Drawing.Point(343, 233);
            this.txtcod_app.Name = "txtcod_app";
            this.txtcod_app.Size = new System.Drawing.Size(53, 20);
            this.txtcod_app.TabIndex = 74;
            this.txtcod_app.Tag = "cod_app";
            // 
            // txtcod_perfapp
            // 
            this.txtcod_perfapp.Location = new System.Drawing.Point(255, 179);
            this.txtcod_perfapp.Name = "txtcod_perfapp";
            this.txtcod_perfapp.Size = new System.Drawing.Size(82, 20);
            this.txtcod_perfapp.TabIndex = 13;
            this.txtcod_perfapp.Tag = "cod_papp";
            this.txtcod_perfapp.TextChanged += new System.EventHandler(this.txtcod_usr_TextChanged);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselect.ForeColor = System.Drawing.Color.Black;
            this.lblselect.Location = new System.Drawing.Point(83, 304);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(41, 15);
            this.lblselect.TabIndex = 81;
            this.lblselect.Text = "Select";
            // 
            // lblfech_perfapp
            // 
            this.lblfech_perfapp.AutoSize = true;
            this.lblfech_perfapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfech_perfapp.ForeColor = System.Drawing.Color.Black;
            this.lblfech_perfapp.Location = new System.Drawing.Point(83, 278);
            this.lblfech_perfapp.Name = "lblfech_perfapp";
            this.lblfech_perfapp.Size = new System.Drawing.Size(94, 15);
            this.lblfech_perfapp.TabIndex = 79;
            this.lblfech_perfapp.Text = "Fecha creacion ";
            // 
            // lblcod_app
            // 
            this.lblcod_app.AutoSize = true;
            this.lblcod_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_app.ForeColor = System.Drawing.Color.Black;
            this.lblcod_app.Location = new System.Drawing.Point(83, 241);
            this.lblcod_app.Name = "lblcod_app";
            this.lblcod_app.Size = new System.Drawing.Size(105, 15);
            this.lblcod_app.TabIndex = 78;
            this.lblcod_app.Text = "Codigo aplicacion";
            // 
            // txtcod_perfil
            // 
            this.txtcod_perfil.Location = new System.Drawing.Point(343, 205);
            this.txtcod_perfil.Name = "txtcod_perfil";
            this.txtcod_perfil.Size = new System.Drawing.Size(53, 20);
            this.txtcod_perfil.TabIndex = 72;
            this.txtcod_perfil.Tag = "cod_pfl";
            // 
            // lblcod_perfil
            // 
            this.lblcod_perfil.AutoSize = true;
            this.lblcod_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblcod_perfil.Location = new System.Drawing.Point(83, 214);
            this.lblcod_perfil.Name = "lblcod_perfil";
            this.lblcod_perfil.Size = new System.Drawing.Size(76, 15);
            this.lblcod_perfil.TabIndex = 77;
            this.lblcod_perfil.Text = "Codigo perfil";
            // 
            // lblcod_perfapp
            // 
            this.lblcod_perfapp.AutoSize = true;
            this.lblcod_perfapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_perfapp.ForeColor = System.Drawing.Color.Black;
            this.lblcod_perfapp.Location = new System.Drawing.Point(83, 180);
            this.lblcod_perfapp.Name = "lblcod_perfapp";
            this.lblcod_perfapp.Size = new System.Drawing.Size(135, 15);
            this.lblcod_perfapp.TabIndex = 73;
            this.lblcod_perfapp.Text = "Codigo perfil aplicacion";
            // 
            // btnCodPerf
            // 
            this.btnCodPerf.Location = new System.Drawing.Point(412, 205);
            this.btnCodPerf.Name = "btnCodPerf";
            this.btnCodPerf.Size = new System.Drawing.Size(75, 23);
            this.btnCodPerf.TabIndex = 100;
            this.btnCodPerf.Text = "Agregar";
            this.btnCodPerf.UseVisualStyleBackColor = true;
            this.btnCodPerf.Click += new System.EventHandler(this.btncodemp_Click);
            // 
            // btnCodAp
            // 
            this.btnCodAp.Location = new System.Drawing.Point(412, 234);
            this.btnCodAp.Name = "btnCodAp";
            this.btnCodAp.Size = new System.Drawing.Size(75, 23);
            this.btnCodAp.TabIndex = 101;
            this.btnCodAp.Text = "Agregar";
            this.btnCodAp.UseVisualStyleBackColor = true;
            this.btnCodAp.Click += new System.EventHandler(this.btncodpriv_Click);
            // 
            // lblGestionUsuarios
            // 
            this.lblGestionUsuarios.AutoSize = true;
            this.lblGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblGestionUsuarios.Location = new System.Drawing.Point(89, 44);
            this.lblGestionUsuarios.Name = "lblGestionUsuarios";
            this.lblGestionUsuarios.Size = new System.Drawing.Size(221, 33);
            this.lblGestionUsuarios.TabIndex = 102;
            this.lblGestionUsuarios.Text = "Perfil aplicación";
            this.lblGestionUsuarios.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(412, 278);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(100, 23);
            this.btnObtener.TabIndex = 103;
            this.btnObtener.Text = "Obtener fecha";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.btnObtener_Click);
            // 
            // wftabt_SGperfilapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 557);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.lblGestionUsuarios);
            this.Controls.Add(this.btnCodAp);
            this.Controls.Add(this.btnCodPerf);
            this.Controls.Add(this.txtestado_perfapp);
            this.Controls.Add(this.cboestado_perfapp);
            this.Controls.Add(this.txtimprimir);
            this.Controls.Add(this.txtdelete);
            this.Controls.Add(this.txtupdate);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblimprimir);
            this.Controls.Add(this.lbldelete);
            this.Controls.Add(this.lblupdate);
            this.Controls.Add(this.txtinsert);
            this.Controls.Add(this.lblinsert);
            this.Controls.Add(this.txtselect);
            this.Controls.Add(this.cbocod_app);
            this.Controls.Add(this.cbocod_perfil);
            this.Controls.Add(this.txtfechcreac_perfapp);
            this.Controls.Add(this.txtcod_app);
            this.Controls.Add(this.txtcod_perfapp);
            this.Controls.Add(this.lblselect);
            this.Controls.Add(this.lblfech_perfapp);
            this.Controls.Add(this.lblcod_app);
            this.Controls.Add(this.txtcod_perfil);
            this.Controls.Add(this.lblcod_perfil);
            this.Controls.Add(this.lblcod_perfapp);
            this.Controls.Add(this.navegador1);
            this.Name = "wftabt_SGperfilapp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Usuarios";
            this.Load += new System.EventHandler(this.wfprincipalUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtestado_perfapp;
        private System.Windows.Forms.ComboBox cboestado_perfapp;
        private System.Windows.Forms.TextBox txtimprimir;
        private System.Windows.Forms.TextBox txtdelete;
        private System.Windows.Forms.TextBox txtupdate;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lblimprimir;
        private System.Windows.Forms.Label lbldelete;
        private System.Windows.Forms.Label lblupdate;
        private System.Windows.Forms.TextBox txtinsert;
        private System.Windows.Forms.Label lblinsert;
        private System.Windows.Forms.TextBox txtselect;
        private System.Windows.Forms.ComboBox cbocod_app;
        private System.Windows.Forms.ComboBox cbocod_perfil;
        private System.Windows.Forms.TextBox txtfechcreac_perfapp;
        private System.Windows.Forms.TextBox txtcod_app;
        private System.Windows.Forms.TextBox txtcod_perfapp;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.Label lblfech_perfapp;
        private System.Windows.Forms.Label lblcod_app;
        private System.Windows.Forms.TextBox txtcod_perfil;
        private System.Windows.Forms.Label lblcod_perfil;
        private System.Windows.Forms.Label lblcod_perfapp;
        private System.Windows.Forms.Button btnCodPerf;
        private System.Windows.Forms.Button btnCodAp;
        private System.Windows.Forms.Label lblGestionUsuarios;
        private System.Windows.Forms.Button btnObtener;
    }
}