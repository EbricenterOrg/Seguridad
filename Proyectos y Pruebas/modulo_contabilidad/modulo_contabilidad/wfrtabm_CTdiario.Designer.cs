namespace modulo_contabilidad
{
    partial class wfrtabm_CTdiario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfrtabm_CTdiario));
            this.navegador1 = new Navegador.Navegador();
            this.lblcodPart = new System.Windows.Forms.Label();
            this.txtcodPartida = new System.Windows.Forms.TextBox();
            this.lblfech = new System.Windows.Forms.Label();
            this.lblcodigcomp = new System.Windows.Forms.Label();
            this.lblconcepto = new System.Windows.Forms.Label();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.txtcodcomp = new System.Windows.Forms.TextBox();
            this.txtconcep = new System.Windows.Forms.TextBox();
            this.btnCodComprobante = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 30);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_CTdiario";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_BeforeClick += new System.EventHandler(this.navegador1_btnNuevo_BeforeClick);
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_BeforeClick += new System.EventHandler(this.navegador1_btnBuscar_BeforeClick);
            this.navegador1.btnModificar_BeforeClick += new System.EventHandler(this.navegador1_btnModificar_BeforeClick);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblcodPart
            // 
            this.lblcodPart.AutoSize = true;
            this.lblcodPart.Location = new System.Drawing.Point(24, 122);
            this.lblcodPart.Name = "lblcodPart";
            this.lblcodPart.Size = new System.Drawing.Size(76, 13);
            this.lblcodPart.TabIndex = 1;
            this.lblcodPart.Text = "Codigo Partida";
            // 
            // txtcodPartida
            // 
            this.txtcodPartida.Location = new System.Drawing.Point(134, 119);
            this.txtcodPartida.Name = "txtcodPartida";
            this.txtcodPartida.Size = new System.Drawing.Size(100, 20);
            this.txtcodPartida.TabIndex = 2;
            this.txtcodPartida.Tag = "codpartd_dro";
            // 
            // lblfech
            // 
            this.lblfech.AutoSize = true;
            this.lblfech.Location = new System.Drawing.Point(24, 156);
            this.lblfech.Name = "lblfech";
            this.lblfech.Size = new System.Drawing.Size(37, 13);
            this.lblfech.TabIndex = 3;
            this.lblfech.Text = "Fecha";
            // 
            // lblcodigcomp
            // 
            this.lblcodigcomp.AutoSize = true;
            this.lblcodigcomp.Location = new System.Drawing.Point(280, 122);
            this.lblcodigcomp.Name = "lblcodigcomp";
            this.lblcodigcomp.Size = new System.Drawing.Size(151, 13);
            this.lblcodigcomp.TabIndex = 4;
            this.lblcodigcomp.Text = "Codigo Comprobante Contable";
            // 
            // lblconcepto
            // 
            this.lblconcepto.AutoSize = true;
            this.lblconcepto.Location = new System.Drawing.Point(24, 199);
            this.lblconcepto.Name = "lblconcepto";
            this.lblconcepto.Size = new System.Drawing.Size(53, 13);
            this.lblconcepto.TabIndex = 5;
            this.lblconcepto.Text = "Concepto";
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(134, 153);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(100, 20);
            this.txtfech.TabIndex = 6;
            this.txtfech.Tag = "fechcreado_dro";
            // 
            // txtcodcomp
            // 
            this.txtcodcomp.Location = new System.Drawing.Point(447, 119);
            this.txtcodcomp.Name = "txtcodcomp";
            this.txtcodcomp.Size = new System.Drawing.Size(100, 20);
            this.txtcodcomp.TabIndex = 7;
            this.txtcodcomp.Tag = "cod_compconta";
            this.txtcodcomp.TextChanged += new System.EventHandler(this.txtcodcomp_TextChanged);
            // 
            // txtconcep
            // 
            this.txtconcep.Location = new System.Drawing.Point(134, 196);
            this.txtconcep.Multiline = true;
            this.txtconcep.Name = "txtconcep";
            this.txtconcep.Size = new System.Drawing.Size(380, 75);
            this.txtconcep.TabIndex = 8;
            this.txtconcep.Tag = "concp_dro";
            // 
            // btnCodComprobante
            // 
            this.btnCodComprobante.Location = new System.Drawing.Point(562, 117);
            this.btnCodComprobante.Name = "btnCodComprobante";
            this.btnCodComprobante.Size = new System.Drawing.Size(75, 23);
            this.btnCodComprobante.TabIndex = 9;
            this.btnCodComprobante.Text = "Agregar";
            this.btnCodComprobante.UseVisualStyleBackColor = true;
            this.btnCodComprobante.Click += new System.EventHandler(this.btnCodComprobante_Click);
            // 
            // wfrtabm_CTdiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 292);
            this.Controls.Add(this.btnCodComprobante);
            this.Controls.Add(this.txtconcep);
            this.Controls.Add(this.txtcodcomp);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.lblconcepto);
            this.Controls.Add(this.lblcodigcomp);
            this.Controls.Add(this.lblfech);
            this.Controls.Add(this.txtcodPartida);
            this.Controls.Add(this.lblcodPart);
            this.Controls.Add(this.navegador1);
            this.Name = "wfrtabm_CTdiario";
            this.Text = "wfrtabm_CTdiario";
            this.Load += new System.EventHandler(this.wfrtabm_CTdiario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblcodPart;
        private System.Windows.Forms.TextBox txtcodPartida;
        private System.Windows.Forms.Label lblfech;
        private System.Windows.Forms.Label lblcodigcomp;
        private System.Windows.Forms.Label lblconcepto;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.TextBox txtcodcomp;
        private System.Windows.Forms.TextBox txtconcep;
        private System.Windows.Forms.Button btnCodComprobante;
    }
}