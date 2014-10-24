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

namespace Modulo_de_Seguridad_2._1.Presentacion
{
    public partial class ControlUsuario : UserControl
    {
        private N_ControlUsr nUser = new N_ControlUsr();
        public ControlUsuario()
        {
            InitializeComponent();
        }

        private void TsbConexion_Click(object sender, EventArgs e)
        {
     
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
    }
}
