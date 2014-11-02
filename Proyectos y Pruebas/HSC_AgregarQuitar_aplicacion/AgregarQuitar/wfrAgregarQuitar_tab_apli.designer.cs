namespace AgregarQuitar
{
    partial class wfrAgregarQuitar_tab_apli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfrAgregarQuitar_tab_apli));
            this.navegador1 = new Navegador.Navegador();
            this.txtcodapp = new System.Windows.Forms.TextBox();
            this.txtnomapp = new System.Windows.Forms.TextBox();
            this.txtfechm = new System.Windows.Forms.TextBox();
            this.txtfechc = new System.Windows.Forms.TextBox();
            this.txtestadoapp = new System.Windows.Forms.TextBox();
            this.lblCod_app = new System.Windows.Forms.Label();
            this.lblnomapli = new System.Windows.Forms.Label();
            this.lblfec = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblfechmod = new System.Windows.Forms.Label();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 31);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_sgaplicacion";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_BeforeClick += new System.EventHandler(this.navegador1_btnNuevo_BeforeClick);
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnModificar_BeforeClick += new System.EventHandler(this.navegador1_btnModificar_BeforeClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtcodapp
            // 
            this.txtcodapp.Location = new System.Drawing.Point(72, 120);
            this.txtcodapp.Name = "txtcodapp";
            this.txtcodapp.Size = new System.Drawing.Size(100, 20);
            this.txtcodapp.TabIndex = 1;
            this.txtcodapp.Tag = "cod_app";
            this.txtcodapp.TextChanged += new System.EventHandler(this.txtcodapp_TextChanged);
            // 
            // txtnomapp
            // 
            this.txtnomapp.Location = new System.Drawing.Point(72, 163);
            this.txtnomapp.Name = "txtnomapp";
            this.txtnomapp.Size = new System.Drawing.Size(100, 20);
            this.txtnomapp.TabIndex = 2;
            this.txtnomapp.Tag = "nomapp_app";
            // 
            // txtfechm
            // 
            this.txtfechm.Location = new System.Drawing.Point(293, 206);
            this.txtfechm.Name = "txtfechm";
            this.txtfechm.Size = new System.Drawing.Size(100, 20);
            this.txtfechm.TabIndex = 3;
            this.txtfechm.Tag = "fechmodif_app";
            // 
            // txtfechc
            // 
            this.txtfechc.Location = new System.Drawing.Point(72, 206);
            this.txtfechc.Name = "txtfechc";
            this.txtfechc.Size = new System.Drawing.Size(100, 20);
            this.txtfechc.TabIndex = 4;
            this.txtfechc.Tag = "fechcreado_app";
            // 
            // txtestadoapp
            // 
            this.txtestadoapp.Enabled = false;
            this.txtestadoapp.Location = new System.Drawing.Point(388, 164);
            this.txtestadoapp.Name = "txtestadoapp";
            this.txtestadoapp.Size = new System.Drawing.Size(47, 20);
            this.txtestadoapp.TabIndex = 5;
            this.txtestadoapp.Tag = "estado_app";
            this.txtestadoapp.TextChanged += new System.EventHandler(this.txtestadoapp_TextChanged);
            // 
            // lblCod_app
            // 
            this.lblCod_app.AutoSize = true;
            this.lblCod_app.Location = new System.Drawing.Point(72, 101);
            this.lblCod_app.Name = "lblCod_app";
            this.lblCod_app.Size = new System.Drawing.Size(91, 13);
            this.lblCod_app.TabIndex = 6;
            this.lblCod_app.Text = "Codigo aplicacion";
            // 
            // lblnomapli
            // 
            this.lblnomapli.AutoSize = true;
            this.lblnomapli.Location = new System.Drawing.Point(72, 147);
            this.lblnomapli.Name = "lblnomapli";
            this.lblnomapli.Size = new System.Drawing.Size(96, 13);
            this.lblnomapli.TabIndex = 7;
            this.lblnomapli.Text = "Nombre Aplicacion";
            // 
            // lblfec
            // 
            this.lblfec.AutoSize = true;
            this.lblfec.Location = new System.Drawing.Point(72, 190);
            this.lblfec.Name = "lblfec";
            this.lblfec.Size = new System.Drawing.Size(96, 13);
            this.lblfec.TabIndex = 8;
            this.lblfec.Text = "Fecha de creacion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(290, 147);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(92, 13);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado Aplicacion";
            // 
            // lblfechmod
            // 
            this.lblfechmod.AutoSize = true;
            this.lblfechmod.Location = new System.Drawing.Point(290, 190);
            this.lblfechmod.Name = "lblfechmod";
            this.lblfechmod.Size = new System.Drawing.Size(100, 13);
            this.lblfechmod.TabIndex = 10;
            this.lblfechmod.Text = "Fecha Modificacion";
            // 
            // cbestado
            // 
            this.cbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbestado.Items.AddRange(new object[] {
            "Activado",
            "Desactivado"});
            this.cbestado.Location = new System.Drawing.Point(293, 164);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(89, 21);
            this.cbestado.TabIndex = 11;
            this.cbestado.SelectedIndexChanged += new System.EventHandler(this.cbestado_SelectedIndexChanged);
            // 
            // wfrAgregarQuitar_tab_apli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 267);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.lblfechmod);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblfec);
            this.Controls.Add(this.lblnomapli);
            this.Controls.Add(this.lblCod_app);
            this.Controls.Add(this.txtestadoapp);
            this.Controls.Add(this.txtfechc);
            this.Controls.Add(this.txtfechm);
            this.Controls.Add(this.txtnomapp);
            this.Controls.Add(this.txtcodapp);
            this.Controls.Add(this.navegador1);
            this.Name = "wfrAgregarQuitar_tab_apli";
            this.Text = "wfrAgregarQuitar_tab_apli";
            this.Load += new System.EventHandler(this.wfrAgregarQuitar_tab_apli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtcodapp;
        private System.Windows.Forms.TextBox txtnomapp;
        private System.Windows.Forms.TextBox txtfechm;
        private System.Windows.Forms.TextBox txtfechc;
        private System.Windows.Forms.TextBox txtestadoapp;
        private System.Windows.Forms.Label lblCod_app;
        private System.Windows.Forms.Label lblnomapli;
        private System.Windows.Forms.Label lblfec;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblfechmod;
        private System.Windows.Forms.ComboBox cbestado;
    }
}