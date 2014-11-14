using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modulo_contabilidad;
using System.Collections;

namespace HSC_gestionBancos2
{
    public partial class wftabt_bcmovbanc : Form
    {
        private ArrayList AldatosEntrada = new ArrayList();
        public wftabt_bcmovbanc()
        {
            InitializeComponent();
        }
        
        private void btnagregarcodcuenta_Click(object sender, EventArgs e)
        {
            wftabm_bccuentabanco wfbccuentabanco = new wftabm_bccuentabanco();
            wfbccuentabanco.ShowDialog();
            txtcod_ctabco.Text = wfbccuentabanco.Scodctabco1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modulo_contabilidad.wfrtabm_CTcompconta wfctcompconta = new modulo_contabilidad.wfrtabm_CTcompconta();
            wfctcompconta.ShowDialog();
            txtcod_compconta.Text = wfctcompconta.Scodconta1;
        }

        private void wftabt_bcmovbanc_Load(object sender, EventArgs e)
        {
            AldatosEntrada.Add(txtcod_mov);
            AldatosEntrada.Add(txtcod_ctabco);
            AldatosEntrada.Add(txtcod_ttrans);
            AldatosEntrada.Add(txtcod_tpago);
            AldatosEntrada.Add(txtcod_ctas);
            AldatosEntrada.Add(txtcod_compconta);
            AldatosEntrada.Add(txtcant_movbco);
            AldatosEntrada.Add(txtestado_movbco);
            navegador2.alDatosEntrada = AldatosEntrada;
            navegador2.vIniciarNavegador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*libreriajessica.tabt_bcctacontab  wfbcctacontab = new libreriajessica.tabt_bcctacontab();
            wfbcctacontab.ShowDialog();
            txtcod_ctas.Text = wfctcompconta.Scodctas;*/
        }

        private void btncod_trans_Click(object sender, EventArgs e)
        {

        }
    }
}
