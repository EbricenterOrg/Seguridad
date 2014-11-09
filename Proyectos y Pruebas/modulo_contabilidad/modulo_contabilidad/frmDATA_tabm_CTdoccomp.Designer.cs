namespace modulo_contabilidad
{
    partial class frmDATA_tabm_CTdoccomp
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
            this.dtDato = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtDato)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDato
            // 
            this.dtDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtDato.Location = new System.Drawing.Point(0, 0);
            this.dtDato.Name = "dtDato";
            this.dtDato.Size = new System.Drawing.Size(458, 303);
            this.dtDato.TabIndex = 0;
            this.dtDato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDato_CellClick);
            this.dtDato.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtDato_CellContentClick);
            this.dtDato.SelectionChanged += new System.EventHandler(this.dtDato_SelectionChanged);
            // 
            // frmDATA_tabm_CTdoccomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 303);
            this.Controls.Add(this.dtDato);
            this.Name = "frmDATA_tabm_CTdoccomp";
            this.Text = "frmDATA_tabm_CTdoccomp";
            this.Load += new System.EventHandler(this.frmDATA_tabm_CTdoccomp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDato)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDato;
    }
}