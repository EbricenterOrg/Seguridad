using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_2._1.Negocio;
using Modulo_de_Seguridad_2._1.Entidades;

namespace Modulo_de_Seguridad_2._1.Presentacion
{
    public partial class ControlUsuario : UserControl
    {
        private N_ControlUsr nUser = new N_ControlUsr();
        private E_Usuario eUser = new E_Usuario();
     

        public ControlUsuario()
        {
            InitializeComponent();
        }

        private void TsbConexion_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmiCuenta_Click(object sender, EventArgs e)
        {
            new wfCuenta().Show();
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            nUser.vSalirSesion();
        }

        private void TsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            nUser.vCerrarSesion();
        }

      public void vIniciarControles()
        {
                nUser.vIniciar();
                lblNombreUsuario.Text = eUser.NombreUsuario;
                lblPrivilegio.Text = eUser.Perfil + ", " + eUser.Privilegio;
                pboImagenUsuario.Image = eUser.ImagenUsuario;
                tmrVerificarConexion.Enabled = true;
        }

        private void tsmiGuardarSalir_Click(object sender, EventArgs e)
        {
            nUser.vGuardarSalir();
        }

        private void tmrVerificarConexion_Tick(object sender, EventArgs e)
        {
            TsbConexion.Image = nUser.bmpRevisarConexion();
        }
    }
}
