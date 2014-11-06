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
    public partial class wftabm_BCprestamo : Form
    {
        private String Scodig = string.Empty;
        private bool BbtnObtener;

        public bool BbtnObtener1
        {
            get { return BbtnObtener; }
            set { BbtnObtener = value; }
        }
        public String Scodig1
        {
            get { return Scodig; }
            set { Scodig = value; }
        }

        ArrayList alDatosEnviados = new ArrayList();
        public wftabm_BCprestamo()
        {
            InitializeComponent();
        }

        private void wftabm_SGpregunta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodPrestamo);
            alDatosEnviados.Add(txtFechCreacion);
            alDatosEnviados.Add(txtInteres);
            alDatosEnviados.Add(txtCantidad);
            alDatosEnviados.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

            btnObtenerF.Enabled = BbtnObtener;
        }

        private void cbonom_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboestado_preg_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboEstado.Text)
            {
                case "Activado": txtEstado.Text = 1 + "";
                    break;
                case "Desactivado": txtEstado.Text = 0 + "";
                    break;
            }
        }

        private void txtestado_preg_TextChanged(object sender, EventArgs e)
        {

           if (txtEstado.Text=="1")
            {
                cboEstado.Text = "Activo";
            }
            else
            {
                cboEstado.Text = "Inactivo";
            }
        }

        private void txtcod_preg_TextChanged(object sender, EventArgs e)
        {
            Scodig = txtCodPrestamo.Text; 
        }

        private void txtnom_preg_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPerfilTecnico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnObtenerF_Click(object sender, EventArgs e)
        {
            txtFechCreacion.Text = DateTime.Now.ToString("yyyy/M/d");
            
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            btnObtenerF.Enabled = true;
            txtFechCreacion.Enabled = false;
        }
    }
}
