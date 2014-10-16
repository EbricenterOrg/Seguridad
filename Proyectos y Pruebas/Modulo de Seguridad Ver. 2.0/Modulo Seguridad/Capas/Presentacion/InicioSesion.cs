using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_de_Usuario.Capas.Negocio;

namespace Control_de_Usuario.Capas.Presentacion
{
    public partial class InicioSesion : UserControl
    {
        private csInicioSesion Inicio = new csInicioSesion();

        public InicioSesion()
        {
            InitializeComponent();
        }

        private void btnSesion_Click(object sender, EventArgs e)
        {
            Inicio.vValidarUsuario(cmbUsuario.SelectedItem.ToString(), txtPassword.Text);
        }

        private void btnCancelarSesion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cuInicioSesion_Load(object sender, EventArgs e)
        {
            //Inicio.vBuscarUsuarios();
        }

       
    }
}
    