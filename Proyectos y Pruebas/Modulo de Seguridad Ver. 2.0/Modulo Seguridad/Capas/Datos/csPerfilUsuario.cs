using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_de_Usuario.Capas.Datos
{
    public class csPerfilUsuario
    {
        private int iCodEmpleado;
        private int iCodPerfilAplicaciones;
        private int iCodPerfilUsuario;
        private int iCodPrivilegio;
        private int iCodSesion;
        private int iCodUsuario;
        private int iCodAplicacionesPersonales;
        private static Form fFormPrincipal; 

        public int CodigoEmpleado
        {
            get { return iCodEmpleado; }
            set { iCodEmpleado = value; }
        }
        public int CodigoPerfilUsuario 
        {
            get { return iCodPerfilUsuario; }
            set { iCodUsuario = value; }
        }
        public int CodigoPerfilApliacion 
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

        public Form FormularioPrincipalMenu 
        {
            get { return fFormPrincipal; }
            set { fFormPrincipal = value; }
        }
    }
}
