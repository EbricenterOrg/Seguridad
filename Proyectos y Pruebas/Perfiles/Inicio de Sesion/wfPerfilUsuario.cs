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

namespace Inicio_de_Sesion
{
    public partial class wfPerfilUsuario : Form
    {
        public wfPerfilUsuario()
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
            alDatosEnviados.Add(txtCodPerUser);
            alDatosEnviados.Add(txtCodUser);
            alDatosEnviados.Add(txtCodPer);
            alDatosEnviados.Add(txtFechCreado);
            alDatosEnviados.Add(txtFechModif);
            alDatosEnviados.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }
    }
}
