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
        private bool bAbrirControles = false;
        public bool bIniciarControles
        {
            get { return bAbrirControles; }
            set { bAbrirControles = value; }
        }

        public ControlUsuario()
        {
            InitializeComponent();
        }

        private void TsbConexion_Click(object sender, EventArgs e)
        {
            nUser.vRevisarConexion();
        }

        private void tsmiCuenta_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            nUser.vSalirSesion();
        }

        private void TsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            nUser.vCerrarSesion();
        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            vIniciarControles();
        }

        private void vIniciarControles()
        {
            if (bAbrirControles == true)
            {
                nUser.vIniciar();
                lblNombreUsuario.Text = eUser.NombreUsuario;
                lblPrivilegio.Text = eUser.Perfil + ", " + eUser.Privilegio;
                pboImagenUsuario.Image = eUser.ImagenUsuario;
            }
        }

        private void tsmiGuardarSalir_Click(object sender, EventArgs e)
        {
            nUser.vGuardarSalir();
        }
    }
}
