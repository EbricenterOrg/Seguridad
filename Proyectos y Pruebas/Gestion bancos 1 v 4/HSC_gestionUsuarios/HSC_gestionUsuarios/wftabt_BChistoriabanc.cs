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

namespace HSC_gestionBancos
{
    public partial class wftabt_BChistoriabanc : Form
    {
        private bool BbtnAgregar;
        private string Scodctacontab2 = string.Empty;
        private string Stxtcodctaconta = string.Empty;

        public string Stxtcodctaconta1
        {
            get { return Stxtcodctaconta; }
            set { Stxtcodctaconta = value; }
        }


        public string Scodctacontab21
        {
            get { return Scodctacontab2; }
            set { Scodctacontab2 = value; }
        }

        public bool BbtnAgregar1
        {
            get { return BbtnAgregar; }
            set { BbtnAgregar = value; }
        }




       

        /*Para la tabla empleado
         private wftabm_NNempleado frmEmpleado;
         */
        ArrayList alDatosEnviados = new ArrayList();
        public wftabt_BChistoriabanc()
        {
            InitializeComponent();
        }


        private void wfprincipalUsuarios_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodHistory);
            alDatosEnviados.Add(txtCodCuentaCta);
            alDatosEnviados.Add(txtAnio);
            alDatosEnviados.Add(txtTrimestre);
            alDatosEnviados.Add(txtMes);
            alDatosEnviados.Add(txtSaldo);
            alDatosEnviados.Add(txtEstado);

            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

            btnAgregar.Enabled = BbtnAgregar;
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
            switch (cboEstado.Text)
            {
                case "Activado": txtEstado.Text = 1 + "";
                    break;
                case "Desactivado": txtEstado.Text = 0 + "";
                    break;
            }

        }

        private void txtestado_usr_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado.Text)
            {
                case "0": cboEstado.Text = "Activado";
                    break;
                case "1": cboEstado.Text = "Desactivado";
                    break;
            }
        }

        private void btncodapp_Click(object sender, EventArgs e)
        {

        
        }

        private void txtcod_usr_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncodemp_Click(object sender, EventArgs e)
        {
            wftabt_BCctacontab frmctacontab = new wftabt_BCctacontab();
            frmctacontab.ShowDialog();
            txtCodCuentaCta.Text = frmctacontab.Stxtcodctacontab1;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
        }

        private void txtCodCuentaCta_TextChanged(object sender, EventArgs e)
        {
            Stxtcodctaconta1 = txtCodCuentaCta.Text;

        }
    }
}

