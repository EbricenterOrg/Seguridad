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
    public partial class wfPerfilAplicacion : Form
    {
        public wfPerfilAplicacion()
        {
            InitializeComponent();
        }
        ArrayList alDatosEnviados = new ArrayList();
        private void wfPerfilAplicacion_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodPerfilApp);
            alDatosEnviados.Add(txtCodPerfil);
            alDatosEnviados.Add(txtCodApp);
            alDatosEnviados.Add(txtFechCreado);
            alDatosEnviados.Add(txtSelect);
            alDatosEnviados.Add(txtInsert);
            alDatosEnviados.Add(txtUpdate);
            alDatosEnviados.Add(txtDelete);
            alDatosEnviados.Add(txtImprmir);
            alDatosEnviados.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void lblCodPerfil_Click(object sender, EventArgs e)
        {

        }

        private void btnElegirPerfil_Click(object sender, EventArgs e)
        {
            wfPerfil ElegirPerfil = new wfPerfil();
            ElegirPerfil.Show();
            
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEstado.Text = cboEstado.Text;
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            cboEstado.Text = txtEstado.Text;
        }
    }
}
