using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Usuario.Capas.Presentacion
{
    public partial class wfAdministracion : Form
    {
        public wfAdministracion()
        {
            InitializeComponent();
        }

        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            wfFormularioUsuario MDI_FormUsuario = new wfFormularioUsuario();
            MDI_FormUsuario.MdiParent = this;
            MDI_FormUsuario.Show();
        }
    }
}
