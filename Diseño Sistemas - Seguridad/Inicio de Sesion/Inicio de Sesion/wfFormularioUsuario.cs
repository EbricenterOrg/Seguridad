using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_de_Sesion
{
    public partial class wfFormularioUsuario : Form
    {
        public wfFormularioUsuario()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            NivelPassword();
            
            VerificarPassword();
        }


        private void txtValidarPassword_TextChanged(object sender, EventArgs e)
        {   
            VerificarPassword();  
        }

        private void NivelPassword()
        {
            pbarPassword.Value = txtPassword.Text.Count();
            if (txtPassword.Text.Count() == 0) { lblNivelPassword.Text = "(Ninguna)"; lblNivelPassword.ForeColor = Color.White; txtValidarPassword.Enabled = false; }
            else
            {
                txtValidarPassword.Enabled = true;
                if (txtPassword.Text.Count() < 5) { lblNivelPassword.Text = "(Mala)"; lblNivelPassword.ForeColor = Color.Red; }
                else
                {
                    if (txtPassword.Text.Count() < 10) { lblNivelPassword.Text = "(Buena)"; lblNivelPassword.ForeColor = Color.Yellow; }
                    else
                    {
                        if (txtPassword.Text.Count() < 15) { lblNivelPassword.Text = "(Muy Buena)"; lblNivelPassword.ForeColor = Color.YellowGreen; }
                        else
                        {
                            if (txtPassword.Text.Count() < 20) { lblNivelPassword.Text = "(Excelente)"; lblNivelPassword.ForeColor = Color.White; }
                        }
                    }
                }
            }
        }

        private void VerificarPassword() 
        {
            if (txtValidarPassword.Text == "") { lblValidarPassword.Text = "(Ninguno)"; lblValidarPassword.ForeColor = Color.White; }
            else
            {
                if (txtPassword.Text != txtValidarPassword.Text) { lblValidarPassword.Text = "No Coincide..."; lblValidarPassword.ForeColor = Color.Red; }
                else { lblValidarPassword.Text = "Coinciden!"; lblValidarPassword.ForeColor = Color.White; }
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {
           new  wfTomarFoto().Show(); 
        }

    }
}
