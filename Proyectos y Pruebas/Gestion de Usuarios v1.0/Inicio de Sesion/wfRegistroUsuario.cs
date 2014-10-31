/*Autor: “Cristian Portillo”
 *Fecha: “24/Octubre/2014”
 *Comentario: “Este formulario trabaja los Usuarios“
 */

using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inicio_de_Sesion
{
    public partial class wfRegistroUsuario : Form
    {
        
        public wfRegistroUsuario()
        {
            InitializeComponent();
        }

        ArrayList alDatosEnviados = new ArrayList();
        private void wfFormularioUsuario_Load(object sender, EventArgs e)
        {
            //crear array list que enviara los datos
           
            alDatosEnviados.Add(txtcod_usr);
            alDatosEnviados.Add(txtcod_emp);
            alDatosEnviados.Add(txtcod_priv);
            alDatosEnviados.Add(txtcod_preg);
            alDatosEnviados.Add(txtcuenta_usr);
            alDatosEnviados.Add(txtresp_usur);
            alDatosEnviados.Add(txtpass_usr);
            alDatosEnviados.Add(txtfechcreado_usr);
            alDatosEnviados.Add(txtfechmodif_usr);
            alDatosEnviados.Add(txthost_usr);
            alDatosEnviados.Add(txtipdir_usr);
            alDatosEnviados.Add(txtestado_usr);

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
            cbocod_priv.Text = txtcod_priv.Text;
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
            cbocod_preg.Text = txtcod_preg.Text;
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

        private void cbocod_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcod_emp.Text = cbocod_emp.Text;
        }

        private void btncod_preg_Click(object sender, EventArgs e)
        {
            wfPreguntaUsuario PreguntaUsuario = new wfPreguntaUsuario();
            PreguntaUsuario.Show();
            

        }

        private void txtcod_emp_TextChanged(object sender, EventArgs e)
        {
            cbocod_emp.Text = txtcod_emp.Text;
        }

        private void cbocod_priv_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcod_priv.Text = cbocod_emp.Text;
        }

        private void cbocod_preg_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcod_preg.Text = cbocod_preg.Text;
        }

        private void cboestado_usr_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtestado_usr.Text = cboestado_usr.Text;
        }

        private void txtestado_usr_TextChanged(object sender, EventArgs e)
        {
           cboestado_usr.Text = txtestado_usr.Text ;
        }

      

        

       

        }

    }

