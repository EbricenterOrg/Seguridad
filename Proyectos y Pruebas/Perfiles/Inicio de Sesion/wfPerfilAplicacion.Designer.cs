namespace Inicio_de_Sesion
{
    partial class wfPerfilAplicacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wfPerfilAplicacion));
            this.navegador1 = new Navegador.Navegador();
            this.txtCodPerfilApp = new System.Windows.Forms.TextBox();
            this.txtFechCreado = new System.Windows.Forms.TextBox();
            this.txtSelect = new System.Windows.Forms.TextBox();
            this.txtInsert = new System.Windows.Forms.TextBox();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.txtImprmir = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechCreado = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblInsert = new System.Windows.Forms.Label();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblImprimir = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCodPerfil = new System.Windows.Forms.Label();
            this.txtCodPerfil = new System.Windows.Forms.TextBox();
            this.lblPerfilApp = new System.Windows.Forms.Label();
            this.lblCodApp = new System.Windows.Forms.Label();
            this.txtCodApp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(12, 34);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "tabt_sgperfilapp";
            this.navegador1.TabIndex = 0;
            // 
            // txtCodPerfilApp
            // 
            this.txtCodPerfilApp.Location = new System.Drawing.Point(338, 94);
            this.txtCodPerfilApp.Name = "txtCodPerfilApp";
            this.txtCodPerfilApp.Size = new System.Drawing.Size(100, 20);
            this.txtCodPerfilApp.TabIndex = 1;
            this.txtCodPerfilApp.Tag = "cod_papp";
            // 
            // txtFechCreado
            // 
            this.txtFechCreado.Location = new System.Drawing.Point(338, 172);
            this.txtFechCreado.Name = "txtFechCreado";
            this.txtFechCreado.Size = new System.Drawing.Size(100, 20);
            this.txtFechCreado.TabIndex = 2;
            this.txtFechCreado.Tag = "fechcreado_papp";
            // 
            // txtSelect
            // 
            this.txtSelect.Location = new System.Drawing.Point(338, 198);
            this.txtSelect.Name = "txtSelect";
            this.txtSelect.Size = new System.Drawing.Size(100, 20);
            this.txtSelect.TabIndex = 3;
            this.txtSelect.Tag = "select_papp";
            // 
            // txtInsert
            // 
            this.txtInsert.Location = new System.Drawing.Point(338, 224);
            this.txtInsert.Name = "txtInsert";
            this.txtInsert.Size = new System.Drawing.Size(100, 20);
            this.txtInsert.TabIndex = 4;
            this.txtInsert.Tag = "insert_papp";
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(338, 250);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtUpdate.TabIndex = 5;
            this.txtUpdate.Tag = "update_papp";
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(338, 276);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(100, 20);
            this.txtDelete.TabIndex = 6;
            this.txtDelete.Tag = "delete_papp";
            // 
            // txtImprmir
            // 
            this.txtImprmir.Location = new System.Drawing.Point(338, 302);
            this.txtImprmir.Name = "txtImprmir";
            this.txtImprmir.Size = new System.Drawing.Size(100, 20);
            this.txtImprmir.TabIndex = 7;
            this.txtImprmir.Tag = "imprimir_papp";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(338, 328);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 8;
            this.txtEstado.Tag = "estado_papp";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(206, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(116, 13);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Codigo perfil aplicacion";
            // 
            // lblFechCreado
            // 
            this.lblFechCreado.AutoSize = true;
            this.lblFechCreado.Location = new System.Drawing.Point(241, 172);
            this.lblFechCreado.Name = "lblFechCreado";
            this.lblFechCreado.Size = new System.Drawing.Size(81, 13);
            this.lblFechCreado.TabIndex = 10;
            this.lblFechCreado.Text = "Fecha creacion";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(285, 198);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(37, 13);
            this.lblSelect.TabIndex = 11;
            this.lblSelect.Text = "Select";
            // 
            // lblInsert
            // 
            this.lblInsert.AutoSize = true;
            this.lblInsert.Location = new System.Drawing.Point(285, 227);
            this.lblInsert.Name = "lblInsert";
            this.lblInsert.Size = new System.Drawing.Size(33, 13);
            this.lblInsert.TabIndex = 12;
            this.lblInsert.Text = "Insert";
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.Location = new System.Drawing.Point(282, 253);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(42, 13);
            this.lblUpdate.TabIndex = 13;
            this.lblUpdate.Text = "Update";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(285, 279);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(38, 13);
            this.lblDelete.TabIndex = 14;
            this.lblDelete.Text = "Delete";
            // 
            // lblImprimir
            // 
            this.lblImprimir.AutoSize = true;
            this.lblImprimir.Location = new System.Drawing.Point(286, 305);
            this.lblImprimir.Name = "lblImprimir";
            this.lblImprimir.Size = new System.Drawing.Size(42, 13);
            this.lblImprimir.TabIndex = 15;
            this.lblImprimir.Text = "Imprimir";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(283, 329);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado";
            // 
            // lblCodPerfil
            // 
            this.lblCodPerfil.AutoSize = true;
            this.lblCodPerfil.Location = new System.Drawing.Point(253, 125);
            this.lblCodPerfil.Name = "lblCodPerfil";
            this.lblCodPerfil.Size = new System.Drawing.Size(65, 13);
            this.lblCodPerfil.TabIndex = 17;
            this.lblCodPerfil.Tag = "";
            this.lblCodPerfil.Text = "Codigo perfil";
            this.lblCodPerfil.Click += new System.EventHandler(this.lblCodPerfil_Click);
            // 
            // txtCodPerfil
            // 
            this.txtCodPerfil.Location = new System.Drawing.Point(338, 125);
            this.txtCodPerfil.Name = "txtCodPerfil";
            this.txtCodPerfil.Size = new System.Drawing.Size(100, 20);
            this.txtCodPerfil.TabIndex = 18;
            this.txtCodPerfil.Tag = "cod_pfl";
            // 
            // lblPerfilApp
            // 
            this.lblPerfilApp.AutoSize = true;
            this.lblPerfilApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilApp.Location = new System.Drawing.Point(23, 9);
            this.lblPerfilApp.Name = "lblPerfilApp";
            this.lblPerfilApp.Size = new System.Drawing.Size(164, 25);
            this.lblPerfilApp.TabIndex = 19;
            this.lblPerfilApp.Text = "Perfil aplicacion";
            // 
            // lblCodApp
            // 
            this.lblCodApp.AutoSize = true;
            this.lblCodApp.Location = new System.Drawing.Point(231, 148);
            this.lblCodApp.Name = "lblCodApp";
            this.lblCodApp.Size = new System.Drawing.Size(91, 13);
            this.lblCodApp.TabIndex = 20;
            this.lblCodApp.Tag = "";
            this.lblCodApp.Text = "Codigo aplicacion";
            // 
            // txtCodApp
            // 
            this.txtCodApp.Location = new System.Drawing.Point(338, 148);
            this.txtCodApp.Name = "txtCodApp";
            this.txtCodApp.Size = new System.Drawing.Size(100, 20);
            this.txtCodApp.TabIndex = 21;
            this.txtCodApp.Tag = "cod_app";
            // 
            // wfPerfilAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 365);
            this.Controls.Add(this.txtCodApp);
            this.Controls.Add(this.lblCodApp);
            this.Controls.Add(this.lblPerfilApp);
            this.Controls.Add(this.txtCodPerfil);
            this.Controls.Add(this.lblCodPerfil);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblImprimir);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.lblInsert);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblFechCreado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtImprmir);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtInsert);
            this.Controls.Add(this.txtSelect);
            this.Controls.Add(this.txtFechCreado);
            this.Controls.Add(this.txtCodPerfilApp);
            this.Controls.Add(this.navegador1);
            this.Name = "wfPerfilAplicacion";
            this.Text = "wfPerfilAplicacion";
            this.Load += new System.EventHandler(this.wfPerfilAplicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Navegador.Navegador navegador1;
        private System.Windows.Forms.TextBox txtCodPerfilApp;
        private System.Windows.Forms.TextBox txtFechCreado;
        private System.Windows.Forms.TextBox txtSelect;
        private System.Windows.Forms.TextBox txtInsert;
        private System.Windows.Forms.TextBox txtUpdate;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.TextBox txtImprmir;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechCreado;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblInsert;
        private System.Windows.Forms.Label lblUpdate;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblImprimir;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCodPerfil;
        private System.Windows.Forms.TextBox txtCodPerfil;
        private System.Windows.Forms.Label lblPerfilApp;
        private System.Windows.Forms.Label lblCodApp;
        private System.Windows.Forms.TextBox txtCodApp;
    }
}