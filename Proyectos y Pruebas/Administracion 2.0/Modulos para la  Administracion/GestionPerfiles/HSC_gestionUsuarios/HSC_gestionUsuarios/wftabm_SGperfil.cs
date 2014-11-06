/*Autor: "Jessica Castellanos"
 * Fecha: "20 Octubre 2014"
 * Comentario: "Este modulo maneja los perfiles"
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
    public partial class wftabm_SGperfil : Form
    {
        private String Scodig = string.Empty;
        private bool BbtnObtenerFechas;

        public bool BbtnObtenerFechas1
        {
            get { return BbtnObtenerFechas; }
            set { BbtnObtenerFechas = value; }
        }

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

            btnObtenerFechas.Enabled = BbtnObtenerFechas;
        }

        private void cbonom_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboestado_preg_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboestado_perfil.Text)
            {
                case "Activado": txtestado_perfil.Text = 1 + "";
                    break;
                case "Desactivado": txtestado_perfil.Text = 0 + "";
                    break;
            }
        }

        private void txtestado_preg_TextChanged(object sender, EventArgs e)
        {

            switch (txtestado_perfil.Text)
            {
                case "0": cboestado_perfil.Text = "Activado";
                    break;
                case "1": cboestado_perfil.Text = "Desactivado";
                    break;
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

        private void btnObtenerFechas_Click(object sender, EventArgs e)
        {
            txtFechCreacion.Text = DateTime.Now.ToString("yyyy/M/d");
            txtFechModif.Text = DateTime.Now.ToString("yyyy/M/d");
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            btnObtenerFechas.Enabled = true;
            txtFechCreacion.Enabled = false;
        }
    }
}
