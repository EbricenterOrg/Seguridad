/* Desarrollador: Jorge Lam
 * Fecha: 09/10/2014
 * Comentario: Programación de la funcion Control de Errores
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


namespace Control_de_Usuario.Capas.Negocio
{
    public class csInicioSesion
    {
        private String sQuery = String.Empty;
        private static Form fFormPrincipal; 
        private ArrayList alResultados = null;
        
        public Form FormularioPrincipal
        {
            get { return fFormPrincipal; }
            set { fFormPrincipal = value; }
        }
        public void vValidarUsuario(String sUser, String sPass)
        {
            if (sUser.Length != 0 && sPass.Length != 0) 
            {
                sQuery = "SELECT cod_emp, cod_usr, cod_pusr, cod_priv, cod_aappp, cod_papp" +
                         "FROM tabm_SGusuario AS T1" +
                         "INNER JOIN tabt_SGperfilusuario AS T2 ON T2.codusr=T1.codusr" +
                         "INNER JOIN tabt_SGasignapppersonal AS T3 ON T3.cod_usr=T1.cod_usr" +
                         "INNER JOIN tabm_SGprivilegio AS T4 ON T4 ON T4.cod_usr=T1.cod_usr" +
                         "INNER JOIN tabm_NNempleado AS T5 ON T5.cod_usr=T1.cod_usr"+
                         "INNER JOIN tabm_SGperfilapp AS T6 ON T6.cod_pfl=T2.cod_pfl"+
                         "WHERE cuenta_usr = " + sUser + " AND pass_usr = " + sPass;
                alResultados = ODBCconnector.csFunciones.alConsultar(sQuery);
                if (alResultados != null)
                {
                    csPerfilUsuario Perfil = new csPerfilUsuario();
                    foreach (ArrayList Datos  in alResultados) 
                    {
                        Perfil.CodigoEmpleado = Convert.ToInt32(Datos[0]);
                        Perfil.CodigoUsuario = Convert.ToInt32(Datos[1]);
                        Perfil.CodigoPerfilUsuario = Convert.ToInt32(Datos[2]);
                        Perfil.CodigoPrivilegio = Convert.ToInt32(Datos[3]);
                        Perfil.CodigoAplicacionesPersonales = Convert.ToInt32(Datos[4]);
                        Perfil.CodigoPerfilApliacion = Convert.ToInt32(Datos[5]);
                    }
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(fFormPrincipal);
                }
                else 
                {
                    MessageBox.Show("Usuario/Password Incorrectos");
                }
            }
            else 
            {
                MessageBox.Show("Usuario/Password Vacios");
            }
        }

        public void vBuscarUsuarios()
        {

        }
    }
}
