namespace Prototipo_No_Funcional_V._2
{
    partial class wfMenuPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfMenuPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContabilidad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtasContab = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarTipoDeDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDiarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientoDiarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasContablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBancos = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaContableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagoPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasBancariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimientosBancariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNomina = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.btninfo = new System.Windows.Forms.ToolStripMenuItem();
            this.SsInfo = new System.Windows.Forms.StatusStrip();
            this.tslBienvenida = new System.Windows.Forms.ToolStripStatusLabel();
            this.msPrincipal.SuspendLayout();
            this.SsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.BackColor = System.Drawing.SystemColors.Control;
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnContabilidad,
            this.btnProductos,
            this.btnSeguridad,
            this.btnAyuda});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.msPrincipal.Size = new System.Drawing.Size(794, 53);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "msPrincipal";
            this.msPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msPrincipal_ItemClicked);
            // 
            // btnInicio
            // 
            this.btnInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir});
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(44, 49);
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.Exit;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnContabilidad
            // 
            this.btnContabilidad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCtasContab,
            this.btnBancos,
            this.btnNomina});
            this.btnContabilidad.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.Accounting_icon;
            this.btnContabilidad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContabilidad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnContabilidad.Name = "btnContabilidad";
            this.btnContabilidad.Size = new System.Drawing.Size(78, 49);
            this.btnContabilidad.Text = "Contabilidad";
            this.btnContabilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnCtasContab
            // 
            this.btnCtasContab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarTipoDeDocumentoToolStripMenuItem,
            this.movimientoDiarioToolStripMenuItem1,
            this.movimientoDiarioToolStripMenuItem,
            this.cuentasContablesToolStripMenuItem});
            this.btnCtasContab.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.Table;
            this.btnCtasContab.Name = "btnCtasContab";
            this.btnCtasContab.Size = new System.Drawing.Size(165, 22);
            this.btnCtasContab.Text = "Cuentas Contables";
            // 
            // agregarTipoDeDocumentoToolStripMenuItem
            // 
            this.agregarTipoDeDocumentoToolStripMenuItem.Name = "agregarTipoDeDocumentoToolStripMenuItem";
            this.agregarTipoDeDocumentoToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.agregarTipoDeDocumentoToolStripMenuItem.Text = "Agregar tipo de Documento";
            this.agregarTipoDeDocumentoToolStripMenuItem.Click += new System.EventHandler(this.agregarTipoDeDocumentoToolStripMenuItem_Click);
            // 
            // movimientoDiarioToolStripMenuItem1
            // 
            this.movimientoDiarioToolStripMenuItem1.Name = "movimientoDiarioToolStripMenuItem1";
            this.movimientoDiarioToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.movimientoDiarioToolStripMenuItem1.Text = "Diario";
            this.movimientoDiarioToolStripMenuItem1.Click += new System.EventHandler(this.movimientoDiarioToolStripMenuItem1_Click);
            // 
            // movimientoDiarioToolStripMenuItem
            // 
            this.movimientoDiarioToolStripMenuItem.Name = "movimientoDiarioToolStripMenuItem";
            this.movimientoDiarioToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.movimientoDiarioToolStripMenuItem.Text = "Movimiento Diario";
            this.movimientoDiarioToolStripMenuItem.Click += new System.EventHandler(this.movimientoDiarioToolStripMenuItem_Click_1);
            // 
            // cuentasContablesToolStripMenuItem
            // 
            this.cuentasContablesToolStripMenuItem.Name = "cuentasContablesToolStripMenuItem";
            this.cuentasContablesToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.cuentasContablesToolStripMenuItem.Text = "Cuentas Contables";
            this.cuentasContablesToolStripMenuItem.Click += new System.EventHandler(this.cuentasContablesToolStripMenuItem_Click);
            // 
            // btnBancos
            // 
            this.btnBancos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoToolStripMenuItem,
            this.cuentaContableToolStripMenuItem,
            this.historialBancoToolStripMenuItem,
            this.pagoPrestamoToolStripMenuItem,
            this.cuentasBancariasToolStripMenuItem,
            this.movimientosBancariosToolStripMenuItem});
            this.btnBancos.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.payment_card;
            this.btnBancos.Name = "btnBancos";
            this.btnBancos.Size = new System.Drawing.Size(165, 22);
            this.btnBancos.Text = "Bancos";
            // 
            // prestamoToolStripMenuItem
            // 
            this.prestamoToolStripMenuItem.Name = "prestamoToolStripMenuItem";
            this.prestamoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.prestamoToolStripMenuItem.Text = "Prestamo";
            this.prestamoToolStripMenuItem.Click += new System.EventHandler(this.prestamoToolStripMenuItem_Click);
            // 
            // cuentaContableToolStripMenuItem
            // 
            this.cuentaContableToolStripMenuItem.Name = "cuentaContableToolStripMenuItem";
            this.cuentaContableToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cuentaContableToolStripMenuItem.Text = "Cuenta Contable";
            this.cuentaContableToolStripMenuItem.Click += new System.EventHandler(this.cuentaContableToolStripMenuItem_Click);
            // 
            // historialBancoToolStripMenuItem
            // 
            this.historialBancoToolStripMenuItem.Name = "historialBancoToolStripMenuItem";
            this.historialBancoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.historialBancoToolStripMenuItem.Text = "Historial Banco";
            this.historialBancoToolStripMenuItem.Click += new System.EventHandler(this.historialBancoToolStripMenuItem_Click);
            // 
            // pagoPrestamoToolStripMenuItem
            // 
            this.pagoPrestamoToolStripMenuItem.Name = "pagoPrestamoToolStripMenuItem";
            this.pagoPrestamoToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.pagoPrestamoToolStripMenuItem.Text = "Pago prestamo";
            this.pagoPrestamoToolStripMenuItem.Click += new System.EventHandler(this.pagoPrestamoToolStripMenuItem_Click);
            // 
            // cuentasBancariasToolStripMenuItem
            // 
            this.cuentasBancariasToolStripMenuItem.Name = "cuentasBancariasToolStripMenuItem";
            this.cuentasBancariasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.cuentasBancariasToolStripMenuItem.Text = "Cuentas Bancarias";
            this.cuentasBancariasToolStripMenuItem.Click += new System.EventHandler(this.cuentasBancariasToolStripMenuItem_Click);
            // 
            // movimientosBancariosToolStripMenuItem
            // 
            this.movimientosBancariosToolStripMenuItem.Name = "movimientosBancariosToolStripMenuItem";
            this.movimientosBancariosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.movimientosBancariosToolStripMenuItem.Text = "Movimientos Bancarios";
            this.movimientosBancariosToolStripMenuItem.Click += new System.EventHandler(this.movimientosBancariosToolStripMenuItem_Click);
            // 
            // btnNomina
            // 
            this.btnNomina.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.Notes;
            this.btnNomina.Name = "btnNomina";
            this.btnNomina.Size = new System.Drawing.Size(165, 22);
            this.btnNomina.Text = "Nominas";
            // 
            // btnProductos
            // 
            this.btnProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInventario});
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProductos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(67, 49);
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnInventario
            // 
            this.btnInventario.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.ordering;
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(129, 22);
            this.btnInventario.Text = "Inventarios";
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUsuarios,
            this.btnBitacora});
            this.btnSeguridad.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.security;
            this.btnSeguridad.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeguridad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(67, 49);
            this.btnSeguridad.Text = "Seguridad";
            this.btnSeguridad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.Search_Male_User;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(168, 22);
            this.btnUsuarios.Text = "Control de Usuarios";
            // 
            // btnBitacora
            // 
            this.btnBitacora.Image = global::Prototipo_No_Funcional_V._2.Properties.Resources.Upline;
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(168, 22);
            this.btnBitacora.Text = "Bitacora";
            // 
            // btnAyuda
            // 
            this.btnAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btninfo});
            this.btnAyuda.Image = ((System.Drawing.Image)(resources.GetObject("btnAyuda.Image")));
            this.btnAyuda.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAyuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAyuda.ImageTransparentColor = System.Drawing.Color.White;
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(50, 49);
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btninfo
            // 
            this.btninfo.Image = ((System.Drawing.Image)(resources.GetObject("btninfo.Image")));
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(131, 22);
            this.btninfo.Text = "Información";
            // 
            // SsInfo
            // 
            this.SsInfo.AutoSize = false;
            this.SsInfo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SsInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslBienvenida});
            this.SsInfo.Location = new System.Drawing.Point(0, 543);
            this.SsInfo.Name = "SsInfo";
            this.SsInfo.Size = new System.Drawing.Size(794, 30);
            this.SsInfo.SizingGrip = false;
            this.SsInfo.TabIndex = 2;
            this.SsInfo.Text = "statusStrip1";
            this.SsInfo.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SsInfo_ItemClicked);
            // 
            // tslBienvenida
            // 
            this.tslBienvenida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslBienvenida.Name = "tslBienvenida";
            this.tslBienvenida.Size = new System.Drawing.Size(83, 25);
            this.tslBienvenida.Text = "tslBienvenida";
            // 
            // wfMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 573);
            this.Controls.Add(this.SsInfo);
            this.Controls.Add(this.msPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.MinimumSize = new System.Drawing.Size(800, 598);
            this.Name = "wfMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel San Carlos";
            this.Load += new System.EventHandler(this.wfMenuPrincipal_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.SsInfo.ResumeLayout(false);
            this.SsInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem btnInicio;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem btnContabilidad;
        private System.Windows.Forms.ToolStripMenuItem btnProductos;
        private System.Windows.Forms.ToolStripMenuItem btnSeguridad;
        private System.Windows.Forms.ToolStripMenuItem btnAyuda;
        private System.Windows.Forms.ToolStripMenuItem btninfo;
        private System.Windows.Forms.ToolStripMenuItem btnCtasContab;
        private System.Windows.Forms.ToolStripMenuItem btnBancos;
        private System.Windows.Forms.ToolStripMenuItem btnNomina;
        private System.Windows.Forms.ToolStripMenuItem btnInventario;
        private System.Windows.Forms.ToolStripMenuItem btnUsuarios;
        private System.Windows.Forms.ToolStripMenuItem btnBitacora;
        private System.Windows.Forms.StatusStrip SsInfo;
        private System.Windows.Forms.ToolStripStatusLabel tslBienvenida;
        private System.Windows.Forms.ToolStripMenuItem agregarTipoDeDocumentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoDiarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentaContableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagoPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasBancariasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientosBancariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasContablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimientoDiarioToolStripMenuItem;
    }
}

