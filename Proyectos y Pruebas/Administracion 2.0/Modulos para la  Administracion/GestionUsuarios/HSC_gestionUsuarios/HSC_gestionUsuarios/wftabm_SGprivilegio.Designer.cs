namespace HSC_gestionUsuarios
{
    partial class wftabm_SGprivilegio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabm_SGprivilegio));
            this.lblgestion_privilegios = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblcod_priv = new System.Windows.Forms.Label();
            this.lblnom_priv = new System.Windows.Forms.Label();
            this.lblfech_cre = new System.Windows.Forms.Label();
            this.lblfech_modif = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtcod_priv = new System.Windows.Forms.TextBox();
            this.txtnom_priv = new System.Windows.Forms.TextBox();
            this.txtfechcreado_privi = new System.Windows.Forms.TextBox();
            this.txtfechmodif_privi = new System.Windows.Forms.TextBox();
            this.cboestado_priv = new System.Windows.Forms.ComboBox();
            this.txtestado_priv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblgestion_privilegios
            // 
            this.lblgestion_privilegios.AutoSize = true;
            this.lblgestion_privilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion_privilegios.ForeColor = System.Drawing.Color.Black;
            this.lblgestion_privilegios.Location = new System.Drawing.Point(63, 27);
            this.lblgestion_privilegios.Name = "lblgestion_privilegios";
            this.lblgestion_privilegios.Size = new System.Drawing.Size(296, 33);
            this.lblgestion_privilegios.TabIndex = 103;
            this.lblgestion_privilegios.Text = "Gestión de privilegios";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(69, 74);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_sgprivilegio";
            this.navegador1.TabIndex = 104;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            // 
            // lblcod_priv
            // 
            this.lblcod_priv.AutoSize = true;
            this.lblcod_priv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_priv.ForeColor = System.Drawing.Color.Black;
            this.lblcod_priv.Location = new System.Drawing.Point(82, 158);
            this.lblcod_priv.Name = "lblcod_priv";
            this.lblcod_priv.Size = new System.Drawing.Size(101, 15);
            this.lblcod_priv.TabIndex = 105;
            this.lblcod_priv.Text = "Codigo privilegio:";
            // 
            // lblnom_priv
            // 
            this.lblnom_priv.AutoSize = true;
            this.lblnom_priv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom_priv.ForeColor = System.Drawing.Color.Black;
            this.lblnom_priv.Location = new System.Drawing.Point(82, 189);
            this.lblnom_priv.Name = "lblnom_priv";
            this.lblnom_priv.Size = new System.Drawing.Size(107, 15);
            this.lblnom_priv.TabIndex = 106;
            this.lblnom_priv.Text = "Nombre privilegio:";
            // 
            // lblfech_cre
            // 
            this.lblfech_cre.AutoSize = true;
            this.lblfech_cre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfech_cre.ForeColor = System.Drawing.Color.Black;
            this.lblfech_cre.Location = new System.Drawing.Point(85, 218);
            this.lblfech_cre.Name = "lblfech_cre";
            this.lblfech_cre.Size = new System.Drawing.Size(85, 15);
            this.lblfech_cre.TabIndex = 107;
            this.lblfech_cre.Text = "Fecha creado:";
            // 
            // lblfech_modif
            // 
            this.lblfech_modif.AutoSize = true;
            this.lblfech_modif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfech_modif.ForeColor = System.Drawing.Color.Black;
            this.lblfech_modif.Location = new System.Drawing.Point(85, 253);
            this.lblfech_modif.Name = "lblfech_modif";
            this.lblfech_modif.Size = new System.Drawing.Size(108, 15);
            this.lblfech_modif.TabIndex = 108;
            this.lblfech_modif.Text = "Fecha modificado:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.ForeColor = System.Drawing.Color.Black;
            this.lblestado.Location = new System.Drawing.Point(85, 282);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(48, 15);
            this.lblestado.TabIndex = 109;
            this.lblestado.Text = "Estado:";
            // 
            // txtcod_priv
            // 
            this.txtcod_priv.Enabled = false;
            this.txtcod_priv.Location = new System.Drawing.Point(218, 153);
            this.txtcod_priv.Name = "txtcod_priv";
            this.txtcod_priv.Size = new System.Drawing.Size(60, 20);
            this.txtcod_priv.TabIndex = 110;
            this.txtcod_priv.Tag = "cod_priv";
            this.txtcod_priv.TextChanged += new System.EventHandler(this.txtcod_priv_TextChanged);
            // 
            // txtnom_priv
            // 
            this.txtnom_priv.Enabled = false;
            this.txtnom_priv.Location = new System.Drawing.Point(218, 185);
            this.txtnom_priv.Name = "txtnom_priv";
            this.txtnom_priv.Size = new System.Drawing.Size(203, 20);
            this.txtnom_priv.TabIndex = 111;
            this.txtnom_priv.Tag = "nom_priv";
            // 
            // txtfechcreado_privi
            // 
            this.txtfechcreado_privi.Enabled = false;
            this.txtfechcreado_privi.Location = new System.Drawing.Point(218, 218);
            this.txtfechcreado_privi.Name = "txtfechcreado_privi";
            this.txtfechcreado_privi.Size = new System.Drawing.Size(141, 20);
            this.txtfechcreado_privi.TabIndex = 112;
            this.txtfechcreado_privi.Tag = "fechcreado_privi";
            // 
            // txtfechmodif_privi
            // 
            this.txtfechmodif_privi.Enabled = false;
            this.txtfechmodif_privi.Location = new System.Drawing.Point(218, 253);
            this.txtfechmodif_privi.Name = "txtfechmodif_privi";
            this.txtfechmodif_privi.Size = new System.Drawing.Size(141, 20);
            this.txtfechmodif_privi.TabIndex = 113;
            this.txtfechmodif_privi.Tag = "fechmodif_privi";
            // 
            // cboestado_priv
            // 
            this.cboestado_priv.Enabled = false;
            this.cboestado_priv.FormattingEnabled = true;
            this.cboestado_priv.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_priv.Location = new System.Drawing.Point(218, 282);
            this.cboestado_priv.Name = "cboestado_priv";
            this.cboestado_priv.Size = new System.Drawing.Size(141, 21);
            this.cboestado_priv.TabIndex = 114;
            this.cboestado_priv.Tag = "estado_priv";
            this.cboestado_priv.SelectedIndexChanged += new System.EventHandler(this.cboestado_priv_SelectedIndexChanged);
            // 
            // txtestado_priv
            // 
            this.txtestado_priv.Enabled = false;
            this.txtestado_priv.Location = new System.Drawing.Point(376, 282);
            this.txtestado_priv.Name = "txtestado_priv";
            this.txtestado_priv.Size = new System.Drawing.Size(100, 20);
            this.txtestado_priv.TabIndex = 115;
            this.txtestado_priv.Tag = "estado_priv";
            this.txtestado_priv.TextChanged += new System.EventHandler(this.txtestado_priv_TextChanged);
            // 
            // wftabm_SGprivilegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 354);
            this.Controls.Add(this.txtestado_priv);
            this.Controls.Add(this.cboestado_priv);
            this.Controls.Add(this.txtfechmodif_privi);
            this.Controls.Add(this.txtfechcreado_privi);
            this.Controls.Add(this.txtnom_priv);
            this.Controls.Add(this.txtcod_priv);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.lblfech_modif);
            this.Controls.Add(this.lblfech_cre);
            this.Controls.Add(this.lblnom_priv);
            this.Controls.Add(this.lblcod_priv);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblgestion_privilegios);
            this.Name = "wftabm_SGprivilegio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privilegio usuario";
            this.Load += new System.EventHandler(this.wftabm_SGprivilegio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgestion_privilegios;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblcod_priv;
        private System.Windows.Forms.Label lblnom_priv;
        private System.Windows.Forms.Label lblfech_cre;
        private System.Windows.Forms.Label lblfech_modif;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtcod_priv;
        private System.Windows.Forms.TextBox txtnom_priv;
        private System.Windows.Forms.TextBox txtfechcreado_privi;
        private System.Windows.Forms.TextBox txtfechmodif_privi;
        private System.Windows.Forms.ComboBox cboestado_priv;
        private System.Windows.Forms.TextBox txtestado_priv;
    }
}