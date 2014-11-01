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
    public partial class wftabm_SGperfilapp : Form
    {
        private wftabm_SGperfil frmPregunta;
        private wftabm_SGperfiluser frmPrivilegio;
        private String Scodusu = string.Empty;

        public String Scodusu1
        {
            get { return Scodusu; }
            set { Scodusu = value; }
        }

        /*Para la tabla empleado
         private wftabm_NNempleado frmEmpleado;
         */
        ArrayList alDatosEnviados = new ArrayList();
        public wftabm_SGperfilapp()
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
            if (cboestado_perfapp.SelectedIndex.Equals(0))
            {
                txtestado_perfapp.Text = "1";
            }
            else
            {
                txtestado_perfapp.Text = "0";
            }

        }

        private void txtestado_usr_TextChanged(object sender, EventArgs e)
        {
            if (txtestado_perfapp.Text == "1")
            {
                cboestado_perfapp.Text = "Activo";
            }
            else
            {
                cboestado_perfapp.Text = "Inactivo";
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
            wftabm_SGperfil frmperfil = new wftabm_SGperfil();
            frmperfil.Show();
        }
    }
}

