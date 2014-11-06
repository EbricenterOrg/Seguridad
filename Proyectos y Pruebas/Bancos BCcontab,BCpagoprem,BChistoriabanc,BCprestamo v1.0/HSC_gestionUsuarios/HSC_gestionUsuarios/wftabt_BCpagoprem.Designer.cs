namespace HSC_gestionUsuarios
{
    partial class wftabt_BCpagoprem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabt_BCpagoprem));
            this.lblgestion_privilegios = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblCodCtaBco = new System.Windows.Forms.Label();
            this.lblCodPrestamo = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCodCtaBco = new System.Windows.Forms.TextBox();
            this.txtCodPrestamo = new System.Windows.Forms.TextBox();
            this.txtFechCreacion = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnObtener = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblgestion_privilegios
            // 
            this.lblgestion_privilegios.AutoSize = true;
            this.lblgestion_privilegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestion_privilegios.ForeColor = System.Drawing.Color.Black;
            this.lblgestion_privilegios.Location = new System.Drawing.Point(58, 26);
            this.lblgestion_privilegios.Name = "lblgestion_privilegios";
            this.lblgestion_privilegios.Size = new System.Drawing.Size(212, 33);
            this.lblgestion_privilegios.TabIndex = 103;
            this.lblgestion_privilegios.Text = "Pago prestamo";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(64, 73);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabt_bcpagoprem";
            this.navegador1.TabIndex = 104;
            this.navegador1.btnNuevo_AfterClick += new System.EventHandler(this.navegador1_btnNuevo_AfterClick);
            // 
            // lblCodCtaBco
            // 
            this.lblCodCtaBco.AutoSize = true;
            this.lblCodCtaBco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCtaBco.ForeColor = System.Drawing.Color.Black;
            this.lblCodCtaBco.Location = new System.Drawing.Point(77, 157);
            this.lblCodCtaBco.Name = "lblCodCtaBco";
            this.lblCodCtaBco.Size = new System.Drawing.Size(123, 15);
            this.lblCodCtaBco.TabIndex = 105;
            this.lblCodCtaBco.Text = "Codigo cuenta banco";
            // 
            // lblCodPrestamo
            // 
            this.lblCodPrestamo.AutoSize = true;
            this.lblCodPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodPrestamo.ForeColor = System.Drawing.Color.Black;
            this.lblCodPrestamo.Location = new System.Drawing.Point(77, 188);
            this.lblCodPrestamo.Name = "lblCodPrestamo";
            this.lblCodPrestamo.Size = new System.Drawing.Size(101, 15);
            this.lblCodPrestamo.TabIndex = 106;
            this.lblCodPrestamo.Text = "Codigo prestamo";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCreacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaCreacion.Location = new System.Drawing.Point(80, 217);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(91, 15);
            this.lblFechaCreacion.TabIndex = 108;
            this.lblFechaCreacion.Text = "Fecha creacion";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.Black;
            this.lblEstado.Location = new System.Drawing.Point(80, 298);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(48, 15);
            this.lblEstado.TabIndex = 109;
            this.lblEstado.Text = "Estado:";
            // 
            // txtCodCtaBco
            // 
            this.txtCodCtaBco.Location = new System.Drawing.Point(213, 152);
            this.txtCodCtaBco.Name = "txtCodCtaBco";
            this.txtCodCtaBco.Size = new System.Drawing.Size(138, 20);
            this.txtCodCtaBco.TabIndex = 110;
            this.txtCodCtaBco.Tag = "cod_ctabco";
            this.txtCodCtaBco.TextChanged += new System.EventHandler(this.txtcod_priv_TextChanged);
            // 
            // txtCodPrestamo
            // 
            this.txtCodPrestamo.Location = new System.Drawing.Point(213, 184);
            this.txtCodPrestamo.Name = "txtCodPrestamo";
            this.txtCodPrestamo.Size = new System.Drawing.Size(141, 20);
            this.txtCodPrestamo.TabIndex = 111;
            this.txtCodPrestamo.Tag = "codprem_prem";
            // 
            // txtFechCreacion
            // 
            this.txtFechCreacion.Location = new System.Drawing.Point(213, 217);
            this.txtFechCreacion.Name = "txtFechCreacion";
            this.txtFechCreacion.Size = new System.Drawing.Size(141, 20);
            this.txtFechCreacion.TabIndex = 113;
            this.txtFechCreacion.Tag = "fechcreado_pagoprem";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(210, 298);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(141, 21);
            this.cboEstado.TabIndex = 114;
            this.cboEstado.Tag = "estado_pagoprem";
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboestado_priv_SelectedIndexChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(368, 298);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 115;
            this.txtEstado.Tag = "estado_pagoprem";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtestado_priv_TextChanged);
            // 
            // btnObtener
            // 
            this.btnObtener.Location = new System.Drawing.Point(368, 217);
            this.btnObtener.Name = "btnObtener";
            this.btnObtener.Size = new System.Drawing.Size(75, 23);
            this.btnObtener.TabIndex = 116;
            this.btnObtener.Text = "Obtener";
            this.btnObtener.UseVisualStyleBackColor = true;
            this.btnObtener.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(368, 188);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 119;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnObtenerCodusr_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(210, 256);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(141, 20);
            this.txtCantidad.TabIndex = 118;
            this.txtCantidad.Tag = "cantpag_pagoprem";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Black;
            this.lblCantidad.Location = new System.Drawing.Point(77, 256);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(56, 15);
            this.lblCantidad.TabIndex = 117;
            this.lblCantidad.Text = "Cantidad";
            // 
            // wftabt_BCpagoprem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(699, 358);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnObtener);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtFechCreacion);
            this.Controls.Add(this.txtCodPrestamo);
            this.Controls.Add(this.txtCodCtaBco);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblCodPrestamo);
            this.Controls.Add(this.lblCodCtaBco);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblgestion_privilegios);
            this.Name = "wftabt_BCpagoprem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privilegio usuario";
            this.Load += new System.EventHandler(this.wftabm_SGprivilegio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgestion_privilegios;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblCodCtaBco;
        private System.Windows.Forms.Label lblCodPrestamo;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCodCtaBco;
        private System.Windows.Forms.TextBox txtCodPrestamo;
        private System.Windows.Forms.TextBox txtFechCreacion;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnObtener;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}