using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_Seguridad_2._1.Entidades
{
    internal class E_Perfil
    {
        private int iCodEmpleado;
        private int iCodPerfil;
        private int iCodPerfilAplicaciones;
        private int iCodPerfilUsuario;
        private int iCodPrivilegio;
        private int iCodSesion;
        private int iCodUsuario;
        private int iCodAplicacionesPersonales;


        public int CodigoEmpleado
        {
            get { return iCodEmpleado; }
            set { iCodEmpleado = value; }
        }
        public int CodigoPerfilUsuario
        {
            get { return iCodPerfilUsuario; }
            set {iCodPerfilUsuario = value; }
        }
        public int CodigoPerfilAplicacion
        {
            get { return iCodPerfilAplicaciones; }
            set { iCodPerfilAplicaciones = value; }
        }
        public int CodigoPrivilegio
        {
            get { return iCodPrivilegio; }
            set { iCodPrivilegio = value; }
        }
        public int CodigoSesion
        {
            get { return iCodSesion; }
            set { iCodSesion = value; }
        }
        public int CodigoUsuario
        {
            get { return iCodUsuario; }
            set { iCodUsuario = value; }
        }
        public int CodigoAplicacionesPersonales
        {
            get { return iCodAplicacionesPersonales; }
            set { iCodAplicacionesPersonales = value; }
        }
        public int CodigoPerfil 
        {
            get { return iCodPerfil; }
            set { iCodPerfil = value; }
        }
    }
}
