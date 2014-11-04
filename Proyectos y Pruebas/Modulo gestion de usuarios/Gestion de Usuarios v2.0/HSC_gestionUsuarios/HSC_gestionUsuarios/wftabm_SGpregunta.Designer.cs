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
            this.cbonom_preg = new System.Windows.Forms.ComboBox();
            this.txtnom_preg = new System.Windows.Forms.TextBox();
            this.txtcod_preg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtestado_preg
            // 
            this.txtestado_preg.Location = new System.Drawing.Point(420, 248);
            this.txtestado_preg.Name = "txtestado_preg";
            this.txtestado_preg.Size = new System.Drawing.Size(123, 20);
            this.txtestado_preg.TabIndex = 39;
            this.txtestado_preg.Tag = "estado_preg";
            this.txtestado_preg.Visible = false;
            this.txtestado_preg.TextChanged += new System.EventHandler(this.txtestado_preg_TextChanged);
            // 
            // cboestado_preg
            // 
            this.cboestado_preg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboestado_preg.FormattingEnabled = true;
            this.cboestado_preg.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_preg.Location = new System.Drawing.Point(141, 249);
            this.cboestado_preg.Name = "cboestado_preg";
            this.cboestado_preg.Size = new System.Drawing.Size(173, 21);
            this.cboestado_preg.TabIndex = 38;
            this.cboestado_preg.Tag = "estado_preg";
            this.cboestado_preg.SelectedIndexChanged += new System.EventHandler(this.cboestado_preg_SelectedIndexChanged);
            // 
            // cbonom_preg
            // 
            this.cbonom_preg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbonom_preg.FormattingEnabled = true;
            this.cbonom_preg.Items.AddRange(new object[] {
            "¿Cuál fue el nombre de su primera mascota?",
            "¿Cuál es el nombre de su abuela materna?",
            "¿Cuál es el nombre de su abuelo paterno?",
            "¿Cuál es su comida preferida?",
            "¿Cuál es su bebida preferida?",
            "¿Cuál es fue el nombre de su primer colegio?"});
            this.cbonom_preg.Location = new System.Drawing.Point(141, 214);
            this.cbonom_preg.Name = "cbonom_preg";
            this.cbonom_preg.Size = new System.Drawing.Size(255, 21);
            this.cbonom_preg.TabIndex = 37;
            this.cbonom_preg.Tag = "nom_preg";
            this.cbonom_preg.SelectedIndexChanged += new System.EventHandler(this.cbonom_preg_SelectedIndexChanged);
            // 
            // txtnom_preg
            // 
            this.txtnom_preg.Location = new System.Drawing.Point(420, 214);
            this.txtnom_preg.Name = "txtnom_preg";
            this.txtnom_preg.Size = new System.Drawing.Size(123, 20);
            this.txtnom_preg.TabIndex = 36;
            this.txtnom_preg.Tag = "nom_preg";
            this.txtnom_preg.Visible = false;
            this.txtnom_preg.TextChanged += new System.EventHandler(this.txtnom_preg_TextChanged);
            // 
            // txtcod_preg
            // 
            this.txtcod_preg.Location = new System.Drawing.Point(141, 176);
            this.txtcod_preg.Name = "txtcod_preg";
            this.txtcod_preg.Size = new System.Drawing.Size(173, 20);
            this.txtcod_preg.TabIndex = 35;
            this.txtcod_preg.Tag = "cod_preg";
            this.txtcod_preg.TextChanged += new System.EventHandler(this.txtcod_preg_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Estado pregunta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre Pregunta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Codigo Pregunta";
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 33);
            this.label4.TabIndex = 104;
            this.label4.Text = "Pregunta secreta";
            // 
            // wftabm_SGpregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(653, 307);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtestado_preg);
            this.Controls.Add(this.cboestado_preg);
            this.Controls.Add(this.cbonom_preg);
            this.Controls.Add(this.txtnom_preg);
            this.Controls.Add(this.txtcod_preg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.ComboBox cbonom_preg;
        private System.Windows.Forms.TextBox txtnom_preg;
        private System.Windows.Forms.TextBox txtcod_preg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label4;
    }
}