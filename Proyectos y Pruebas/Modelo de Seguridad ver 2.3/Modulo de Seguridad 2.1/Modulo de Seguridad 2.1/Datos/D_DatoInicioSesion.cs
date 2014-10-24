using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODBCconnector;
using System.Collections;
using Modulo_de_Seguridad_2._1.Entidades;
using System.Windows.Forms;
using System.Net;
using System.Data.Odbc; 

namespace Modulo_de_Seguridad_2._1.Datos
{
    internal class D_DatoInicioSesion
    {
        private IPHostEntry ipHostName; 
        private String sQuery = String.Empty;
        private ArrayList alResultados = new ArrayList();
        private E_Perfil ePerfil = new E_Perfil();
        private E_Usuario eUsuario = new E_Usuario();
        private E_DatosUsuario eDatosPublicos = new E_DatosUsuario();
        private ArrayList alApps = new ArrayList();


        public bool bBuscarUsuario(String sUser, String sPass)
        {
            sQuery = "SELECT cod_usr FROM tabm_sgusuario WHERE cuenta_usr = '" + sUser + "' AND pass_usr = '" + sPass + "'";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoUsuario = Convert.ToInt32(Datos[0]);
                    eDatosPublicos.iCodigoUsuario = Convert.ToInt32(Datos[0]);
                }
                return true;
            }
            else 
            {
                MessageBox.Show("ERROR","Usuario/Contraseña Incorrectos");
                return false;
            }    
        }

        public bool bComprobarFuente() 
        {
            sQuery = "SELECT cod_usr FROM tabm_sgusuario WHERE cod_priv = 1 AND ipdir_usr = '%.%.%.%' ";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count == 0)
            {
                bool bBandera = false;
                ipHostName = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress ip in ipHostName.AddressList)
                {
                    sQuery = "SELECT cod_usr FROM tabm_sgusuario WHERE ipdir_usr = \"" + ip.ToString() + "\"";
                    alResultados = csFunciones.alConsultar(sQuery);
                    if (alResultados.Count != 0)
                    {
                        bBandera = true;
                        break;
                    }
                    else
                    {
                        bBandera = false;
                    }     
                }
                if (bBandera == false) { MessageBox.Show("La dirección del equipo no corresponde con la cuenta"); }
                return bBandera;
            }
            else 
            {
                return true;
            }
        }

        public bool bObtenerPrivilegio()
        {
            sQuery = "SELECT T1.cod_priv FROM tabm_sgusuario T1 INNER JOIN tabm_sgprivilegio T2 ON T1.cod_priv = T2.cod_priv WHERE cod_usr = " + ePerfil.CodigoUsuario + " AND estado_priv = 1";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoUsuario = Convert.ToInt32(Datos[0]);
                }
                return true;
            }
            else
            {
               MessageBox.Show("El Privilegio no esta disponible en este momento");
               return false;
            }
        }

        public bool bBuscarSesionesAbiertas()
        {
            sQuery = "SELECT cod_ses FROM tabt_sgsesion WHERE cod_usr = " + ePerfil.CodigoUsuario + " AND cod_ses IN (SELECT cod_ses FROM tabt_sgsesion WHERE fechfin_ses = 0000-00-00 AND sesact_ses = 1 )";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count == 0)
            {
                return bCrearNuevaSesion();
            }
            else 
            {
                MessageBox.Show("Esta cuenta tiene actualmente una sesion abierta");
                return false;
            }
        }

        public bool bCrearNuevaSesion()
        {
            try
            {
                sQuery = "SELECT MAX(cod_ses) FROM tabt_sgsesion WHERE cod_usr = " + ePerfil.CodigoUsuario;
                alResultados = csFunciones.alConsultar(sQuery);
                if (alResultados.Count == 0)
                {
                    sQuery = "INSERT INTO tabt_sgsesion (cod_usr,cod_ses,fechinic_ses,fechfin_ses,sesact_ses) VALUES (" + ePerfil.CodigoUsuario + ",1,NOW(),NOW(),0)";      
                    csFunciones.vInsertar(sQuery);
                }
                else
                {
                    foreach (ArrayList Dato in alResultados)
                    {
                        ePerfil.CodigoSesion = Convert.ToInt32(Dato[0]) + 1;
                        sQuery = "INSERT INTO tabt_sgsesion (cod_usr,cod_ses,fechinic_ses,fechfin_ses,sesact_ses) VALUES (" + ePerfil.CodigoUsuario + "," + ePerfil.CodigoSesion + ",NOW(),'0000-00-00',0)";
                        csFunciones.vInsertar(sQuery);
                    }
                }
                return true;
            }
            catch
            {
                MessageBox.Show("Error al crear la sesion");
                return false;
            }
        }


        public bool bMarcarSesionActiva()
        {
            try
            {
                sQuery = "UPDATE tabt_sgsesion SET sesact_ses = 1 WHERE cod_ses = " + ePerfil.CodigoSesion;
                csFunciones.vInsertar(sQuery);
                return true;
            }
            catch
            {
                MessageBox.Show("No se puede obtener la sesion, Intentelo más tarde...");
                return false;
            }    
        }

        public bool bObtenerPerfilUsuario()
        {
            sQuery = "SELECT cod_pusr FROM tabt_sgperfiusuario WHERE cod_usr = " + ePerfil.CodigoUsuario + " AND estado_plfusr = 1";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoPerfilUsuario = Convert.ToInt32(Datos[0]);
                }
                return true;
            }
            else
            {
                MessageBox.Show("El Perfil de esta cuenta no esta disponible");
                return false;
            }
        }

        public bool bObtenerPerfil() 
        {
            sQuery = "SELECT cod_pfll FROM tabt_sgperfiusuario  WHERE cod_pusr = " + ePerfil.CodigoPerfilUsuario + " AND estado_plfusr = 1";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoPerfil = Convert.ToInt32(Datos[0]);
                }
                return true;
            }
            else 
            {
                MessageBox.Show("El Perfil de esta cuenta no esta disponible");
                return false;
            }
        }

        public bool bBuscarAplicaciones()
        {
            sQuery = "SELECT T2.nomapp_app, T1.cod_app, T1.select_papp, T1.insert_paap, T1.delete_papp, T1.update_papp, T1.imprimir_papp FROM tabt_sgperfilapp T1 INNER JOIN tabm_sgaplicacion T2 ON T1.cod_app = T2.cod_app WHERE T1.id_perfil = \"" + ePerfil.CodigoPerfil + "\" AND T2.cod_app IN (SELECT T3.cod_app FROM tabm_sgaplicacion T3 INNER JOIN tabt_sgperfilapp T4 ON T3.cod_app = T4.cod_app WHERE T3.estado_app = 1 AND T4.estado_papp = 1)";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    E_Aplicaciones App = new E_Aplicaciones();
                    App.CodigoAplicacion = Convert.ToInt32(Datos[1]);
                    App.NombreAplicacion = Datos[0].ToString();
                    App.PrivilegiosAplicacion.Add("SLC", Convert.ToInt32(Datos[2]));
                    App.PrivilegiosAplicacion.Add("INS", Convert.ToInt32(Datos[3]));
                    App.PrivilegiosAplicacion.Add("DEL", Convert.ToInt32(Datos[4]));
                    App.PrivilegiosAplicacion.Add("UPD", Convert.ToInt32(Datos[5]));
                    App.PrivilegiosAplicacion.Add("IMP", Convert.ToInt32(Datos[6]));
                    alApps.Add(App);  
                }
                eDatosPublicos.alAplicaciones = alApps;
                return true;
            }
            else 
            {
                MessageBox.Show("Error","Error al obtener las aplicaciones");
                return false;
            }
        }
    }
}
