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
    public partial class wftabm_SGusuario : Form
    {
        private wftabm_SGpregunta frmPregunta;
        private wftabm_SGprivilegio frmPrivilegio;
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
        public wftabm_SGusuario()
        {
            InitializeComponent();
        }


        private void wfprincipalUsuarios_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_usr);
            alDatosEnviados.Add(txtcod_emp);
            alDatosEnviados.Add(txtcod_priv);
            alDatosEnviados.Add(txtcod_preg);
            alDatosEnviados.Add(txtcuenta_usr);
            alDatosEnviados.Add(txtresp_usur);
            alDatosEnviados.Add(txtpass_usr);
            alDatosEnviados.Add(txtfechcreado_usr);
            alDatosEnviados.Add(txtfechmodif_usr);
            alDatosEnviados.Add(txthost_usr);
            alDatosEnviados.Add(txtipdir_usr);
            alDatosEnviados.Add(txtestado_usr);

            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void btncod_preg_Click(object sender, EventArgs e)
        {


            frmPregunta = new wftabm_SGpregunta();
            frmPregunta.ShowDialog();
            txtcod_preg.Text = frmPregunta.Scodig1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncodpriv_Click(object sender, EventArgs e)
        {
            frmPrivilegio = new wftabm_SGprivilegio();
            frmPrivilegio.ShowDialog();
            txtcod_priv.Text = frmPrivilegio.Scodig2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void cboestado_usr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboestado_usr.SelectedIndex.Equals(0))
            {
                txtestado_usr.Text = "1";
            }
            else
            {
                txtestado_usr.Text = "0";
            }

        }

        private void txtestado_usr_TextChanged(object sender, EventArgs e)
        {
            if (txtestado_usr.Text == "1")
            {
                cboestado_usr.Text = "Activo";
            }
            else
            {
                cboestado_usr.Text = "Inactivo";
            }
        }

        private void btncodemp_Click(object sender, EventArgs e)
        {

           /* Codigo Para tabla empleado solo descomentar
            * 
            * frmEmpleado = new wftabm_NNempleado();
            frmPrivilegio.ShowDialog();
            txtcod_emp.Text = frmEmpleado.Scodig3;
            cbocod_emp.Text = frmEmpleado.Scodig3;*/
        }

        private void txtcod_usr_TextChanged(object sender, EventArgs e)
        {
            Scodusu = txtcod_usr.Text;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            this.btncodemp.Enabled = true;
            this.btncodpriv.Enabled = true;
            this.btncodpreg.Enabled = true;
            this.txtfechcreado_usr.Enabled = false;
            this.txtfechmodif_usr.Enabled = false;
            this.txthost_usr.Enabled = false;
            this.txtipdir_usr.Enabled = false;
            this.cboestado_usr.Enabled = true;

            string str = "";
            String ShostName = Dns.GetHostName();
            System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(str);
            IPAddress[] addr = ipEntry.AddressList;
            txtipdir_usr.Text = addr[addr.Length - 1].ToString();
            txthost_usr.Text = ShostName;
            txtfechcreado_usr.Text = DateTime.Now.ToString("yyyy/M/d");
          
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {

            this.btncodemp.Enabled = true;
            this.btncodpriv.Enabled = true;
            this.btncodpreg.Enabled = true;
            this.txtfechcreado_usr.Enabled = false;
            this.txtfechmodif_usr.Enabled = false;
            this.txthost_usr.Enabled = false;
            this.txtipdir_usr.Enabled = false;
            this.cboestado_usr.Enabled = true;
            string str = "";
            String ShostName = Dns.GetHostName();
            System.Net.Dns.GetHostName();
            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(str);
            IPAddress[] addr = ipEntry.AddressList;
            txtipdir_usr.Text = addr[addr.Length - 1].ToString();
            txthost_usr.Text = ShostName;
            txtfechmodif_usr.Text = DateTime.Now.ToString("yyyy/M/d");
        }
    }
}

