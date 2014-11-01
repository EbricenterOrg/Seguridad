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
    public partial class wftabm_SGperfiluser : Form
    {
        private String Scodig_priv = string.Empty;
        ArrayList alDatosEnviados = new ArrayList();
        public String Scodig2
        {
            get { return Scodig_priv; }
            set { Scodig_priv = value; }
        }
        public wftabm_SGperfiluser()
        {
            InitializeComponent();
        }

        private void wftabm_SGprivilegio_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_perfilusuario);
            alDatosEnviados.Add(txtnom_codusr);
            alDatosEnviados.Add(txtcod_perfil);
            alDatosEnviados.Add(txtfechcreac_perfusr);
            alDatosEnviados.Add(txtfechmodif_perfusr);
            alDatosEnviados.Add(txtestado_perfusr);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void txtcod_priv_TextChanged(object sender, EventArgs e)
        {
            Scodig_priv = txtcod_perfilusuario.Text;
        }

        private void cboestado_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboestado_perfusr.SelectedIndex.Equals(0))
            {
                txtestado_perfusr.Text = "1";
            }
            else
            {
                txtestado_perfusr.Text = "0";
            }
        }

        private void txtestado_priv_TextChanged(object sender, EventArgs e)
        {
            if (txtestado_perfusr.Text == "1")
            {
                cboestado_perfusr.Text = "Activo";
            }
            else
            {
                cboestado_perfusr.Text = "Inactivo";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           wftabm_SGperfil frm = new wftabm_SGperfil();
            frm.Show();

            
            
        }

        private void btnObtenerCodusr_Click(object sender, EventArgs e)
        {
            // quitar comentario para Codigo Para tabla usuario
            //wftabm_SGusuario frm = new wftabm_SGusuario();
            //frm.Show();
            

        }
    }
}
