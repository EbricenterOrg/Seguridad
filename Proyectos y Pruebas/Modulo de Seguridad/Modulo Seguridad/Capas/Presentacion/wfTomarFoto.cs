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
    public partial class wfTomarFoto : Form
    {
        public wfTomarFoto()
        {
            InitializeComponent();
        }

        private PictureBox[] pboCajaFoto = new PictureBox[2];
        private int gbIContador=0;

        private void wfTomarFoto_Load(object sender, EventArgs e)
        {
            for (int ICont = 0; ICont < pboCajaFoto.Count();ICont++) 
            {
                pboCajaFoto[ICont] = new PictureBox();
                pboCajaFoto[ICont].BorderStyle = BorderStyle.FixedSingle;
                pboCajaFoto[ICont].Location = new Point(15, 35 + ICont * (120));
            }
        }

        private void btnGuardarFoto_Click(object sender, EventArgs e)
        {
            
            pboCajaFoto[gbIContador].Image = imgVideo.Image;
        }
    }
}
