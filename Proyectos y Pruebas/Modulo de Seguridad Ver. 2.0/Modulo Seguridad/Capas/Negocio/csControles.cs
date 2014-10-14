using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Navegador;
using System.Windows.Forms;

namespace Control_de_Usuario
{
    class csControles
    {
       
        private Bitmap BmpImagen;
        private String sNombreUsuario;
        private String sPerfil;
        private String sPrivilegio;
      
           
        public String NombreUsuario 
        { 
            get { return sNombreUsuario; } 
            set { sNombreUsuario = value; } 
        }

        public String Privilegio 
        {
            get { return sPrivilegio; } 
            set { sPrivilegio = value; } 
        }

        public String Perfil 
        {
            get { return sPerfil; } 
            set { sPerfil = value; } 
        }

      

    }
}
