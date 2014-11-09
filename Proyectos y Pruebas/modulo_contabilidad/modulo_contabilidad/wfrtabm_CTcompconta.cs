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
    public partial class wfrtabm_CTcompconta : Form
    {
        csN_Fecha Fecha = new csN_Fecha();
        private ArrayList AldatosEntrada = new ArrayList();
        private String Scodconta = string.Empty;

        public String Scodconta1
        {
            get { return Scodconta; }
            set { Scodconta = value; }
        }
        public wfrtabm_CTcompconta()
        {
            InitializeComponent();
            AldatosEntrada.Add(txtcodconta);
            AldatosEntrada.Add(txtcodtipo);
            AldatosEntrada.Add(txtcodserie);
            AldatosEntrada.Add(txtfech);
            navegador1.alDatosEntrada = AldatosEntrada;
            navegador1.vIniciarNavegador();
            btncoddoc.Enabled = false;

        }

        private void wfrtabm_CTcompconta_Load(object sender, EventArgs e)
        {

        }

        private void txtcodtipo_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            btncoddoc.Enabled = true;
            txtfech.Enabled = false;
            txtfech.Text = Fecha.Sobtienefecha();
            navegador1.btnAnterior.Enabled = false;
            navegador1.btnSiguiente.Enabled = false;
            navegador1.btnEliminar.Enabled = false;
            navegador1.btnModificar.Enabled = false;
            navegador1.btnUltimo.Enabled = false;
            navegador1.btnPrimero.Enabled = false;
            navegador1.btnGuardar.Enabled = true;
            navegador1.btnLimpiar.Enabled = true;
            btncoddoc.Enabled = true; 
        }

        private void btncoddoc_Click(object sender, EventArgs e)
        {
            frmDATA_tabm_CTdoccomp frmData = new frmDATA_tabm_CTdoccomp();            
            frmData.ShowDialog();
            txtcodtipo.Text = frmData.Scodigo1;
            
        }

        private void txtcodconta_TextChanged(object sender, EventArgs e)
        {
            Scodconta = txtcodconta.Text;
        }

        private void navegador1_btnBuscar_BeforeClick(object sender, EventArgs e)
        {
            navegador1.btnAnterior.Enabled = true;
            navegador1.btnSiguiente.Enabled = true;
            navegador1.btnEliminar.Enabled = true;
            navegador1.btnModificar.Enabled = true;
            navegador1.btnUltimo.Enabled = true;
            navegador1.btnPrimero.Enabled = true;
            navegador1.btnNuevo.Enabled = true;
            btncoddoc.Enabled = false; 
            navegador1.btnGuardar.Enabled = false;
            navegador1.vIniciarNavegador();
        }

        private void navegador1_btnGuardar_BeforeClick(object sender, EventArgs e)
        {
            navegador1.btnAnterior.Enabled = true;
            navegador1.btnSiguiente.Enabled = true;
            navegador1.btnEliminar.Enabled = true;
            navegador1.btnModificar.Enabled = true;
            navegador1.btnUltimo.Enabled = true;
            navegador1.btnPrimero.Enabled = true;
            navegador1.btnNuevo.Enabled = true;
            navegador1.btnGuardar.Enabled = false;            
            btncoddoc.Enabled = false; 
        }

        private void navegador1_btnModificar_BeforeClick(object sender, EventArgs e)
        {
            navegador1.btnAnterior.Enabled = true;
            navegador1.btnSiguiente.Enabled = true;
            navegador1.btnEliminar.Enabled = false;
            navegador1.btnNuevo.Enabled = false;
            navegador1.btnUltimo.Enabled = true;
            navegador1.btnPrimero.Enabled = true;
            navegador1.btnLimpiar.Enabled = false;
            navegador1.btnGuardar.Enabled = true;
            btncoddoc.Enabled = true; 
        }
    }
}
