/* Desarrollador: Jorge Lam
 * Fecha: 09/10/2014
 * Comentario: Programación de Incio de Sesion y 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODBCconnector;
using System.Collections;
using Control_de_Usuario.Capas.Datos;
using ODBCconnector.csFunciones;
using System.Drawing;
using System.IO;
using System.Net;



namespace Control_de_Usuario.Capas.Negocio
{
    class csInicioSesion
    {
          private static Form fFormPrincipal; 
        private String sQuery = String.Empty;
        private IPHostEntry ipHostName; 
        private ArrayList alResultados = null;
        private byte[] gbbImagen;
        private Bitmap[] BmpImagen = new Bitmap[6];
        private String[] sCuentas = new String[6];
        private csPerfilUsuario Perfil = new csPerfilUsuario();
        private csControles Control = new csControles();

        public void vValidarUsuario(String sUser, String sPass)
        {
            if (sUser.Length != 0 && sPass.Length != 0) 
            {
                sQuery = "SELECT cod_emp, cod_usr, cod_pusr, cod_priv, cod_aappp, cod_papp" +
                         "FROM tabm_SGusuario AS T1" +
                         "INNER JOIN tabt_SGperfilusuario T2 ON T2.codusr=T1.codusr" +
                         "INNER JOIN tabt_SGasignapppersonal T3 ON T3.cod_usr=T1.cod_usr" +
                         "INNER JOIN tabm_SGprivilegio T4 ON T4 ON T4.cod_usr=T1.cod_usr" +
                         "INNER JOIN tabm_NNempleado T5 ON T5.cod_usr=T1.cod_usr"+
                         "INNER JOIN tabm_SGperfilapp T6 ON T6.cod_pfl=T2.cod_pfl"+
                         "WHERE cuenta_usr = " + sUser + " AND pass_usr = " + sPass;
                vObtenerTablaPerfil();
            }
            else 
            {
                MessageBox.Show("Usuario/Password Vacios");
            }
        }

        private void vObtenerTablaPerfil()
        {
             alResultados = csFunciones.alConsultar(sQuery);
             if (alResultados != null)
                {
                    foreach (ArrayList Datos  in alResultados) 
                    {
                        Perfil.CodigoEmpleado = Convert.ToInt32(Datos[0]);
                        Perfil.CodigoUsuario = Convert.ToInt32(Datos[1]);
                        Perfil.CodigoPerfilUsuario = Convert.ToInt32(Datos[2]);
                        Perfil.CodigoPrivilegio = Convert.ToInt32(Datos[3]);
                        Perfil.CodigoAplicacionesPersonales = Convert.ToInt32(Datos[4]);
                        Perfil.CodigoPerfilApliacion = Convert.ToInt32(Datos[5]);
                    }
                    vCargarMenuPrincipal();
                } 
                else 
                {
                    MessageBox.Show("Usuario/Password Incorrectos");
                }
        }

        private void vCargarMenuPrincipal()
        {

            Form fFormPrincipal = Perfil.FormularioPrincipalMenu;
             if(fFormPrincipal!=null)
             {
                Application.EnableVisualStyles(); 
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(fFormPrincipal);
             }
             else
             {
                MessageBox.Show("El Formulario Principal de Menu no ha sido indicado");
             }
        }

        private void vObtenerSesion()
        {
            sQuery = "SELECT MAX(cod_ses) FROM tabt_ses WHERE cod_usr =  " +  Perfil.CodigoUsuario;
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados != null) 
            {
                foreach (ArrayList Datos in alResultados)
                {
                    Perfil.CodigoSesion = Convert.ToInt32(Datos[0]);
                }
            }
        }

        public void vBuscarUsuarios()
        {
            ipHostName = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipHostName.AddressList)
            {
                int Cont=0;
                sQuery = "SELECT cuenta_usr, foto_usr FROM tabm_SGusuario T1  " +
                         "INNER JOIN tabt_SGsesion T2 ON T2.cod_usr = T1.cod_usr" +
                         "WHERE ipdir=" + ip.ToString() + "LIMIT 6";
                alResultados = csFunciones.alConsultar(sQuery);
                if (alResultados != null)
                {
                    foreach (ArrayList Datos in alResultados)
                    {
                        sCuentas[Cont] = Datos[0].ToString();
                        BmpImagen[Cont] = ObtenerImagen ((byte[])Datos[2]);
                    }
                    break;
                }
            }
        }

        private Bitmap ObtenerImagen(byte[] bbImagen)
        {
            Bitmap bmpImagen = null;
            try
            {
                MemoryStream MemoryStream = new MemoryStream(bbImagen);
                bmpImagen = new Bitmap(MemoryStream);
                return bmpImagen;
            }
            catch (Exception)
            {
                // gbBmpImagen = global::Control_de_Usuario.Properties.Resources.UserDefault;
                return bmpImagen;
            }
        }

    }
    
}
