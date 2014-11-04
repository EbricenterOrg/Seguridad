namespace HSC_gestionUsuarios
{
    partial class wftabm_SGpregunta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabm_SGpregunta));
            this.txtestado_preg = new System.Windows.Forms.TextBox();
            this.cboestado_preg = new System.Windows.Forms.ComboBox();
            this.txtnom_preg = new System.Windows.Forms.TextBox();
            this.txtcod_preg = new System.Windows.Forms.TextBox();
            this.lblestado_preg = new System.Windows.Forms.Label();
            this.lblnom_preg = new System.Windows.Forms.Label();
            this.lblcod_preg = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblpregunta_secreta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtestado_preg
            // 
            this.txtestado_preg.Enabled = false;
            this.txtestado_preg.Location = new System.Drawing.Point(331, 247);
            this.txtestado_preg.Name = "txtestado_preg";
            this.txtestado_preg.Size = new System.Drawing.Size(123, 20);
            this.txtestado_preg.TabIndex = 39;
            this.txtestado_preg.Tag = "estado_preg";
            this.txtestado_preg.TextChanged += new System.EventHandler(this.txtestado_preg_TextChanged);
            // 
            // cboestado_preg
            // 
            this.cboestado_preg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado_preg.Enabled = false;
            this.cboestado_preg.FormattingEnabled = true;
            this.cboestado_preg.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_preg.Location = new System.Drawing.Point(141, 249);
            this.cboestado_preg.Name = "cboestado_preg";
            this.cboestado_preg.Size = new System.Drawing.Size(173, 21);
            this.cboestado_preg.TabIndex = 38;
            this.cboestado_preg.Tag = "";
            this.cboestado_preg.SelectedIndexChanged += new System.EventHandler(this.cboestado_preg_SelectedIndexChanged);
            // 
            // txtnom_preg
            // 
            this.txtnom_preg.Enabled = false;
            this.txtnom_preg.Location = new System.Drawing.Point(141, 218);
            this.txtnom_preg.Name = "txtnom_preg";
            this.txtnom_preg.Size = new System.Drawing.Size(173, 20);
            this.txtnom_preg.TabIndex = 36;
            this.txtnom_preg.Tag = "nom_preg";
            this.txtnom_preg.TextChanged += new System.EventHandler(this.txtnom_preg_TextChanged);
            // 
            // txtcod_preg
            // 
            this.txtcod_preg.Enabled = false;
            this.txtcod_preg.Location = new System.Drawing.Point(141, 176);
            this.txtcod_preg.Name = "txtcod_preg";
            this.txtcod_preg.Size = new System.Drawing.Size(173, 20);
            this.txtcod_preg.TabIndex = 35;
            this.txtcod_preg.Tag = "cod_preg";
            this.txtcod_preg.TextChanged += new System.EventHandler(this.txtcod_preg_TextChanged);
            // 
            // lblestado_preg
            // 
            this.lblestado_preg.AutoSize = true;
            this.lblestado_preg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado_preg.ForeColor = System.Drawing.Color.Black;
            this.lblestado_preg.Location = new System.Drawing.Point(20, 252);
            this.lblestado_preg.Name = "lblestado_preg";
            this.lblestado_preg.Size = new System.Drawing.Size(100, 15);
            this.lblestado_preg.TabIndex = 34;
            this.lblestado_preg.Text = "Estado pregunta:";
            // 
            // lblnom_preg
            // 
            this.lblnom_preg.AutoSize = true;
            this.lblnom_preg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom_preg.ForeColor = System.Drawing.Color.Black;
            this.lblnom_preg.Location = new System.Drawing.Point(20, 219);
            this.lblnom_preg.Name = "lblnom_preg";
            this.lblnom_preg.Size = new System.Drawing.Size(105, 15);
            this.lblnom_preg.TabIndex = 33;
            this.lblnom_preg.Text = "Nombre Pregunta";
            // 
            // lblcod_preg
            // 
            this.lblcod_preg.AutoSize = true;
            this.lblcod_preg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcod_preg.ForeColor = System.Drawing.Color.Black;
            this.lblcod_preg.Location = new System.Drawing.Point(20, 180);
            this.lblcod_preg.Name = "lblcod_preg";
            this.lblcod_preg.Size = new System.Drawing.Size(99, 15);
            this.lblcod_preg.TabIndex = 32;
            this.lblcod_preg.Text = "Codigo Pregunta";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(23, 88);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_sgpregunta";
            this.navegador1.TabIndex = 40;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // lblpregunta_secreta
            // 
            this.lblpregunta_secreta.AutoSize = true;
            this.lblpregunta_secreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpregunta_secreta.ForeColor = System.Drawing.Color.Black;
            this.lblpregunta_secreta.Location = new System.Drawing.Point(17, 38);
            this.lblpregunta_secreta.Name = "lblpregunta_secreta";
            this.lblpregunta_secreta.Size = new System.Drawing.Size(236, 33);
            this.lblpregunta_secreta.TabIndex = 104;
            this.lblpregunta_secreta.Text = "Pregunta secreta";
            // 
            // wftabm_SGpregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 307);
            this.Controls.Add(this.lblpregunta_secreta);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtestado_preg);
            this.Controls.Add(this.cboestado_preg);
            this.Controls.Add(this.txtnom_preg);
            this.Controls.Add(this.txtcod_preg);
            this.Controls.Add(this.lblestado_preg);
            this.Controls.Add(this.lblnom_preg);
            this.Controls.Add(this.lblcod_preg);
            this.Name = "wftabm_SGpregunta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta secreta";
            this.Load += new System.EventHandler(this.wftabm_SGpregunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtestado_preg;
        private System.Windows.Forms.ComboBox cboestado_preg;
        private System.Windows.Forms.TextBox txtnom_preg;
        private System.Windows.Forms.TextBox txtcod_preg;
        private System.Windows.Forms.Label lblestado_preg;
        private System.Windows.Forms.Label lblnom_preg;
        private System.Windows.Forms.Label lblcod_preg;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblpregunta_secreta;
    }
}