namespace Inicio_de_Sesion
{
    partial class wfPreguntaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPreguntaUsuario));
            this.navegador1 = new Navegador.Navegador();
            this.lblPerfilUser = new System.Windows.Forms.Label();
            this.txtestado_preg = new System.Windows.Forms.TextBox();
            this.lblCodPer = new System.Windows.Forms.Label();
            this.txtnom_preg = new System.Windows.Forms.TextBox();
            this.lblCodUsur = new System.Windows.Forms.Label();
            this.lblCodPUser = new System.Windows.Forms.Label();
            this.txtcod_preg = new System.Windows.Forms.TextBox();
            this.cbonom_preg = new System.Windows.Forms.ComboBox();
            this.cboestado_preg = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(28, 36);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_sgpregunta";
            this.navegador1.TabIndex = 0;
            // 
            // lblPerfilUser
            // 
            this.lblPerfilUser.AutoSize = true;
            this.lblPerfilUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilUser.Location = new System.Drawing.Point(23, 9);
            this.lblPerfilUser.Name = "lblPerfilUser";
            this.lblPerfilUser.Size = new System.Drawing.Size(176, 25);
            this.lblPerfilUser.TabIndex = 20;
            this.lblPerfilUser.Text = "Pregunta usuario";
            // 
            // txtestado_preg
            // 
            this.txtestado_preg.Location = new System.Drawing.Point(268, 195);
            this.txtestado_preg.Name = "txtestado_preg";
            this.txtestado_preg.Size = new System.Drawing.Size(74, 20);
            this.txtestado_preg.TabIndex = 41;
            this.txtestado_preg.Tag = "estado_preg";
            this.txtestado_preg.TextChanged += new System.EventHandler(this.txtestado_preg_TextChanged);
            // 
            // lblCodPer
            // 
            this.lblCodPer.AutoSize = true;
            this.lblCodPer.Location = new System.Drawing.Point(33, 199);
            this.lblCodPer.Name = "lblCodPer";
            this.lblCodPer.Size = new System.Drawing.Size(86, 13);
            this.lblCodPer.TabIndex = 40;
            this.lblCodPer.Tag = "";
            this.lblCodPer.Text = "Estado Pregunta";
            this.lblCodPer.Click += new System.EventHandler(this.lblCodApp_Click);
            // 
            // txtnom_preg
            // 
            this.txtnom_preg.Location = new System.Drawing.Point(448, 158);
            this.txtnom_preg.Name = "txtnom_preg";
            this.txtnom_preg.Size = new System.Drawing.Size(100, 20);
            this.txtnom_preg.TabIndex = 39;
            this.txtnom_preg.Tag = "nom_preg";
            this.txtnom_preg.TextChanged += new System.EventHandler(this.txtnom_preg_TextChanged);
            // 
            // lblCodUsur
            // 
            this.lblCodUsur.AutoSize = true;
            this.lblCodUsur.Location = new System.Drawing.Point(33, 162);
            this.lblCodUsur.Name = "lblCodUsur";
            this.lblCodUsur.Size = new System.Drawing.Size(90, 13);
            this.lblCodUsur.TabIndex = 38;
            this.lblCodUsur.Tag = "";
            this.lblCodUsur.Text = "Nombre Pregunta";
            // 
            // lblCodPUser
            // 
            this.lblCodPUser.AutoSize = true;
            this.lblCodPUser.Location = new System.Drawing.Point(33, 127);
            this.lblCodPUser.Name = "lblCodPUser";
            this.lblCodPUser.Size = new System.Drawing.Size(85, 13);
            this.lblCodPUser.TabIndex = 30;
            this.lblCodPUser.Tag = "";
            this.lblCodPUser.Text = "Codigo pregunta";
            // 
            // txtcod_preg
            // 
            this.txtcod_preg.Location = new System.Drawing.Point(141, 124);
            this.txtcod_preg.Name = "txtcod_preg";
            this.txtcod_preg.Size = new System.Drawing.Size(93, 20);
            this.txtcod_preg.TabIndex = 22;
            this.txtcod_preg.Tag = "cod_preg";
            this.txtcod_preg.TextChanged += new System.EventHandler(this.txtCodPerUser_TextChanged);
            // 
            // cbonom_preg
            // 
            this.cbonom_preg.FormattingEnabled = true;
            this.cbonom_preg.Items.AddRange(new object[] {
            "¿Cuál fue el nombre de su primera mascota?",
            "¿Cuál es el nombre de su abuela materna?",
            "¿Cuál es el nombre de su abuelo paterno?",
            "¿Cuál es su comida preferida?",
            "¿Cuál es su bebida preferida?",
            "¿Cuál es fue el nombre de su primer colegio?"});
            this.cbonom_preg.Location = new System.Drawing.Point(141, 157);
            this.cbonom_preg.Name = "cbonom_preg";
            this.cbonom_preg.Size = new System.Drawing.Size(301, 21);
            this.cbonom_preg.TabIndex = 42;
            this.cbonom_preg.Tag = "nom_preg1";
            this.cbonom_preg.SelectedIndexChanged += new System.EventHandler(this.cbonom_preg_SelectedIndexChanged);
            // 
            // cboestado_preg
            // 
            this.cboestado_preg.FormattingEnabled = true;
            this.cboestado_preg.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboestado_preg.Location = new System.Drawing.Point(141, 194);
            this.cboestado_preg.Name = "cboestado_preg";
            this.cboestado_preg.Size = new System.Drawing.Size(121, 21);
            this.cboestado_preg.TabIndex = 43;
            this.cboestado_preg.Tag = "estado_preg1";
            this.cboestado_preg.SelectedIndexChanged += new System.EventHandler(this.cboestado_preg_SelectedIndexChanged);
            // 
            // wfPreguntaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 291);
            this.Controls.Add(this.cboestado_preg);
            this.Controls.Add(this.cbonom_preg);
            this.Controls.Add(this.txtestado_preg);
            this.Controls.Add(this.lblCodPer);
            this.Controls.Add(this.txtnom_preg);
            this.Controls.Add(this.lblCodUsur);
            this.Controls.Add(this.lblCodPUser);
            this.Controls.Add(this.txtcod_preg);
            this.Controls.Add(this.lblPerfilUser);
            this.Controls.Add(this.navegador1);
            this.Name = "wfPreguntaUsuario";
            this.Text = "Formulario pregunta usuario";
            this.Load += new System.EventHandler(this.wfPerfilUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblPerfilUser;
        private System.Windows.Forms.TextBox txtestado_preg;
        private System.Windows.Forms.Label lblCodPer;
        private System.Windows.Forms.TextBox txtnom_preg;
        private System.Windows.Forms.Label lblCodUsur;
        private System.Windows.Forms.Label lblCodPUser;
        private System.Windows.Forms.TextBox txtcod_preg;
        private System.Windows.Forms.ComboBox cbonom_preg;
        private System.Windows.Forms.ComboBox cboestado_preg;
    }
}