/*Autor: "Jessica Castellanos"
 * Fecha: "20 Octubre 2014"
 * Comentario: "Este modulo maneja el perfil del usuario"
 */

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

namespace HSC_gestionPerfiles
{
    public partial class wftabt_SGperfiluser : Form
    {
        private String Scodig_priv = string.Empty;
        private bool bbtnFechCreaModif;

        public bool BbtnFechCreaModif
        {
            get { return bbtnFechCreaModif; }
            set { bbtnFechCreaModif = value; }
        }

        ArrayList alDatosEnviados = new ArrayList();
        public String Scodig2
        {
            get { return Scodig_priv; }
            set { Scodig_priv = value; }
        }
        public wftabt_SGperfiluser()
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

            btnFechC.Enabled = bbtnFechCreaModif;
        }

        private void txtcod_priv_TextChanged(object sender, EventArgs e)
        {
            Scodig_priv = txtcod_perfilusuario.Text;
        }

        private void cboestado_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboestado_perfusr.Text)
            {
                case "Activado": txtestado_perfusr.Text = 1 + "";
                    break;
                case "Desactivado": txtestado_perfusr.Text = 0 + "";
                    break;
            }
        }

        private void txtestado_priv_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado_perfusr.Text)
            {
                case "0": cboestado_perfusr.Text = "Activado";
                    break;
                case "1": cboestado_perfusr.Text = "Desactivado";
                    break;
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

        private void btnFechC_Click(object sender, EventArgs e)
        {
            txtfechcreac_perfusr.Text = DateTime.Now.ToString("yyyy/M/d");
            txtfechmodif_perfusr.Text = DateTime.Now.ToString("yyyy/M/d");
        }

        private void txtfechmodif_perfusr_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            btnFechC.Enabled = true;
            btnObtenerCodusr.Enabled = true;
            btnObtenerCodPerfil.Enabled = true;
            txtfechcreac_perfusr.Enabled = false;
            txtfechmodif_perfusr.Enabled = false;

        }
    }
}
