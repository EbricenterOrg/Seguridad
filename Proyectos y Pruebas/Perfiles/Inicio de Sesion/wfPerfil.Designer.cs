namespace Inicio_de_Sesion
{
    partial class wfPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPerfil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtEstadoPerfil = new System.Windows.Forms.TextBox();
            this.txtCodpfl1 = new System.Windows.Forms.TextBox();
            this.txtFechModifPerfil = new System.Windows.Forms.TextBox();
            this.txtFechCreacionPerfil = new System.Windows.Forms.TextBox();
            this.lblNombreFormulario = new System.Windows.Forms.Label();
            this.txtCodperfil = new System.Windows.Forms.TextBox();
            this.lblPerfiltecnico = new System.Windows.Forms.Label();
            this.lblEstadoperfil = new System.Windows.Forms.Label();
            this.lblFechmodifperfil = new System.Windows.Forms.Label();
            this.lblFechacreacionperfil = new System.Windows.Forms.Label();
            this.txtNombreperfil = new System.Windows.Forms.TextBox();
            this.lblNombreperfil = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblCodperfil = new System.Windows.Forms.Label();
            this.cboEstadoPerf = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.cboEstadoPerf);
            this.panel1.Controls.Add(this.txtEstadoPerfil);
            this.panel1.Controls.Add(this.txtCodpfl1);
            this.panel1.Controls.Add(this.txtFechModifPerfil);
            this.panel1.Controls.Add(this.txtFechCreacionPerfil);
            this.panel1.Controls.Add(this.lblNombreFormulario);
            this.panel1.Controls.Add(this.txtCodperfil);
            this.panel1.Controls.Add(this.lblPerfiltecnico);
            this.panel1.Controls.Add(this.lblEstadoperfil);
            this.panel1.Controls.Add(this.lblFechmodifperfil);
            this.panel1.Controls.Add(this.lblFechacreacionperfil);
            this.panel1.Controls.Add(this.txtNombreperfil);
            this.panel1.Controls.Add(this.lblNombreperfil);
            this.panel1.Controls.Add(this.navegador1);
            this.panel1.Controls.Add(this.lblCodperfil);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 720);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtEstadoPerfil
            // 
            this.txtEstadoPerfil.Location = new System.Drawing.Point(536, 318);
            this.txtEstadoPerfil.Name = "txtEstadoPerfil";
            this.txtEstadoPerfil.Size = new System.Drawing.Size(79, 20);
            this.txtEstadoPerfil.TabIndex = 17;
            this.txtEstadoPerfil.Tag = "estado_pfl";
            this.txtEstadoPerfil.Visible = false;
            this.txtEstadoPerfil.TextChanged += new System.EventHandler(this.txt14_TextChanged);
            // 
            // txtCodpfl1
            // 
            this.txtCodpfl1.Location = new System.Drawing.Point(392, 279);
            this.txtCodpfl1.Name = "txtCodpfl1";
            this.txtCodpfl1.Size = new System.Drawing.Size(123, 20);
            this.txtCodpfl1.TabIndex = 16;
            this.txtCodpfl1.Tag = "cod_pfl_1";
            this.txtCodpfl1.TextChanged += new System.EventHandler(this.txt13_TextChanged);
            // 
            // txtFechModifPerfil
            // 
            this.txtFechModifPerfil.Location = new System.Drawing.Point(393, 247);
            this.txtFechModifPerfil.Name = "txtFechModifPerfil";
            this.txtFechModifPerfil.Size = new System.Drawing.Size(122, 20);
            this.txtFechModifPerfil.TabIndex = 15;
            this.txtFechModifPerfil.Tag = "fechmodif_pfl";
            this.txtFechModifPerfil.TextChanged += new System.EventHandler(this.txt12_TextChanged);
            // 
            // txtFechCreacionPerfil
            // 
            this.txtFechCreacionPerfil.Location = new System.Drawing.Point(388, 206);
            this.txtFechCreacionPerfil.Name = "txtFechCreacionPerfil";
            this.txtFechCreacionPerfil.Size = new System.Drawing.Size(126, 20);
            this.txtFechCreacionPerfil.TabIndex = 14;
            this.txtFechCreacionPerfil.Tag = "fechcreado_pfl";
            this.txtFechCreacionPerfil.TextChanged += new System.EventHandler(this.txt11_TextChanged);
            // 
            // lblNombreFormulario
            // 
            this.lblNombreFormulario.AutoSize = true;
            this.lblNombreFormulario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreFormulario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreFormulario.Location = new System.Drawing.Point(11, 12);
            this.lblNombreFormulario.Name = "lblNombreFormulario";
            this.lblNombreFormulario.Size = new System.Drawing.Size(83, 31);
            this.lblNombreFormulario.TabIndex = 52;
            this.lblNombreFormulario.Text = "Perfil ";
            // 
            // txtCodperfil
            // 
            this.txtCodperfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodperfil.Location = new System.Drawing.Point(388, 123);
            this.txtCodperfil.Name = "txtCodperfil";
            this.txtCodperfil.Size = new System.Drawing.Size(125, 20);
            this.txtCodperfil.TabIndex = 12;
            this.txtCodperfil.Tag = "cod_pfl";
            this.txtCodperfil.TextChanged += new System.EventHandler(this.txtCodperfil_TextChanged);
            // 
            // lblPerfiltecnico
            // 
            this.lblPerfiltecnico.AutoSize = true;
            this.lblPerfiltecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfiltecnico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPerfiltecnico.Location = new System.Drawing.Point(273, 283);
            this.lblPerfiltecnico.Name = "lblPerfiltecnico";
            this.lblPerfiltecnico.Size = new System.Drawing.Size(49, 13);
            this.lblPerfiltecnico.TabIndex = 38;
            this.lblPerfiltecnico.Text = "Cod pfl 1";
            // 
            // lblEstadoperfil
            // 
            this.lblEstadoperfil.AutoSize = true;
            this.lblEstadoperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoperfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstadoperfil.Location = new System.Drawing.Point(272, 325);
            this.lblEstadoperfil.Name = "lblEstadoperfil";
            this.lblEstadoperfil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoperfil.TabIndex = 40;
            this.lblEstadoperfil.Text = "Estado perfil";
            // 
            // lblFechmodifperfil
            // 
            this.lblFechmodifperfil.AutoSize = true;
            this.lblFechmodifperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechmodifperfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechmodifperfil.Location = new System.Drawing.Point(230, 246);
            this.lblFechmodifperfil.Name = "lblFechmodifperfil";
            this.lblFechmodifperfil.Size = new System.Drawing.Size(124, 13);
            this.lblFechmodifperfil.TabIndex = 36;
            this.lblFechmodifperfil.Text = "Fecha modificacion perfil";
            this.lblFechmodifperfil.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblFechacreacionperfil
            // 
            this.lblFechacreacionperfil.AutoSize = true;
            this.lblFechacreacionperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechacreacionperfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFechacreacionperfil.Location = new System.Drawing.Point(245, 210);
            this.lblFechacreacionperfil.Name = "lblFechacreacionperfil";
            this.lblFechacreacionperfil.Size = new System.Drawing.Size(106, 13);
            this.lblFechacreacionperfil.TabIndex = 34;
            this.lblFechacreacionperfil.Text = "Fecha creacion perfil";
            this.lblFechacreacionperfil.Click += new System.EventHandler(this.lblFechacreacionperfil_Click);
            // 
            // txtNombreperfil
            // 
            this.txtNombreperfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreperfil.Location = new System.Drawing.Point(388, 166);
            this.txtNombreperfil.Name = "txtNombreperfil";
            this.txtNombreperfil.Size = new System.Drawing.Size(125, 20);
            this.txtNombreperfil.TabIndex = 13;
            this.txtNombreperfil.Tag = "nom_pfl";
            // 
            // lblNombreperfil
            // 
            this.lblNombreperfil.AutoSize = true;
            this.lblNombreperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreperfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombreperfil.Location = new System.Drawing.Point(267, 166);
            this.lblNombreperfil.Name = "lblNombreperfil";
            this.lblNombreperfil.Size = new System.Drawing.Size(69, 13);
            this.lblNombreperfil.TabIndex = 32;
            this.lblNombreperfil.Text = "Nombre perfil";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(101, 46);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_sgperfil";
            this.navegador1.TabIndex = 1;
            this.navegador1.btnGuardar_AfterClick += new System.EventHandler(this.navegador1_btnGuardar_AfterClick);
            this.navegador1.btnBuscar_AfterClick += new System.EventHandler(this.textBox9_TextChanged);
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // lblCodperfil
            // 
            this.lblCodperfil.AutoSize = true;
            this.lblCodperfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodperfil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCodperfil.Location = new System.Drawing.Point(268, 125);
            this.lblCodperfil.Name = "lblCodperfil";
            this.lblCodperfil.Size = new System.Drawing.Size(68, 13);
            this.lblCodperfil.TabIndex = 14;
            this.lblCodperfil.Text = "Codigo perfil ";
            // 
            // cboEstadoPerf
            // 
            this.cboEstadoPerf.FormattingEnabled = true;
            this.cboEstadoPerf.Location = new System.Drawing.Point(394, 317);
            this.cboEstadoPerf.Name = "cboEstadoPerf";
            this.cboEstadoPerf.Size = new System.Drawing.Size(121, 21);
            this.cboEstadoPerf.TabIndex = 53;
            this.cboEstadoPerf.Tag = "estado_pfl";
            this.cboEstadoPerf.SelectedIndexChanged += new System.EventHandler(this.cboEstadoPerf_SelectedIndexChanged);
            // 
            // wfPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(796, 365);
            this.Controls.Add(this.panel1);
            this.Name = "wfPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Perfil";
            this.Load += new System.EventHandler(this.wfFormularioUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCodperfil;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtNombreperfil;
        private System.Windows.Forms.Label lblNombreperfil;
        private System.Windows.Forms.Label lblFechmodifperfil;
        private System.Windows.Forms.Label lblFechacreacionperfil;
        private System.Windows.Forms.Label lblEstadoperfil;
        private System.Windows.Forms.Label lblPerfiltecnico;
        private System.Windows.Forms.TextBox txtCodperfil;
        private System.Windows.Forms.Label lblNombreFormulario;
        private System.Windows.Forms.TextBox txtEstadoPerfil;
        private System.Windows.Forms.TextBox txtCodpfl1;
        private System.Windows.Forms.TextBox txtFechModifPerfil;
        private System.Windows.Forms.TextBox txtFechCreacionPerfil;
        private System.Windows.Forms.ComboBox cboEstadoPerf;

    }
}