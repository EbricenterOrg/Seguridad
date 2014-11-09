namespace modulo_contabilidad
{
    partial class wfrtabm_CTcompconta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfrtabm_CTcompconta));
            this.navegador1 = new Navegador.Navegador();
            this.txtcodconta = new System.Windows.Forms.TextBox();
            this.txtcodtipo = new System.Windows.Forms.TextBox();
            this.txtcodserie = new System.Windows.Forms.TextBox();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.lblcodconta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btncoddoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 12);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_CTcompconta";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_BeforeClick += new System.EventHandler(this.navegador1_btnNuevo_BeforeClick);
            this.navegador1.btnGuardar_BeforeClick += new System.EventHandler(this.navegador1_btnGuardar_BeforeClick);
            this.navegador1.btnBuscar_BeforeClick += new System.EventHandler(this.navegador1_btnBuscar_BeforeClick);
            this.navegador1.btnModificar_BeforeClick += new System.EventHandler(this.navegador1_btnModificar_BeforeClick);
            // 
            // txtcodconta
            // 
            this.txtcodconta.Location = new System.Drawing.Point(237, 92);
            this.txtcodconta.Name = "txtcodconta";
            this.txtcodconta.Size = new System.Drawing.Size(100, 20);
            this.txtcodconta.TabIndex = 1;
            this.txtcodconta.Tag = "cod_compconta";
            this.txtcodconta.TextChanged += new System.EventHandler(this.txtcodconta_TextChanged);
            // 
            // txtcodtipo
            // 
            this.txtcodtipo.Location = new System.Drawing.Point(237, 118);
            this.txtcodtipo.Name = "txtcodtipo";
            this.txtcodtipo.Size = new System.Drawing.Size(100, 20);
            this.txtcodtipo.TabIndex = 2;
            this.txtcodtipo.Tag = "codtipodoc_compcont";
            this.txtcodtipo.TextChanged += new System.EventHandler(this.txtcodtipo_TextChanged);
            // 
            // txtcodserie
            // 
            this.txtcodserie.Location = new System.Drawing.Point(237, 146);
            this.txtcodserie.Name = "txtcodserie";
            this.txtcodserie.Size = new System.Drawing.Size(100, 20);
            this.txtcodserie.TabIndex = 3;
            this.txtcodserie.Tag = "serie_compcont";
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(237, 172);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(100, 20);
            this.txtfech.TabIndex = 4;
            this.txtfech.Tag = "fech_compconta";
            // 
            // lblcodconta
            // 
            this.lblcodconta.AutoSize = true;
            this.lblcodconta.Location = new System.Drawing.Point(49, 99);
            this.lblcodconta.Name = "lblcodconta";
            this.lblcodconta.Size = new System.Drawing.Size(151, 13);
            this.lblcodconta.TabIndex = 5;
            this.lblcodconta.Text = "Codigo Comprobante Contable";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo tipo de Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Serie documento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha";
            // 
            // btncoddoc
            // 
            this.btncoddoc.Location = new System.Drawing.Point(353, 114);
            this.btncoddoc.Name = "btncoddoc";
            this.btncoddoc.Size = new System.Drawing.Size(75, 23);
            this.btncoddoc.TabIndex = 9;
            this.btncoddoc.Text = "Agregar";
            this.btncoddoc.UseVisualStyleBackColor = true;
            this.btncoddoc.Click += new System.EventHandler(this.btncoddoc_Click);
            // 
            // wfrtabm_CTcompconta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 211);
            this.Controls.Add(this.btncoddoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblcodconta);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.txtcodserie);
            this.Controls.Add(this.txtcodtipo);
            this.Controls.Add(this.txtcodconta);
            this.Controls.Add(this.navegador1);
            this.Name = "wfrtabm_CTcompconta";
            this.Text = "wfrtabm_CTcompconta";
            this.Load += new System.EventHandler(this.wfrtabm_CTcompconta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtcodconta;
        private System.Windows.Forms.TextBox txtcodtipo;
        private System.Windows.Forms.TextBox txtcodserie;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.Label lblcodconta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncoddoc;

    }
}