using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HSC_gestionBancos2
{
    public partial class wftabm_bccuentabanco : Form
    {
        private ArrayList AldatosEntrada = new ArrayList();
        public wftabm_bccuentabanco()
        {
            InitializeComponent();

        }

        private String Scodctabco = string.Empty;
        public String Scodctabco1
        {
            get { return Scodctabco; }
            set { Scodctabco = value; }
        }

        private void tabm_bccuentabanco_Load(object sender, EventArgs e)
        {
            AldatosEntrada.Add(txtcod_ctabco);
            AldatosEntrada.Add(txtbanco_ctabco);
            AldatosEntrada.Add(txtcuenta_ctabco);
            AldatosEntrada.Add(txtsaldo_ctabco);
            AldatosEntrada.Add(txttipo_ctabanc);
            AldatosEntrada.Add(txtfechmodf_ctabco);
            AldatosEntrada.Add(txtfechcreado_ctabco);
            AldatosEntrada.Add(txtsaldoant_sal);
            AldatosEntrada.Add(txtsaldoact_sal);
            AldatosEntrada.Add(txtinteresactual_sal);
            AldatosEntrada.Add(txtinteresacum_sal);
            AldatosEntrada.Add(txtestado_ctabco);
            navegador2.alDatosEntrada = AldatosEntrada;
            navegador2.vIniciarNavegador();
        }

        private void txtestado_ctabco_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcod_ctabco_TextChanged(object sender, EventArgs e)
        {
            Scodctabco = txtcod_ctabco.Text;
        }

        private void txtinteresactual_sal_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
           ;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
       
        }

        private void navegador2_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtfechcreado_ctabco.Text = DateTime.Now.ToString("yyyy/M/d");
        }

        private void navegador2_btnModificar_AfterClick(object sender, EventArgs e)
        {
            txtfechmodf_ctabco.Text = DateTime.Now.ToString("yyyy/M/d");
        }
    }
}
