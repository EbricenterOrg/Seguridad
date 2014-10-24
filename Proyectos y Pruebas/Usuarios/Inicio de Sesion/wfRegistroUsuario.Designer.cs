namespace Inicio_de_Sesion
{
    partial class wfRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfRegistroUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.btncod_preg = new System.Windows.Forms.Button();
            this.txtresp_usur = new System.Windows.Forms.TextBox();
            this.cbocod_priv = new System.Windows.Forms.ComboBox();
            this.cbocod_preg = new System.Windows.Forms.ComboBox();
            this.cbocod_emp = new System.Windows.Forms.ComboBox();
            this.txtcuenta_usr = new System.Windows.Forms.TextBox();
            this.txtcod_preg = new System.Windows.Forms.TextBox();
            this.txtcod_priv = new System.Windows.Forms.TextBox();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.txtcod_usr = new System.Windows.Forms.TextBox();
            this.lblcod_preg = new System.Windows.Forms.Label();
            this.lblresp_usur = new System.Windows.Forms.Label();
            this.lblcuenta_usr = new System.Windows.Forms.Label();
            this.lblcod_priv = new System.Windows.Forms.Label();
            this.txtcod_emp = new System.Windows.Forms.TextBox();
            this.lblcod_emp = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblcod_usr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtestado_usr);
            this.panel1.Controls.Add(this.cboestado_usr);
            this.panel1.Controls.Add(this.txtipdir_usr);
            this.panel1.Controls.Add(this.txthost_usr);
            this.panel1.Controls.Add(this.txtfechmodif_usr);
            this.panel1.Controls.Add(this.txtfechcreado_usr);
            this.panel1.Controls.Add(this.lblestado_usr);
            this.panel1.Controls.Add(this.lblipdir_usr);
            this.panel1.Controls.Add(this.lblhost_usr);
            this.panel1.Controls.Add(this.lblfechmodif_usr);
            this.panel1.Controls.Add(this.lblfechcreado_usr);
            this.panel1.Controls.Add(this.txtpass_usr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btncod_preg);
            this.panel1.Controls.Add(this.txtresp_usur);
            this.panel1.Controls.Add(this.cbocod_priv);
            this.panel1.Controls.Add(this.cbocod_preg);
            this.panel1.Controls.Add(this.cbocod_emp);
            this.panel1.Controls.Add(this.txtcuenta_usr);
            this.panel1.Controls.Add(this.txtcod_preg);
            this.panel1.Controls.Add(this.txtcod_priv);
            this.panel1.Controls.Add(this.lblNombreFormulario);
            this.panel1.Controls.Add(this.txtcod_usr);
            this.panel1.Controls.Add(this.lblcod_preg);
            this.panel1.Controls.Add(this.lblresp_usur);
            this.panel1.Controls.Add(this.lblcuenta_usr);
            this.panel1.Controls.Add(this.lblcod_priv);
            this.panel1.Controls.Add(this.txtcod_emp);
            this.panel1.Controls.Add(this.lblcod_emp);
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Controls.Add(this.lblcod_usr);
            this.panel1.Location = new System.Drawing.Point(-2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 715);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtestado_usr
            // 
            this.txtestado_usr.Location = new System.Drawing.Point(330, 456);
            this.txtestado_usr.Name = "txtestado_usr";
            this.txtestado_usr.Size = new System.Drawing.Size(100, 20);
            this.txtestado_usr.TabIndex = 70;
            this.txtestado_usr.Tag = "estado_usr";
            this.txtestado_usr.TextChanged += new System.EventHandler(this.txtestado_usr_TextChanged);
            // 
            // cboestado_usr
            // 
            this.cboestado_usr.FormattingEnabled = true;
            this.cboestado_usr.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_usr.Location = new System.Drawing.Point(173, 456);
            this.cboestado_usr.Name = "cboestado_usr";
            this.cboestado_usr.Size = new System.Drawing.Size(141, 21);
            this.cboestado_usr.TabIndex = 69;
            this.cboestado_usr.Tag = "estado_usr";
            this.cboestado_usr.SelectedIndexChanged += new System.EventHandler(this.cboestado_usr_SelectedIndexChanged);
            // 
            // txtipdir_usr
            // 
            this.txtipdir_usr.Location = new System.Drawing.Point(173, 427);
            this.txtipdir_usr.Name = "txtipdir_usr";
            this.txtipdir_usr.Size = new System.Drawing.Size(141, 20);
            this.txtipdir_usr.TabIndex = 68;
            this.txtipdir_usr.Tag = "ipdir_usr";
            // 
            // txthost_usr
            // 
            this.txthost_usr.Location = new System.Drawing.Point(173, 397);
            this.txthost_usr.Name = "txthost_usr";
            this.txthost_usr.Size = new System.Drawing.Size(141, 20);
            this.txthost_usr.TabIndex = 67;
            this.txthost_usr.Tag = "host_usr";
            // 
            // txtfechmodif_usr
            // 
            this.txtfechmodif_usr.Location = new System.Drawing.Point(173, 363);
            this.txtfechmodif_usr.Name = "txtfechmodif_usr";
            this.txtfechmodif_usr.Size = new System.Drawing.Size(141, 20);
            this.txtfechmodif_usr.TabIndex = 66;
            this.txtfechmodif_usr.Tag = "fechmodif_usr";
            // 
            // txtfechcreado_usr
            // 
            this.txtfechcreado_usr.Location = new System.Drawing.Point(173, 337);
            this.txtfechcreado_usr.Name = "txtfechcreado_usr";
            this.txtfechcreado_usr.Size = new System.Drawing.Size(141, 20);
            this.txtfechcreado_usr.TabIndex = 65;
            this.txtfechcreado_usr.Tag = "fechcreado_usr";
            // 
            // lblestado_usr
            // 
            this.lblestado_usr.AutoSize = true;
            this.lblestado_usr.Location = new System.Drawing.Point(37, 456);
            this.lblestado_usr.Name = "lblestado_usr";
            this.lblestado_usr.Size = new System.Drawing.Size(80, 13);
            this.lblestado_usr.TabIndex = 64;
            this.lblestado_usr.Tag = "estado_usr";
            this.lblestado_usr.Text = "Estado usuario:";
            // 
            // lblipdir_usr
            // 
            this.lblipdir_usr.AutoSize = true;
            this.lblipdir_usr.Location = new System.Drawing.Point(37, 427);
            this.lblipdir_usr.Name = "lblipdir_usr";
            this.lblipdir_usr.Size = new System.Drawing.Size(65, 13);
            this.lblipdir_usr.TabIndex = 63;
            this.lblipdir_usr.Tag = "ipdir_usr";
            this.lblipdir_usr.Text = "Direccion IP";
            // 
            // lblhost_usr
            // 
            this.lblhost_usr.AutoSize = true;
            this.lblhost_usr.Location = new System.Drawing.Point(37, 397);
            this.lblhost_usr.Name = "lblhost_usr";
            this.lblhost_usr.Size = new System.Drawing.Size(116, 13);
            this.lblhost_usr.TabIndex = 62;
            this.lblhost_usr.Text = "Nombre de la maquina:";
            // 
            // lblfechmodif_usr
            // 
            this.lblfechmodif_usr.AutoSize = true;
            this.lblfechmodif_usr.Location = new System.Drawing.Point(37, 369);
            this.lblfechmodif_usr.Name = "lblfechmodif_usr";
            this.lblfechmodif_usr.Size = new System.Drawing.Size(94, 13);
            this.lblfechmodif_usr.TabIndex = 61;
            this.lblfechmodif_usr.Text = "Fecha modificado:";
            // 
            // lblfechcreado_usr
            // 
            this.lblfechcreado_usr.AutoSize = true;
            this.lblfechcreado_usr.Location = new System.Drawing.Point(37, 344);
            this.lblfechcreado_usr.Name = "lblfechcreado_usr";
            this.lblfechcreado_usr.Size = new System.Drawing.Size(77, 13);
            this.lblfechcreado_usr.TabIndex = 60;
            this.lblfechcreado_usr.Text = "Fecha Creado:";
            // 
            // txtpass_usr
            // 
            this.txtpass_usr.Location = new System.Drawing.Point(173, 306);
            this.txtpass_usr.Name = "txtpass_usr";
            this.txtpass_usr.Size = new System.Drawing.Size(141, 20);
            this.txtpass_usr.TabIndex = 59;
            this.txtpass_usr.Tag = "pass_usr";
            this.txtpass_usr.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 58;
            this.label1.Tag = "lblpass_usr";
            this.label1.Text = "Contraseña:";
            // 
            // btncod_preg
            // 
            this.btncod_preg.Location = new System.Drawing.Point(330, 216);
            this.btncod_preg.Name = "btncod_preg";
            this.btncod_preg.Size = new System.Drawing.Size(131, 23);
            this.btncod_preg.TabIndex = 57;
            this.btncod_preg.Text = "Seleccionar Pregunta";
            this.btncod_preg.UseVisualStyleBackColor = true;
            this.btncod_preg.Click += new System.EventHandler(this.btncod_preg_Click);
            // 
            // txtresp_usur
            // 
            this.txtresp_usur.Location = new System.Drawing.Point(173, 279);
            this.txtresp_usur.Name = "txtresp_usur";
            this.txtresp_usur.Size = new System.Drawing.Size(141, 20);
            this.txtresp_usur.TabIndex = 56;
            this.txtresp_usur.Tag = "resp_usur";
            // 
            // cbocod_priv
            // 
            this.cbocod_priv.FormattingEnabled = true;
            this.cbocod_priv.Location = new System.Drawing.Point(173, 185);
            this.cbocod_priv.Name = "cbocod_priv";
            this.cbocod_priv.Size = new System.Drawing.Size(82, 21);
            this.cbocod_priv.TabIndex = 55;
            this.cbocod_priv.Tag = "cod_priv";
            this.cbocod_priv.SelectedIndexChanged += new System.EventHandler(this.cbocod_priv_SelectedIndexChanged);
            // 
            // cbocod_preg
            // 
            this.cbocod_preg.FormattingEnabled = true;
            this.cbocod_preg.Location = new System.Drawing.Point(173, 215);
            this.cbocod_preg.Name = "cbocod_preg";
            this.cbocod_preg.Size = new System.Drawing.Size(82, 21);
            this.cbocod_preg.TabIndex = 54;
            this.cbocod_preg.SelectedIndexChanged += new System.EventHandler(this.cbocod_preg_SelectedIndexChanged);
            // 
            // cbocod_emp
            // 
            this.cbocod_emp.FormattingEnabled = true;
            this.cbocod_emp.Location = new System.Drawing.Point(173, 158);
            this.cbocod_emp.Name = "cbocod_emp";
            this.cbocod_emp.Size = new System.Drawing.Size(82, 21);
            this.cbocod_emp.TabIndex = 53;
            this.cbocod_emp.Tag = "cod_emp";
            this.cbocod_emp.SelectedIndexChanged += new System.EventHandler(this.cbocod_emp_SelectedIndexChanged);
            // 
            // txtcuenta_usr
            // 
            this.txtcuenta_usr.Location = new System.Drawing.Point(173, 250);
            this.txtcuenta_usr.Name = "txtcuenta_usr";
            this.txtcuenta_usr.Size = new System.Drawing.Size(141, 20);
            this.txtcuenta_usr.TabIndex = 17;
            this.txtcuenta_usr.Tag = "cuenta_usr";
            this.txtcuenta_usr.TextChanged += new System.EventHandler(this.txt14_TextChanged);
            // 
            // txtcod_preg
            // 
            this.txtcod_preg.Location = new System.Drawing.Point(261, 216);
            this.txtcod_preg.Name = "txtcod_preg";
            this.txtcod_preg.Size = new System.Drawing.Size(53, 20);
            this.txtcod_preg.TabIndex = 16;
            this.txtcod_preg.Tag = "cod_preg";
            this.txtcod_preg.Visible = false;
            this.txtcod_preg.TextChanged += new System.EventHandler(this.txt13_TextChanged);
            // 
            // txtcod_priv
            // 
            this.txtcod_priv.Location = new System.Drawing.Point(261, 186);
            this.txtcod_priv.Name = "txtcod_priv";
            this.txtcod_priv.Size = new System.Drawing.Size(53, 20);
            this.txtcod_priv.TabIndex = 14;
            this.txtcod_priv.Tag = "cod_priv";
            this.txtcod_priv.Visible = false;
            this.txtcod_priv.TextChanged += new System.EventHandler(this.txt11_TextChanged);
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.AutoSize = true;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFormulario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreFormulario.Location = new System.Drawing.Point(22, 12);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(249, 31);
            this.lblNombreFormulario.TabIndex = 52;
            this.lblNombreFormulario.Text = "Registro de usuario";
            // 
            // txtcod_usr
            // 
            this.txtcod_usr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_usr.Location = new System.Drawing.Point(173, 132);
            this.txtcod_usr.Name = "txtcod_usr";
            this.txtcod_usr.Size = new System.Drawing.Size(82, 20);
            this.txtcod_usr.TabIndex = 12;
            this.txtcod_usr.Tag = "cod_usr";
            this.txtcod_usr.TextChanged += new System.EventHandler(this.txtCodperfil_TextChanged);
            // 
            // lblcod_preg
            // 
            this.lblcod_preg.AutoSize = true;
            this.lblcod_preg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_preg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcod_preg.Location = new System.Drawing.Point(34, 223);
            this.lblcod_preg.Name = "lblcod_preg";
            this.lblcod_preg.Size = new System.Drawing.Size(88, 13);
            this.lblcod_preg.TabIndex = 38;
            this.lblcod_preg.Text = "Codigo pregunta:";
            // 
            // lblresp_usur
            // 
            this.lblresp_usur.AutoSize = true;
            this.lblresp_usur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresp_usur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblresp_usur.Location = new System.Drawing.Point(34, 279);
            this.lblresp_usur.Name = "lblresp_usur";
            this.lblresp_usur.Size = new System.Drawing.Size(106, 13);
            this.lblresp_usur.TabIndex = 40;
            this.lblresp_usur.Text = "Respuesta pregunta:";
            // 
            // lblcuenta_usr
            // 
            this.lblcuenta_usr.AutoSize = true;
            this.lblcuenta_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcuenta_usr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcuenta_usr.Location = new System.Drawing.Point(34, 253);
            this.lblcuenta_usr.Name = "lblcuenta_usr";
            this.lblcuenta_usr.Size = new System.Drawing.Size(132, 13);
            this.lblcuenta_usr.TabIndex = 36;
            this.lblcuenta_usr.Text = "Nombre de cuenta usuario";
            this.lblcuenta_usr.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblcod_priv
            // 
            this.lblcod_priv.AutoSize = true;
            this.lblcod_priv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_priv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcod_priv.Location = new System.Drawing.Point(34, 193);
            this.lblcod_priv.Name = "lblcod_priv";
            this.lblcod_priv.Size = new System.Drawing.Size(85, 13);
            this.lblcod_priv.TabIndex = 34;
            this.lblcod_priv.Text = "Codigo Privilegio";
            this.lblcod_priv.Click += new System.EventHandler(this.lblFechacreacionperfil_Click);
            // 
            // txtcod_emp
            // 
            this.txtcod_emp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcod_emp.Location = new System.Drawing.Point(261, 158);
            this.txtcod_emp.Name = "txtcod_emp";
            this.txtcod_emp.Size = new System.Drawing.Size(53, 20);
            this.txtcod_emp.TabIndex = 13;
            this.txtcod_emp.Tag = "cod_emp";
            this.txtcod_emp.Visible = false;
            this.txtcod_emp.TextChanged += new System.EventHandler(this.txtcod_emp_TextChanged);
            // 
            // lblcod_emp
            // 
            this.lblcod_emp.AutoSize = true;
            this.lblcod_emp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_emp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcod_emp.Location = new System.Drawing.Point(34, 166);
            this.lblcod_emp.Name = "lblcod_emp";
            this.lblcod_emp.Size = new System.Drawing.Size(92, 13);
            this.lblcod_emp.TabIndex = 32;
            this.lblcod_emp.Text = "Codigo empleado:";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(28, 46);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = " tabm_sgusuario";
            this.navegador1.TabIndex = 1;
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.textBox9_TextChanged);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblcod_usr
            // 
            this.lblcod_usr.AutoSize = true;
            this.lblcod_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_usr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblcod_usr.Location = new System.Drawing.Point(34, 139);
            this.lblcod_usr.Name = "lblcod_usr";
            this.lblcod_usr.Size = new System.Drawing.Size(79, 13);
            this.lblcod_usr.TabIndex = 14;
            this.lblcod_usr.Text = "Codigo Usuario";
            // 
            // wfRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(767, 552);
            this.Controls.Add(this.panel1);
            this.Name = "wfRegistroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de usuarios";
            this.Load += new System.EventHandler(this.wfFormularioUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcod_usr;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtcod_emp;
        private System.Windows.Forms.Label lblcod_emp;
        private System.Windows.Forms.Label lblcuenta_usr;
        private System.Windows.Forms.Label lblcod_priv;
        private System.Windows.Forms.Label lblresp_usur;
        private System.Windows.Forms.Label lblcod_preg;
        private System.Windows.Forms.TextBox txtcod_usr;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.TextBox txtcuenta_usr;
        private System.Windows.Forms.TextBox txtcod_preg;
        private System.Windows.Forms.TextBox txtcod_priv;
        private System.Windows.Forms.ComboBox cbocod_preg;
        private System.Windows.Forms.ComboBox cbocod_emp;
        private System.Windows.Forms.ComboBox cbocod_priv;
        private System.Windows.Forms.TextBox txtpass_usr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncod_preg;
        private System.Windows.Forms.TextBox txtresp_usur;
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

    }
}