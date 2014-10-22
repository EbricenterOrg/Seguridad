using Modulo_de_Seguridad_2._1.Presentacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_2._1.Datos;
using Modulo_de_Seguridad_2._1.Entidades;
using System.Drawing;
using System.IO;

namespace Modulo_de_Seguridad_2._1
{
    public class N_InicioSesion
    {
        private ArrayList alResultados = new ArrayList();
        private D_DatoInicioSesion D_Inicio = new D_DatoInicioSesion();
        private E_Usuario E_Usuario = new E_Usuario();
        private IPHostEntry ipHostName;
        

        public ArrayList alBuscarUsuarios()
        {
            ipHostName = Dns.GetHostEntry(Dns.GetHostName()); 
            foreach (IPAddress ip in ipHostName.AddressList)
            {
                alResultados = D_Inicio.alBuscarUsuarios();
            }
            return alResultados;
        }
        
        public Bitmap bmpObtenerImagen(byte[] bbImagen)
        {
            Bitmap bmpImagen = null;
            try
            {
                MemoryStream MemoryStream = new MemoryStream(bbImagen);
                bmpImagen = new Bitmap(MemoryStream);
                return bmpImagen;
            }
            catch (Exception er)
            {
                // gbBmpImagen = global::Control_de_Usuario.Properties.Resources.UserDefault;
                return bmpImagen;
            }
        }

        private void vCargarMenuPrincipal(bool bCargaForm, String sForm)
        {
            if (bCargaForm == true)
            {
                try
                {
                    Assembly asm = Assembly.GetEntryAssembly();
                    Type formtype = asm.GetType(sForm);
                    Form fFormularioPrincipal = (Form)Activator.CreateInstance(formtype);
                    fFormularioPrincipal.Dock = DockStyle.Fill;
                    E_Usuario.FormularioPrincipal = fFormularioPrincipal;
                    D_Inicio.vObtenerSesion();
                    D_Inicio.vObtenerPerfil();
                    D_Inicio.vBuscarAplicaciones();
                    wfInicioSesion.ActiveForm.Hide();
                    fFormularioPrincipal.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay Formulario Principal Cargado");
                }
            }
        }

        public void vValidarUsuario(String sUser, String sPass, String sFormPrincipal)
        {
            bool bCargarForm = false;
            if (sUser.Length != 0 && sPass.Length != 0)
            {
                try
                {
                    bCargarForm = D_Inicio.bObtenerTablaPerfil(sUser, sPass);
                    vCargarMenuPrincipal(bCargarForm, sFormPrincipal);
                }
                catch { }      
            }
            else
            {
                MessageBox.Show("Usuario/Password Vacios");
            }
        }
      
    }
}
