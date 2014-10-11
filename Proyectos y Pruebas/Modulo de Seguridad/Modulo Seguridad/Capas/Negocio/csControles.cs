using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Componente_de_Conexion
{
    public class csControles
    {
        private Bitmap gbBmpImagen;
        private String gbsNombreUsuario;
        private String gbsPerfil;
        private String gbsPrivilegio;
        private byte[] gbbImagen;

        

        public Bitmap ObtenerImagen() 
        {
            try
            {
                MemoryStream MemoryStream = new MemoryStream(gbbImagen);
                gbBmpImagen = new Bitmap(MemoryStream);
                return gbBmpImagen;
            }
            catch (Exception er) 
            {
               // gbBmpImagen = global::Control_de_Usuario.Properties.Resources.UserDefault;
                return gbBmpImagen;
            }
        }

        public byte[] CargarImagen{ get { return gbbImagen; } set { gbbImagen = value; } }
         
        public String NombreUsuario { get { return gbsNombreUsuario; } set { gbsNombreUsuario = value; } }

        public String Privilegio { get { return gbsPrivilegio; } set { gbsPrivilegio = value; } }

        public String Perfil { get { return gbsPerfil; } set { gbsPerfil = value; } }

       

        

    }
}
