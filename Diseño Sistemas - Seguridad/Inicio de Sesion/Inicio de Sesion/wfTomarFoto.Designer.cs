namespace Inicio_de_Sesion
{
    partial class wfTomarFoto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloFoto = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbFiltroDispositivos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarFoto = new System.Windows.Forms.Button();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.lblTituloFoto);
            this.panel1.Location = new System.Drawing.Point(293, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 409);
            this.panel1.TabIndex = 1;
            // 
            // lblTituloFoto
            // 
            this.lblTituloFoto.AutoSize = true;
            this.lblTituloFoto.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTituloFoto.Location = new System.Drawing.Point(16, 16);
            this.lblTituloFoto.Name = "lblTituloFoto";
            this.lblTituloFoto.Size = new System.Drawing.Size(57, 22);
            this.lblTituloFoto.TabIndex = 6;
            this.lblTituloFoto.Text = "Fotos";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancelar.Location = new System.Drawing.Point(153, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 32);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbFiltroDispositivos
            // 
            this.cmbFiltroDispositivos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbFiltroDispositivos.FormattingEnabled = true;
            this.cmbFiltroDispositivos.Location = new System.Drawing.Point(37, 32);
            this.cmbFiltroDispositivos.Name = "cmbFiltroDispositivos";
            this.cmbFiltroDispositivos.Size = new System.Drawing.Size(222, 21);
            this.cmbFiltroDispositivos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(34, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = " Dispositivos:";
            // 
            // btnGuardarFoto
            // 
            this.btnGuardarFoto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarFoto.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarFoto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarFoto.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarFoto.Image = global::Inicio_de_Sesion.Properties.Resources.Camara1;
            this.btnGuardarFoto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarFoto.Location = new System.Drawing.Point(37, 316);
            this.btnGuardarFoto.Name = "btnGuardarFoto";
            this.btnGuardarFoto.Size = new System.Drawing.Size(109, 32);
            this.btnGuardarFoto.TabIndex = 2;
            this.btnGuardarFoto.Text = "Tomar";
            this.btnGuardarFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarFoto.UseVisualStyleBackColor = false;
            this.btnGuardarFoto.Click += new System.EventHandler(this.btnGuardarFoto_Click);
            // 
            // imgVideo
            // 
            this.imgVideo.Location = new System.Drawing.Point(37, 60);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(222, 250);
            this.imgVideo.TabIndex = 6;
            this.imgVideo.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wfTomarFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(470, 408);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFiltroDispositivos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarFoto);
            this.Controls.Add(this.panel1);
            this.Name = "wfTomarFoto";
            this.Text = "Tomar Foto";
            this.Load += new System.EventHandler(this.wfTomarFoto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarFoto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTituloFoto;
        private System.Windows.Forms.ComboBox cmbFiltroDispositivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button button1;
    }
}