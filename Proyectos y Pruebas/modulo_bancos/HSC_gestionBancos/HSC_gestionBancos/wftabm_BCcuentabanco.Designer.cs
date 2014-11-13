namespace HSC_gestionBancos
{
    partial class wftabm_BCcuentabanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabm_BCcuentabanco));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblbanco = new System.Windows.Forms.Label();
            this.lblsaldo = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblmodificacion = new System.Windows.Forms.Label();
            this.lblcreacion = new System.Windows.Forms.Label();
            this.lblsaldoanterior = new System.Windows.Forms.Label();
            this.lblsaldoactual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcod_ctabco = new System.Windows.Forms.TextBox();
            this.txtbanco_ctabco = new System.Windows.Forms.TextBox();
            this.txtcuenta_ctabco = new System.Windows.Forms.TextBox();
            this.txtsaldo_ctabco = new System.Windows.Forms.TextBox();
            this.txttipo_ctabanc = new System.Windows.Forms.TextBox();
            this.txtfechmodf_ctabco = new System.Windows.Forms.TextBox();
            this.txtfechcreado_ctabco = new System.Windows.Forms.TextBox();
            this.txtsaldoant_sal = new System.Windows.Forms.TextBox();
            this.txtsaldoact_sal = new System.Windows.Forms.TextBox();
            this.txtinteresactual_sal = new System.Windows.Forms.TextBox();
            this.cboestado_ctabco = new System.Windows.Forms.ComboBox();
            this.navegador1 = new Navegador.Navegador();
            this.txtinteresacum_sal = new System.Windows.Forms.TextBox();
            this.lblcuenta_ctabco = new System.Windows.Forms.Label();
            this.txtestado_ctabco = new System.Windows.Forms.TextBox();
            this.lblgestioncuentasbancarias = new System.Windows.Forms.Label();
            this.btnfechamodif = new System.Windows.Forms.Button();
            this.btnfechacreacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(37, 159);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(43, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Código:";
            // 
            // lblbanco
            // 
            this.lblbanco.AutoSize = true;
            this.lblbanco.Location = new System.Drawing.Point(37, 188);
            this.lblbanco.Name = "lblbanco";
            this.lblbanco.Size = new System.Drawing.Size(41, 13);
            this.lblbanco.TabIndex = 1;
            this.lblbanco.Text = "Banco:";
            // 
            // lblsaldo
            // 
            this.lblsaldo.AutoSize = true;
            this.lblsaldo.Location = new System.Drawing.Point(37, 250);
            this.lblsaldo.Name = "lblsaldo";
            this.lblsaldo.Size = new System.Drawing.Size(37, 13);
            this.lblsaldo.TabIndex = 2;
            this.lblsaldo.Text = "Saldo:";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(37, 281);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(31, 13);
            this.lbltipo.TabIndex = 3;
            this.lbltipo.Text = "Tipo:";
            // 
            // lblmodificacion
            // 
            this.lblmodificacion.AutoSize = true;
            this.lblmodificacion.Location = new System.Drawing.Point(37, 308);
            this.lblmodificacion.Name = "lblmodificacion";
            this.lblmodificacion.Size = new System.Drawing.Size(102, 13);
            this.lblmodificacion.TabIndex = 4;
            this.lblmodificacion.Text = "Fecha modificación:";
            // 
            // lblcreacion
            // 
            this.lblcreacion.AutoSize = true;
            this.lblcreacion.Location = new System.Drawing.Point(37, 340);
            this.lblcreacion.Name = "lblcreacion";
            this.lblcreacion.Size = new System.Drawing.Size(84, 13);
            this.lblcreacion.TabIndex = 5;
            this.lblcreacion.Text = "Fecha creación:";
            // 
            // lblsaldoanterior
            // 
            this.lblsaldoanterior.AutoSize = true;
            this.lblsaldoanterior.Location = new System.Drawing.Point(37, 376);
            this.lblsaldoanterior.Name = "lblsaldoanterior";
            this.lblsaldoanterior.Size = new System.Drawing.Size(75, 13);
            this.lblsaldoanterior.TabIndex = 6;
            this.lblsaldoanterior.Text = "Saldo anterior:";
            // 
            // lblsaldoactual
            // 
            this.lblsaldoactual.AutoSize = true;
            this.lblsaldoactual.Location = new System.Drawing.Point(37, 407);
            this.lblsaldoactual.Name = "lblsaldoactual";
            this.lblsaldoactual.Size = new System.Drawing.Size(69, 13);
            this.lblsaldoactual.TabIndex = 7;
            this.lblsaldoactual.Text = "Saldo actual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Interés actual:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Interés acumulado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Estado:";
            // 
            // txtcod_ctabco
            // 
            this.txtcod_ctabco.Location = new System.Drawing.Point(150, 152);
            this.txtcod_ctabco.Name = "txtcod_ctabco";
            this.txtcod_ctabco.Size = new System.Drawing.Size(126, 20);
            this.txtcod_ctabco.TabIndex = 11;
            this.txtcod_ctabco.Tag = "cod_ctabco";
            // 
            // txtbanco_ctabco
            // 
            this.txtbanco_ctabco.Location = new System.Drawing.Point(150, 181);
            this.txtbanco_ctabco.Name = "txtbanco_ctabco";
            this.txtbanco_ctabco.Size = new System.Drawing.Size(126, 20);
            this.txtbanco_ctabco.TabIndex = 12;
            this.txtbanco_ctabco.Tag = "banco_ctabco";
            // 
            // txtcuenta_ctabco
            // 
            this.txtcuenta_ctabco.Location = new System.Drawing.Point(150, 211);
            this.txtcuenta_ctabco.Name = "txtcuenta_ctabco";
            this.txtcuenta_ctabco.Size = new System.Drawing.Size(126, 20);
            this.txtcuenta_ctabco.TabIndex = 13;
            this.txtcuenta_ctabco.Tag = "cuenta_ctabco";
            // 
            // txtsaldo_ctabco
            // 
            this.txtsaldo_ctabco.Location = new System.Drawing.Point(150, 243);
            this.txtsaldo_ctabco.Name = "txtsaldo_ctabco";
            this.txtsaldo_ctabco.Size = new System.Drawing.Size(126, 20);
            this.txtsaldo_ctabco.TabIndex = 14;
            this.txtsaldo_ctabco.Tag = "saldo_ctabco";
            // 
            // txttipo_ctabanc
            // 
            this.txttipo_ctabanc.Location = new System.Drawing.Point(150, 270);
            this.txttipo_ctabanc.Name = "txttipo_ctabanc";
            this.txttipo_ctabanc.Size = new System.Drawing.Size(126, 20);
            this.txttipo_ctabanc.TabIndex = 15;
            this.txttipo_ctabanc.Tag = "tipo_ctabanc";
            // 
            // txtfechmodf_ctabco
            // 
            this.txtfechmodf_ctabco.Location = new System.Drawing.Point(150, 302);
            this.txtfechmodf_ctabco.Name = "txtfechmodf_ctabco";
            this.txtfechmodf_ctabco.Size = new System.Drawing.Size(126, 20);
            this.txtfechmodf_ctabco.TabIndex = 16;
            this.txtfechmodf_ctabco.Tag = "fechmodf_ctabco";
            // 
            // txtfechcreado_ctabco
            // 
            this.txtfechcreado_ctabco.Location = new System.Drawing.Point(150, 337);
            this.txtfechcreado_ctabco.Name = "txtfechcreado_ctabco";
            this.txtfechcreado_ctabco.Size = new System.Drawing.Size(126, 20);
            this.txtfechcreado_ctabco.TabIndex = 17;
            this.txtfechcreado_ctabco.Tag = "creado_ctabco";
            // 
            // txtsaldoant_sal
            // 
            this.txtsaldoant_sal.Location = new System.Drawing.Point(150, 368);
            this.txtsaldoant_sal.Name = "txtsaldoant_sal";
            this.txtsaldoant_sal.Size = new System.Drawing.Size(126, 20);
            this.txtsaldoant_sal.TabIndex = 18;
            this.txtsaldoant_sal.Tag = "saldoant_sal";
            // 
            // txtsaldoact_sal
            // 
            this.txtsaldoact_sal.Location = new System.Drawing.Point(150, 402);
            this.txtsaldoact_sal.Name = "txtsaldoact_sal";
            this.txtsaldoact_sal.Size = new System.Drawing.Size(126, 20);
            this.txtsaldoact_sal.TabIndex = 19;
            this.txtsaldoact_sal.Tag = "saldoact_sal";
            // 
            // txtinteresactual_sal
            // 
            this.txtinteresactual_sal.Location = new System.Drawing.Point(150, 431);
            this.txtinteresactual_sal.Name = "txtinteresactual_sal";
            this.txtinteresactual_sal.Size = new System.Drawing.Size(126, 20);
            this.txtinteresactual_sal.TabIndex = 20;
            this.txtinteresactual_sal.Tag = "interesactual_sal";
            // 
            // cboestado_ctabco
            // 
            this.cboestado_ctabco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado_ctabco.FormattingEnabled = true;
            this.cboestado_ctabco.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_ctabco.Location = new System.Drawing.Point(150, 492);
            this.cboestado_ctabco.Name = "cboestado_ctabco";
            this.cboestado_ctabco.Size = new System.Drawing.Size(126, 21);
            this.cboestado_ctabco.TabIndex = 21;
            this.cboestado_ctabco.Tag = "estado_ctabco";
            this.cboestado_ctabco.SelectedIndexChanged += new System.EventHandler(this.cboestado_ctabco_SelectedIndexChanged);
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(41, 79);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_BCcuentabanco";
            this.navegador1.TabIndex = 22;
            // 
            // txtinteresacum_sal
            // 
            this.txtinteresacum_sal.Location = new System.Drawing.Point(150, 462);
            this.txtinteresacum_sal.Name = "txtinteresacum_sal";
            this.txtinteresacum_sal.Size = new System.Drawing.Size(126, 20);
            this.txtinteresacum_sal.TabIndex = 23;
            this.txtinteresacum_sal.Tag = "interesacum_sal";
            // 
            // lblcuenta_ctabco
            // 
            this.lblcuenta_ctabco.AutoSize = true;
            this.lblcuenta_ctabco.Location = new System.Drawing.Point(36, 218);
            this.lblcuenta_ctabco.Name = "lblcuenta_ctabco";
            this.lblcuenta_ctabco.Size = new System.Drawing.Size(44, 13);
            this.lblcuenta_ctabco.TabIndex = 24;
            this.lblcuenta_ctabco.Text = "Cuenta:";
            // 
            // txtestado_ctabco
            // 
            this.txtestado_ctabco.Location = new System.Drawing.Point(290, 493);
            this.txtestado_ctabco.Name = "txtestado_ctabco";
            this.txtestado_ctabco.Size = new System.Drawing.Size(100, 20);
            this.txtestado_ctabco.TabIndex = 25;
            this.txtestado_ctabco.Tag = "estado_ctabco";
            this.txtestado_ctabco.Visible = false;
            this.txtestado_ctabco.TextChanged += new System.EventHandler(this.txtestado_ctabco_TextChanged);
            // 
            // lblgestioncuentasbancarias
            // 
            this.lblgestioncuentasbancarias.AutoSize = true;
            this.lblgestioncuentasbancarias.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestioncuentasbancarias.Location = new System.Drawing.Point(35, 45);
            this.lblgestioncuentasbancarias.Name = "lblgestioncuentasbancarias";
            this.lblgestioncuentasbancarias.Size = new System.Drawing.Size(336, 31);
            this.lblgestioncuentasbancarias.TabIndex = 26;
            this.lblgestioncuentasbancarias.Text = "Gestión cuentas bancarias";
            // 
            // btnfechamodif
            // 
            this.btnfechamodif.Location = new System.Drawing.Point(290, 299);
            this.btnfechamodif.Name = "btnfechamodif";
            this.btnfechamodif.Size = new System.Drawing.Size(151, 23);
            this.btnfechamodif.TabIndex = 27;
            this.btnfechamodif.Text = "Obtener fecha modificación";
            this.btnfechamodif.UseVisualStyleBackColor = true;
            this.btnfechamodif.Click += new System.EventHandler(this.btnfechamodif_Click);
            // 
            // btnfechacreacion
            // 
            this.btnfechacreacion.Location = new System.Drawing.Point(290, 334);
            this.btnfechacreacion.Name = "btnfechacreacion";
            this.btnfechacreacion.Size = new System.Drawing.Size(151, 23);
            this.btnfechacreacion.TabIndex = 28;
            this.btnfechacreacion.Text = "Obtener fecha creación";
            this.btnfechacreacion.UseVisualStyleBackColor = true;
            this.btnfechacreacion.Click += new System.EventHandler(this.btnfechacreacion_Click);
            // 
            // wftabm_BCcuentabanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 548);
            this.Controls.Add(this.btnfechacreacion);
            this.Controls.Add(this.btnfechamodif);
            this.Controls.Add(this.lblgestioncuentasbancarias);
            this.Controls.Add(this.txtestado_ctabco);
            this.Controls.Add(this.lblcuenta_ctabco);
            this.Controls.Add(this.txtinteresacum_sal);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.cboestado_ctabco);
            this.Controls.Add(this.txtinteresactual_sal);
            this.Controls.Add(this.txtsaldoact_sal);
            this.Controls.Add(this.txtsaldoant_sal);
            this.Controls.Add(this.txtfechcreado_ctabco);
            this.Controls.Add(this.txtfechmodf_ctabco);
            this.Controls.Add(this.txttipo_ctabanc);
            this.Controls.Add(this.txtsaldo_ctabco);
            this.Controls.Add(this.txtcuenta_ctabco);
            this.Controls.Add(this.txtbanco_ctabco);
            this.Controls.Add(this.txtcod_ctabco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblsaldoactual);
            this.Controls.Add(this.lblsaldoanterior);
            this.Controls.Add(this.lblcreacion);
            this.Controls.Add(this.lblmodificacion);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.lblsaldo);
            this.Controls.Add(this.lblbanco);
            this.Controls.Add(this.lblcodigo);
            this.Name = "wftabm_BCcuentabanco";
            this.Text = "Cuenta banco";
            this.Load += new System.EventHandler(this.wftabm_BCcuentabanco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblbanco;
        private System.Windows.Forms.Label lblsaldo;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblmodificacion;
        private System.Windows.Forms.Label lblcreacion;
        private System.Windows.Forms.Label lblsaldoanterior;
        private System.Windows.Forms.Label lblsaldoactual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcod_ctabco;
        private System.Windows.Forms.TextBox txtbanco_ctabco;
        private System.Windows.Forms.TextBox txtcuenta_ctabco;
        private System.Windows.Forms.TextBox txtsaldo_ctabco;
        private System.Windows.Forms.TextBox txttipo_ctabanc;
        private System.Windows.Forms.TextBox txtfechmodf_ctabco;
        private System.Windows.Forms.TextBox txtfechcreado_ctabco;
        private System.Windows.Forms.TextBox txtsaldoant_sal;
        private System.Windows.Forms.TextBox txtsaldoact_sal;
        private System.Windows.Forms.TextBox txtinteresactual_sal;
        private System.Windows.Forms.ComboBox cboestado_ctabco;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtinteresacum_sal;
        private System.Windows.Forms.Label lblcuenta_ctabco;
        private System.Windows.Forms.TextBox txtestado_ctabco;
        private System.Windows.Forms.Label lblgestioncuentasbancarias;
        private System.Windows.Forms.Button btnfechamodif;
        private System.Windows.Forms.Button btnfechacreacion;
    }
}