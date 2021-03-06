﻿namespace Modulo_de_Seguridad_2._1.Presentacion
{
    partial class ControlUsuario
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuario));
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.pboImagenUsuario = new System.Windows.Forms.PictureBox();
            this.TsMenuUsuario = new System.Windows.Forms.ToolStrip();
            this.TsdbArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGuardarSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.TsdbOpciones = new System.Windows.Forms.ToolStripDropDownButton();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TssMenuUsuario = new System.Windows.Forms.ToolStripSeparator();
            this.TsbConexion = new System.Windows.Forms.ToolStripButton();
            this.lblPrivilegio = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.tmrVerificarConexion = new System.Windows.Forms.Timer(this.components);
            this.pnlImagen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenUsuario)).BeginInit();
            this.TsMenuUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackColor = System.Drawing.SystemColors.ControlText;
            this.pnlImagen.Controls.Add(this.pboImagenUsuario);
            this.pnlImagen.Location = new System.Drawing.Point(0, 0);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(66, 83);
            this.pnlImagen.TabIndex = 9;
            // 
            // pboImagenUsuario
            // 
            this.pboImagenUsuario.BackColor = System.Drawing.Color.Gainsboro;
            this.pboImagenUsuario.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.UserDefault;
            this.pboImagenUsuario.Location = new System.Drawing.Point(5, 4);
            this.pboImagenUsuario.Name = "pboImagenUsuario";
            this.pboImagenUsuario.Size = new System.Drawing.Size(56, 75);
            this.pboImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImagenUsuario.TabIndex = 2;
            this.pboImagenUsuario.TabStop = false;
            // 
            // TsMenuUsuario
            // 
            this.TsMenuUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.TsMenuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsdbArchivo,
            this.TsdbOpciones,
            this.TssMenuUsuario,
            this.TsbConexion});
            this.TsMenuUsuario.Location = new System.Drawing.Point(69, 54);
            this.TsMenuUsuario.Name = "TsMenuUsuario";
            this.TsMenuUsuario.Size = new System.Drawing.Size(258, 25);
            this.TsMenuUsuario.TabIndex = 8;
            // 
            // TsdbArchivo
            // 
            this.TsdbArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCuenta,
            this.tsmiGuardarSalir,
            this.TsmiCerrarSesion,
            this.tsmiSalir});
            this.TsdbArchivo.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.folder;
            this.TsdbArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsdbArchivo.Name = "TsdbArchivo";
            this.TsdbArchivo.Size = new System.Drawing.Size(77, 22);
            this.TsdbArchivo.Text = "Archivo";
            // 
            // tsmiCuenta
            // 
            this.tsmiCuenta.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.UserPanel;
            this.tsmiCuenta.Name = "tsmiCuenta";
            this.tsmiCuenta.Size = new System.Drawing.Size(150, 22);
            this.tsmiCuenta.Text = "Cuenta";
            this.tsmiCuenta.Click += new System.EventHandler(this.tsmiCuenta_Click);
            // 
            // tsmiGuardarSalir
            // 
            this.tsmiGuardarSalir.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.GuardarSalir;
            this.tsmiGuardarSalir.Name = "tsmiGuardarSalir";
            this.tsmiGuardarSalir.Size = new System.Drawing.Size(150, 22);
            this.tsmiGuardarSalir.Text = "Guardar y Salir";
            this.tsmiGuardarSalir.Click += new System.EventHandler(this.tsmiGuardarSalir_Click);
            // 
            // TsmiCerrarSesion
            // 
            this.TsmiCerrarSesion.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.Vault;
            this.TsmiCerrarSesion.Name = "TsmiCerrarSesion";
            this.TsmiCerrarSesion.Size = new System.Drawing.Size(150, 22);
            this.TsmiCerrarSesion.Text = "Cerrar Sesión";
            this.TsmiCerrarSesion.Click += new System.EventHandler(this.TsmiCerrarSesion_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.close;
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(150, 22);
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // TsdbOpciones
            // 
            this.TsdbOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem});
            this.TsdbOpciones.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.Engranaje;
            this.TsdbOpciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsdbOpciones.Name = "TsdbOpciones";
            this.TsdbOpciones.Size = new System.Drawing.Size(86, 22);
            this.TsdbOpciones.Text = "Opciones";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrarToolStripMenuItem.Image")));
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // TssMenuUsuario
            // 
            this.TssMenuUsuario.Name = "TssMenuUsuario";
            this.TssMenuUsuario.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbConexion
            // 
            this.TsbConexion.Image = global::Modulo_de_Seguridad_2._1.Properties.Resources.GreenPoint1;
            this.TsbConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbConexion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbConexion.Name = "TsbConexion";
            this.TsbConexion.Size = new System.Drawing.Size(77, 22);
            this.TsbConexion.Text = "Conexión";
            this.TsbConexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TsbConexion.Click += new System.EventHandler(this.TsbConexion_Click);
            // 
            // lblPrivilegio
            // 
            this.lblPrivilegio.AutoSize = true;
            this.lblPrivilegio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilegio.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPrivilegio.Location = new System.Drawing.Point(72, 27);
            this.lblPrivilegio.Name = "lblPrivilegio";
            this.lblPrivilegio.Size = new System.Drawing.Size(102, 16);
            this.lblPrivilegio.TabIndex = 7;
            this.lblPrivilegio.Text = "(Privilegio, Perfil)";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.Location = new System.Drawing.Point(71, 7);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(153, 20);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre del Usuario";
            // 
            // tmrVerificarConexion
            // 
            this.tmrVerificarConexion.Interval = 10000;
            this.tmrVerificarConexion.Tick += new System.EventHandler(this.tmrVerificarConexion_Tick);
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.pnlImagen);
            this.Controls.Add(this.TsMenuUsuario);
            this.Controls.Add(this.lblPrivilegio);
            this.Controls.Add(this.lblNombreUsuario);
            this.Name = "ControlUsuario";
            this.Size = new System.Drawing.Size(333, 83);
            this.pnlImagen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenUsuario)).EndInit();
            this.TsMenuUsuario.ResumeLayout(false);
            this.TsMenuUsuario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.PictureBox pboImagenUsuario;
        private System.Windows.Forms.ToolStrip TsMenuUsuario;
        private System.Windows.Forms.ToolStripDropDownButton TsdbArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiCuenta;
        private System.Windows.Forms.ToolStripMenuItem TsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
        private System.Windows.Forms.ToolStripDropDownButton TsdbOpciones;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TssMenuUsuario;
        private System.Windows.Forms.ToolStripButton TsbConexion;
        private System.Windows.Forms.Label lblPrivilegio;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsmiGuardarSalir;
        private System.Windows.Forms.Timer tmrVerificarConexion;
    }
}
