namespace AgregarQuitar
{
    partial class wfrPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfrPrincipal));
            this.navegador1 = new Navegador.Navegador();
            this.txtcodaappp = new System.Windows.Forms.TextBox();
            this.txtcodusr = new System.Windows.Forms.TextBox();
            this.txtcodap = new System.Windows.Forms.TextBox();
            this.lblcodappasi = new System.Windows.Forms.Label();
            this.lblcodusr = new System.Windows.Forms.Label();
            this.lblcodapp = new System.Windows.Forms.Label();
            this.lblfecModifi = new System.Windows.Forms.Label();
            this.txtfeccrea = new System.Windows.Forms.TextBox();
            this.lblfecModificacion = new System.Windows.Forms.Label();
            this.txtfecmod = new System.Windows.Forms.TextBox();
            this.btnagreapli = new System.Windows.Forms.Button();
            this.btnAgregaruser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 25);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(600, 54);
            this.navegador1.sNombreTabla = "tabt_sgasignapppersonal";
            this.navegador1.TabIndex = 0;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.navegador1_btnBuscar_AfterClick);
            this.navegador1.btnModificar_AfterClick += new System.EventHandler(this.navegador1_btnModificar_AfterClick);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // txtcodaappp
            // 
            this.txtcodaappp.Location = new System.Drawing.Point(53, 107);
            this.txtcodaappp.Name = "txtcodaappp";
            this.txtcodaappp.Size = new System.Drawing.Size(100, 20);
            this.txtcodaappp.TabIndex = 1;
            this.txtcodaappp.Tag = "cod_aappp";
            // 
            // txtcodusr
            // 
            this.txtcodusr.Location = new System.Drawing.Point(53, 154);
            this.txtcodusr.Name = "txtcodusr";
            this.txtcodusr.Size = new System.Drawing.Size(100, 20);
            this.txtcodusr.TabIndex = 2;
            this.txtcodusr.Tag = "cod_usr";
            this.txtcodusr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcodusr_MouseClick);
            // 
            // txtcodap
            // 
            this.txtcodap.Location = new System.Drawing.Point(275, 154);
            this.txtcodap.Name = "txtcodap";
            this.txtcodap.Size = new System.Drawing.Size(100, 20);
            this.txtcodap.TabIndex = 3;
            this.txtcodap.Tag = "cod_app";
            this.txtcodap.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtcodap_MouseClick);
            // 
            // lblcodappasi
            // 
            this.lblcodappasi.AutoSize = true;
            this.lblcodappasi.Location = new System.Drawing.Point(50, 91);
            this.lblcodappasi.Name = "lblcodappasi";
            this.lblcodappasi.Size = new System.Drawing.Size(138, 13);
            this.lblcodappasi.TabIndex = 11;
            this.lblcodappasi.Text = "Código Aplicación asignada";
            // 
            // lblcodusr
            // 
            this.lblcodusr.AutoSize = true;
            this.lblcodusr.Location = new System.Drawing.Point(50, 138);
            this.lblcodusr.Name = "lblcodusr";
            this.lblcodusr.Size = new System.Drawing.Size(79, 13);
            this.lblcodusr.TabIndex = 5;
            this.lblcodusr.Text = "Código Usuario";
            // 
            // lblcodapp
            // 
            this.lblcodapp.AutoSize = true;
            this.lblcodapp.Location = new System.Drawing.Point(275, 138);
            this.lblcodapp.Name = "lblcodapp";
            this.lblcodapp.Size = new System.Drawing.Size(92, 13);
            this.lblcodapp.TabIndex = 6;
            this.lblcodapp.Text = "Código Aplicación";
            // 
            // lblfecModifi
            // 
            this.lblfecModifi.AutoSize = true;
            this.lblfecModifi.Location = new System.Drawing.Point(50, 188);
            this.lblfecModifi.Name = "lblfecModifi";
            this.lblfecModifi.Size = new System.Drawing.Size(136, 13);
            this.lblfecModifi.TabIndex = 7;
            this.lblfecModifi.Text = "Fecha Aplicación Asignada";
            // 
            // txtfeccrea
            // 
            this.txtfeccrea.Location = new System.Drawing.Point(53, 204);
            this.txtfeccrea.Name = "txtfeccrea";
            this.txtfeccrea.Size = new System.Drawing.Size(100, 20);
            this.txtfeccrea.TabIndex = 4;
            this.txtfeccrea.Tag = "fechcreado_aappp";
            // 
            // lblfecModificacion
            // 
            this.lblfecModificacion.AutoSize = true;
            this.lblfecModificacion.Location = new System.Drawing.Point(275, 188);
            this.lblfecModificacion.Name = "lblfecModificacion";
            this.lblfecModificacion.Size = new System.Drawing.Size(100, 13);
            this.lblfecModificacion.TabIndex = 9;
            this.lblfecModificacion.Text = "Fecha Modificacion";
            // 
            // txtfecmod
            // 
            this.txtfecmod.Location = new System.Drawing.Point(275, 204);
            this.txtfecmod.Name = "txtfecmod";
            this.txtfecmod.Size = new System.Drawing.Size(100, 20);
            this.txtfecmod.TabIndex = 5;
            this.txtfecmod.Tag = "fechmodif_aappp";
            // 
            // btnagreapli
            // 
            this.btnagreapli.Location = new System.Drawing.Point(381, 150);
            this.btnagreapli.Name = "btnagreapli";
            this.btnagreapli.Size = new System.Drawing.Size(75, 23);
            this.btnagreapli.TabIndex = 12;
            this.btnagreapli.Text = "Agregar";
            this.btnagreapli.UseVisualStyleBackColor = true;
            this.btnagreapli.Click += new System.EventHandler(this.btnagreapli_Click);
            // 
            // btnAgregaruser
            // 
            this.btnAgregaruser.Location = new System.Drawing.Point(160, 150);
            this.btnAgregaruser.Name = "btnAgregaruser";
            this.btnAgregaruser.Size = new System.Drawing.Size(75, 23);
            this.btnAgregaruser.TabIndex = 13;
            this.btnAgregaruser.Text = "Agregar";
            this.btnAgregaruser.UseVisualStyleBackColor = true;
            this.btnAgregaruser.Click += new System.EventHandler(this.Agregaruser_Click);
            // 
            // wfrPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 247);
            this.Controls.Add(this.btnAgregaruser);
            this.Controls.Add(this.btnagreapli);
            this.Controls.Add(this.txtfecmod);
            this.Controls.Add(this.lblfecModificacion);
            this.Controls.Add(this.txtfeccrea);
            this.Controls.Add(this.lblfecModifi);
            this.Controls.Add(this.lblcodapp);
            this.Controls.Add(this.lblcodusr);
            this.Controls.Add(this.lblcodappasi);
            this.Controls.Add(this.txtcodap);
            this.Controls.Add(this.txtcodusr);
            this.Controls.Add(this.txtcodaappp);
            this.Controls.Add(this.navegador1);
            this.Name = "wfrPrincipal";
            this.Text = "wfrPrincipal";
            this.Load += new System.EventHandler(this.wfrPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtcodaappp;
        private System.Windows.Forms.TextBox txtcodusr;
        private System.Windows.Forms.TextBox txtcodap;
        private System.Windows.Forms.Label lblcodappasi;
        private System.Windows.Forms.Label lblcodusr;
        private System.Windows.Forms.Label lblcodapp;
        private System.Windows.Forms.Label lblfecModifi;
        private System.Windows.Forms.TextBox txtfeccrea;
        private System.Windows.Forms.Label lblfecModificacion;
        private System.Windows.Forms.TextBox txtfecmod;
        private System.Windows.Forms.Button btnagreapli;
        private System.Windows.Forms.Button btnAgregaruser;
    }
}