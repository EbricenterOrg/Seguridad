using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_de_Sesion
{
    public partial class wfPreguntaUsuario : Form
    {
        public wfPreguntaUsuario()
        {
            InitializeComponent();
        }

        ArrayList alDatosEnviados = new ArrayList();

        private void lblCodApp_Click(object sender, EventArgs e)
        {

        }

        private void txtCodPerUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void wfPerfilUsuario_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtcod_preg);
            alDatosEnviados.Add(txtnom_preg);
            alDatosEnviados.Add(txtestado_preg);

            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void cbonom_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnom_preg.Text = cbonom_preg.Text;
        }

        private void cboestado_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboestado_preg.SelectedIndex == 0)
            {
                txtestado_preg.Text = "1";

            }
            else {
                txtestado_preg.Text = "0";
            }
        }

        private void txtnom_preg_TextChanged(object sender, EventArgs e)
        {
            cbonom_preg.Text = txtnom_preg.Text;
        }

        private void txtestado_preg_TextChanged(object sender, EventArgs e)
        {
            if (txtestado_preg.Text == "1")
            {
                cboestado_preg.SelectedIndex=0;

            }
            else
            {
                cboestado_preg.SelectedIndex = 1;
            }
        }
    }
}
