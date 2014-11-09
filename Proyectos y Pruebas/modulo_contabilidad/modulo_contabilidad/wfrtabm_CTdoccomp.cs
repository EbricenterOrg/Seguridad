using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modulo_contabilidad.Negocio;
namespace modulo_contabilidad
{
     
    public partial class wfrtabm_CTdoccomp : Form
    {

        private csN_Fecha fecha = new csN_Fecha();
        private ArrayList Aldatosentrada = new ArrayList();
        public wfrtabm_CTdoccomp()
        {
            InitializeComponent();
            
            Aldatosentrada.Add(txtcoddoc);
            Aldatosentrada.Add(txtnomtipo);
            Aldatosentrada.Add(txtfech);
            Aldatosentrada.Add(txtestadodoc);
            navegador1.alDatosEntrada = Aldatosentrada;
            navegador1.vIniciarNavegador();
        }

        private void wfrtabm_CTdoccomp_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            txtcoddoc.Enabled = false;
            txtestadodoc.Enabled = false;
            txtfech.Enabled = false;
            txtfech.Text = fecha.Sobtienefecha();
            txtnomtipo.Enabled = false;

        }
    }
}
