using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_Seguridad_2._1.Entidades
{
    internal class E_Aplicaciones
    {
        private Dictionary<string,int> dicPrivilegiosAplicacion = new Dictionary<string,int>();
        private int iCodigoAplicacion;
        private String sNombreAplicacion;
       

        public Dictionary<string,int> PrivilegiosAplicacion
        {
            get { return dicPrivilegiosAplicacion; }
            set {dicPrivilegiosAplicacion = value;}
        }
        public int CodigoAplicacion 
        {
            get { return iCodigoAplicacion; }
            set { iCodigoAplicacion = value; }
        }

        public String NombreAplicacion 
        {
            get { return sNombreAplicacion; }
            set { sNombreAplicacion = value; }
        }

      
    }
}
