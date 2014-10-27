/*Autor: “Jessica Castellanos”
 *Fecha: “16/Octubre/2014”
 *Comentario: “Este formulario trabaja los perfiles del usuario, la insercion, modificacion,eliminacion y busqueda de los perfiles“
 */

using System;
using System.Collections;
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
    public partial class wfPerfil : Form
    {
        
        public wfPerfil()
        {
            InitializeComponent();
        }

        ArrayList alDatosEnviados = new ArrayList();
        private void wfFormularioUsuario_Load(object sender, EventArgs e)
        {
            //crear array list que enviara los datos
           
            alDatosEnviados.Add(txtCodperfil);
            alDatosEnviados.Add(txtNombreperfil);
            alDatosEnviados.Add(txtFechCreacionPerfil);
            alDatosEnviados.Add(txtFechModifPerfil);
            alDatosEnviados.Add(txtCodpfl1);
            alDatosEnviados.Add(txtEstadoPerfil);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {

        }

        

        private void gbxPrivilegios_Enter(object sender, EventArgs e)
        {

        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            //navegador1.stabmsgperfil
             //MessageBox.Show("Este es el boton guardar");
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       
            

        private void label13_Click(object sender, EventArgs e)
        {
        
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
        
        }

      

        private void lblCodperfilapp_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        

        
       
        private void txt11_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboFechmodifperfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void cboPerfiltecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txt13_TextChanged(object sender, EventArgs e)
        {
           
        }

       private void cboEstadoperfil_SelectedIndexChanged(object sender, EventArgs e)
        {

           /*switch(cboEstadoperfil.Text){

                            case 0: txt14.Text = "1"; break;
                            case 1: txt14.Text = "1"; break;
                            default: txt14.Text = String.Empty;
           }*/

                 
        } 

        private void txt14_TextChanged(object sender, EventArgs e)
        {
            if (txtEstadoPerfil.Text == "1")
            {
                cboEstadoPerf.SelectedIndex = 0;
            }
            else { cboEstadoPerf.SelectedIndex = 1;
            }
        }

        private void txtCodperfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFechacreacionperfil_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*switch(cboEstadoPerfil.Text){

                         case 0: txtEstadoPerfil.Text = "1"; break;
                         case 1: txtEstadoPerfil.Text = "1"; break;
                        default: txtEstadoPerfil.Text = String.Empty;
                                         }*/
        }

        private void cboEstadoPerf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstadoPerf.SelectedIndex == 0)
            {
                txtEstadoPerfil.Text = "1";
            }
            else { txtEstadoPerfil.Text = "0";
            }
        }

      

        

       

        }

    }

