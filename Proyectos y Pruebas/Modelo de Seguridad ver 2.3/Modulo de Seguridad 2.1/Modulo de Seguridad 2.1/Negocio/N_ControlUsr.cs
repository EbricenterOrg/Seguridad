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

namespace Modulo_de_Seguridad_2._1.Negocio
{
    internal class N_ControlUsr: D_DatoControlUsr
    {
        private E_Usuario eUsuario = new E_Usuario();
        public void vCerrarSesion() 
        {
            Form fMenuCerrar = eUsuario.FormularioPrincipal;
            try
            {
                if (bCerrarSesion() == true)
                {
                    fMenuCerrar.Hide();
                    new wfInicioSesion(eUsuario.FormularioAuxiliar).Show();
                }
            }
            catch 
            {
                fMenuCerrar.Hide();
                new wfInicioSesion(eUsuario.FormularioAuxiliar).Show();
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
                MessageBox.Show("Error al cerrar la aplicación");
            }
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
                bmpImagen = global::Modulo_de_Seguridad_2._1.Properties.Resources.UserDefault;
                return bmpImagen;
            }
        }   
    }
}
