using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modulo_contabilidad;

namespace Prototipo_No_Funcional_V._2
{
    public partial class wfMenuPrincipal : Form
    {
        public wfMenuPrincipal()
        {
            InitializeComponent();
        }

        private void iniciarConexion()
        {

        }
        void wfMenuPrincipal_Load(object sender, EventArgs e)
        {
          tslBienvenida.Text = "Bienvenido...";
        }

        private void SsInfo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuesped_Click(object sender, EventArgs e)
        {
              
        }

        private void msPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void documentosContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void movimientoDiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
                  
        }

        private void agregarTipoDeDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modulo_contabilidad.wfrtabm_CTdoccomp wfdoc = new modulo_contabilidad.wfrtabm_CTdoccomp();
            wfdoc.MdiParent = this;
            wfdoc.Show();
        }

        private void movimientoDiarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            modulo_contabilidad.wfrtabm_CTdiario wfdiario = new modulo_contabilidad.wfrtabm_CTdiario();
            wfdiario.MdiParent = this;
            wfdiario.Show();    
        }

        private void prestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSC_gestionBancos.wftabm_BCprestamo wfPrestamo = new HSC_gestionBancos.wftabm_BCprestamo();
            wfPrestamo.MdiParent = this;
            wfPrestamo.Show();
        }

        private void cuentaContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSC_gestionBancos.wftabt_BCctacontab wfcta = new HSC_gestionBancos.wftabt_BCctacontab();
            wfcta.MdiParent = this;
            wfcta.Show();
        }

        private void historialBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSC_gestionBancos.wftabt_BChistoriabanc wfhisto = new HSC_gestionBancos.wftabt_BChistoriabanc();
            wfhisto.MdiParent = this;
            wfhisto.Show();
        }

        private void pagoPrestamoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSC_gestionBancos.wftabt_BCpagoprem wfpago = new HSC_gestionBancos.wftabt_BCpagoprem();
            wfpago.MdiParent = this;
            wfpago.Show();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            HSC_inventario.Inventario wfinventario = new HSC_inventario.Inventario();
            wfinventario.MdiParent = this;
            wfinventario.Show();
        }

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSC_gestionBancos2.wftabm_bccuentabanco wfcuenta = new HSC_gestionBancos2.wftabm_bccuentabanco();
            wfcuenta.MdiParent = this;
            wfcuenta.Show();
        }

        private void movimientosBancariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSC_gestionBancos2.wftabt_bcmovbanc wfmov = new HSC_gestionBancos2.wftabt_bcmovbanc();
            wfmov.MdiParent = this;
            wfmov.Show();
        }

        private void cuentasContablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HSC_inventario.wftabm_CTctacont wfctacont = new HSC_inventario.wftabm_CTctacont();
            wfctacont.MdiParent = this;
            wfctacont.Show();
        }

        private void movimientoDiarioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            HSC_inventario.wfmovdiario wfmov = new HSC_inventario.wfmovdiario();
            wfmov.MdiParent = this;
            wfmov.Show();
        }

        
     }
}
