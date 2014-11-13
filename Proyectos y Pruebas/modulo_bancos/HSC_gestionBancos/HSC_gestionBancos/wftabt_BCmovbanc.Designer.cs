namespace HSC_gestionBancos
{
    partial class wftabt_BCmovbanc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wftabt_BCmovbanc));
            this.lblcodigomovimiento = new System.Windows.Forms.Label();
            this.lblcodigocuenta = new System.Windows.Forms.Label();
            this.lblcodtipopago = new System.Windows.Forms.Label();
            this.lblcodcuentas = new System.Windows.Forms.Label();
            this.lblcodigocomp = new System.Windows.Forms.Label();
            this.lblcantidadmovimiento = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.lblgestionmovimientos = new System.Windows.Forms.Label();
            this.txtcod_mov = new System.Windows.Forms.TextBox();
            this.txtcod_ctabco = new System.Windows.Forms.TextBox();
            this.txtcod_ttrans = new System.Windows.Forms.TextBox();
            this.txtcod_tpago = new System.Windows.Forms.TextBox();
            this.txtcod_ctas = new System.Windows.Forms.TextBox();
            this.txtcod_compconta = new System.Windows.Forms.TextBox();
            this.lblcod_transaccion = new System.Windows.Forms.Label();
            this.txtcant_movbco = new System.Windows.Forms.TextBox();
            this.btnagregarcodcuenta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigomovimiento
            // 
            this.lblcodigomovimiento.AutoSize = true;
            this.lblcodigomovimiento.Location = new System.Drawing.Point(67, 178);
            this.lblcodigomovimiento.Name = "lblcodigomovimiento";
            this.lblcodigomovimiento.Size = new System.Drawing.Size(99, 13);
            this.lblcodigomovimiento.TabIndex = 0;
            this.lblcodigomovimiento.Text = "Código movimiento:";
            // 
            // lblcodigocuenta
            // 
            this.lblcodigocuenta.AutoSize = true;
            this.lblcodigocuenta.Location = new System.Drawing.Point(67, 212);
            this.lblcodigocuenta.Name = "lblcodigocuenta";
            this.lblcodigocuenta.Size = new System.Drawing.Size(79, 13);
            this.lblcodigocuenta.TabIndex = 1;
            this.lblcodigocuenta.Text = "Código cuenta:";
            // 
            // lblcodtipopago
            // 
            this.lblcodtipopago.AutoSize = true;
            this.lblcodtipopago.Location = new System.Drawing.Point(67, 276);
            this.lblcodtipopago.Name = "lblcodtipopago";
            this.lblcodtipopago.Size = new System.Drawing.Size(105, 13);
            this.lblcodtipopago.TabIndex = 2;
            this.lblcodtipopago.Text = "Código tipo de pago:";
            // 
            // lblcodcuentas
            // 
            this.lblcodcuentas.AutoSize = true;
            this.lblcodcuentas.Location = new System.Drawing.Point(67, 311);
            this.lblcodcuentas.Name = "lblcodcuentas";
            this.lblcodcuentas.Size = new System.Drawing.Size(84, 13);
            this.lblcodcuentas.TabIndex = 3;
            this.lblcodcuentas.Text = "Código cuentas:";
            // 
            // lblcodigocomp
            // 
            this.lblcodigocomp.AutoSize = true;
            this.lblcodigocomp.Location = new System.Drawing.Point(67, 344);
            this.lblcodigocomp.Name = "lblcodigocomp";
            this.lblcodigocomp.Size = new System.Drawing.Size(72, 13);
            this.lblcodigocomp.TabIndex = 4;
            this.lblcodigocomp.Text = "Código comp:";
            // 
            // lblcantidadmovimiento
            // 
            this.lblcantidadmovimiento.AutoSize = true;
            this.lblcantidadmovimiento.Location = new System.Drawing.Point(67, 379);
            this.lblcantidadmovimiento.Name = "lblcantidadmovimiento";
            this.lblcantidadmovimiento.Size = new System.Drawing.Size(108, 13);
            this.lblcantidadmovimiento.TabIndex = 5;
            this.lblcantidadmovimiento.Text = "Cantidad movimiento:";
            // 
            // navegador1
            // 
            this.navegador1.alDatosEntrada = ((System.Collections.ArrayList)(resources.GetObject("navegador1.alDatosEntrada")));
            this.navegador1.bEjecutarEvento = true;
            this.navegador1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(70, 86);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(598, 54);
            this.navegador1.sNombreTabla = "";
            this.navegador1.TabIndex = 6;
            // 
            // lblgestionmovimientos
            // 
            this.lblgestionmovimientos.AutoSize = true;
            this.lblgestionmovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgestionmovimientos.Location = new System.Drawing.Point(64, 34);
            this.lblgestionmovimientos.Name = "lblgestionmovimientos";
            this.lblgestionmovimientos.Size = new System.Drawing.Size(392, 31);
            this.lblgestionmovimientos.TabIndex = 7;
            this.lblgestionmovimientos.Text = "Gestión movimientos bancarios";
            // 
            // txtcod_mov
            // 
            this.txtcod_mov.Location = new System.Drawing.Point(203, 171);
            this.txtcod_mov.Name = "txtcod_mov";
            this.txtcod_mov.Size = new System.Drawing.Size(100, 20);
            this.txtcod_mov.TabIndex = 8;
            this.txtcod_mov.Tag = "cod_mov";
            // 
            // txtcod_ctabco
            // 
            this.txtcod_ctabco.Location = new System.Drawing.Point(203, 205);
            this.txtcod_ctabco.Name = "txtcod_ctabco";
            this.txtcod_ctabco.Size = new System.Drawing.Size(100, 20);
            this.txtcod_ctabco.TabIndex = 9;
            this.txtcod_ctabco.Tag = "cod_ctabco";
            // 
            // txtcod_ttrans
            // 
            this.txtcod_ttrans.Location = new System.Drawing.Point(203, 236);
            this.txtcod_ttrans.Name = "txtcod_ttrans";
            this.txtcod_ttrans.Size = new System.Drawing.Size(100, 20);
            this.txtcod_ttrans.TabIndex = 10;
            this.txtcod_ttrans.Tag = "cod_ttrans";
            // 
            // txtcod_tpago
            // 
            this.txtcod_tpago.Location = new System.Drawing.Point(203, 269);
            this.txtcod_tpago.Name = "txtcod_tpago";
            this.txtcod_tpago.Size = new System.Drawing.Size(100, 20);
            this.txtcod_tpago.TabIndex = 11;
            this.txtcod_tpago.Tag = "cod_tpago";
            // 
            // txtcod_ctas
            // 
            this.txtcod_ctas.Location = new System.Drawing.Point(203, 304);
            this.txtcod_ctas.Name = "txtcod_ctas";
            this.txtcod_ctas.Size = new System.Drawing.Size(100, 20);
            this.txtcod_ctas.TabIndex = 12;
            this.txtcod_ctas.Tag = "cod_ctas";
            // 
            // txtcod_compconta
            // 
            this.txtcod_compconta.Location = new System.Drawing.Point(203, 337);
            this.txtcod_compconta.Name = "txtcod_compconta";
            this.txtcod_compconta.Size = new System.Drawing.Size(100, 20);
            this.txtcod_compconta.TabIndex = 13;
            this.txtcod_compconta.Tag = "cod_compconta";
            // 
            // lblcod_transaccion
            // 
            this.lblcod_transaccion.AutoSize = true;
            this.lblcod_transaccion.Location = new System.Drawing.Point(67, 243);
            this.lblcod_transaccion.Name = "lblcod_transaccion";
            this.lblcod_transaccion.Size = new System.Drawing.Size(98, 13);
            this.lblcod_transaccion.TabIndex = 14;
            this.lblcod_transaccion.Text = "Código transacción";
            // 
            // txtcant_movbco
            // 
            this.txtcant_movbco.Location = new System.Drawing.Point(203, 372);
            this.txtcant_movbco.Name = "txtcant_movbco";
            this.txtcant_movbco.Size = new System.Drawing.Size(100, 20);
            this.txtcant_movbco.TabIndex = 15;
            this.txtcant_movbco.Tag = "cant_movbco";
            // 
            // btnagregarcodcuenta
            // 
            this.btnagregarcodcuenta.Location = new System.Drawing.Point(334, 202);
            this.btnagregarcodcuenta.Name = "btnagregarcodcuenta";
            this.btnagregarcodcuenta.Size = new System.Drawing.Size(122, 23);
            this.btnagregarcodcuenta.TabIndex = 16;
            this.btnagregarcodcuenta.Text = "Agregar cuenta";
            this.btnagregarcodcuenta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Agregar transacción";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(334, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Agregar tipo de pago";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // wftabt_BCmovbanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 421);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnagregarcodcuenta);
            this.Controls.Add(this.txtcant_movbco);
            this.Controls.Add(this.lblcod_transaccion);
            this.Controls.Add(this.txtcod_compconta);
            this.Controls.Add(this.txtcod_ctas);
            this.Controls.Add(this.txtcod_tpago);
            this.Controls.Add(this.txtcod_ttrans);
            this.Controls.Add(this.txtcod_ctabco);
            this.Controls.Add(this.txtcod_mov);
            this.Controls.Add(this.lblgestionmovimientos);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.lblcantidadmovimiento);
            this.Controls.Add(this.lblcodigocomp);
            this.Controls.Add(this.lblcodcuentas);
            this.Controls.Add(this.lblcodtipopago);
            this.Controls.Add(this.lblcodigocuenta);
            this.Controls.Add(this.lblcodigomovimiento);
            this.Name = "wftabt_BCmovbanc";
            this.Text = "Movimientos bancarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigomovimiento;
        private System.Windows.Forms.Label lblcodigocuenta;
        private System.Windows.Forms.Label lblcodtipopago;
        private System.Windows.Forms.Label lblcodcuentas;
        private System.Windows.Forms.Label lblcodigocomp;
        private System.Windows.Forms.Label lblcantidadmovimiento;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label lblgestionmovimientos;
        private System.Windows.Forms.TextBox txtcod_mov;
        private System.Windows.Forms.TextBox txtcod_ctabco;
        private System.Windows.Forms.TextBox txtcod_ttrans;
        private System.Windows.Forms.TextBox txtcod_tpago;
        private System.Windows.Forms.TextBox txtcod_ctas;
        private System.Windows.Forms.TextBox txtcod_compconta;
        private System.Windows.Forms.Label lblcod_transaccion;
        private System.Windows.Forms.TextBox txtcant_movbco;
        private System.Windows.Forms.Button btnagregarcodcuenta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}