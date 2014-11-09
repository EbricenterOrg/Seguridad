namespace modulo_contabilidad
{
    partial class wfrtabm_CTdoccomp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfrtabm_CTdoccomp));
            this.navegador1 = new Navegador.Navegador();
            this.lblcodcomp = new System.Windows.Forms.Label();
            this.lblnom = new System.Windows.Forms.Label();
            this.lblfec = new System.Windows.Forms.Label();
            this.txtcoddoc = new System.Windows.Forms.TextBox();
            this.txtnomtipo = new System.Windows.Forms.TextBox();
            this.txtfech = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestadodoc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 27);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_ctdoccomp";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_BeforeClick += new System.EventHandler(this.navegador1_btnNuevo_BeforeClick);
            // 
            // lblcodcomp
            // 
            this.lblcodcomp.AutoSize = true;
            this.lblcodcomp.Location = new System.Drawing.Point(12, 120);
            this.lblcodcomp.Name = "lblcodcomp";
            this.lblcodcomp.Size = new System.Drawing.Size(98, 13);
            this.lblcodcomp.TabIndex = 1;
            this.lblcodcomp.Text = "Codigo Documento";
            // 
            // lblnom
            // 
            this.lblnom.AutoSize = true;
            this.lblnom.Location = new System.Drawing.Point(12, 167);
            this.lblnom.Name = "lblnom";
            this.lblnom.Size = new System.Drawing.Size(102, 13);
            this.lblnom.TabIndex = 2;
            this.lblnom.Text = "Nombre Documento";
            // 
            // lblfec
            // 
            this.lblfec.AutoSize = true;
            this.lblfec.Location = new System.Drawing.Point(274, 117);
            this.lblfec.Name = "lblfec";
            this.lblfec.Size = new System.Drawing.Size(37, 13);
            this.lblfec.TabIndex = 3;
            this.lblfec.Text = "Fecha";
            // 
            // txtcoddoc
            // 
            this.txtcoddoc.Location = new System.Drawing.Point(120, 114);
            this.txtcoddoc.Name = "txtcoddoc";
            this.txtcoddoc.Size = new System.Drawing.Size(100, 20);
            this.txtcoddoc.TabIndex = 4;
            this.txtcoddoc.Tag = "codtipodoc_compcont";
            // 
            // txtnomtipo
            // 
            this.txtnomtipo.Location = new System.Drawing.Point(120, 160);
            this.txtnomtipo.Name = "txtnomtipo";
            this.txtnomtipo.Size = new System.Drawing.Size(100, 20);
            this.txtnomtipo.TabIndex = 5;
            this.txtnomtipo.Tag = "nom_tipocomp";
            // 
            // txtfech
            // 
            this.txtfech.Location = new System.Drawing.Point(384, 110);
            this.txtfech.Name = "txtfech";
            this.txtfech.Size = new System.Drawing.Size(100, 20);
            this.txtfech.TabIndex = 6;
            this.txtfech.Tag = "fechcreado_tipocomp";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(274, 167);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(40, 13);
            this.lblestado.TabIndex = 7;
            this.lblestado.Text = "Estado";
            // 
            // txtestadodoc
            // 
            this.txtestadodoc.Location = new System.Drawing.Point(384, 160);
            this.txtestadodoc.Name = "txtestadodoc";
            this.txtestadodoc.Size = new System.Drawing.Size(100, 20);
            this.txtestadodoc.TabIndex = 8;
            this.txtestadodoc.Tag = "estado_doccomp";
            // 
            // wfrtabm_CTdoccomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 224);
            this.Controls.Add(this.txtestadodoc);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtfech);
            this.Controls.Add(this.txtnomtipo);
            this.Controls.Add(this.txtcoddoc);
            this.Controls.Add(this.lblfec);
            this.Controls.Add(this.lblnom);
            this.Controls.Add(this.lblcodcomp);
            this.Controls.Add(this.navegador1);
            this.Name = "wfrtabm_CTdoccomp";
            this.Text = "wfrtabm_CTdoccomp";
            this.Load += new System.EventHandler(this.wfrtabm_CTdoccomp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblcodcomp;
        private System.Windows.Forms.Label lblnom;
        private System.Windows.Forms.Label lblfec;
        private System.Windows.Forms.TextBox txtcoddoc;
        private System.Windows.Forms.TextBox txtnomtipo;
        private System.Windows.Forms.TextBox txtfech;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestadodoc;
    }
}