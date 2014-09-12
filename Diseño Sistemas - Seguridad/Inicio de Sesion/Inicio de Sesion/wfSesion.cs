using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio_Sesion;

namespace Inicio_de_Sesion
{
    public partial class wfSesion : Form
    {
        public wfSesion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            new csConsultar().validar_User_Pass(cmbUsuario.SelectedItem.ToString(),txtPassword.Text);
        }

        

     
    }
}
