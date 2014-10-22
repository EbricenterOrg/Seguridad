using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modulo_de_Seguridad_2._1.Entidades
{
    class E_Usuario
    {
        private Bitmap bmpImagen;
        private String sNombreUsuario;
        private String sPerfil;
        private String sPrivilegio;
        private String sCuenta;
        private static Form fFormPrincipal;
        private byte[] byImagen;

        public Form FormularioPrincipal { get { return fFormPrincipal; } set { fFormPrincipal = value; } } 
        public Bitmap ImagenUsuario { get { return bmpImagen; } set { bmpImagen = value; } }
        public byte[] ImagenBytes { get { return byImagen; } set { byImagen = value; } }
        public String NombreUsuario { get { return sNombreUsuario; } set { sNombreUsuario = value; } }
        public String Privilegio { get { return sPrivilegio; } set { sPrivilegio = value; } }
        public String Perfil { get { return sPerfil; } set { sPerfil = value; } }
        public String Cuenta { get { return sCuenta; } set { sCuenta = value; } }
    }
}
