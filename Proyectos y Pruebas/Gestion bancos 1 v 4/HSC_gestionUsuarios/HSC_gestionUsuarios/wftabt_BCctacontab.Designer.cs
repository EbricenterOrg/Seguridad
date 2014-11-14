namespace HSC_gestionBancos
{
    partial class wftabt_BCctacontab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabt_BCctacontab));
            this.btnAgregarCodCta = new System.Windows.Forms.Button();
            this.txtCodCte = new System.Windows.Forms.TextBox();
            this.lblCodCte = new System.Windows.Forms.Label();
            this.txtCodigoCta = new System.Windows.Forms.TextBox();
            this.lblCodCuenta = new System.Windows.Forms.Label();
            this.lblpregunta_secreta = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtCodCta = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblnom_perfil = new System.Windows.Forms.Label();
            this.lblCtaContab = new System.Windows.Forms.Label();
            this.btnAgregarCodCte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCodCta
            // 
            this.btnAgregarCodCta.Location = new System.Drawing.Point(356, 197);
            this.btnAgregarCodCta.Name = "btnAgregarCodCta";
            this.btnAgregarCodCta.Size = new System.Drawing.Size(94, 23);
            this.btnAgregarCodCta.TabIndex = 128;
            this.btnAgregarCodCta.Text = "Agregar";
            this.btnAgregarCodCta.UseVisualStyleBackColor = true;
            this.btnAgregarCodCta.Click += new System.EventHandler(this.btnAgregarCodCta_Click);
            // 
            // txtCodCte
            // 
            this.txtCodCte.Location = new System.Drawing.Point(168, 233);
            this.txtCodCte.Name = "txtCodCte";
            this.txtCodCte.Size = new System.Drawing.Size(173, 20);
            this.txtCodCte.TabIndex = 127;
            this.txtCodCte.Tag = "cod_cte";
            // 
            // lblCodCte
            // 
            this.lblCodCte.AutoSize = true;
            this.lblCodCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCte.ForeColor = System.Drawing.Color.Black;
            this.lblCodCte.Location = new System.Drawing.Point(26, 238);
            this.lblCodCte.Name = "lblCodCte";
            this.lblCodCte.Size = new System.Drawing.Size(85, 15);
            this.lblCodCte.TabIndex = 126;
            this.lblCodCte.Text = "Codigo cliente";
            // 
            // txtCodigoCta
            // 
            this.txtCodigoCta.Location = new System.Drawing.Point(168, 195);
            this.txtCodigoCta.Name = "txtCodigoCta";
            this.txtCodigoCta.Size = new System.Drawing.Size(173, 20);
            this.txtCodigoCta.TabIndex = 123;
            this.txtCodigoCta.Tag = "cod_ctas";
            // 
            // lblCodCuenta
            // 
            this.lblCodCuenta.AutoSize = true;
            this.lblCodCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCuenta.ForeColor = System.Drawing.Color.Black;
            this.lblCodCuenta.Location = new System.Drawing.Point(26, 200);
            this.lblCodCuenta.Name = "lblCodCuenta";
            this.lblCodCuenta.Size = new System.Drawing.Size(86, 15);
            this.lblCodCuenta.TabIndex = 122;
            this.lblCodCuenta.Text = "Codigo cuenta";
            this.lblCodCuenta.Click += new System.EventHandler(this.lblFechCreacion_Click);
            // 
            // lblpregunta_secreta
            // 
            this.lblpregunta_secreta.AutoSize = true;
            this.lblpregunta_secreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregunta_secreta.ForeColor = System.Drawing.Color.Black;
            this.lblpregunta_secreta.Location = new System.Drawing.Point(23, 19);
            this.lblpregunta_secreta.Name = "lblpregunta_secreta";
            this.lblpregunta_secreta.Size = new System.Drawing.Size(226, 33);
            this.lblpregunta_secreta.TabIndex = 121;
            this.lblpregunta_secreta.Text = "Cuenta contable";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(29, 69);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabt_bcctacontab";
            this.navegador1.TabIndex = 120;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(347, 281);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 20);
            this.txtEstado.TabIndex = 119;
            this.txtEstado.Tag = "estado_ctacontab";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(168, 280);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(173, 21);
            this.cboEstado.TabIndex = 118;
            this.cboEstado.Tag = "estado_ctacontab";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // txtCodCta
            // 
            this.txtCodCta.Location = new System.Drawing.Point(168, 156);
            this.txtCodCta.Name = "txtCodCta";
            this.txtCodCta.Size = new System.Drawing.Size(173, 20);
            this.txtCodCta.TabIndex = 117;
            this.txtCodCta.Tag = "cod_compconta";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(26, 281);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 116;
            this.lblEstado.Text = "Estado";
            // 
            // lblnom_perfil
            // 
            this.lblnom_perfil.AutoSize = true;
            this.lblnom_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblnom_perfil.Location = new System.Drawing.Point(26, 200);
            this.lblnom_perfil.Name = "lblnom_perfil";
            this.lblnom_perfil.Size = new System.Drawing.Size(0, 15);
            this.lblnom_perfil.TabIndex = 115;
            // 
            // lblCtaContab
            // 
            this.lblCtaContab.AutoSize = true;
            this.lblCtaContab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCtaContab.ForeColor = System.Drawing.Color.Black;
            this.lblCtaContab.Location = new System.Drawing.Point(26, 161);
            this.lblCtaContab.Name = "lblCtaContab";
            this.lblCtaContab.Size = new System.Drawing.Size(136, 15);
            this.lblCtaContab.TabIndex = 114;
            this.lblCtaContab.Text = "Codigo cuenta contable";
            // 
            // btnAgregarCodCte
            // 
            this.btnAgregarCodCte.Location = new System.Drawing.Point(356, 238);
            this.btnAgregarCodCte.Name = "btnAgregarCodCte";
            this.btnAgregarCodCte.Size = new System.Drawing.Size(94, 23);
            this.btnAgregarCodCte.TabIndex = 129;
            this.btnAgregarCodCte.Text = "Agregar";
            this.btnAgregarCodCte.UseVisualStyleBackColor = true;
            this.btnAgregarCodCte.Click += new System.EventHandler(this.btnAgregarCodCte_Click);
            // 
            // wftabt_BCctacontab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 357);
            this.Controls.Add(this.btnAgregarCodCte);
            this.Controls.Add(this.btnAgregarCodCta);
            this.Controls.Add(this.txtCodCte);
            this.Controls.Add(this.lblCodCte);
            this.Controls.Add(this.txtCodigoCta);
            this.Controls.Add(this.lblCodCuenta);
            this.Controls.Add(this.lblpregunta_secreta);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtCodCta);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblnom_perfil);
            this.Controls.Add(this.lblCtaContab);
            this.Name = "wftabt_BCctacontab";
            this.Text = "wftabt_BCctacontab";
            this.Load += new System.EventHandler(this.wftabt_BCctacontab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCodCta;
        private System.Windows.Forms.TextBox txtCodCte;
        private System.Windows.Forms.Label lblCodCte;
        private System.Windows.Forms.TextBox txtCodigoCta;
        private System.Windows.Forms.Label lblCodCuenta;
        private System.Windows.Forms.Label lblpregunta_secreta;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtCodCta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblnom_perfil;
        private System.Windows.Forms.Label lblCtaContab;
        private System.Windows.Forms.Button btnAgregarCodCte;
    }
}