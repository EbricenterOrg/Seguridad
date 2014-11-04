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

namespace HSC_gestionUsuarios
{
    public partial class wftabm_SGprivilegio : Form
    {
        private String Scodig_priv = string.Empty;
        ArrayList alDatosEnviados = new ArrayList();
        public String Scodig2
        {
            get { return Scodig_priv; }
            set { Scodig_priv = value; }
        }
        public wftabm_SGprivilegio()
        {
            InitializeComponent();
        }

        private void wftabm_SGprivilegio_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_priv);
            alDatosEnviados.Add(txtnom_priv);
            alDatosEnviados.Add(txtfechcreado_privi);
            alDatosEnviados.Add(txtfechmodif_privi);
            alDatosEnviados.Add(txtestado_priv);


            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void txtcod_priv_TextChanged(object sender, EventArgs e)
        {
            Scodig_priv = txtcod_priv.Text;
        }

        private void cboestado_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboestado_priv.SelectedIndex.Equals(0))
            {
                txtestado_priv.Text = "1";
            }
            else
            {
                txtestado_priv.Text = "0";
            }
        }

        private void txtestado_priv_TextChanged(object sender, EventArgs e)
        {
            if (txtestado_priv.Text == "1")
            {
                cboestado_priv.Text = "Activo";
            }
            else
            {
                cboestado_priv.Text = "Inactivo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtfechcreado_privi.Text = DateTime.Now.ToString("yyyy/M/d");
            txtfechmodif_privi.Text = DateTime.Now.ToString("yyyy/M/d");
        }
    }
}
