namespace Componente_de_Conexion
{
    partial class UcControlUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcControlUsuario));
            this.TscMenuOpciones = new System.Windows.Forms.ToolStripContainer();
            this.TsMenuUsuario = new System.Windows.Forms.ToolStrip();
            this.TsdbArchivo = new System.Windows.Forms.ToolStripDropDownButton();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.TsdbOpciones = new System.Windows.Forms.ToolStripDropDownButton();
            this.notificadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TssMenuUsuario = new System.Windows.Forms.ToolStripSeparator();
            this.TsbConexion = new System.Windows.Forms.ToolStripButton();
            this.lblPrivilegio = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.pboImagenUsuario = new System.Windows.Forms.PictureBox();
            this.TscMenuOpciones.SuspendLayout();
            this.TsMenuUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // TscMenuOpciones
            // 
            this.TscMenuOpciones.BottomToolStripPanelVisible = false;
            // 
            // TscMenuOpciones.ContentPanel
            // 
            this.TscMenuOpciones.ContentPanel.Size = new System.Drawing.Size(192, 0);
            this.TscMenuOpciones.LeftToolStripPanelVisible = false;
            this.TscMenuOpciones.Location = new System.Drawing.Point(63, 53);
            this.TscMenuOpciones.Name = "TscMenuOpciones";
            this.TscMenuOpciones.RightToolStripPanelVisible = false;
            this.TscMenuOpciones.Size = new System.Drawing.Size(192, 25);
            this.TscMenuOpciones.TabIndex = 1;
            this.TscMenuOpciones.Text = "toolStripContainer1";
            // 
            // TsMenuUsuario
            // 
            this.TsMenuUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.TsMenuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsdbArchivo,
            this.TsdbOpciones,
            this.TssMenuUsuario,
            this.TsbConexion});
            this.TsMenuUsuario.Location = new System.Drawing.Point(63, 53);
            this.TsMenuUsuario.Name = "TsMenuUsuario";
            this.TsMenuUsuario.Size = new System.Drawing.Size(223, 25);
            this.TsMenuUsuario.TabIndex = 0;
            // 
            // TsdbArchivo
            // 
            this.TsdbArchivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsdbArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.TsmiCerrarSesion});
            this.TsdbArchivo.Image = ((System.Drawing.Image)(resources.GetObject("TsdbArchivo.Image")));
            this.TsdbArchivo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsdbArchivo.Name = "TsdbArchivo";
            this.TsdbArchivo.Size = new System.Drawing.Size(56, 22);
            this.TsdbArchivo.Text = "Archivo";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perfilToolStripMenuItem.Text = "Perfil de Usuario";
            // 
            // TsmiCerrarSesion
            // 
            this.TsmiCerrarSesion.Name = "TsmiCerrarSesion";
            this.TsmiCerrarSesion.Size = new System.Drawing.Size(152, 22);
            this.TsmiCerrarSesion.Text = "Cerrar Sesión";
            // 
            // TsdbOpciones
            // 
            this.TsdbOpciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsdbOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificadorToolStripMenuItem,
            this.cambiarContraseñaToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.TsdbOpciones.Image = ((System.Drawing.Image)(resources.GetObject("TsdbOpciones.Image")));
            this.TsdbOpciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsdbOpciones.Name = "TsdbOpciones";
            this.TsdbOpciones.Size = new System.Drawing.Size(64, 22);
            this.TsdbOpciones.Text = "Opciones";
            // 
            // notificadorToolStripMenuItem
            // 
            this.notificadorToolStripMenuItem.Name = "notificadorToolStripMenuItem";
            this.notificadorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.notificadorToolStripMenuItem.Text = "Notificador";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarContraseñaToolStripMenuItem.Image")));
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("administrarToolStripMenuItem.Image")));
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // TssMenuUsuario
            // 
            this.TssMenuUsuario.Name = "TssMenuUsuario";
            this.TssMenuUsuario.Size = new System.Drawing.Size(6, 25);
            // 
            // TsbConexion
            // 
            this.TsbConexion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TsbConexion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsbConexion.Name = "TsbConexion";
            this.TsbConexion.Size = new System.Drawing.Size(56, 22);
            this.TsbConexion.Text = "Conexión";
            this.TsbConexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TsbConexion.Click += new System.EventHandler(this.TsbConexion_Click);
            // 
            // lblPrivilegio
            // 
            this.lblPrivilegio.AutoSize = true;
            this.lblPrivilegio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivilegio.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblPrivilegio.Location = new System.Drawing.Point(66, 28);
            this.lblPrivilegio.Name = "lblPrivilegio";
            this.lblPrivilegio.Size = new System.Drawing.Size(102, 16);
            this.lblPrivilegio.TabIndex = 1;
            this.lblPrivilegio.Text = "(Privilegio, Perfil)";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.Location = new System.Drawing.Point(65, 8);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(153, 20);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre del Usuario";
            // 
            // pboImagenUsuario
            // 
            this.pboImagenUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pboImagenUsuario.Location = new System.Drawing.Point(3, 3);
            this.pboImagenUsuario.Name = "pboImagenUsuario";
            this.pboImagenUsuario.Size = new System.Drawing.Size(56, 75);
            this.pboImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboImagenUsuario.TabIndex = 0;
            this.pboImagenUsuario.TabStop = false;
            // 
            // UcControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Controls.Add(this.TsMenuUsuario);
            this.Controls.Add(this.lblPrivilegio);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.TscMenuOpciones);
            this.Controls.Add(this.pboImagenUsuario);
            this.Name = "UcControlUsuario";
            this.Size = new System.Drawing.Size(260, 81);
            this.Load += new System.EventHandler(this.UcControlUsuario_Load);
            this.TscMenuOpciones.ResumeLayout(false);
            this.TscMenuOpciones.PerformLayout();
            this.TsMenuUsuario.ResumeLayout(false);
            this.TsMenuUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboImagenUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pboImagenUsuario;
        private System.Windows.Forms.ToolStripContainer TscMenuOpciones;
        private System.Windows.Forms.ToolStrip TsMenuUsuario;
        private System.Windows.Forms.ToolStripDropDownButton TsdbArchivo;
        private System.Windows.Forms.ToolStripDropDownButton TsdbOpciones;
        private System.Windows.Forms.ToolStripButton TsbConexion;
        private System.Windows.Forms.Label lblPrivilegio;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.ToolStripSeparator TssMenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem TsmiCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;


    }
}
