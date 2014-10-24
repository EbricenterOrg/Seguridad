using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_Seguridad_2._1.Entidades
{
    public class E_DatosUsuario
    {
        private static ArrayList alApps;
        private static int iCodUsr;

        public ArrayList alAplicaciones
        {
            get { return alApps; }
            set { alApps = value; }
        }

        public int iCodigoUsuario
        {
            get { return iCodUsr; }
            set { iCodUsr = value; }
        }

    }
}
