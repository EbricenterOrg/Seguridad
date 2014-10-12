using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_de_Usuario.Capas.Presentacion;

namespace Control_de_Usuario.Capas.Presentacion
{
    public partial class wfAdministradorPrueba : Form
    {
        public wfAdministradorPrueba()
        {
            InitializeComponent();
        }

        private void wfAdministradorPrueba_Load(object sender, EventArgs e)
        {
    
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            wfFormularioUsuario child = new wfFormularioUsuario();
            child.MdiParent = this;
            child.Show();
        }
    }
}
