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
    public partial class wfrtabm_CTdiario : Form
    {
        private ArrayList alDatos = new ArrayList();
        private csN_Fecha fecha = new csN_Fecha();
        public wfrtabm_CTdiario()
        {            
            InitializeComponent();
            alDatos.Add(txtcodPartida);            
            alDatos.Add(txtfech);
            alDatos.Add(txtcodcomp);
            alDatos.Add(txtconcep);
            navegador1.alDatosEntrada = alDatos;
            navegador1.vIniciarNavegador();
            navegador1.btnGuardar.Enabled = false;
            btnCodComprobante.Enabled = false;
        }

        private void wfrtabm_CTdiario_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {            
            navegador1.btnAnterior.Enabled = false;
            navegador1.btnSiguiente.Enabled = false;
            navegador1.btnEliminar.Enabled = false;
            navegador1.btnModificar.Enabled = false;
            navegador1.btnUltimo.Enabled = false;
            navegador1.btnPrimero.Enabled = false;
            navegador1.btnGuardar.Enabled = true;
            navegador1.btnLimpiar.Enabled = true;
            btnCodComprobante.Enabled = true;
           
        }

        private void btnCodComprobante_Click(object sender, EventArgs e)
        {
            wfrtabm_CTcompconta wfrcomconta = new wfrtabm_CTcompconta();
            wfrcomconta.ShowDialog();
            txtcodcomp.Text = wfrcomconta.Scodconta1;
        }

        private void txtcodcomp_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

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
            btnCodComprobante.Enabled = false;
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
            btnCodComprobante.Enabled = false;
            navegador1.btnGuardar.Enabled = false;
            navegador1.vIniciarNavegador();
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
            btnCodComprobante.Enabled = true;
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
           
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtfech.Enabled = false;
            txtfech.Text = fecha.Sobtienefecha();
        }
    }
}
