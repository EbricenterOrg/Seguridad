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
    public partial class wftabm_SGperfil : Form
    {
        private String Scodig = string.Empty;

        public String Scodig1
        {
            get { return Scodig; }
            set { Scodig = value; }
        }

        ArrayList alDatosEnviados = new ArrayList();
        public wftabm_SGperfil()
        {
            InitializeComponent();
        }

        private void wftabm_SGpregunta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_perfil);
            alDatosEnviados.Add(txtFechCreacion);
            alDatosEnviados.Add(txtFechModif);
            alDatosEnviados.Add(txtPerfilTecnico);
            alDatosEnviados.Add(txtestado_perfil);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void cbonom_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboestado_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           if (cboestado_perfil.SelectedIndex.Equals(0))
            {
                txtestado_perfil.Text = "1";
            }
            else
            {
                txtestado_perfil.Text = "0";
            }
        }

        private void txtestado_preg_TextChanged(object sender, EventArgs e)
        {

           if (txtestado_perfil.Text=="1")
            {
                cboestado_perfil.Text = "Activo";
            }
            else
            {
                cboestado_perfil.Text = "Inactivo";
            }
        }

        private void txtcod_preg_TextChanged(object sender, EventArgs e)
        {
            Scodig = txtcod_perfil.Text; 
        }

        private void txtnom_preg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
