using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos_Sesion;

namespace Negocio_Sesion
{
    public class csConsultar
    {
        private String sUsuario, sPassword, sQuery;

        public String validar_User_Pass(String Usuario,String Password) 
        {
            sUsuario = Usuario;
            sPassword = Password;
            if (sUsuario == "" || sPassword == "") 
            { 
                return "Usuario/Contaseña falta..." ;
            }
            else
            {
                sQuery = "SELECT usur_nom, usur_pass FROM tabm_usuario WHERE usur_name = \"" + sUsuario + "\" AND usur_pass = \"" + sPassword + "\"";
                try
                {
                     String sRes = "";
                     ArrayList arTabla_Usuario = new csDatos().Obtener_Tabla_Usuario(sQuery);
                     foreach (t_Usuario dato in arTabla_Usuario)
                     {
                         if (dato.Apodo != "" && dato.Password != "") { sRes = "Iniciando Sesion..."; } else { sRes = "Usuario/Contraseña Invalidos"; }
                     }
                     return sRes;
                }
                catch (Exception) { return "Error al Obtener Datos"; }
            }
        }
    }
}
