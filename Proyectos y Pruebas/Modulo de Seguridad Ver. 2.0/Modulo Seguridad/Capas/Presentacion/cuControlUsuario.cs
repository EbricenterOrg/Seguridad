using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_de_Usuario.Capas.Presentacion;

namespace Componente_de_Conexion
{
    public partial class UcControlUsuario : UserControl
    {
        public UcControlUsuario()
        {
            InitializeComponent();
        }

        private void UcControlUsuario_Load(object sender, EventArgs e)
        {
           
        }

        private void TsbConexion_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("odbcad32.exe");
            }catch(Exception)
            {
                try
                {
                    System.Diagnostics.Process.Start("odbcad64.exe");
                }catch(Exception)
                {
                    MessageBox.Show("No Existe Ninguna de las versiones de ODBC","ERROR");
                }
            }
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new wfAdministradorPrueba().Show();
        }
    }
}
