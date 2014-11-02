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
using HSC_gestionUsuarios;


namespace AgregarQuitar
{
    public partial class wfrPrincipal : Form
    {
        private HSC_gestionUsuarios.wftabm_SGusuario frm_usuarios;
        private wfrAgregarQuitar_tab_apli frmTab_apli;
        private Negocio.csfecha csFec = new Negocio.csfecha();
        private bool bAgregaruser, bagreapli;

        public bool Bagreapli
        {
            get { return bagreapli; }
            set { bagreapli = value; }
        }

        public bool BAgregaruser
        {
            get { return bAgregaruser; }
            set { bAgregaruser = value; }
        }
        ArrayList alDatosEnviados = new ArrayList();
        public wfrPrincipal()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void wfrPrincipal_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcodaappp);
            alDatosEnviados.Add(txtcodusr);
            alDatosEnviados.Add(txtcodap);
            alDatosEnviados.Add(txtfeccrea);
            alDatosEnviados.Add(txtfecmod);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            btnagreapli.Enabled = Bagreapli;
            btnAgregaruser.Enabled = BAgregaruser;
        }

        private void btnagreapli_Click(object sender, EventArgs e)
        {
            frmTab_apli = new wfrAgregarQuitar_tab_apli();
            frmTab_apli.ShowDialog();
            txtcodap.Text = frmTab_apli.Scodig1;
        }


        private void Agregaruser_Click(object sender, EventArgs e)
        {
            frm_usuarios = new HSC_gestionUsuarios.wftabm_SGusuario();
            frm_usuarios.Bcodemp = false;
            frm_usuarios.Bcodpriv = false;
            frm_usuarios.Bcod_preg = false;
            frm_usuarios.BObtenerFechaIpNombre = false;
            frm_usuarios.ShowDialog();
            txtcodusr.Text = frm_usuarios.Scodusu1;
        }

        private void navegador1_btnBuscar_AfterClick(object sender, EventArgs e)
        {
            
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtcodaappp.Enabled = false;
            txtfeccrea.Text = csFec.Sagregafecha();
            txtfeccrea.Enabled = false;
            txtfecmod.Enabled = false;
            btnagreapli.Enabled = true;
            btnAgregaruser.Enabled = true;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            txtcodaappp.Enabled = false;
            txtfeccrea.Enabled = false;
            txtfecmod.Text = csFec.Sagregafecha();
            txtfecmod.Enabled = false;
        }

        private void txtcodap_MouseClick(object sender, MouseEventArgs e)
        {
            frmTab_apli = new wfrAgregarQuitar_tab_apli();
            frmTab_apli.ShowDialog();
            txtcodap.Text = frmTab_apli.Scodig1; 
        }

        private void txtcodusr_MouseClick(object sender, MouseEventArgs e)
        {
            frm_usuarios = new HSC_gestionUsuarios.wftabm_SGusuario();
            frm_usuarios.ShowDialog();
            txtcodusr.Text = frm_usuarios.Scodusu1;
        }
    }
}
