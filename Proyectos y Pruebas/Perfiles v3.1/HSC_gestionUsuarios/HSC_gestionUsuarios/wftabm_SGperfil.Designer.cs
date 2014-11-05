namespace HSC_gestionPerfiles
{
    partial class wftabm_SGperfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabm_SGperfil));
            this.txtestado_perfil = new System.Windows.Forms.TextBox();
            this.cboestado_perfil = new System.Windows.Forms.ComboBox();
            this.txtnom_perfil = new System.Windows.Forms.TextBox();
            this.txtcod_perfil = new System.Windows.Forms.TextBox();
            this.lblestado_perfil = new System.Windows.Forms.Label();
            this.lblnom_perfil = new System.Windows.Forms.Label();
            this.lblcod_perfil = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblpregunta_secreta = new System.Windows.Forms.Label();
            this.lblfechcreado_perfil = new System.Windows.Forms.Label();
            this.txtFechCreacion = new System.Windows.Forms.TextBox();
            this.txtFechModif = new System.Windows.Forms.TextBox();
            this.lblfechmodif_perfil = new System.Windows.Forms.Label();
            this.txtPerfilTecnico = new System.Windows.Forms.TextBox();
            this.lblperfiltecnico = new System.Windows.Forms.Label();
            this.btnObtenerFechas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtestado_perfil
            // 
            this.txtestado_perfil.Location = new System.Drawing.Point(320, 345);
            this.txtestado_perfil.Name = "txtestado_perfil";
            this.txtestado_perfil.Size = new System.Drawing.Size(123, 20);
            this.txtestado_perfil.TabIndex = 39;
            this.txtestado_perfil.Tag = "estado_pfl";
            this.txtestado_perfil.Visible = false;
            this.txtestado_perfil.TextChanged += new System.EventHandler(this.txtestado_preg_TextChanged);
            // 
            // cboestado_perfil
            // 
            this.cboestado_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado_perfil.FormattingEnabled = true;
            this.cboestado_perfil.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_perfil.Location = new System.Drawing.Point(141, 347);
            this.cboestado_perfil.Name = "cboestado_perfil";
            this.cboestado_perfil.Size = new System.Drawing.Size(173, 21);
            this.cboestado_perfil.TabIndex = 38;
            this.cboestado_perfil.Tag = "";
            this.cboestado_perfil.SelectedIndexChanged += new System.EventHandler(this.cboestado_preg_SelectedIndexChanged);
            // 
            // txtnom_perfil
            // 
            this.txtnom_perfil.Location = new System.Drawing.Point(141, 219);
            this.txtnom_perfil.Name = "txtnom_perfil";
            this.txtnom_perfil.Size = new System.Drawing.Size(173, 20);
            this.txtnom_perfil.TabIndex = 36;
            this.txtnom_perfil.Tag = "nom_pfl";
            this.txtnom_perfil.TextChanged += new System.EventHandler(this.txtnom_preg_TextChanged);
            // 
            // txtcod_perfil
            // 
            this.txtcod_perfil.Location = new System.Drawing.Point(141, 176);
            this.txtcod_perfil.Name = "txtcod_perfil";
            this.txtcod_perfil.Size = new System.Drawing.Size(173, 20);
            this.txtcod_perfil.TabIndex = 35;
            this.txtcod_perfil.Tag = "cod_pfl";
            this.txtcod_perfil.TextChanged += new System.EventHandler(this.txtcod_preg_TextChanged);
            // 
            // lblestado_perfil
            // 
            this.lblestado_perfil.AutoSize = true;
            this.lblestado_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblestado_perfil.Location = new System.Drawing.Point(20, 347);
            this.lblestado_perfil.Name = "lblestado_perfil";
            this.lblestado_perfil.Size = new System.Drawing.Size(75, 15);
            this.lblestado_perfil.TabIndex = 34;
            this.lblestado_perfil.Text = "Estado perfil";
            // 
            // lblnom_perfil
            // 
            this.lblnom_perfil.AutoSize = true;
            this.lblnom_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblnom_perfil.Location = new System.Drawing.Point(20, 219);
            this.lblnom_perfil.Name = "lblnom_perfil";
            this.lblnom_perfil.Size = new System.Drawing.Size(82, 15);
            this.lblnom_perfil.TabIndex = 33;
            this.lblnom_perfil.Text = "Nombre perfil";
            // 
            // lblcod_perfil
            // 
            this.lblcod_perfil.AutoSize = true;
            this.lblcod_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblcod_perfil.Location = new System.Drawing.Point(20, 180);
            this.lblcod_perfil.Name = "lblcod_perfil";
            this.lblcod_perfil.Size = new System.Drawing.Size(77, 15);
            this.lblcod_perfil.TabIndex = 32;
            this.lblcod_perfil.Text = "Codigo Perfil";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(36, 56);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_sgperfil";
            this.navegador1.TabIndex = 40;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // lblpregunta_secreta
            // 
            this.lblpregunta_secreta.AutoSize = true;
            this.lblpregunta_secreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregunta_secreta.ForeColor = System.Drawing.Color.Black;
            this.lblpregunta_secreta.Location = new System.Drawing.Point(17, 20);
            this.lblpregunta_secreta.Name = "lblpregunta_secreta";
            this.lblpregunta_secreta.Size = new System.Drawing.Size(82, 33);
            this.lblpregunta_secreta.TabIndex = 104;
            this.lblpregunta_secreta.Text = "Perfil";
            // 
            // lblfechcreado_perfil
            // 
            this.lblfechcreado_perfil.AutoSize = true;
            this.lblfechcreado_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechcreado_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblfechcreado_perfil.Location = new System.Drawing.Point(20, 265);
            this.lblfechcreado_perfil.Name = "lblfechcreado_perfil";
            this.lblfechcreado_perfil.Size = new System.Drawing.Size(91, 15);
            this.lblfechcreado_perfil.TabIndex = 105;
            this.lblfechcreado_perfil.Text = "Fecha creacion";
            // 
            // txtFechCreacion
            // 
            this.txtFechCreacion.Enabled = false;
            this.txtFechCreacion.Location = new System.Drawing.Point(141, 260);
            this.txtFechCreacion.Name = "txtFechCreacion";
            this.txtFechCreacion.Size = new System.Drawing.Size(173, 20);
            this.txtFechCreacion.TabIndex = 106;
            this.txtFechCreacion.Tag = "fechcreado_pfl";
            // 
            // txtFechModif
            // 
            this.txtFechModif.Enabled = false;
            this.txtFechModif.Location = new System.Drawing.Point(141, 291);
            this.txtFechModif.Name = "txtFechModif";
            this.txtFechModif.Size = new System.Drawing.Size(173, 20);
            this.txtFechModif.TabIndex = 108;
            this.txtFechModif.Tag = "fechmodif_pfl";
            // 
            // lblfechmodif_perfil
            // 
            this.lblfechmodif_perfil.AutoSize = true;
            this.lblfechmodif_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechmodif_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblfechmodif_perfil.Location = new System.Drawing.Point(21, 292);
            this.lblfechmodif_perfil.Name = "lblfechmodif_perfil";
            this.lblfechmodif_perfil.Size = new System.Drawing.Size(114, 15);
            this.lblfechmodif_perfil.TabIndex = 107;
            this.lblfechmodif_perfil.Text = "Fecha modificacion";
            this.lblfechmodif_perfil.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPerfilTecnico
            // 
            this.txtPerfilTecnico.Location = new System.Drawing.Point(141, 318);
            this.txtPerfilTecnico.Name = "txtPerfilTecnico";
            this.txtPerfilTecnico.Size = new System.Drawing.Size(173, 20);
            this.txtPerfilTecnico.TabIndex = 110;
            this.txtPerfilTecnico.Tag = "perte_pfl";
            // 
            // lblperfiltecnico
            // 
            this.lblperfiltecnico.AutoSize = true;
            this.lblperfiltecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperfiltecnico.ForeColor = System.Drawing.Color.Black;
            this.lblperfiltecnico.Location = new System.Drawing.Point(20, 323);
            this.lblperfiltecnico.Name = "lblperfiltecnico";
            this.lblperfiltecnico.Size = new System.Drawing.Size(77, 15);
            this.lblperfiltecnico.TabIndex = 109;
            this.lblperfiltecnico.Text = "Perfil tecnico";
            // 
            // btnObtenerFechas
            // 
            this.btnObtenerFechas.Location = new System.Drawing.Point(346, 265);
            this.btnObtenerFechas.Name = "btnObtenerFechas";
            this.btnObtenerFechas.Size = new System.Drawing.Size(97, 23);
            this.btnObtenerFechas.TabIndex = 111;
            this.btnObtenerFechas.Text = "Obtener fechas";
            this.btnObtenerFechas.UseVisualStyleBackColor = true;
            this.btnObtenerFechas.Click += new System.EventHandler(this.btnObtenerFechas_Click);
            // 
            // wftabm_SGperfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(683, 413);
            this.Controls.Add(this.btnObtenerFechas);
            this.Controls.Add(this.txtPerfilTecnico);
            this.Controls.Add(this.lblperfiltecnico);
            this.Controls.Add(this.txtFechModif);
            this.Controls.Add(this.lblfechmodif_perfil);
            this.Controls.Add(this.txtFechCreacion);
            this.Controls.Add(this.lblfechcreado_perfil);
            this.Controls.Add(this.lblpregunta_secreta);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtestado_perfil);
            this.Controls.Add(this.cboestado_perfil);
            this.Controls.Add(this.txtnom_perfil);
            this.Controls.Add(this.txtcod_perfil);
            this.Controls.Add(this.lblestado_perfil);
            this.Controls.Add(this.lblnom_perfil);
            this.Controls.Add(this.lblcod_perfil);
            this.Name = "wftabm_SGperfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta secreta";
            this.Load += new System.EventHandler(this.wftabm_SGpregunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtestado_perfil;
        private System.Windows.Forms.ComboBox cboestado_perfil;
        private System.Windows.Forms.TextBox txtnom_perfil;
        private System.Windows.Forms.TextBox txtcod_perfil;
        private System.Windows.Forms.Label lblestado_perfil;
        private System.Windows.Forms.Label lblnom_perfil;
        private System.Windows.Forms.Label lblcod_perfil;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblpregunta_secreta;
        private System.Windows.Forms.Label lblfechcreado_perfil;
        private System.Windows.Forms.TextBox txtFechCreacion;
        private System.Windows.Forms.TextBox txtFechModif;
        private System.Windows.Forms.Label lblfechmodif_perfil;
        private System.Windows.Forms.TextBox txtPerfilTecnico;
        private System.Windows.Forms.Label lblperfiltecnico;
        private System.Windows.Forms.Button btnObtenerFechas;
    }
}