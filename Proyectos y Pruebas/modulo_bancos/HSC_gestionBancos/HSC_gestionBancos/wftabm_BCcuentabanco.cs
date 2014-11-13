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
    public partial class wftabm_BCcuentabanco : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public wftabm_BCcuentabanco()
        {
            InitializeComponent();
        }

        private void cboestado_ctabco_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboestado_ctabco.SelectedIndex.Equals(0))
            {
                txtestado_ctabco.Text = "1";
            }
            else
            {
                txtestado_ctabco.Text = "0";
            }
        }

        private void txtestado_ctabco_TextChanged(object sender, EventArgs e)
        {
            if (txtestado_ctabco.Text == "1")
            {
                cboestado_ctabco.Text = "Activo";
            }
            else
            {
                cboestado_ctabco.Text = "Inactivo";
            }
        }

        private void btnfechamodif_Click(object sender, EventArgs e)
        {
            txtfechmodf_ctabco.Text = DateTime.Now.ToString("yyyy/M/d");
           
        }

        private void btnfechacreacion_Click(object sender, EventArgs e)
        {
            txtfechcreado_ctabco.Text = DateTime.Now.ToString("yyyy/M/d");
        }

        private void wftabm_BCcuentabanco_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_ctabco);
            alDatosEnviados.Add(txtbanco_ctabco);
            alDatosEnviados.Add(txtcuenta_ctabco);
            alDatosEnviados.Add(txtsaldo_ctabco);
            alDatosEnviados.Add(txttipo_ctabanc);
            alDatosEnviados.Add(txtfechmodf_ctabco);
            alDatosEnviados.Add(txtfechcreado_ctabco);
            alDatosEnviados.Add(txtsaldoant_sal);
            alDatosEnviados.Add(txtsaldoact_sal);
            alDatosEnviados.Add(txtinteresactual_sal);
            alDatosEnviados.Add(txtinteresacum_sal);
            alDatosEnviados.Add(txtestado_ctabco);

            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }
    }
}
