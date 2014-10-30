namespace Modulo_de_Seguridad_2._1.Presentacion
{
    partial class wfCuenta
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
            this.pnlCuenta = new System.Windows.Forms.Panel();
            this.pboImagenUsuario = new System.Windows.Forms.PictureBox();
            this.gpbCuenta = new System.Windows.Forms.GroupBox();
            this.lblTituloNombre = new System.Windows.Forms.Label();
            this.lblTituloCuenta = new System.Windows.Forms.Label();
            this.lblTituloPrivilegio = new System.Windows.Forms.Label();
            this.lblTituloPerfil = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblPrivilegio = new System.Windows.Forms.Label();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenUsuario)).BeginInit();
            this.gpbCuenta.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCuenta
            // 
            this.pnlCuenta.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlCuenta.Controls.Add(this.pboImagenUsuario);
            this.pnlCuenta.Location = new System.Drawing.Point(0, -1);
            this.pnlCuenta.Name = "pnlCuenta";
            this.pnlCuenta.Size = new System.Drawing.Size(200, 262);
            this.pnlCuenta.TabIndex = 0;
            // 
            // pboImagenUsuario
            // 
            this.pboImagenUsuario.Location = new System.Drawing.Point(12, 13);
            this.pboImagenUsuario.Name = "pboImagenUsuario";
            this.pboImagenUsuario.Size = new System.Drawing.Size(176, 238);
            this.pboImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImagenUsuario.TabIndex = 1;
            this.pboImagenUsuario.TabStop = false;
            // 
            // gpbCuenta
            // 
            this.gpbCuenta.Controls.Add(this.btnCerrar);
            this.gpbCuenta.Controls.Add(this.lblPerfil);
            this.gpbCuenta.Controls.Add(this.lblPrivilegio);
            this.gpbCuenta.Controls.Add(this.lblCuenta);
            this.gpbCuenta.Controls.Add(this.lblNombre);
            this.gpbCuenta.Controls.Add(this.lblTituloPerfil);
            this.gpbCuenta.Controls.Add(this.lblTituloPrivilegio);
            this.gpbCuenta.Controls.Add(this.lblTituloCuenta);
            this.gpbCuenta.Controls.Add(this.lblTituloNombre);
            this.gpbCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCuenta.Location = new System.Drawing.Point(221, 12);
            this.gpbCuenta.Name = "gpbCuenta";
            this.gpbCuenta.Size = new System.Drawing.Size(372, 238);
            this.gpbCuenta.TabIndex = 1;
            this.gpbCuenta.TabStop = false;
            this.gpbCuenta.Text = "Datos de la Cuenta";
            // 
            // lblTituloNombre
            // 
            this.lblTituloNombre.AutoSize = true;
            this.lblTituloNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloNombre.Location = new System.Drawing.Point(15, 46);
            this.lblTituloNombre.Name = "lblTituloNombre";
            this.lblTituloNombre.Size = new System.Drawing.Size(67, 16);
            this.lblTituloNombre.TabIndex = 0;
            this.lblTituloNombre.Text = "Nombre:";
            // 
            // lblTituloCuenta
            // 
            this.lblTituloCuenta.AutoSize = true;
            this.lblTituloCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCuenta.Location = new System.Drawing.Point(15, 81);
            this.lblTituloCuenta.Name = "lblTituloCuenta";
            this.lblTituloCuenta.Size = new System.Drawing.Size(56, 16);
            this.lblTituloCuenta.TabIndex = 1;
            this.lblTituloCuenta.Text = "Cuenta";
            // 
            // lblTituloPrivilegio
            // 
            this.lblTituloPrivilegio.AutoSize = true;
            this.lblTituloPrivilegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrivilegio.Location = new System.Drawing.Point(15, 119);
            this.lblTituloPrivilegio.Name = "lblTituloPrivilegio";
            this.lblTituloPrivilegio.Size = new System.Drawing.Size(74, 16);
            this.lblTituloPrivilegio.TabIndex = 2;
            this.lblTituloPrivilegio.Text = "Privilegio";
            // 
            // lblTituloPerfil
            // 
            this.lblTituloPerfil.AutoSize = true;
            this.lblTituloPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPerfil.Location = new System.Drawing.Point(15, 152);
            this.lblTituloPerfil.Name = "lblTituloPerfil";
            this.lblTituloPerfil.Size = new System.Drawing.Size(44, 16);
            this.lblTituloPerfil.TabIndex = 3;
            this.lblTituloPerfil.Text = "Perfil";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(137, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "label5";
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(137, 81);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(45, 16);
            this.lblCuenta.TabIndex = 5;
            this.lblCuenta.Text = "label6";
            // 
            // lblPrivilegio
            // 
            this.lblPrivilegio.AutoSize = true;
            this.lblPrivilegio.Location = new System.Drawing.Point(137, 119);
            this.lblPrivilegio.Name = "lblPrivilegio";
            this.lblPrivilegio.Size = new System.Drawing.Size(45, 16);
            this.lblPrivilegio.TabIndex = 6;
            this.lblPrivilegio.Text = "label7";
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Location = new System.Drawing.Point(137, 152);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(45, 16);
            this.lblPerfil.TabIndex = 7;
            this.lblPerfil.Text = "label8";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(279, 209);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // wfCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 262);
            this.Controls.Add(this.gpbCuenta);
            this.Controls.Add(this.pnlCuenta);
            this.Name = "wfCuenta";
            this.Text = "wfCuenta";
            this.Load += new System.EventHandler(this.wfCuenta_Load);
            this.pnlCuenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenUsuario)).EndInit();
            this.gpbCuenta.ResumeLayout(false);
            this.gpbCuenta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCuenta;
        private System.Windows.Forms.PictureBox pboImagenUsuario;
        private System.Windows.Forms.GroupBox gpbCuenta;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblPrivilegio;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTituloPerfil;
        private System.Windows.Forms.Label lblTituloPrivilegio;
        private System.Windows.Forms.Label lblTituloCuenta;
        private System.Windows.Forms.Label lblTituloNombre;
        private System.Windows.Forms.Button btnCerrar;
    }
}