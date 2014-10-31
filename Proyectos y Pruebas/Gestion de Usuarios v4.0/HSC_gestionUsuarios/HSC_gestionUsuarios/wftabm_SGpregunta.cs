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
    public partial class wftabm_SGpregunta : Form
    {
        private String Scodig = string.Empty;

        public String Scodig1
        {
            get { return Scodig; }
            set { Scodig = value; }
        }

        ArrayList alDatosEnviados = new ArrayList();
        public wftabm_SGpregunta()
        {
            InitializeComponent();
        }

        private void wftabm_SGpregunta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_preg);
            alDatosEnviados.Add(txtnom_preg);
            alDatosEnviados.Add(txtestado_preg);

            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void cbonom_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnom_preg.Text = cbonom_preg.Text;
        }

        private void cboestado_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           if (cboestado_preg.SelectedIndex.Equals(0))
            {
                txtestado_preg.Text = "1";
            }
            else
            {
                txtestado_preg.Text = "0";
            }
        }

        private void txtestado_preg_TextChanged(object sender, EventArgs e)
        {

           if (txtestado_preg.Text=="1")
            {
                cboestado_preg.Text = "Activo";
            }
            else
            {
                cboestado_preg.Text = "Inactivo";
            }
        }

        private void txtcod_preg_TextChanged(object sender, EventArgs e)
        {
            Scodig = txtcod_preg.Text; 
        }

        private void txtnom_preg_TextChanged(object sender, EventArgs e)
        {
            cbonom_preg.Text = txtnom_preg.Text;
        }
    }
}
