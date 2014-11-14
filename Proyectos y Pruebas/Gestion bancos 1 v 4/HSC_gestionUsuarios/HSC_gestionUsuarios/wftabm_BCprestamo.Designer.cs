namespace HSC_gestionBancos
{
    partial class wftabm_BCprestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabm_BCprestamo));
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtCodPrestamo = new System.Windows.Forms.TextBox();
            this.lblEstadoPrestamo = new System.Windows.Forms.Label();
            this.lblnom_perfil = new System.Windows.Forms.Label();
            this.lblCodPrest = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblpregunta_secreta = new System.Windows.Forms.Label();
            this.lblFechCreacion = new System.Windows.Forms.Label();
            this.txtFechCreacion = new System.Windows.Forms.TextBox();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.lblInteres = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnObtenerF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(320, 345);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(123, 20);
            this.txtEstado.TabIndex = 39;
            this.txtEstado.Tag = "estado_prem";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtestado_preg_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(141, 344);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(173, 21);
            this.cboEstado.TabIndex = 38;
            this.cboEstado.Tag = "estado_prem";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboestado_preg_SelectedIndexChanged);
            // 
            // txtCodPrestamo
            // 
            this.txtCodPrestamo.Location = new System.Drawing.Point(141, 176);
            this.txtCodPrestamo.Name = "txtCodPrestamo";
            this.txtCodPrestamo.Size = new System.Drawing.Size(173, 20);
            this.txtCodPrestamo.TabIndex = 35;
            this.txtCodPrestamo.Tag = "codprem_prem";
            this.txtCodPrestamo.TextChanged += new System.EventHandler(this.txtcod_preg_TextChanged);
            // 
            // lblEstadoPrestamo
            // 
            this.lblEstadoPrestamo.AutoSize = true;
            this.lblEstadoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoPrestamo.ForeColor = System.Drawing.Color.Black;
            this.lblEstadoPrestamo.Location = new System.Drawing.Point(20, 347);
            this.lblEstadoPrestamo.Name = "lblEstadoPrestamo";
            this.lblEstadoPrestamo.Size = new System.Drawing.Size(45, 15);
            this.lblEstadoPrestamo.TabIndex = 34;
            this.lblEstadoPrestamo.Text = "Estado";
            // 
            // lblnom_perfil
            // 
            this.lblnom_perfil.AutoSize = true;
            this.lblnom_perfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnom_perfil.ForeColor = System.Drawing.Color.Black;
            this.lblnom_perfil.Location = new System.Drawing.Point(20, 219);
            this.lblnom_perfil.Name = "lblnom_perfil";
            this.lblnom_perfil.Size = new System.Drawing.Size(0, 15);
            this.lblnom_perfil.TabIndex = 33;
            // 
            // lblCodPrest
            // 
            this.lblCodPrest.AutoSize = true;
            this.lblCodPrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPrest.ForeColor = System.Drawing.Color.Black;
            this.lblCodPrest.Location = new System.Drawing.Point(20, 180);
            this.lblCodPrest.Name = "lblCodPrest";
            this.lblCodPrest.Size = new System.Drawing.Size(101, 15);
            this.lblCodPrest.TabIndex = 32;
            this.lblCodPrest.Text = "Codigo prestamo";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(23, 88);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabm_bcprestamo";
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
            this.lblpregunta_secreta.Size = new System.Drawing.Size(140, 33);
            this.lblpregunta_secreta.TabIndex = 104;
            this.lblpregunta_secreta.Text = "Prestamo";
            // 
            // lblFechCreacion
            // 
            this.lblFechCreacion.AutoSize = true;
            this.lblFechCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechCreacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechCreacion.Location = new System.Drawing.Point(20, 219);
            this.lblFechCreacion.Name = "lblFechCreacion";
            this.lblFechCreacion.Size = new System.Drawing.Size(91, 15);
            this.lblFechCreacion.TabIndex = 105;
            this.lblFechCreacion.Text = "Fecha creacion";
            // 
            // txtFechCreacion
            // 
            this.txtFechCreacion.Location = new System.Drawing.Point(141, 214);
            this.txtFechCreacion.Name = "txtFechCreacion";
            this.txtFechCreacion.Size = new System.Drawing.Size(173, 20);
            this.txtFechCreacion.TabIndex = 106;
            this.txtFechCreacion.Tag = "fechcreac_prem";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(141, 255);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(173, 20);
            this.txtInteres.TabIndex = 110;
            this.txtInteres.Tag = "intr_prem";
            this.txtInteres.TextChanged += new System.EventHandler(this.txtPerfilTecnico_TextChanged);
            // 
            // lblInteres
            // 
            this.lblInteres.AutoSize = true;
            this.lblInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteres.ForeColor = System.Drawing.Color.Black;
            this.lblInteres.Location = new System.Drawing.Point(20, 256);
            this.lblInteres.Name = "lblInteres";
            this.lblInteres.Size = new System.Drawing.Size(44, 15);
            this.lblInteres.TabIndex = 109;
            this.lblInteres.Text = "Interes";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(20, 304);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 111;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(141, 299);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(173, 20);
            this.txtCantidad.TabIndex = 112;
            this.txtCantidad.Tag = "cant_prem";
            // 
            // btnObtenerF
            // 
            this.btnObtenerF.Location = new System.Drawing.Point(329, 216);
            this.btnObtenerF.Name = "btnObtenerF";
            this.btnObtenerF.Size = new System.Drawing.Size(94, 23);
            this.btnObtenerF.TabIndex = 113;
            this.btnObtenerF.Text = "Obtener fechas";
            this.btnObtenerF.UseVisualStyleBackColor = true;
            this.btnObtenerF.Click += new System.EventHandler(this.btnObtenerF_Click);
            // 
            // wftabm_BCprestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(683, 413);
            this.Controls.Add(this.btnObtenerF);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.lblInteres);
            this.Controls.Add(this.txtFechCreacion);
            this.Controls.Add(this.lblFechCreacion);
            this.Controls.Add(this.lblpregunta_secreta);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtCodPrestamo);
            this.Controls.Add(this.lblEstadoPrestamo);
            this.Controls.Add(this.lblnom_perfil);
            this.Controls.Add(this.lblCodPrest);
            this.Name = "wftabm_BCprestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregunta secreta";
            this.Load += new System.EventHandler(this.wftabm_SGpregunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtCodPrestamo;
        private System.Windows.Forms.Label lblEstadoPrestamo;
        private System.Windows.Forms.Label lblnom_perfil;
        private System.Windows.Forms.Label lblCodPrest;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblpregunta_secreta;
        private System.Windows.Forms.Label lblFechCreacion;
        private System.Windows.Forms.TextBox txtFechCreacion;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label lblInteres;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnObtenerF;
    }
}