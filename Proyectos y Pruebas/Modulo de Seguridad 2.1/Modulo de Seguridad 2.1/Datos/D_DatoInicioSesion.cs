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
    public class D_DatoInicioSesion:csConexion
    {
        private IPHostEntry ipHostName; 
        private String sQuery = String.Empty;
        private ArrayList alResultados = new ArrayList();
        private E_Perfil ePerfil = new E_Perfil();
        private E_Usuario eUsuario = new E_Usuario();
        private ArrayList alAplicaciones = new ArrayList();


        public ArrayList Aplicaciones 
        {
            get { return alAplicaciones; }
            set { alAplicaciones = value; }
        }

        protected ArrayList alBuscarUsuarios()
        {
            ipHostName = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in ipHostName.AddressList)
            {
                sQuery = "SELECT cuenta_usr, foto_usr FROM tabm_SGusuario T1 INNER JOIN tabt_SGsesion T2 ON T2.cod_usr = T1.cod_usr WHERE ipdir_usr= \"" + ip.ToString() + "\" LIMIT 6";
                if (bAbrirConexion())
                {
                    try
                    {
                        OdbcCommand ocComando = new OdbcCommand(sQuery, Conexion);
                        OdbcDataReader odcReader = ocComando.ExecuteReader();
                        while (odcReader.Read())
                        {
                            E_Usuario eUsuario = new E_Usuario();
                            eUsuario.Cuenta = odcReader[0].ToString();
                            eUsuario.ImagenBytes = (byte[])odcReader[1];
                            alResultados.Add(eUsuario);
                        }
                        vCerrarConexion();
                    }
                    catch (OdbcException ex)
                    {
                        return null;
                    }
                }
            }
            return alResultados;
        }

        protected bool bObtenerTablaPerfil(String sUser, String sPass)
        {
            bool bBandera = false;
            sQuery = "SELECT T1.cod_usr, T1.cod_priv, T2.cod_emp, T3.cod_pusr FROM tabm_SGusuario AS T1 INNER JOIN tabm_NNempleado T2 ON T2.cod_emp = T1.cod_emp INNER JOIN tabt_SGperfiusuario T3 ON T3.cod_usr = T3.cod_usr WHERE cuenta_usr = '" + sUser + "' AND pass_usr = '" + sPass + "'";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoUsuario = Convert.ToInt32(Datos[0]);
                    ePerfil.CodigoPrivilegio = Convert.ToInt32(Datos[1]);
                    ePerfil.CodigoEmpleado = Convert.ToInt32(Datos[2]);
                    ePerfil.CodigoPerfilUsuario = Convert.ToInt32(Datos[3]);
                    MessageBox.Show("CodigoPerfilUsr " + Datos[3].ToString() + Environment.NewLine + "CodigoPriv " + ePerfil.CodigoPrivilegio);

                }
                bBandera = true;
            }
            else
            {
                MessageBox.Show("Usuario/Pass Invalidos");
                bBandera = false;
            }
            return bBandera;
        }

        protected void vObtenerSesion()
        {
            sQuery = "SELECT MAX(cod_ses) FROM tabt_SGsesion WHERE cod_usr =  \"" + ePerfil.CodigoUsuario + "\"";
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoSesion = Convert.ToInt32(Datos[0]);
                }
                MessageBox.Show("Sesion " + ePerfil.CodigoSesion.ToString());
            }
        }

        protected void vObtenerPerfil() 
        {
            sQuery = "SELECT cod_pfll FROM tabt_SGperfiusuario WHERE cod_pusr = " + ePerfil.CodigoPerfilUsuario;
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    ePerfil.CodigoPerfil = Convert.ToInt32(Datos[0]);
                }
                MessageBox.Show("CodigoPerfil " + ePerfil.CodigoPerfil.ToString());
            }
        }
       
     

        protected void vBuscarAplicaciones()
        {
            sQuery = "SELECT  T2.estado_app, T2.nomapp_app, T1.cod_app, T1.select_papp, T1.insert_paap, T1.delete_papp, T1.update_papp, T1.imprimir_papp, T1.estado_papp FROM tabt_sgperfilapp T1 INNER JOIN tabm_SGaplicacion T2 ON T1.cod_app = T2.cod_app WHERE T1.id_perfil = " + ePerfil.CodigoPerfil + " AND T1.estado_papp = 1" ;
            alResultados = csFunciones.alConsultar(sQuery);
            if (alResultados.Count != 0)
            {
                foreach (ArrayList Datos in alResultados)
                {
                    E_Aplicaciones App = new E_Aplicaciones();
                    App.CodigoAplicacion = Convert.ToInt32(Datos[2]);
                    App.NombreAplicacion = Datos[1].ToString();
                    App.PrivilegiosAplicacion.Add("SLC", Convert.ToInt32(Datos[3]));
                    App.PrivilegiosAplicacion.Add("INS", Convert.ToInt32(Datos[4]));
                    App.PrivilegiosAplicacion.Add("DEL", Convert.ToInt32(Datos[5]));
                    App.PrivilegiosAplicacion.Add("UPD", Convert.ToInt32(Datos[6]));
                    App.PrivilegiosAplicacion.Add("IMP", Convert.ToInt32(Datos[7]));
                    alAplicaciones.Add(App);  
                }
            }
        }
    }
}
