using Modulo_de_Seguridad_2._1.Entidades;
using Modulo_de_Seguridad_2._1.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_2._1.Datos;
using System.Drawing;
using System.IO;
using System.Data.Odbc;

namespace Modulo_de_Seguridad_2._1.Negocio
{
    internal class N_ControlUsr: D_DatoControlUsr
    {
        private E_Usuario eUsuario = new E_Usuario();
        private static string gsConexion = "DSN=HSCconexion";
        private static OdbcConnection ocConnect;

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
                bmpImagen = global::Modulo_de_Seguridad_2._1.Properties.Resources.UserDefault;
                return bmpImagen;
            }
        }

        public void vCerrarSesion() 
        {
            Form fMenuCerrar = eUsuario.FormularioPrincipal;
            try
            {
                if (bCerrarSesion() == true)
                {
                    fMenuCerrar.Hide();
                    new wfInicioSesion().Show();
                }
            }
            catch 
            {
                fMenuCerrar.Hide();
                new wfInicioSesion().Show();
                MessageBox.Show("Error al cerrar la sesion");
            }
        }

        public void vSalirSesion()
        {
            try
            {
                if (bCerrarSesion() == true)
                {
                    Application.Exit();
                }
            }
            catch 
            {
                Application.Exit();
                MessageBox.Show("Error al cerrar la aplicación");
            }
        }

        public void vIniciar()
        {
            bool bBandera = false;
            if (bBandera = bObtenerNombre() == true) 
            {
                if(bBandera = bObtenerPerfil()== true){
                    bBandera = bObtenerImagen();
                }
            }            
            vObtenerPrivilegio();
            if (bBandera == false)
            {
                MessageBox.Show("No se pudo cargar los datos de la cuenta");
            }
            else
            {
                eUsuario.ImagenUsuario = bmpObtenerImagen(eUsuario.ImagenBytes);
            }
        }

        public void vGuardarSalir()
        {
            Form fMenuCerrar = eUsuario.FormularioPrincipal;
            try
            {
                fMenuCerrar.Hide();
                new wfInicioSesion().Show();
                MessageBox.Show("La Sesion sera Guardada y podra ser utilizada más tarde","Hotel San Carlos");
            }
            catch
            {
                fMenuCerrar.Hide();
                new wfInicioSesion().Show();
                MessageBox.Show("Error al cerrar la sesion");
            }
        }

        public Bitmap bmpRevisarConexion()
        {
            Bitmap bmpImagen = global::Modulo_de_Seguridad_2._1.Properties.Resources.GreenPoint;
            try
            {
                ocConnect = new OdbcConnection(gsConexion);
                ocConnect.Open();
                ocConnect.Close();
                return bmpImagen = global::Modulo_de_Seguridad_2._1.Properties.Resources.GreenPoint;
            }
            catch (OdbcException)
            {
                return bmpImagen = global::Modulo_de_Seguridad_2._1.Properties.Resources.RedPoint;  
            }
        }
      
    }
}
