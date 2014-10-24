using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_de_Seguridad_2._1.Presentacion
{
    public partial class wfInicioSesion : Form
    {
        private N_InicioSesion N_Inicio = new N_InicioSesion();
        private String sForm;

        public wfInicioSesion(String FormularioPrincipal = null)
        {
            sForm = FormularioPrincipal;
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            N_Inicio.vValidarUsuario(txtUsuario.Text, txtPassword.Text, sForm);
        }

        private void btnCancelarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
