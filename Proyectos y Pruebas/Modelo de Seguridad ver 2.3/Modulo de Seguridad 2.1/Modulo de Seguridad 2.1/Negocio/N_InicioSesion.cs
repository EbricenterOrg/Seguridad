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
    internal class N_InicioSesion: D_DatoInicioSesion
    {
        private ArrayList alResultados = new ArrayList();
        private E_Usuario E_Usuario = new E_Usuario();

        private void vCargarMenuPrincipal(bool bCargaForm)
        {
            if (bCargaForm == true)
            {
                try
                {

                    Form fFormularioPrincipal = E_Usuario.FormularioPrincipal;
                    fFormularioPrincipal.Dock = DockStyle.Fill;
                    fFormularioPrincipal.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("No hay Formulario Principal Cargado");
                }
            }
        }

        public void vValidarUsuario(String sUser, String sPass)
        {
            if (sUser.Length != 0 && sPass.Length != 0)
            {
                try
                {
                    if (bBuscarUsuario(sUser, sPass) == true)
                    {
                        if (bComprobarFuente() == true)
                        {
                            if (bObtenerPrivilegio() == true)
                            {
                                if (bBuscarSesionesAbiertas() == true)
                                {
                                    if (bObtenerPerfilUsuario() == true)
                                    {
                                        if (bObtenerPerfil() == true)
                                        {
                                            wfInicioSesion.ActiveForm.Hide();
                                            vCargarMenuPrincipal(bBuscarAplicaciones());
                                        }
                                    }   
                                }
                            }
                        }
                    }
                } catch
                {
                    MessageBox.Show("Error al Inicio de Sesion");
                }
            }
            else
            {
                MessageBox.Show("Usuario/Password Vacios","Hotel San Carlos");
            }
        }
      
    }
}
