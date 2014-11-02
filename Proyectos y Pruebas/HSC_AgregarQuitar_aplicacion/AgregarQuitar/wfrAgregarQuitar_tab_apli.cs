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


namespace AgregarQuitar
{
    
    public partial class wfrAgregarQuitar_tab_apli : Form
    {
        private String Scodig = string.Empty;
        private Negocio.csfecha csFec = new Negocio.csfecha();
        
        public String Scodig1
        {
            get { return Scodig; }
            set { Scodig = value; }
        }

        ArrayList alDatosSalida = new ArrayList();
        public wfrAgregarQuitar_tab_apli()
        {
            InitializeComponent();
        }

        private void wfrAgregarQuitar_tab_apli_Load(object sender, EventArgs e)
        {
            alDatosSalida.Add(txtcodapp);
            alDatosSalida.Add(txtnomapp);
            alDatosSalida.Add(txtfechc);
            alDatosSalida.Add(txtfechm);
            alDatosSalida.Add(txtestadoapp);            
            navegador1.alDatosEntrada = alDatosSalida;
            navegador1.vIniciarNavegador();
            
            
        }

        private void txtcodapp_TextChanged(object sender, EventArgs e)
        {
            Scodig = txtcodapp.Text; 
        }

        private void navegador1_btnModificar_BeforeClick(object sender, EventArgs e)
        {
            
        }

        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {            
            txtfechc.Text = csFec.Sagregafecha();
            txtfechc.Enabled = false;
            txtcodapp.Enabled = false;
            txtfechm.Enabled = false;
            txtestadoapp.Enabled = false;
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbestado.Text)
            {
                case "Activado": txtestadoapp.Text = 1+"";
                    break;
                case "Desactivado": txtestadoapp.Text = 0 + "";
                    break;
            }
        }

        private void txtestadoapp_TextChanged(object sender, EventArgs e)
        {
            
            /* switch (txtcodapp.Text)
            {
                case "0": cbestado.Text = "Activado";
                    break;
                case "1": cbestado.Text= "Desactivado";
                    break;
            }*/
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            txtestadoapp.Enabled = false;
            txtfechm.Text = csFec.Sagregafecha();
            txtfechm.Enabled = false;
            txtfechc.Enabled = false;
            txtcodapp.Enabled = false;
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }
    }
}
