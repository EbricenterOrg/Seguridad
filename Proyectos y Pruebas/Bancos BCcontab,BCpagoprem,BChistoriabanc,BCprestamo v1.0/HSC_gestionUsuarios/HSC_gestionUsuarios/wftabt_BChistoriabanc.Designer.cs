namespace HSC_gestionUsuarios
{
    partial class wftabt_BChistoriabanc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabt_BChistoriabanc));
            this.navegador1 = new Navegador.Navegador();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.txtTrimestre = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtCodHistory = new System.Windows.Forms.TextBox();
            this.lblTrimestre = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtCodCuentaCta = new System.Windows.Forms.TextBox();
            this.lblCodCuentaCta = new System.Windows.Forms.Label();
            this.lblCodHistory = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblGestionUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(79, 80);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabt_bchistoriabanc";
            this.navegador1.TabIndex = 12;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(405, 369);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 99;
            this.txtEstado.Tag = "estado_hstbco";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtestado_usr_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(248, 369);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(141, 21);
            this.cboEstado.TabIndex = 25;
            this.cboEstado.Tag = "estado_hstbco";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboestado_usr_SelectedIndexChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(248, 330);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(141, 20);
            this.txtSaldo.TabIndex = 21;
            this.txtSaldo.Tag = "saldo_hstbco";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(76, 369);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 15);
            this.lblEstado.TabIndex = 93;
            this.lblEstado.Tag = "estado_usr";
            this.lblEstado.Text = "Estado";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.Black;
            this.lblSaldo.Location = new System.Drawing.Point(76, 331);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(39, 15);
            this.lblSaldo.TabIndex = 89;
            this.lblSaldo.Text = "Saldo";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(248, 301);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(141, 20);
            this.txtMes.TabIndex = 20;
            this.txtMes.Tag = "mes_hstbco";
            this.txtMes.UseSystemPasswordChar = true;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.ForeColor = System.Drawing.Color.Black;
            this.lblMes.Location = new System.Drawing.Point(76, 302);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(31, 15);
            this.lblMes.TabIndex = 87;
            this.lblMes.Tag = "lblpass_usr";
            this.lblMes.Text = "Mes";
            // 
            // txtTrimestre
            // 
            this.txtTrimestre.Location = new System.Drawing.Point(248, 275);
            this.txtTrimestre.Name = "txtTrimestre";
            this.txtTrimestre.Size = new System.Drawing.Size(141, 20);
            this.txtTrimestre.TabIndex = 19;
            this.txtTrimestre.Tag = "trim_hstbco";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(248, 237);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(141, 20);
            this.txtAnio.TabIndex = 18;
            this.txtAnio.Tag = "anio_hstbco";
            // 
            // txtCodHistory
            // 
            this.txtCodHistory.Location = new System.Drawing.Point(248, 165);
            this.txtCodHistory.Name = "txtCodHistory";
            this.txtCodHistory.Size = new System.Drawing.Size(141, 20);
            this.txtCodHistory.TabIndex = 13;
            this.txtCodHistory.Tag = "codhstbco_hstbco";
            this.txtCodHistory.TextChanged += new System.EventHandler(this.txtcod_usr_TextChanged);
            // 
            // lblTrimestre
            // 
            this.lblTrimestre.AutoSize = true;
            this.lblTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrimestre.ForeColor = System.Drawing.Color.Black;
            this.lblTrimestre.Location = new System.Drawing.Point(76, 276);
            this.lblTrimestre.Name = "lblTrimestre";
            this.lblTrimestre.Size = new System.Drawing.Size(59, 15);
            this.lblTrimestre.TabIndex = 81;
            this.lblTrimestre.Text = "Trimestre";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnio.ForeColor = System.Drawing.Color.Black;
            this.lblAnio.Location = new System.Drawing.Point(76, 242);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(28, 15);
            this.lblAnio.TabIndex = 79;
            this.lblAnio.Text = "Año";
            // 
            // txtCodCuentaCta
            // 
            this.txtCodCuentaCta.Location = new System.Drawing.Point(248, 199);
            this.txtCodCuentaCta.Name = "txtCodCuentaCta";
            this.txtCodCuentaCta.Size = new System.Drawing.Size(141, 20);
            this.txtCodCuentaCta.TabIndex = 72;
            this.txtCodCuentaCta.Tag = "cod_ctabco";
            // 
            // lblCodCuentaCta
            // 
            this.lblCodCuentaCta.AutoSize = true;
            this.lblCodCuentaCta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCuentaCta.ForeColor = System.Drawing.Color.Black;
            this.lblCodCuentaCta.Location = new System.Drawing.Point(76, 200);
            this.lblCodCuentaCta.Name = "lblCodCuentaCta";
            this.lblCodCuentaCta.Size = new System.Drawing.Size(136, 15);
            this.lblCodCuentaCta.TabIndex = 77;
            this.lblCodCuentaCta.Text = "Codigo cuenta contable";
            // 
            // lblCodHistory
            // 
            this.lblCodHistory.AutoSize = true;
            this.lblCodHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodHistory.ForeColor = System.Drawing.Color.Black;
            this.lblCodHistory.Location = new System.Drawing.Point(76, 166);
            this.lblCodHistory.Name = "lblCodHistory";
            this.lblCodHistory.Size = new System.Drawing.Size(92, 15);
            this.lblCodHistory.TabIndex = 73;
            this.lblCodHistory.Text = "Codigo historial";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(405, 197);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 100;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btncodemp_Click);
            // 
            // lblGestionUsuarios
            // 
            this.lblGestionUsuarios.AutoSize = true;
            this.lblGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lblGestionUsuarios.Location = new System.Drawing.Point(82, 30);
            this.lblGestionUsuarios.Name = "lblGestionUsuarios";
            this.lblGestionUsuarios.Size = new System.Drawing.Size(209, 33);
            this.lblGestionUsuarios.TabIndex = 102;
            this.lblGestionUsuarios.Text = "Historial banco";
            this.lblGestionUsuarios.Click += new System.EventHandler(this.label2_Click);
            // 
            // wftabt_BChistoriabanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(736, 424);
            this.Controls.Add(this.lblGestionUsuarios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.txtTrimestre);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtCodHistory);
            this.Controls.Add(this.lblTrimestre);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.txtCodCuentaCta);
            this.Controls.Add(this.lblCodCuentaCta);
            this.Controls.Add(this.lblCodHistory);
            this.Controls.Add(this.navegador1);
            this.Name = "wftabt_BChistoriabanc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Usuarios";
            this.Load += new System.EventHandler(this.wfprincipalUsuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.TextBox txtTrimestre;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtCodHistory;
        private System.Windows.Forms.Label lblTrimestre;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtCodCuentaCta;
        private System.Windows.Forms.Label lblCodCuentaCta;
        private System.Windows.Forms.Label lblCodHistory;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblGestionUsuarios;
    }
}