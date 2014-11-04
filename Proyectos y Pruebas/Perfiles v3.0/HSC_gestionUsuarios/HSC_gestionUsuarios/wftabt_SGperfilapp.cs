/*Autor: "Jessica Castellanos"
 * Fecha: "20 Octubre 2014"
 * Comentario: "Este modulo maneja el perfil aplicacion"
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_gestionUsuarios
{
    public partial class wftabt_SGperfilapp : Form
    {
        private wftabm_SGperfil frmPregunta;
        private wftabt_SGperfiluser frmPrivilegio;
        private String Scodusu = string.Empty;

        private bool BbtnCodPerfil;

        public bool BbtnCodPerfil1
        {
            get { return BbtnCodPerfil; }
            set { BbtnCodPerfil = value; }
        }
        private bool BbtnCodAplicacion;

        public bool BbtnCodAplicacion2
        {
            get { return BbtnCodAplicacion; }
            set { BbtnCodAplicacion = value; }
        }

        public bool BbtnCodAplicacion1
        {
            get { return BbtnCodAplicacion; }
            set { BbtnCodAplicacion = value; }
        }
        private bool BbtnObtenerFecha;

        
        public String Scodusu1
        {
            get { return Scodusu; }
            set { Scodusu = value; }
        }


        
        ArrayList alDatosEnviados = new ArrayList();
        public wftabt_SGperfilapp()
        {
            InitializeComponent();
        }


        private void wfprincipalUsuarios_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_perfapp);
            alDatosEnviados.Add(txtcod_perfil);
            alDatosEnviados.Add(txtcod_app);
            alDatosEnviados.Add(txtfechcreac_perfapp);
            alDatosEnviados.Add(txtselect);
            alDatosEnviados.Add(txtinsert);
            alDatosEnviados.Add(txtupdate);
            alDatosEnviados.Add(txtdelete);
            alDatosEnviados.Add(txtimprimir);
            alDatosEnviados.Add(txtestado_perfapp);

            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

            btnCodPerf.Enabled = BbtnCodPerfil1;
            btnCodAp.Enabled = BbtnCodAplicacion1;
            btnObtener.Enabled = BbtnObtenerFecha;
        }

        private void btncod_preg_Click(object sender, EventArgs e)
        {


            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncodpriv_Click(object sender, EventArgs e)
        {
            //Descomentar para tabla aplicacion
            //wftabm_SGaplicacion frmaplicacion = new wftabm_SGaplicacion();
            //frmaplicacion.Show();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void cboestado_usr_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboestado_perfapp.Text)
            {
                case "Activado": txtestado_perfapp.Text = 1 + "";
                    break;
                case "Desactivado": txtestado_perfapp.Text = 0 + "";
                    break;
            }
        }

        private void txtestado_usr_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado_perfapp.Text)
            {
                case "0": cboestado_perfapp.Text = "Activado";
                    break;
                case "1": cboestado_perfapp.Text = "Desactivado";
                    break;
            }
        }

        private void btncodapp_Click(object sender, EventArgs e)
        {

        
        }

        private void txtcod_usr_TextChanged(object sender, EventArgs e)
        {
            Scodusu = txtcod_perfapp.Text;
        }

        private void btncodemp_Click(object sender, EventArgs e)
        {
            
            //wftabm_SGperfil frmperfil = new wftabm_SGperfil();
            //frmperfil.Show();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            txtfechcreac_perfapp.Text = DateTime.Now.ToString("yyyy/M/d");
           
        }
    }
}

