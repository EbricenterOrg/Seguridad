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
    public partial class wftabt_BCctacontab : Form
    {
        ArrayList alDatosEnviados = new ArrayList();

        private bool BbtnbtnAgregarCodCta, BbtnAgregarCodCte;
        private String Scodctacontab = string.Empty;
        public bool BbtnAgregarCodCte1
        {
            get { return BbtnAgregarCodCte; }
            set { BbtnAgregarCodCte = value; }
        }

        public bool BbtnbtnAgregarCodCta1
        {
            get { return BbtnbtnAgregarCodCta; }
            set { BbtnbtnAgregarCodCta = value; }
        }

        public wftabt_BCctacontab()
        {
            InitializeComponent();
        }

        private void lblFechCreacion_Click(object sender, EventArgs e)
        {
            
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado.Text)
            {
                case "0": cboEstado.Text = "Activado";
                    break;
                case "1": cboEstado.Text = "Desactivado";
                    break;
            }
        }

        private void btnAgregarCodCta_Click(object sender, EventArgs e)
        {
            //wftabm_cccuenta frmcuenta = new wftabmcccuenta();
            //frmcuenta.ShowDialog();
            //txtcodcomp.Text = wfrcuenta.Scodconta1;
        }

        private void btnAgregarCodCte_Click(object sender, EventArgs e)
        {
            //wftabm_cccliente frmcliente = new wftabm_cccliente();
            //frmcliente.show();
        }

        private void wftabt_BCctacontab_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodCta);
            alDatosEnviados.Add(txtCodigoCta);
            alDatosEnviados.Add(txtCodCte);
            alDatosEnviados.Add(txtEstado);
           
           
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

            btnAgregarCodCta.Enabled = BbtnbtnAgregarCodCta;
            btnAgregarCodCte.Enabled = BbtnAgregarCodCte;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            btnAgregarCodCta.Enabled = true;
            btnAgregarCodCte.Enabled = true;
            
        }
    }
}
