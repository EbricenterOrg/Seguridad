using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;

namespace Inicio_de_Sesion
{
    public partial class wfTomarFoto : Form
    {
        wfFormularioUsuario FormularioUsuario = new wfFormularioUsuario();

        public wfTomarFoto()
        {
            InitializeComponent();
        }
        WebCam webcam;

        private void wfTomarFoto_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref imgVideo);
            
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {
            FormularioUsuario.imgCapture.Image = imgVideo.Image;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            webcam.Stop();
           
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

       
    }
}
