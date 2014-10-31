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
            this.label2 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcod_priv = new System.Windows.Forms.TextBox();
            this.txtnom_priv = new System.Windows.Forms.TextBox();
            this.txtfechcreado_privi = new System.Windows.Forms.TextBox();
            this.txtfechmodif_privi = new System.Windows.Forms.TextBox();
            this.cboestado_priv = new System.Windows.Forms.ComboBox();
            this.txtestado_priv = new System.Windows.Forms.TextBox();
            this.btnObtenerFechas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 33);
            this.label2.TabIndex = 103;
            this.label2.Text = "Gestión de privilegios";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(69, 74);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_SGprivilegio";
            this.navegador1.TabIndex = 104;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 105;
            this.label1.Text = "Codigo privilegio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 106;
            this.label3.Text = "Nombre privilegio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Fecha creado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 108;
            this.label5.Text = "Fecha modificado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(85, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 109;
            this.label6.Text = "Estado:";
            // 
            // txtcod_priv
            // 
            this.txtcod_priv.Location = new System.Drawing.Point(218, 153);
            this.txtcod_priv.Name = "txtcod_priv";
            this.txtcod_priv.Size = new System.Drawing.Size(60, 20);
            this.txtcod_priv.TabIndex = 110;
            this.txtcod_priv.Tag = "cod_priv";
            this.txtcod_priv.TextChanged += new System.EventHandler(this.txtcod_priv_TextChanged);
            // 
            // txtnom_priv
            // 
            this.txtnom_priv.Location = new System.Drawing.Point(218, 185);
            this.txtnom_priv.Name = "txtnom_priv";
            this.txtnom_priv.Size = new System.Drawing.Size(203, 20);
            this.txtnom_priv.TabIndex = 111;
            this.txtnom_priv.Tag = "nom_priv";
            // 
            // txtfechcreado_privi
            // 
            this.txtfechcreado_privi.Location = new System.Drawing.Point(218, 218);
            this.txtfechcreado_privi.Name = "txtfechcreado_privi";
            this.txtfechcreado_privi.Size = new System.Drawing.Size(141, 20);
            this.txtfechcreado_privi.TabIndex = 112;
            this.txtfechcreado_privi.Tag = "fechcreado_privi";
            // 
            // txtfechmodif_privi
            // 
            this.txtfechmodif_privi.Location = new System.Drawing.Point(218, 253);
            this.txtfechmodif_privi.Name = "txtfechmodif_privi";
            this.txtfechmodif_privi.Size = new System.Drawing.Size(141, 20);
            this.txtfechmodif_privi.TabIndex = 113;
            this.txtfechmodif_privi.Tag = "fechmodif_privi";
            // 
            // cboestado_priv
            // 
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
            this.txtestado_priv.Location = new System.Drawing.Point(376, 282);
            this.txtestado_priv.Name = "txtestado_priv";
            this.txtestado_priv.Size = new System.Drawing.Size(100, 20);
            this.txtestado_priv.TabIndex = 115;
            this.txtestado_priv.Tag = "estado_priv";
            this.txtestado_priv.TextChanged += new System.EventHandler(this.txtestado_priv_TextChanged);
            // 
            // btnObtenerFechas
            // 
            this.btnObtenerFechas.Location = new System.Drawing.Point(376, 215);
            this.btnObtenerFechas.Name = "btnObtenerFechas";
            this.btnObtenerFechas.Size = new System.Drawing.Size(75, 23);
            this.btnObtenerFechas.TabIndex = 116;
            this.btnObtenerFechas.Text = "Obtener";
            this.btnObtenerFechas.UseVisualStyleBackColor = true;
            this.btnObtenerFechas.Click += new System.EventHandler(this.button1_Click);
            // 
            // wftabm_SGprivilegio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(699, 354);
            this.Controls.Add(this.btnObtenerFechas);
            this.Controls.Add(this.txtestado_priv);
            this.Controls.Add(this.cboestado_priv);
            this.Controls.Add(this.txtfechmodif_privi);
            this.Controls.Add(this.txtfechcreado_privi);
            this.Controls.Add(this.txtnom_priv);
            this.Controls.Add(this.txtcod_priv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label2);
            this.Name = "wftabm_SGprivilegio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privilegio usuario";
            this.Load += new System.EventHandler(this.wftabm_SGprivilegio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcod_priv;
        private System.Windows.Forms.TextBox txtnom_priv;
        private System.Windows.Forms.TextBox txtfechcreado_privi;
        private System.Windows.Forms.TextBox txtfechmodif_privi;
        private System.Windows.Forms.ComboBox cboestado_priv;
        private System.Windows.Forms.TextBox txtestado_priv;
        private System.Windows.Forms.Button btnObtenerFechas;
    }
}