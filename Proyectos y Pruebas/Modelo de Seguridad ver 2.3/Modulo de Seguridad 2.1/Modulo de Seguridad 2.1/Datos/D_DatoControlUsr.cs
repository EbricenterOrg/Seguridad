using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulo_de_Seguridad_2._1.Entidades;
using ODBCconnector;
using System.Windows.Forms;
using System.IO;

namespace Modulo_de_Seguridad_2._1.Datos
{
    internal class D_DatoControlUsr 
    {
        private E_Perfil ePerfil = new E_Perfil();
        private E_Usuario eUsuario = new E_Usuario();
        private String sQuery = String.Empty;

        public bool bCerrarSesion()
        {
            try 
            {
                sQuery = "UPDATE tabt_sgsesion SET fechfin_ses = NOW(), sesact_ses = 1 WHERE cod_ses = " + ePerfil.CodigoSesion;
                csFunciones.vModificar(sQuery);
                return true;
            }
            catch 
            {
                MessageBox.Show("No se pudo cerrar la sesion adecuadamente, Intente de nuevo");
                return false;
            }
        }

        /*public bool ObtenerCuenta()
        {
            sQuery = "SELE";
        }*/
    }
}
