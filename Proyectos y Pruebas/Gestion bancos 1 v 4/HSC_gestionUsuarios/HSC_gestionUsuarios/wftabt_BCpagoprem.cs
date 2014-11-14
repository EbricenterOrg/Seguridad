using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_gestionBancos
{
    public partial class wftabt_BCpagoprem : Form
    {
        private bool BbtnAgregar, BbtnObtener;

        public bool BbtnObtener1
        {
            get { return BbtnObtener; }
            set { BbtnObtener = value; }
        }

        public bool BbtnAgregar1
        {
            get { return BbtnAgregar; }
            set { BbtnAgregar = value; }
        }

        ArrayList alDatosEnviados = new ArrayList();
        
        public wftabt_BCpagoprem()
        {
            InitializeComponent();
        }

        private void wftabm_SGprivilegio_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodCtaBco);
            alDatosEnviados.Add(txtCodPrestamo);
            alDatosEnviados.Add(txtFechCreacion);
            alDatosEnviados.Add(txtCantidad);
            alDatosEnviados.Add(txtEstado);
        
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

            btnAgregar.Enabled = BbtnAgregar;
            btnObtener.Enabled = BbtnObtener;
        }

        private void txtcod_priv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboestado_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado.Text)
            {
                case "Activado": txtEstado.Text = 1 + "";
                    break;
                case "Desactivado": txtEstado.Text = 0 + "";
                    break;
            }
        }

        private void txtestado_priv_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado.Text)
            {
                case "0": cboEstado.Text = "Activado";
                    break;
                case "1": cboEstado.Text = "Desactivado";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtFechCreacion.Text = DateTime.Now.ToString("yyyy/M/d");
            
            
        }

        private void btnObtenerCodusr_Click(object sender, EventArgs e)
        {
            
            wftabm_BCprestamo frmprestamo = new wftabm_BCprestamo();
            frmprestamo.ShowDialog();
            txtCodPrestamo.Text = wftabm_BCprestamo.ScodPrestamo;
            

        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnObtener.Enabled = true;
            txtFechCreacion.Enabled = false;

        }
    }
}
